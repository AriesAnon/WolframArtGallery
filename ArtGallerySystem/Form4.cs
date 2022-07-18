using AForge.Video;
using AForge.Video.DirectShow;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ArtGallerySystem
{
    public partial class Form4 : Form
    {
        //global variables

        private bool isCollapsed = false;
        private FilterInfoCollection colCam;
        private VideoCaptureDevice capDev;

        private void clearAll()
        {
            //Create clean method for lesser code
            IDtextbox.Clear();
            nameTBox.Clear();
            posTBox.Clear();
            capturedImgPB.Image = new Bitmap(640, 480);
            employeeDataRTB.Clear();
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed == true)
            {

                panelAdminDropDown.Height -= 30;

                if (panelAdminDropDown.Height == 0)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else if (isCollapsed == false)
            {

                panelAdminDropDown.Height += 30;

                if (panelAdminDropDown.Height == 30)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void adminButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void AAButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            FillComboBoxCamera();

            displayListView.GridLines = true;
            displayListView.View = View.Details;
            displayListView.Columns.Add("ID", 106);
            displayListView.Columns.Add("Name", 106);
            displayListView.Columns.Add("Position", 106);

            //Establish connection to database
            String connection = "datasource = 127.0.0.1; port = 3306; username = root; password = ; database = artgallery;";
            MySqlConnection dbConnection = new MySqlConnection(connection);
            MySqlCommand cmd;

            //Query for database
            String query = "SELECT employeeID, name, position FROM employee_data;";

            //Connecting to database
            try
            {
                dbConnection.Open();
                cmd = new MySqlCommand(query, dbConnection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        ListViewItem lvi = new ListViewItem(dataReader.GetInt32(0).ToString());
                        lvi.SubItems.Add(dataReader.GetString(1));
                        lvi.SubItems.Add(dataReader.GetString(2));
                        displayListView.Items.Add(lvi);
                    }

                    this.displayListView.Items[0].Focused = true;
                    this.displayListView.Items[0].Selected = true;

                }


                dbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FillComboBoxCamera()
        {
            colCam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in colCam)
            {
                cameraComboBox.Items.Add(Device.Name);
                cameraComboBox.SelectedIndex = 0;
                capDev = new VideoCaptureDevice();
            }

        }

        private void cameraButton_Click(object sender, EventArgs e)
        {
            capDev = new VideoCaptureDevice(colCam[cameraComboBox.SelectedIndex].MonikerString);
            capDev.NewFrame += new NewFrameEventHandler(NewFrame);
            capDev.Start();
        }

        private void NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap video = (Bitmap)eventArgs.Frame.Clone();
            cameraPBox.Image = video;
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseCamera();
        }

        private void cameraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CloseCamera();
        }

        private void CloseCamera()
        {
            if (capDev != null)
            {
                if (capDev.IsRunning == true)
                {
                    capDev.Stop();
                    cameraPBox.Image = new Bitmap(640, 480);
                    capturedImgPB.Image = new Bitmap(640, 480);
                }
            }

        }

        private void Form4_VisibleChanged(object sender, EventArgs e)
        {
            CloseCamera();
        }

        private void captureImgButton_Click(object sender, EventArgs e)
        {
            capturedImgPB.Image = cameraPBox.Image;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Save image to directory
            SaveFileDialog sv = new SaveFileDialog();
            sv.DefaultExt = "jpg";
            sv.Filter = "jpg files (*.jpg)| *.jpg| PNG files (*.png)| *.png| All files (*.*)| *.*";

            if (String.IsNullOrWhiteSpace(nameTBox.Text) || String.IsNullOrWhiteSpace(posTBox.Text) || String.IsNullOrWhiteSpace(employeeDataRTB.Text))
            {
                MessageBox.Show("Please fill in the textboxes.");
            }

            else
            {

                if (capturedImgPB.Image != null)
                {
                    if (sv.ShowDialog() == DialogResult.OK)
                    {
                        capturedImgPB.Image.Save(sv.FileName);
                    }


                    //Save image and info to database
                    //Establish connection to database
                    String connection = "datasource = 127.0.0.1; port = 3306; username = root; password = ; database = artgallery;";
                    MySqlConnection dbConnection = new MySqlConnection(connection);
                    MySqlCommand cmd;

                    //Prepare image for saving
                    try
                    {

                        MemoryStream ms = new MemoryStream();
                        capturedImgPB.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        Byte[] img = ms.GetBuffer();

                        try
                        {
                            dbConnection.Open();
                            cmd = new MySqlCommand("INSERT INTO employee_data (name, position, pic) VALUES (@name, @position, @pic)", dbConnection);
                            cmd.Parameters.AddWithValue("@name", nameTBox.Text);
                            cmd.Parameters.AddWithValue("@position", posTBox.Text);
                            cmd.Parameters.AddWithValue("@pic", img);
                            cmd.ExecuteNonQuery();



                            dbConnection.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }



                    //Save text as pdf
                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file| *.pdf", ValidateNames = true })
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.LETTER);

                            try
                            {
                                PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                                doc.Open();
                                doc.Add(new iTextSharp.text.Paragraph(employeeDataRTB.Text));
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                doc.Close();
                            }
                        }
                    }

                    MessageBox.Show("Data Saved.");

                    //Clear all contents including image
                    clearAll();

                }
                else
                {
                    MessageBox.Show("Please capture an image.");
                }

            }


            updateListView();
        }

        private void empListButton_Click(object sender, EventArgs e)
        {
            //Opens form 5 (Employee List)
            this.Hide();
            var form5 = new Form5();
            form5.Closed += (s, args) => this.Close();
            form5.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            //Goes Back to Log In Menu
            this.Hide();
            var LogInForm = new LogInForm();
            LogInForm.Closed += (s, args) => this.Close();
            LogInForm.Show();
        }

        private void displayListView_Click(object sender, EventArgs e)
        {
            clearAll();

            //For displaying Texts
            IDtextbox.Text = displayListView.SelectedItems[0].SubItems[0].Text;
            nameTBox.Text = displayListView.SelectedItems[0].SubItems[1].Text;
            posTBox.Text = displayListView.SelectedItems[0].SubItems[2].Text;

            displaySelectedEmployee(IDtextbox.Text);
        }

        private void displaySelectedEmployee(String id)
        {
            // THIS IS USED TO DISPLAY IMAGES BASED ON THE SELECTED ID
            //Convert string to int
            int idNum = System.Convert.ToInt32(id);

            //Establish connection to database
            String connection = "datasource = 127.0.0.1; port = 3306; username = root; password = ; database = artgallery;";
            MySqlConnection dbConnection = new MySqlConnection(connection);
            MySqlCommand cmd;
            MySqlDataReader dataReader;

            dbConnection.Open();
            cmd = new MySqlCommand("SELECT pic FROM `employee_data` WHERE employeeID = " + idNum, dbConnection);

            dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                //As long as there is Data....

                //Convert Blob to Array
                long length = dataReader.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(length + 1)];
                dataReader.GetBytes(0, 0, array, 0, System.Convert.ToInt32(length));

                //Turn Array to Bitmap
                MemoryStream ms = new MemoryStream(array);
                Bitmap bm = new Bitmap(ms);

                //Display Image
                capturedImgPB.Image = bm; //Assign bitmap to picturebox

            }

            dataReader.Close();
            dbConnection.Close();
        }

        private void editDataButton_Click(object sender, EventArgs e)
        {
            //Establish connection to database
            String connection = "datasource = 127.0.0.1; port = 3306; username = root; password = ; database = artgallery;";
            MySqlConnection dbConnection = new MySqlConnection(connection);
            MySqlCommand cmd;

            //Check if artworkPBox is empty
            if (capturedImgPB.Image == null)
            {
                MessageBox.Show("Please select an image.");
            }
            else
            {

                int idNum = System.Convert.ToInt32(IDtextbox.Text);

                //Ready Image for Saving
                MemoryStream ms = new MemoryStream();
                capturedImgPB.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Byte[] img = ms.GetBuffer();


                //Connecting to database
                try
                {

                    dbConnection.Open();
                    cmd = new MySqlCommand("UPDATE `employee_data` SET name = @name, position = @position, pic = @pic WHERE employeeID = @id", dbConnection);
                    cmd.Parameters.AddWithValue("@name", nameTBox.Text);
                    cmd.Parameters.AddWithValue("@position", posTBox.Text);
                    cmd.Parameters.AddWithValue("@pic", img);
                    cmd.Parameters.AddWithValue("@id", idNum);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("New Data Saved.");

                    dbConnection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                //Clear all contents including image
                clearAll();
                updateListView();
            }
        }

        private void updateListView()
        {
            clearAll();
            displayListView.Items.Clear();

            //Establish connection to database
            String connection = "datasource = 127.0.0.1; port = 3306; username = root; password = ; database = artgallery;";
            MySqlConnection dbConnection = new MySqlConnection(connection);
            MySqlCommand cmd;

            //Query for database
            String query = "SELECT employeeID, name, position FROM employee_data;";

            //Connecting to database
            try
            {
                dbConnection.Open();
                cmd = new MySqlCommand(query, dbConnection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        ListViewItem lvi = new ListViewItem(dataReader.GetInt32(0).ToString());
                        lvi.SubItems.Add(dataReader.GetString(1));
                        lvi.SubItems.Add(dataReader.GetString(2));
                        displayListView.Items.Add(lvi);
                    }
                }

                else
                {
                    MessageBox.Show("There is no data in the database.");
                }

                dbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void showDataButton_Click(object sender, EventArgs e)
        {
            //Clear list view items
            displayListView.Items.Clear();

            //Establish connection to database
            String connection = "datasource = 127.0.0.1; port = 3306; username = root; password = ; database = artgallery;";
            MySqlConnection dbConnection = new MySqlConnection(connection);
            MySqlCommand cmd;

            //Check if IDtextbox is empty
            if (!String.IsNullOrWhiteSpace(IDtextbox.Text)) //if not empty
            {
                //Get ID number from textbox and check if its int
                bool isInt = Int32.TryParse(IDtextbox.Text, out int y);
                if (!isInt)
                {
                    MessageBox.Show("Invalid ID number.");
                }
                else
                {
                    int idNum = y;
                    String queryID = "SELECT employeeID, name, position FROM employee_data WHERE employeeID = " + idNum;

                    //Connecting to database
                    try
                    {
                        dbConnection.Open();
                        cmd = new MySqlCommand(queryID, dbConnection);

                        MySqlDataReader dataReader = cmd.ExecuteReader();

                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                ListViewItem lvi = new ListViewItem(dataReader.GetInt32(0).ToString());
                                lvi.SubItems.Add(dataReader.GetString(1));
                                lvi.SubItems.Add(dataReader.GetString(2));
                                displayListView.Items.Add(lvi);
                            }

                            clearAll();

                            //For displaying Texts
                            IDtextbox.Text = displayListView.Items[0].SubItems[0].Text;
                            nameTBox.Text = displayListView.Items[0].SubItems[1].Text;
                            posTBox.Text = displayListView.Items[0].SubItems[2].Text;
                            displaySelectedEmployee(IDtextbox.Text);
                        }

                        else
                        {
                            MessageBox.Show("There is no data in the database with that ID.");
                            updateListView();
                        }

                        dbConnection.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
            }
            else
            {
                MessageBox.Show("Please enter an ID number.");
                updateListView();
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            updateListView();
        }
    }
}

