namespace Foto_album
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Folder_startowy = new System.Windows.Forms.Label();
            this.Wybierz_F = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Wybierz_2 = new System.Windows.Forms.Button();
            this.Kopiuj = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Folder_startowy
            // 
            this.Folder_startowy.AutoSize = true;
            this.Folder_startowy.BackColor = System.Drawing.Color.Transparent;
            this.Folder_startowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Folder_startowy.Location = new System.Drawing.Point(64, 83);
            this.Folder_startowy.Name = "Folder_startowy";
            this.Folder_startowy.Size = new System.Drawing.Size(236, 37);
            this.Folder_startowy.TabIndex = 0;
            this.Folder_startowy.Text = "Folder startowy";
            // 
            // Wybierz_F
            // 
            this.Wybierz_F.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Wybierz_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wybierz_F.Location = new System.Drawing.Point(70, 190);
            this.Wybierz_F.Name = "Wybierz_F";
            this.Wybierz_F.Size = new System.Drawing.Size(170, 40);
            this.Wybierz_F.TabIndex = 1;
            this.Wybierz_F.Text = "Wybierz folder";
            this.Wybierz_F.UseVisualStyleBackColor = false;
            this.Wybierz_F.Click += new System.EventHandler(this.Wybierz_F_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(458, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Folder Wynikowy";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(465, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 26);
            this.textBox2.TabIndex = 4;
            // 
            // Wybierz_2
            // 
            this.Wybierz_2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Wybierz_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wybierz_2.Location = new System.Drawing.Point(465, 190);
            this.Wybierz_2.Name = "Wybierz_2";
            this.Wybierz_2.Size = new System.Drawing.Size(170, 40);
            this.Wybierz_2.TabIndex = 5;
            this.Wybierz_2.Text = "Wybierz";
            this.Wybierz_2.UseVisualStyleBackColor = false;
            this.Wybierz_2.Click += new System.EventHandler(this.Wybierz_2_Click);
            // 
            // Kopiuj
            // 
            this.Kopiuj.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Kopiuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kopiuj.Location = new System.Drawing.Point(307, 288);
            this.Kopiuj.Name = "Kopiuj";
            this.Kopiuj.Size = new System.Drawing.Size(160, 60);
            this.Kopiuj.TabIndex = 6;
            this.Kopiuj.Text = "Kopiuj";
            this.Kopiuj.UseVisualStyleBackColor = false;
            this.Kopiuj.Click += new System.EventHandler(this.Kopiuj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.Kopiuj);
            this.Controls.Add(this.Wybierz_2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Wybierz_F);
            this.Controls.Add(this.Folder_startowy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label Folder_startowy;
        private System.Windows.Forms.Button Wybierz_F;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Wybierz_2;
        private System.Windows.Forms.Button Kopiuj;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

