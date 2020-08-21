namespace Econtact_02
{
    partial class delete4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btndelete4 = new System.Windows.Forms.Button();
            this.btnback4 = new System.Windows.Forms.Button();
            this.txtfirstname4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Contact";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // btndelete4
            // 
            this.btndelete4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete4.Location = new System.Drawing.Point(67, 131);
            this.btndelete4.Name = "btndelete4";
            this.btndelete4.Size = new System.Drawing.Size(92, 27);
            this.btndelete4.TabIndex = 3;
            this.btndelete4.Text = "DELETE";
            this.btndelete4.UseVisualStyleBackColor = true;
            this.btndelete4.Click += new System.EventHandler(this.btndelete4_Click);
            // 
            // btnback4
            // 
            this.btnback4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback4.Location = new System.Drawing.Point(183, 131);
            this.btnback4.Name = "btnback4";
            this.btnback4.Size = new System.Drawing.Size(92, 27);
            this.btnback4.TabIndex = 4;
            this.btnback4.Text = "BACK";
            this.btnback4.UseVisualStyleBackColor = true;
            this.btnback4.Click += new System.EventHandler(this.btnback4_Click);
            // 
            // txtfirstname4
            // 
            this.txtfirstname4.Location = new System.Drawing.Point(157, 88);
            this.txtfirstname4.Name = "txtfirstname4";
            this.txtfirstname4.Size = new System.Drawing.Size(154, 20);
            this.txtfirstname4.TabIndex = 5;
            // 
            // delete4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(363, 205);
            this.Controls.Add(this.txtfirstname4);
            this.Controls.Add(this.btnback4);
            this.Controls.Add(this.btndelete4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "delete4";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndelete4;
        private System.Windows.Forms.Button btnback4;
        private System.Windows.Forms.TextBox txtfirstname4;
    }
}