namespace BookEntrySystem
{
    partial class BOOKS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BOOKS));
            this.btntranslations = new System.Windows.Forms.Button();
            this.btnshortstory = new System.Windows.Forms.Button();
            this.btnnovels = new System.Windows.Forms.Button();
            this.btnsubjectbooks = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btntranslations
            // 
            this.btntranslations.Location = new System.Drawing.Point(228, 357);
            this.btntranslations.Name = "btntranslations";
            this.btntranslations.Size = new System.Drawing.Size(140, 47);
            this.btntranslations.TabIndex = 0;
            this.btntranslations.Text = "TRANSLATIONS";
            this.btntranslations.UseVisualStyleBackColor = true;
            this.btntranslations.Click += new System.EventHandler(this.btntranslations_Click);
            // 
            // btnshortstory
            // 
            this.btnshortstory.Location = new System.Drawing.Point(331, 281);
            this.btnshortstory.Name = "btnshortstory";
            this.btnshortstory.Size = new System.Drawing.Size(143, 45);
            this.btnshortstory.TabIndex = 1;
            this.btnshortstory.Text = "SHORT STORY";
            this.btnshortstory.UseVisualStyleBackColor = true;
            this.btnshortstory.Click += new System.EventHandler(this.btnshortstory_Click);
            // 
            // btnnovels
            // 
            this.btnnovels.Location = new System.Drawing.Point(128, 281);
            this.btnnovels.Name = "btnnovels";
            this.btnnovels.Size = new System.Drawing.Size(143, 47);
            this.btnnovels.TabIndex = 2;
            this.btnnovels.Text = "NOVELS";
            this.btnnovels.UseVisualStyleBackColor = true;
            this.btnnovels.Click += new System.EventHandler(this.btnnovels_Click);
            // 
            // btnsubjectbooks
            // 
            this.btnsubjectbooks.Location = new System.Drawing.Point(26, 359);
            this.btnsubjectbooks.Name = "btnsubjectbooks";
            this.btnsubjectbooks.Size = new System.Drawing.Size(140, 45);
            this.btnsubjectbooks.TabIndex = 3;
            this.btnsubjectbooks.Text = "SUBJECT BOOKS";
            this.btnsubjectbooks.UseVisualStyleBackColor = true;
            this.btnsubjectbooks.Click += new System.EventHandler(this.btnsubjectbooks_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(446, 358);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(123, 45);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "~SAMAGI BOOK SHOP~";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "PANADURA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 51);
            this.label3.TabIndex = 10;
            this.label3.Text = "TP-0382278654,EMAIL-samagibs@gmail.com\r\n               NO12,galle road,panadura\r\n" +
                "\r\n";
            // 
            // BOOKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(637, 416);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnsubjectbooks);
            this.Controls.Add(this.btnnovels);
            this.Controls.Add(this.btnshortstory);
            this.Controls.Add(this.btntranslations);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BOOKS";
            this.Text = "BOOKS";
            this.Load += new System.EventHandler(this.BOOKS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntranslations;
        private System.Windows.Forms.Button btnshortstory;
        private System.Windows.Forms.Button btnnovels;
        private System.Windows.Forms.Button btnsubjectbooks;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}