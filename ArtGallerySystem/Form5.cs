using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;



namespace ArtGallerySystem
{
    public partial class Form5 : Form
    {
        private bool isCollapsed = false;
        private PictureBox picBox;
        private Label name, position;

        private void GetData()
        {

            //Establish connection to database
            String connection = "datasource = 127.0.0.1; port = 3306; username = root; password = ; database = artgallery;";
            MySqlConnection dbConnection = new MySqlConnection(connection);
            MySqlCommand cmd;
            MySqlDataReader dataReader;

            dbConnection.Open();
            cmd = new MySqlCommand("SELECT pic, name, position FROM `employee_data`", dbConnection);

            dataReader = cmd.ExecuteReader();
            
            
            while (dataReader.Read())
            {
                //As long as there is Data....

                //Convert Blob to Array
                long length = dataReader.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(length + 1)];
                dataReader.GetBytes(0, 0, array, 0, System.Convert.ToInt32(length));

                //Create Picture Box Parameters
                picBox = new PictureBox();
                picBox.Height = 200;
                picBox.Width = 200;
                picBox.BackgroundImageLayout = ImageLayout.Zoom;

                //Add Name
                name = new Label();
                name.Text = dataReader["name"].ToString();
                name.Font = new Font("Bahnschrift Condensed", 14, FontStyle.Bold);
                name.ForeColor = Color.FromArgb(236, 236, 236);
                name.Image = Image.FromFile("C:\\Users\\maria\\Desktop\\ArtGalleryProject\\Backgrounds\\PaintingLabelOpacityBG1.png");
                name.Dock = DockStyle.Bottom;
                name.TextAlign = ContentAlignment.MiddleCenter;

                //Add position
                position = new Label();
                position.Text = dataReader["position"].ToString();
                position.Font = new Font("Bahnschrift Condensed", 12, FontStyle.Italic);
                position.ForeColor = Color.Black;
                position.Image = Image.FromFile("C:\\Users\\maria\\Desktop\\ArtGalleryProject\\Backgrounds\\PaintingLabelOpacityBG.png");
                position.Dock = DockStyle.Bottom;
                position.TextAlign = ContentAlignment.MiddleCenter;


                //Turn Array to Bitmap
                MemoryStream ms = new MemoryStream(array);
                Bitmap bm = new Bitmap(ms);

                //Display Image
                picBox.BackgroundImage = bm; //Assign bitmap to picturebox
                flowLayoutPanel1.Controls.Add(picBox); //Display picturebox

                //Display Text
                picBox.Controls.Add(name);
                picBox.Controls.Add(position);

            }

            dataReader.Close();
            dbConnection.Close();
        }


        public Form5()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isCollapsed == true)
            {
                
                panelAdminDropDown.Height -= 30;
             
                if (panelAdminDropDown.Height == 0)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else if(isCollapsed == false)
            {
                
                panelAdminDropDown.Height += 30;
                
                if (panelAdminDropDown.Height == 30)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }


        private void EditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void AAButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            //Opens form 4 (Employee Data)
            this.Hide();
            var form4 = new Form4();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            //Opens form 3 (Browse Artwork)
            this.Hide();
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            //Goes Back to Log In Menu
            this.Hide();
            var LogInForm = new LogInForm();
            LogInForm.Closed += (s, args) => this.Close();
            LogInForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

