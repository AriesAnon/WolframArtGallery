namespace ArtGallerySystem
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.editDataButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.employeeDataRTB = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.captureImgButton = new System.Windows.Forms.Button();
            this.posTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cameraComboBox = new System.Windows.Forms.ComboBox();
            this.cameraPBox = new System.Windows.Forms.PictureBox();
            this.cameraButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.showAllButton = new System.Windows.Forms.Button();
            this.IDtextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.showDataButton = new System.Windows.Forms.Button();
            this.displayListView = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.capturedImgPB = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelAdminDropDown = new System.Windows.Forms.Panel();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.empListButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AAButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraPBox)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capturedImgPB)).BeginInit();
            this.panel6.SuspendLayout();
            this.panelAdminDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.empListButton);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.browseButton);
            this.panel1.Controls.Add(this.EditButton);
            this.panel1.Controls.Add(this.AAButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 635);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 112);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "WOLFRAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ART GALLERY";
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ArtGallerySystem.Properties.Resources.vanGoghStarryNight1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(199, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 635);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.editDataButton);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.clearButton);
            this.panel7.Controls.Add(this.employeeDataRTB);
            this.panel7.Controls.Add(this.saveButton);
            this.panel7.Controls.Add(this.captureImgButton);
            this.panel7.Controls.Add(this.posTBox);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.nameTBox);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.cameraComboBox);
            this.panel7.Controls.Add(this.cameraPBox);
            this.panel7.Controls.Add(this.cameraButton);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(339, 635);
            this.panel7.TabIndex = 33;
            // 
            // editDataButton
            // 
            this.editDataButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.editDataButton.FlatAppearance.BorderSize = 0;
            this.editDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editDataButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.editDataButton.Location = new System.Drawing.Point(148, 594);
            this.editDataButton.Name = "editDataButton";
            this.editDataButton.Size = new System.Drawing.Size(70, 29);
            this.editDataButton.TabIndex = 47;
            this.editDataButton.Text = "Edit Data";
            this.editDataButton.UseVisualStyleBackColor = false;
            this.editDataButton.Click += new System.EventHandler(this.editDataButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 19);
            this.label5.TabIndex = 46;
            this.label5.Text = "Employee Data for Database:";
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.clearButton.Location = new System.Drawing.Point(28, 594);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(57, 29);
            this.clearButton.TabIndex = 43;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // employeeDataRTB
            // 
            this.employeeDataRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.employeeDataRTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.employeeDataRTB.Location = new System.Drawing.Point(28, 430);
            this.employeeDataRTB.Name = "employeeDataRTB";
            this.employeeDataRTB.Size = new System.Drawing.Size(284, 158);
            this.employeeDataRTB.TabIndex = 44;
            this.employeeDataRTB.Text = "";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.saveButton.Location = new System.Drawing.Point(224, 594);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(77, 29);
            this.saveButton.TabIndex = 45;
            this.saveButton.Text = "Add Data";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // captureImgButton
            // 
            this.captureImgButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.captureImgButton.FlatAppearance.BorderSize = 0;
            this.captureImgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.captureImgButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.captureImgButton.Location = new System.Drawing.Point(193, 203);
            this.captureImgButton.Name = "captureImgButton";
            this.captureImgButton.Size = new System.Drawing.Size(108, 29);
            this.captureImgButton.TabIndex = 42;
            this.captureImgButton.Text = "Capture Picture";
            this.captureImgButton.UseVisualStyleBackColor = false;
            this.captureImgButton.Click += new System.EventHandler(this.captureImgButton_Click);
            // 
            // posTBox
            // 
            this.posTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.posTBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.posTBox.Location = new System.Drawing.Point(83, 382);
            this.posTBox.Name = "posTBox";
            this.posTBox.Size = new System.Drawing.Size(218, 27);
            this.posTBox.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Position:";
            // 
            // nameTBox
            // 
            this.nameTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.nameTBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.nameTBox.Location = new System.Drawing.Point(70, 332);
            this.nameTBox.Name = "nameTBox";
            this.nameTBox.Size = new System.Drawing.Size(231, 27);
            this.nameTBox.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 19);
            this.label8.TabIndex = 38;
            this.label8.Text = "Name:";
            // 
            // cameraComboBox
            // 
            this.cameraComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.cameraComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.cameraComboBox.FormattingEnabled = true;
            this.cameraComboBox.Location = new System.Drawing.Point(28, 250);
            this.cameraComboBox.Name = "cameraComboBox";
            this.cameraComboBox.Size = new System.Drawing.Size(273, 27);
            this.cameraComboBox.TabIndex = 21;
            this.cameraComboBox.SelectedIndexChanged += new System.EventHandler(this.cameraComboBox_SelectedIndexChanged);
            // 
            // cameraPBox
            // 
            this.cameraPBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cameraPBox.Location = new System.Drawing.Point(28, 43);
            this.cameraPBox.Name = "cameraPBox";
            this.cameraPBox.Size = new System.Drawing.Size(273, 154);
            this.cameraPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cameraPBox.TabIndex = 11;
            this.cameraPBox.TabStop = false;
            // 
            // cameraButton
            // 
            this.cameraButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.cameraButton.FlatAppearance.BorderSize = 0;
            this.cameraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cameraButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.cameraButton.Location = new System.Drawing.Point(28, 203);
            this.cameraButton.Name = "cameraButton";
            this.cameraButton.Size = new System.Drawing.Size(94, 29);
            this.cameraButton.TabIndex = 20;
            this.cameraButton.Text = "Start Camera";
            this.cameraButton.UseVisualStyleBackColor = false;
            this.cameraButton.Click += new System.EventHandler(this.cameraButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.showAllButton);
            this.panel5.Controls.Add(this.IDtextbox);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.showDataButton);
            this.panel5.Controls.Add(this.displayListView);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.capturedImgPB);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(339, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(369, 635);
            this.panel5.TabIndex = 32;
            // 
            // showAllButton
            // 
            this.showAllButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.showAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.showAllButton.FlatAppearance.BorderSize = 0;
            this.showAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.showAllButton.Location = new System.Drawing.Point(277, 596);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(67, 29);
            this.showAllButton.TabIndex = 51;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = false;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // IDtextbox
            // 
            this.IDtextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.IDtextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.IDtextbox.Location = new System.Drawing.Point(53, 596);
            this.IDtextbox.Name = "IDtextbox";
            this.IDtextbox.Size = new System.Drawing.Size(118, 27);
            this.IDtextbox.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 599);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 19);
            this.label9.TabIndex = 48;
            this.label9.Text = "ID:";
            // 
            // showDataButton
            // 
            this.showDataButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.showDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.showDataButton.FlatAppearance.BorderSize = 0;
            this.showDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showDataButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.showDataButton.Location = new System.Drawing.Point(177, 596);
            this.showDataButton.Name = "showDataButton";
            this.showDataButton.Size = new System.Drawing.Size(76, 29);
            this.showDataButton.TabIndex = 50;
            this.showDataButton.Text = "Show Data";
            this.showDataButton.UseVisualStyleBackColor = false;
            this.showDataButton.Click += new System.EventHandler(this.showDataButton_Click);
            // 
            // displayListView
            // 
            this.displayListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.displayListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.displayListView.HideSelection = false;
            this.displayListView.Location = new System.Drawing.Point(25, 295);
            this.displayListView.Name = "displayListView";
            this.displayListView.Size = new System.Drawing.Size(319, 293);
            this.displayListView.TabIndex = 47;
            this.displayListView.UseCompatibleStateImageBehavior = false;
            this.displayListView.Click += new System.EventHandler(this.displayListView_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 46;
            this.label4.Text = "Image Preview:";
            // 
            // capturedImgPB
            // 
            this.capturedImgPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.capturedImgPB.Location = new System.Drawing.Point(53, 123);
            this.capturedImgPB.Name = "capturedImgPB";
            this.capturedImgPB.Size = new System.Drawing.Size(273, 154);
            this.capturedImgPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.capturedImgPB.TabIndex = 42;
            this.capturedImgPB.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panelAdminDropDown);
            this.panel6.Controls.Add(this.adminButton);
            this.panel6.Controls.Add(this.exitButton);
            this.panel6.Controls.Add(this.minButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(369, 98);
            this.panel6.TabIndex = 21;
            // 
            // panelAdminDropDown
            // 
            this.panelAdminDropDown.BackColor = System.Drawing.Color.Transparent;
            this.panelAdminDropDown.Controls.Add(this.LogOutButton);
            this.panelAdminDropDown.Location = new System.Drawing.Point(214, 43);
            this.panelAdminDropDown.Name = "panelAdminDropDown";
            this.panelAdminDropDown.Size = new System.Drawing.Size(90, 0);
            this.panelAdminDropDown.TabIndex = 31;
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogOutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(130)))), ((int)(((byte)(151)))));
            this.LogOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Location = new System.Drawing.Point(0, 0);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(90, 30);
            this.LogOutButton.TabIndex = 2;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.FlatAppearance.BorderSize = 0;
            this.adminButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(130)))), ((int)(((byte)(151)))));
            this.adminButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.adminButton.Image = global::ArtGallerySystem.Properties.Resources.admin_icon_small2;
            this.adminButton.Location = new System.Drawing.Point(214, 3);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(90, 40);
            this.adminButton.TabIndex = 3;
            this.adminButton.Text = "Admin";
            this.adminButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.adminButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(130)))), ((int)(((byte)(151)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Image = global::ArtGallerySystem.Properties.Resources.exit_button;
            this.exitButton.Location = new System.Drawing.Point(333, 3);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 40);
            this.exitButton.TabIndex = 28;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minButton
            // 
            this.minButton.FlatAppearance.BorderSize = 0;
            this.minButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(130)))), ((int)(((byte)(151)))));
            this.minButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.Image = global::ArtGallerySystem.Properties.Resources.min_button1;
            this.minButton.Location = new System.Drawing.Point(301, 3);
            this.minButton.Margin = new System.Windows.Forms.Padding(0);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(30, 40);
            this.minButton.TabIndex = 30;
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // empListButton
            // 
            this.empListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.empListButton.FlatAppearance.BorderSize = 0;
            this.empListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empListButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.empListButton.Image = global::ArtGallerySystem.Properties.Resources.browseEmpIcon;
            this.empListButton.Location = new System.Drawing.Point(0, 534);
            this.empListButton.Name = "empListButton";
            this.empListButton.Size = new System.Drawing.Size(199, 98);
            this.empListButton.TabIndex = 5;
            this.empListButton.Text = "Employee List";
            this.empListButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.empListButton.UseVisualStyleBackColor = false;
            this.empListButton.Click += new System.EventHandler(this.empListButton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.button4.Image = global::ArtGallerySystem.Properties.Resources.employeeIconUpdatedSelected;
            this.button4.Location = new System.Drawing.Point(0, 430);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 98);
            this.button4.TabIndex = 4;
            this.button4.Text = "Employee Data";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // browseButton
            // 
            this.browseButton.FlatAppearance.BorderSize = 0;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.Image = global::ArtGallerySystem.Properties.Resources.displayIcon1;
            this.browseButton.Location = new System.Drawing.Point(0, 326);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(199, 98);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "Browse Artworks";
            this.browseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Image = global::ArtGallerySystem.Properties.Resources.editiconsmall2;
            this.EditButton.Location = new System.Drawing.Point(0, 222);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(199, 98);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit Artworks";
            this.EditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AAButton
            // 
            this.AAButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.AAButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.AAButton.FlatAppearance.BorderSize = 0;
            this.AAButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AAButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.AAButton.Image = global::ArtGallerySystem.Properties.Resources.addiconFsmall2;
            this.AAButton.Location = new System.Drawing.Point(0, 118);
            this.AAButton.Name = "AAButton";
            this.AAButton.Size = new System.Drawing.Size(199, 98);
            this.AAButton.TabIndex = 1;
            this.AAButton.Text = "Add Artworks";
            this.AAButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AAButton.UseVisualStyleBackColor = false;
            this.AAButton.Click += new System.EventHandler(this.AAButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::ArtGallerySystem.Properties.Resources.wolf1;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(103, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(118, 96);
            this.panel4.TabIndex = 2;
            // 
            // Form4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(907, 635);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.VisibleChanged += new System.EventHandler(this.Form4_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraPBox)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capturedImgPB)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panelAdminDropDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button AAButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cameraButton;
        private System.Windows.Forms.PictureBox cameraPBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelAdminDropDown;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cameraComboBox;
        private System.Windows.Forms.TextBox posTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RichTextBox employeeDataRTB;
        private System.Windows.Forms.PictureBox capturedImgPB;
        private System.Windows.Forms.Button captureImgButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button empListButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button editDataButton;
        private System.Windows.Forms.ListView displayListView;
        private System.Windows.Forms.TextBox IDtextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Button showDataButton;
    }
}

