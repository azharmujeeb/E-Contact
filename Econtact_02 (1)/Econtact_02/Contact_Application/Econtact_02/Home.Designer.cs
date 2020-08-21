namespace Econtact_02
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnadd1 = new System.Windows.Forms.Button();
            this.btnupdate1 = new System.Windows.Forms.Button();
            this.btndelete1 = new System.Windows.Forms.Button();
            this.btnview1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(448, 178);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 81);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnadd1
            // 
            this.btnadd1.BackColor = System.Drawing.Color.Green;
            this.btnadd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd1.ForeColor = System.Drawing.Color.White;
            this.btnadd1.Location = new System.Drawing.Point(138, 392);
            this.btnadd1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnadd1.Name = "btnadd1";
            this.btnadd1.Size = new System.Drawing.Size(164, 58);
            this.btnadd1.TabIndex = 1;
            this.btnadd1.Text = "ADD";
            this.btnadd1.UseVisualStyleBackColor = false;
            this.btnadd1.Click += new System.EventHandler(this.btnadd1_Click);
            // 
            // btnupdate1
            // 
            this.btnupdate1.BackColor = System.Drawing.Color.Gold;
            this.btnupdate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate1.ForeColor = System.Drawing.Color.White;
            this.btnupdate1.Location = new System.Drawing.Point(376, 392);
            this.btnupdate1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnupdate1.Name = "btnupdate1";
            this.btnupdate1.Size = new System.Drawing.Size(164, 58);
            this.btnupdate1.TabIndex = 2;
            this.btnupdate1.Text = "UPDATE";
            this.btnupdate1.UseVisualStyleBackColor = false;
            this.btnupdate1.Click += new System.EventHandler(this.btnupdate1_Click);
            // 
            // btndelete1
            // 
            this.btndelete1.BackColor = System.Drawing.Color.Red;
            this.btndelete1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete1.ForeColor = System.Drawing.Color.White;
            this.btndelete1.Location = new System.Drawing.Point(614, 392);
            this.btndelete1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndelete1.Name = "btndelete1";
            this.btndelete1.Size = new System.Drawing.Size(164, 58);
            this.btndelete1.TabIndex = 3;
            this.btndelete1.Text = "DELETE";
            this.btndelete1.UseVisualStyleBackColor = false;
            this.btndelete1.Click += new System.EventHandler(this.btndelete1_Click);
            // 
            // btnview1
            // 
            this.btnview1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnview1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview1.ForeColor = System.Drawing.Color.White;
            this.btnview1.Location = new System.Drawing.Point(846, 392);
            this.btnview1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnview1.Name = "btnview1";
            this.btnview1.Size = new System.Drawing.Size(164, 58);
            this.btnview1.TabIndex = 4;
            this.btnview1.Text = "VIEW";
            this.btnview1.UseVisualStyleBackColor = false;
            this.btnview1.Click += new System.EventHandler(this.btnview1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1144, 615);
            this.Controls.Add(this.btnview1);
            this.Controls.Add(this.btndelete1);
            this.Controls.Add(this.btnupdate1);
            this.Controls.Add(this.btnadd1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnadd1;
        private System.Windows.Forms.Button btnupdate1;
        private System.Windows.Forms.Button btndelete1;
        private System.Windows.Forms.Button btnview1;
    }
}

