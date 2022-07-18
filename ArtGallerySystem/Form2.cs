using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ArtGallerySystem
{
    public partial class Form2 : Form
    {
        private bool isCollapsed = false;

        private void clearAll()
        {
            //Create clean method for lesser code
            titleTBox.Clear();
            artistTBox.Clear();
            yearTBox.Clear();
            birthplaceTBox.Clear();
            mediumTBox.Clear();
            priceTBox.Clear();
            IDtextbox.Clear();
        }

        public Form2()
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

        private void uploadIMGButton_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files (*.jpg)| *.jpg| PNG files (*.png)| *.png| All files (*.*)| *.*";
                dialog.ShowDialog();
                artworkPBox.BackgroundImage = Image.FromFile(dialog.FileName);

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void AAButton_Click(object sender, EventArgs e)
        {
            //Opens form1
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
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
                    String queryID = "SELECT  id_artwork, title, year_painted, artist, birthplace, mediumUsed, price FROM artworks WHERE id_artwork = " + idNum;

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
                                lvi.SubItems.Add(dataReader.GetInt32(2).ToString());
                                lvi.SubItems.Add(dataReader.GetString(3));
                                lvi.SubItems.Add(dataReader.GetString(4));
                                lvi.SubItems.Add(dataReader.GetString(5));
                                lvi.SubItems.Add(dataReader.GetInt32(6).ToString());
                                displayListView.Items.Add(lvi);
                            }

                            clearAll();

                            //For displaying Texts
                            IDtextbox.Text = displayListView.Items[0].SubItems[0].Text;
                            titleTBox.Text = displayListView.Items[0].SubItems[1].Text;
                            yearTBox.Text = displayListView.Items[0].SubItems[2].Text;
                            artistTBox.Text = displayListView.Items[0].SubItems[3].Text;
                            birthplaceTBox.Text = displayListView.Items[0].SubItems[4].Text;
                            mediumTBox.Text = displayListView.Items[0].SubItems[5].Text;
                            priceTBox.Text = displayListView.Items[0].SubItems[6].Text;
                            displaySelectedArtwork(IDtextbox.Text);
                        }

                        else
                        {
                            MessageBox.Show("There is no data in the database with that ID.");
                            listviewDisplay();
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
                listviewDisplay();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            displayListView.GridLines = true;
            displayListView.View = View.Details;
            displayListView.Columns.Add("ID", 25);
            displayListView.Columns.Add("Title", 108);
            displayListView.Columns.Add("Year", 52);
            displayListView.Columns.Add("Artist", 108);
            displayListView.Columns.Add("Birthplace", 108);
            displayListView.Columns.Add("Medium", 108);
            displayListView.Columns.Add("Price", 108);

            //Establish connection to database
            String connection = "datasource = 127.0.0.1; port = 3306; username = root; password = ; database = artgallery;";
            MySqlConnection dbConnection = new MySqlConnection(connection);
            MySqlCommand cmd;

            //Query for database
            String query = "SELECT id_artwork, title, year_painted, artist, birthplace, mediumUsed, price FROM artworks;";

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
                        lvi.SubItems.Add(dataReader.GetInt32(2).ToString());
                        lvi.SubItems.Add(dataReader.GetString(3));
                        lvi.SubItems.Add(dataReader.GetString(4));
                        lvi.SubItems.Add(dataReader.GetString(5));
                        lvi.SubItems.Add(dataReader.GetInt32(6).ToString());
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

        private void editDataButton_Click(object sender, EventArgs e)
        {

            //Establish connection to database
            String connection = "datasource = 127.0.0.1; port = 3306; username = root; password = ; database = artgallery;";
            MySqlConnection dbConnection = new MySqlConnection(connection);
            MySqlCommand cmd;

            //Check if artworkPBox is empty
            if (artworkPBox.BackgroundImage == null)
            {
                MessageBox.Show("Please select an image.");
            }
            else
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

                    //Ready Image for Saving
                    MemoryStream ms = new MemoryStream();
                    artworkPBox.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    Byte[] img = ms.GetBuffer();


                    //Connecting to database
                    try
                    {

                        dbConnection.Open();
                        cmd = new MySqlCommand("UPDATE `artworks` SET `id_artwork`= @id, `title`= @title, `year_painted`= @year_painted, `artist`= @artist, `birthplace`= @birthplace, `price`= @price, `artworkImg`= @artworkImg, `mediumUsed`= @mediumUsed WHERE id_artwork = @idCondition", dbConnection);
                        cmd.Parameters.AddWithValue("@id", System.Convert.ToInt32(idNum));
                        cmd.Parameters.AddWithValue("@title", titleTBox.Text);
                        cmd.Parameters.AddWithValue("@year_painted", System.Convert.ToInt32(yearTBox.Text));
                        cmd.Parameters.AddWithValue("@artist", artistTBox.Text);
                        cmd.Parameters.AddWithValue("@birthplace", birthplaceTBox.Text);
                        cmd.Parameters.AddWithValue("@price", System.Convert.ToInt32(priceTBox.Text));
                        cmd.Parameters.AddWithValue("@artworkImg", img);
                        cmd.Parameters.AddWithValue("@mediumUsed", mediumTBox.Text);
                        cmd.Parameters.AddWithValue("@idCondition", System.Convert.ToInt32(idNum));
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("New Data Saved.");

                        dbConnection.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                //Clear all contents including image
                clearAll();
                artworkPBox.BackgroundImage = null;
                listviewDisplay();
            }



        }

        private void deleteDataButton_Click(object sender, EventArgs e)
        {
            //Establish connection to database
            String connection = "datasource = 127.0.0.1; port = 3306; username = root; password = ; database = artgallery;";
            MySqlConnection dbConnection = new MySqlConnection(connection);
            MySqlCommand cmd;

            //Get ID number from textbox and check if its int
            bool isInt = Int32.TryParse(IDtextbox.Text, out int y);
            if (!isInt)
            {
                MessageBox.Show("Invalid ID number.");
            }
            else
            {
                int idNum = y;

                String query = "DELETE FROM `artworks` WHERE id_artwork = " + idNum;

                //Connecting to database
                try
                {
                    dbConnection.Open();
                    cmd = new MySqlCommand(query, dbConnection);

                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    MessageBox.Show("Data Deleted.");
                    dbConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //Clear all contents including image
            clearAll();
            artworkPBox.BackgroundImage = null;
            listviewDisplay();

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            //Opens Form3 (Browse Artwork)
            this.Hide();
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            //Opens form 4 (Employee Data)
            this.Hide();
            var form4 = new Form4();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
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
            titleTBox.Text = displayListView.SelectedItems[0].SubItems[1].Text;
            yearTBox.Text = displayListView.SelectedItems[0].SubItems[2].Text;
            artistTBox.Text = displayListView.SelectedItems[0].SubItems[3].Text;
            birthplaceTBox.Text = displayListView.SelectedItems[0].SubItems[4].Text;
            mediumTBox.Text = displayListView.SelectedItems[0].SubItems[5].Text;
            priceTBox.Text = displayListView.SelectedItems[0].SubItems[6].Text;

            displaySelectedArtwork(IDtextbox.Text);
        }


        private void displaySelectedArtwork(String id)
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
            cmd = new MySqlCommand("SELECT artworkImg FROM `artworks` WHERE id_artwork = " + idNum, dbConnection);

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
                artworkPBox.BackgroundImage = bm; //Assign bitmap to picturebox

            }

            dataReader.Close();
            dbConnection.Close();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            listviewDisplay();
        }

        private void listviewDisplay()
        {
            clearAll();
            displayListView.Items.Clear();
            artworkPBox.BackgroundImage = null;

            //Establish connection to database
            String connection = "datasource = 127.0.0.1; port = 3306; username = root; password = ; database = artgallery;";
            MySqlConnection dbConnection = new MySqlConnection(connection);
            MySqlCommand cmd;

            //Query for database
            String query = "SELECT id_artwork, title, year_painted, artist, birthplace, mediumUsed, price FROM artworks;";

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
                        lvi.SubItems.Add(dataReader.GetInt32(2).ToString());
                        lvi.SubItems.Add(dataReader.GetString(3));
                        lvi.SubItems.Add(dataReader.GetString(4));
                        lvi.SubItems.Add(dataReader.GetString(5));
                        lvi.SubItems.Add(dataReader.GetInt32(6).ToString());
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


    }
}

