﻿namespace ArtGallerySystem
{
    partial class Form2
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
            this.empListButton = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AAButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.showAllButton = new System.Windows.Forms.Button();
            this.deleteDataButton = new System.Windows.Forms.Button();
            this.showDataButton = new System.Windows.Forms.Button();
            this.IDtextbox = new System.Windows.Forms.TextBox();
            this.displayListView = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.yearTBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.editDataButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.titleTBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.priceTBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mediumTBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.birthplaceTBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.artistTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelAdminDropDown = new System.Windows.Forms.Panel();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.uploadIMGButton = new System.Windows.Forms.Button();
            this.artworkPBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelAdminDropDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artworkPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.empListButton);
            this.panel1.Controls.Add(this.employeeButton);
            this.panel1.Controls.Add(this.browseButton);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.AAButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 635);
            this.panel1.TabIndex = 0;
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
            this.empListButton.TabIndex = 6;
            this.empListButton.Text = "Employee List";
            this.empListButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.empListButton.UseVisualStyleBackColor = false;
            this.empListButton.Click += new System.EventHandler(this.empListButton_Click);
            // 
            // employeeButton
            // 
            this.employeeButton.FlatAppearance.BorderSize = 0;
            this.employeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeButton.Image = global::ArtGallerySystem.Properties.Resources.employeeIconUpdated;
            this.employeeButton.Location = new System.Drawing.Point(0, 430);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(199, 98);
            this.employeeButton.TabIndex = 4;
            this.employeeButton.Text = "Employee Data";
            this.employeeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.employeeButton.UseVisualStyleBackColor = true;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.button2.Image = global::ArtGallerySystem.Properties.Resources.editiconsmallSelected;
            this.button2.Location = new System.Drawing.Point(0, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 98);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edit Artworks";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
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
            // panel4
            // 
            this.panel4.BackgroundImage = global::ArtGallerySystem.Properties.Resources.wolf1;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(103, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(118, 96);
            this.panel4.TabIndex = 2;
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
            this.panel2.Size = new System.Drawing.Size(937, 635);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.showAllButton);
            this.panel7.Controls.Add(this.deleteDataButton);
            this.panel7.Controls.Add(this.showDataButton);
            this.panel7.Controls.Add(this.IDtextbox);
            this.panel7.Controls.Add(this.displayListView);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.yearTBox);
            this.panel7.Controls.Add(this.clearButton);
            this.panel7.Controls.Add(this.editDataButton);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.titleTBox);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.priceTBox);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.mediumTBox);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.birthplaceTBox);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.artistTBox);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(643, 635);
            this.panel7.TabIndex = 33;
            // 
            // showAllButton
            // 
            this.showAllButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.showAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.showAllButton.FlatAppearance.BorderSize = 0;
            this.showAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.showAllButton.Location = new System.Drawing.Point(529, 342);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(101, 29);
            this.showAllButton.TabIndex = 48;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = false;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // deleteDataButton
            // 
            this.deleteDataButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.deleteDataButton.FlatAppearance.BorderSize = 0;
            this.deleteDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteDataButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.deleteDataButton.Location = new System.Drawing.Point(520, 566);
            this.deleteDataButton.Name = "deleteDataButton";
            this.deleteDataButton.Size = new System.Drawing.Size(116, 29);
            this.deleteDataButton.TabIndex = 46;
            this.deleteDataButton.Text = "Delete Data";
            this.deleteDataButton.UseVisualStyleBackColor = false;
            this.deleteDataButton.Click += new System.EventHandler(this.deleteDataButton_Click);
            // 
            // showDataButton
            // 
            this.showDataButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.showDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.showDataButton.FlatAppearance.BorderSize = 0;
            this.showDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showDataButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.showDataButton.Location = new System.Drawing.Point(196, 344);
            this.showDataButton.Name = "showDataButton";
            this.showDataButton.Size = new System.Drawing.Size(101, 29);
            this.showDataButton.TabIndex = 45;
            this.showDataButton.Text = "Show Data";
            this.showDataButton.UseVisualStyleBackColor = false;
            this.showDataButton.Click += new System.EventHandler(this.showDataButton_Click);
            // 
            // IDtextbox
            // 
            this.IDtextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.IDtextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.IDtextbox.Location = new System.Drawing.Point(50, 344);
            this.IDtextbox.Name = "IDtextbox";
            this.IDtextbox.Size = new System.Drawing.Size(140, 27);
            this.IDtextbox.TabIndex = 47;
            // 
            // displayListView
            // 
            this.displayListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.displayListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.displayListView.HideSelection = false;
            this.displayListView.Location = new System.Drawing.Point(13, 46);
            this.displayListView.Name = "displayListView";
            this.displayListView.Size = new System.Drawing.Size(617, 290);
            this.displayListView.TabIndex = 44;
            this.displayListView.UseCompatibleStateImageBehavior = false;
            this.displayListView.Click += new System.EventHandler(this.displayListView_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 19);
            this.label9.TabIndex = 46;
            this.label9.Text = "ID:";
            // 
            // yearTBox
            // 
            this.yearTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.yearTBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.yearTBox.Location = new System.Drawing.Point(119, 474);
            this.yearTBox.Name = "yearTBox";
            this.yearTBox.Size = new System.Drawing.Size(197, 27);
            this.yearTBox.TabIndex = 43;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.clearButton.Location = new System.Drawing.Point(19, 566);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(152, 29);
            this.clearButton.TabIndex = 42;
            this.clearButton.Text = "Clear Text Boxes";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // editDataButton
            // 
            this.editDataButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.editDataButton.FlatAppearance.BorderSize = 0;
            this.editDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editDataButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.editDataButton.Location = new System.Drawing.Point(397, 566);
            this.editDataButton.Name = "editDataButton";
            this.editDataButton.Size = new System.Drawing.Size(102, 29);
            this.editDataButton.TabIndex = 40;
            this.editDataButton.Text = "Edit Data";
            this.editDataButton.UseVisualStyleBackColor = false;
            this.editDataButton.Click += new System.EventHandler(this.editDataButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 38;
            this.label7.Text = "Year Painted:";
            // 
            // titleTBox
            // 
            this.titleTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.titleTBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.titleTBox.Location = new System.Drawing.Point(56, 435);
            this.titleTBox.Name = "titleTBox";
            this.titleTBox.Size = new System.Drawing.Size(260, 27);
            this.titleTBox.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 19);
            this.label8.TabIndex = 36;
            this.label8.Text = "Title: ";
            // 
            // priceTBox
            // 
            this.priceTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.priceTBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.priceTBox.Location = new System.Drawing.Point(392, 516);
            this.priceTBox.Name = "priceTBox";
            this.priceTBox.Size = new System.Drawing.Size(245, 27);
            this.priceTBox.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Price:";
            // 
            // mediumTBox
            // 
            this.mediumTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.mediumTBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.mediumTBox.Location = new System.Drawing.Point(454, 474);
            this.mediumTBox.Name = "mediumTBox";
            this.mediumTBox.Size = new System.Drawing.Size(183, 27);
            this.mediumTBox.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Medium Used: ";
            // 
            // birthplaceTBox
            // 
            this.birthplaceTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.birthplaceTBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.birthplaceTBox.Location = new System.Drawing.Point(428, 430);
            this.birthplaceTBox.Name = "birthplaceTBox";
            this.birthplaceTBox.Size = new System.Drawing.Size(209, 27);
            this.birthplaceTBox.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Birthplace:";
            // 
            // artistTBox
            // 
            this.artistTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.artistTBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.artistTBox.Location = new System.Drawing.Point(71, 512);
            this.artistTBox.Name = "artistTBox";
            this.artistTBox.Size = new System.Drawing.Size(245, 27);
            this.artistTBox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Artist:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.uploadIMGButton);
            this.panel5.Controls.Add(this.artworkPBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(643, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(294, 635);
            this.panel5.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(87, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 25);
            this.label10.TabIndex = 46;
            this.label10.Text = "Artwork Preview:";
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
            this.panel6.Size = new System.Drawing.Size(294, 98);
            this.panel6.TabIndex = 21;
            // 
            // panelAdminDropDown
            // 
            this.panelAdminDropDown.BackColor = System.Drawing.Color.Transparent;
            this.panelAdminDropDown.Controls.Add(this.LogOutButton);
            this.panelAdminDropDown.Location = new System.Drawing.Point(142, 43);
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
            this.adminButton.Location = new System.Drawing.Point(142, 3);
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
            this.exitButton.Location = new System.Drawing.Point(261, 3);
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
            this.minButton.Location = new System.Drawing.Point(229, 3);
            this.minButton.Margin = new System.Windows.Forms.Padding(0);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(30, 40);
            this.minButton.TabIndex = 30;
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // uploadIMGButton
            // 
            this.uploadIMGButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.uploadIMGButton.FlatAppearance.BorderSize = 0;
            this.uploadIMGButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadIMGButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.uploadIMGButton.Location = new System.Drawing.Point(100, 550);
            this.uploadIMGButton.Name = "uploadIMGButton";
            this.uploadIMGButton.Size = new System.Drawing.Size(118, 29);
            this.uploadIMGButton.TabIndex = 20;
            this.uploadIMGButton.Text = "Upload Image";
            this.uploadIMGButton.UseVisualStyleBackColor = false;
            this.uploadIMGButton.Click += new System.EventHandler(this.uploadIMGButton_Click);
            // 
            // artworkPBox
            // 
            this.artworkPBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.artworkPBox.Location = new System.Drawing.Point(20, 158);
            this.artworkPBox.Name = "artworkPBox";
            this.artworkPBox.Size = new System.Drawing.Size(262, 370);
            this.artworkPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.artworkPBox.TabIndex = 11;
            this.artworkPBox.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1136, 635);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panelAdminDropDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.artworkPBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button AAButton;
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button uploadIMGButton;
        private System.Windows.Forms.PictureBox artworkPBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelAdminDropDown;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button editDataButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox titleTBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox priceTBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mediumTBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox birthplaceTBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox artistTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox yearTBox;
        private System.Windows.Forms.Button showDataButton;
        private System.Windows.Forms.ListView displayListView;
        private System.Windows.Forms.Button deleteDataButton;
        private System.Windows.Forms.TextBox IDtextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button empListButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button showAllButton;
    }
}

