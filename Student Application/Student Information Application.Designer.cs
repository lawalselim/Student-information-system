namespace Student_Application
{
    partial class Student_Information_Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Information_Application));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnadmin = new System.Windows.Forms.Button();
            this.btnregstd = new System.Windows.Forms.Button();
            this.btnviewstd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnadmin
            // 
            this.btnadmin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnadmin, "btnadmin");
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.UseVisualStyleBackColor = false;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // btnregstd
            // 
            this.btnregstd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnregstd, "btnregstd");
            this.btnregstd.Name = "btnregstd";
            this.btnregstd.UseVisualStyleBackColor = false;
            this.btnregstd.Click += new System.EventHandler(this.btnregstd_Click);
            // 
            // btnviewstd
            // 
            this.btnviewstd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnviewstd, "btnviewstd");
            this.btnviewstd.Name = "btnviewstd";
            this.btnviewstd.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Student_Information_Application
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnviewstd);
            this.Controls.Add(this.btnregstd);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Name = "Student_Information_Application";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Student_Information_Application_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Button btnregstd;
        private System.Windows.Forms.Button btnviewstd;
        private System.Windows.Forms.Button button1;
    }
}