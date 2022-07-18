namespace ArtGallerySystem
{
    partial class Form5
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
            this.button1 = new System.Windows.Forms.Button();
            this.employeeButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AAButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelAdminDropDown = new System.Windows.Forms.Panel();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelAdminDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.employeeButton);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.button1.Image = global::ArtGallerySystem.Properties.Resources.browseEmpIconSelected;
            this.button1.Location = new System.Drawing.Point(0, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 98);
            this.button1.TabIndex = 6;
            this.button1.Text = "Employee List";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
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
            this.browseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.browseButton.FlatAppearance.BorderSize = 0;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.browseButton.Image = global::ArtGallerySystem.Properties.Resources.displayIcon1;
            this.browseButton.Location = new System.Drawing.Point(0, 326);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(199, 98);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "Browse Artworks";
            this.browseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.browseButton.UseVisualStyleBackColor = false;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(205, 79);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(690, 544);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.panelAdminDropDown);
            this.panel6.Controls.Add(this.adminButton);
            this.panel6.Controls.Add(this.exitButton);
            this.panel6.Controls.Add(this.minButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(199, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(708, 70);
            this.panel6.TabIndex = 33;
            // 
            // panelAdminDropDown
            // 
            this.panelAdminDropDown.BackColor = System.Drawing.Color.Transparent;
            this.panelAdminDropDown.Controls.Add(this.LogOutButton);
            this.panelAdminDropDown.Location = new System.Drawing.Point(552, 43);
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
            this.adminButton.Location = new System.Drawing.Point(552, 3);
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
            this.exitButton.Location = new System.Drawing.Point(670, 3);
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
            this.minButton.Location = new System.Drawing.Point(639, 3);
            this.minButton.Margin = new System.Windows.Forms.Padding(0);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(30, 40);
            this.minButton.TabIndex = 30;
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // Form5
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.BackgroundImage = global::ArtGallerySystem.Properties.Resources.vanGoghStarryNight1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 635);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Button employeeButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelAdminDropDown;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button button1;
    }
}

