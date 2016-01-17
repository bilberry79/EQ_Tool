namespace EQ_Tool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.EQInfo_label1 = new System.Windows.Forms.Label();
            this.Get_button = new System.Windows.Forms.Button();
            this.EQInfo_label2 = new System.Windows.Forms.Label();
            this.EQInfo_label3 = new System.Windows.Forms.Label();
            this.head_label1 = new System.Windows.Forms.Label();
            this.head_label2 = new System.Windows.Forms.Label();
            this.head_label3 = new System.Windows.Forms.Label();
            this.Today_label = new System.Windows.Forms.Label();
            this.my_dyn_loc_label1 = new System.Windows.Forms.Label();
            this.head_label4 = new System.Windows.Forms.Label();
            this.EQInfo_label4 = new System.Windows.Forms.Label();
            this.location_linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // EQInfo_label1
            // 
            this.EQInfo_label1.AutoSize = true;
            this.EQInfo_label1.Location = new System.Drawing.Point(205, 231);
            this.EQInfo_label1.Name = "EQInfo_label1";
            this.EQInfo_label1.Size = new System.Drawing.Size(35, 13);
            this.EQInfo_label1.TabIndex = 0;
            this.EQInfo_label1.Text = "label1";
            // 
            // Get_button
            // 
            this.Get_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Get_button.Location = new System.Drawing.Point(11, 83);
            this.Get_button.Name = "Get_button";
            this.Get_button.Size = new System.Drawing.Size(148, 23);
            this.Get_button.TabIndex = 1;
            this.Get_button.Text = "Get quakes of last week";
            this.Get_button.UseVisualStyleBackColor = true;
            this.Get_button.Click += new System.EventHandler(this.Get_button_Click);
            // 
            // EQInfo_label2
            // 
            this.EQInfo_label2.AutoSize = true;
            this.EQInfo_label2.Location = new System.Drawing.Point(124, 67);
            this.EQInfo_label2.Name = "EQInfo_label2";
            this.EQInfo_label2.Size = new System.Drawing.Size(35, 13);
            this.EQInfo_label2.TabIndex = 2;
            this.EQInfo_label2.Text = "label1";
            // 
            // EQInfo_label3
            // 
            this.EQInfo_label3.AutoSize = true;
            this.EQInfo_label3.Location = new System.Drawing.Point(269, 67);
            this.EQInfo_label3.Name = "EQInfo_label3";
            this.EQInfo_label3.Size = new System.Drawing.Size(35, 13);
            this.EQInfo_label3.TabIndex = 3;
            this.EQInfo_label3.Text = "label2";
            // 
            // head_label1
            // 
            this.head_label1.AutoSize = true;
            this.head_label1.Location = new System.Drawing.Point(9, 47);
            this.head_label1.Name = "head_label1";
            this.head_label1.Size = new System.Drawing.Size(39, 13);
            this.head_label1.TabIndex = 4;
            this.head_label1.Text = "Where";
            // 
            // head_label2
            // 
            this.head_label2.AutoSize = true;
            this.head_label2.Location = new System.Drawing.Point(124, 47);
            this.head_label2.Name = "head_label2";
            this.head_label2.Size = new System.Drawing.Size(36, 13);
            this.head_label2.TabIndex = 5;
            this.head_label2.Text = "When";
            // 
            // head_label3
            // 
            this.head_label3.AutoSize = true;
            this.head_label3.Location = new System.Drawing.Point(269, 47);
            this.head_label3.Name = "head_label3";
            this.head_label3.Size = new System.Drawing.Size(57, 13);
            this.head_label3.TabIndex = 6;
            this.head_label3.Text = "Magnitude";
            // 
            // Today_label
            // 
            this.Today_label.AutoSize = true;
            this.Today_label.Location = new System.Drawing.Point(9, 9);
            this.Today_label.Name = "Today_label";
            this.Today_label.Size = new System.Drawing.Size(35, 13);
            this.Today_label.TabIndex = 7;
            this.Today_label.Text = "label1";
            // 
            // my_dyn_loc_label1
            // 
            this.my_dyn_loc_label1.AutoSize = true;
            this.my_dyn_loc_label1.Location = new System.Drawing.Point(184, 9);
            this.my_dyn_loc_label1.Name = "my_dyn_loc_label1";
            this.my_dyn_loc_label1.Size = new System.Drawing.Size(35, 13);
            this.my_dyn_loc_label1.TabIndex = 8;
            this.my_dyn_loc_label1.Text = "label1";
            // 
            // head_label4
            // 
            this.head_label4.AutoSize = true;
            this.head_label4.Location = new System.Drawing.Point(364, 47);
            this.head_label4.Name = "head_label4";
            this.head_label4.Size = new System.Drawing.Size(169, 13);
            this.head_label4.TabIndex = 9;
            this.head_label4.Text = "Distance from your location (in km)";
            // 
            // EQInfo_label4
            // 
            this.EQInfo_label4.AutoSize = true;
            this.EQInfo_label4.Location = new System.Drawing.Point(364, 67);
            this.EQInfo_label4.Name = "EQInfo_label4";
            this.EQInfo_label4.Size = new System.Drawing.Size(35, 13);
            this.EQInfo_label4.TabIndex = 10;
            this.EQInfo_label4.Text = "label2";
            // 
            // location_linkLabel1
            // 
            this.location_linkLabel1.AutoSize = true;
            this.location_linkLabel1.Location = new System.Drawing.Point(9, 67);
            this.location_linkLabel1.Name = "location_linkLabel1";
            this.location_linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.location_linkLabel1.TabIndex = 11;
            this.location_linkLabel1.TabStop = true;
            this.location_linkLabel1.Text = "linkLabel1";
            this.location_linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.location_linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 118);
            this.Controls.Add(this.location_linkLabel1);
            this.Controls.Add(this.EQInfo_label4);
            this.Controls.Add(this.head_label4);
            this.Controls.Add(this.my_dyn_loc_label1);
            this.Controls.Add(this.Today_label);
            this.Controls.Add(this.head_label3);
            this.Controls.Add(this.head_label2);
            this.Controls.Add(this.head_label1);
            this.Controls.Add(this.EQInfo_label3);
            this.Controls.Add(this.EQInfo_label2);
            this.Controls.Add(this.Get_button);
            this.Controls.Add(this.EQInfo_label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "Quake Buddy 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EQInfo_label1;
        private System.Windows.Forms.Button Get_button;
        private System.Windows.Forms.Label EQInfo_label2;
        private System.Windows.Forms.Label EQInfo_label3;
        private System.Windows.Forms.Label head_label1;
        private System.Windows.Forms.Label head_label2;
        private System.Windows.Forms.Label head_label3;
        private System.Windows.Forms.Label Today_label;
        private System.Windows.Forms.Label my_dyn_loc_label1;
        private System.Windows.Forms.Label head_label4;
        private System.Windows.Forms.Label EQInfo_label4;
        private System.Windows.Forms.LinkLabel location_linkLabel1;
    }
}

