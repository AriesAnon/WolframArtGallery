using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ArtGallerySystem
{
    public partial class Form1 : Form
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
        }

        public Form1()
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
            String imagelocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files (*.jpg)| *.jpg| PNG files (*.png)| *.png| All files (*.*)| *.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    imagelocation = dialog.FileName;
                    artworkPBox.BackgroundImage = Image.FromFile(imagelocation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void addToDBButton_Click(object sender, EventArgs e)
        {
            //Use to check for invalid data
            bool isInvalid = false;

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
                //Prepare image for saving

                try
                {

                    MemoryStream ms = new MemoryStream();
                    artworkPBox.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    Byte[] img = ms.GetBuffer();


                    //Check if medium used is empty
                    if (String.IsNullOrWhiteSpace(mediumTBox.Text))
                    {
                        MessageBox.Show("Please enter the medium used.");
                    }
                    else
                    {
                        //Initialize the default value of year
                        int year = 0000;

                        //Check if yearTBox is empty
                        if (!String.IsNullOrWhiteSpace(yearTBox.Text))
                        {
                            //Check if text length is == 4
                            if (yearTBox.Text.Length == 4)
                            {
                                //Check if text is int
                                bool isInt = Int32.TryParse(yearTBox.Text, out int y);
                                if (!isInt)
                                {
                                    MessageBox.Show("Invalid year.");
                                    isInvalid = true;
                                }
                                else
                                {
                                    year = y;
                                }
                            }

                            else
                            {
                                MessageBox.Show("Invalid year.");
                                isInvalid = true;
                            }
                        }

                        //Check for invalid data
                        if (!isInvalid)
                        {
                            //Check if text in priceTBox is int
                            bool success = Int32.TryParse(priceTBox.Text, out int price);
                            if (success)
                            {

                                //Connecting to database
                                try
                                {
                                    dbConnection.Open();
                                    cmd = new MySqlCommand("INSERT INTO artworks (title, year_painted, artist, birthplace, price, artworkImg, mediumUsed) VALUES (@title, @year_painted, @artist, @birthplace, @price, @artworkImg, @mediumUsed)", dbConnection);
                                    cmd.Parameters.AddWithValue("@title", titleTBox.Text);
                                    cmd.Parameters.AddWithValue("@year_painted", System.Convert.ToInt32(yearTBox.Text));
                                    cmd.Parameters.AddWithValue("@artist", artistTBox.Text);
                                    cmd.Parameters.AddWithValue("@birthplace", birthplaceTBox.Text);
                                    cmd.Parameters.AddWithValue("@price", System.Convert.ToInt32(priceTBox.Text));
                                    cmd.Parameters.AddWithValue("@artworkImg", img);
                                    cmd.Parameters.AddWithValue("@mediumUsed", mediumTBox.Text);
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Data Saved.");

                                    dbConnection.Close();


                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                                //Clear all contents including image
                                clearAll();
                                artworkPBox.BackgroundImage = null;
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid price and make sure that there are no punctuations.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearAll();
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
    }
}

