namespace WindowsFormsApp20
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.class27 = new WindowsFormsApp20.Class2();
            this.class26 = new WindowsFormsApp20.Class2();
            this.class24 = new WindowsFormsApp20.Class2();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(139, 131);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(464, 61);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Good Evening MR.Mohammed Salah";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(109, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1232, 95);
            this.panel3.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(392, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 565);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // class27
            // 
            this.class27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(182)))));
            this.class27.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(182)))));
            this.class27.BorderRadius = 40;
            this.class27.BorderSize = 0;
            this.class27.FlatAppearance.BorderSize = 0;
            this.class27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.class27.ForeColor = System.Drawing.Color.White;
            this.class27.Image = ((System.Drawing.Image)(resources.GetObject("class27.Image")));
            this.class27.Location = new System.Drawing.Point(12, 265);
            this.class27.Name = "class27";
            this.class27.Size = new System.Drawing.Size(85, 91);
            this.class27.TabIndex = 4;
            this.class27.TextColor = System.Drawing.Color.White;
            this.class27.UseVisualStyleBackColor = false;
            this.class27.Click += new System.EventHandler(this.class27_Click);
            this.class27.Enter += new System.EventHandler(this.class27_Enter);
            // 
            // class26
            // 
            this.class26.BackColor = System.Drawing.Color.LightGray;
            this.class26.BackgroundColor = System.Drawing.Color.LightGray;
            this.class26.BorderRadius = 40;
            this.class26.BorderSize = 0;
            this.class26.FlatAppearance.BorderSize = 0;
            this.class26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.class26.ForeColor = System.Drawing.Color.White;
            this.class26.Image = ((System.Drawing.Image)(resources.GetObject("class26.Image")));
            this.class26.Location = new System.Drawing.Point(12, 382);
            this.class26.Name = "class26";
            this.class26.Size = new System.Drawing.Size(84, 90);
            this.class26.TabIndex = 5;
            this.class26.TextColor = System.Drawing.Color.White;
            this.class26.UseVisualStyleBackColor = false;
            // 
            // class24
            // 
            this.class24.BackColor = System.Drawing.Color.LightGray;
            this.class24.BackgroundColor = System.Drawing.Color.LightGray;
            this.class24.BorderRadius = 40;
            this.class24.BorderSize = 0;
            this.class24.FlatAppearance.BorderSize = 0;
            this.class24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.class24.ForeColor = System.Drawing.Color.White;
            this.class24.Image = ((System.Drawing.Image)(resources.GetObject("class24.Image")));
            this.class24.Location = new System.Drawing.Point(12, 141);
            this.class24.Name = "class24";
            this.class24.Size = new System.Drawing.Size(85, 93);
            this.class24.TabIndex = 6;
            this.class24.TextColor = System.Drawing.Color.White;
            this.class24.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.class24);
            this.panel4.Controls.Add(this.class26);
            this.panel4.Controls.Add(this.class27);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(109, 777);
            this.panel4.TabIndex = 8;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1341, 777);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.richTextBox1);
            this.Name = "home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Class2 class27;
        private Class2 class26;
        private Class2 class24;
        private System.Windows.Forms.Panel panel4;
    }
}

