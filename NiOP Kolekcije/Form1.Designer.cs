namespace NiOP_Kolekcije
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
            this.Unesi = new System.Windows.Forms.Button();
            this.Obradi = new System.Windows.Forms.Button();
            this.Ispisi = new System.Windows.Forms.Button();
            this.TextKutija = new System.Windows.Forms.RichTextBox();
            this.Podatak1 = new System.Windows.Forms.TextBox();
            this.Podatak2 = new System.Windows.Forms.TextBox();
            this.Podatak3 = new System.Windows.Forms.TextBox();
            this.Podatak4 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Unesi
            // 
            this.Unesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Unesi.Location = new System.Drawing.Point(139, 17);
            this.Unesi.Name = "Unesi";
            this.Unesi.Size = new System.Drawing.Size(164, 75);
            this.Unesi.TabIndex = 0;
            this.Unesi.Text = "Unesi";
            this.Unesi.UseVisualStyleBackColor = false;
            this.Unesi.Click += new System.EventHandler(this.Unesi_Click);
            // 
            // Obradi
            // 
            this.Obradi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Obradi.Location = new System.Drawing.Point(309, 18);
            this.Obradi.Name = "Obradi";
            this.Obradi.Size = new System.Drawing.Size(164, 75);
            this.Obradi.TabIndex = 1;
            this.Obradi.Text = "Obradi";
            this.Obradi.UseVisualStyleBackColor = false;
            this.Obradi.Click += new System.EventHandler(this.Obradi_Click);
            // 
            // Ispisi
            // 
            this.Ispisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Ispisi.Location = new System.Drawing.Point(479, 18);
            this.Ispisi.Name = "Ispisi";
            this.Ispisi.Size = new System.Drawing.Size(164, 75);
            this.Ispisi.TabIndex = 2;
            this.Ispisi.Text = "Ispiši";
            this.Ispisi.UseVisualStyleBackColor = false;
            this.Ispisi.Click += new System.EventHandler(this.Ispisi_Click);
            // 
            // TextKutija
            // 
            this.TextKutija.Location = new System.Drawing.Point(139, 99);
            this.TextKutija.Name = "TextKutija";
            this.TextKutija.Size = new System.Drawing.Size(504, 292);
            this.TextKutija.TabIndex = 3;
            this.TextKutija.Text = "";
            // 
            // Podatak1
            // 
            this.Podatak1.Location = new System.Drawing.Point(12, 99);
            this.Podatak1.Name = "Podatak1";
            this.Podatak1.Size = new System.Drawing.Size(121, 20);
            this.Podatak1.TabIndex = 4;
            this.Podatak1.Text = "Podatak1";
            // 
            // Podatak2
            // 
            this.Podatak2.Location = new System.Drawing.Point(12, 125);
            this.Podatak2.Name = "Podatak2";
            this.Podatak2.Size = new System.Drawing.Size(121, 20);
            this.Podatak2.TabIndex = 5;
            this.Podatak2.Text = "Podatak2";
            // 
            // Podatak3
            // 
            this.Podatak3.Location = new System.Drawing.Point(12, 151);
            this.Podatak3.Name = "Podatak3";
            this.Podatak3.Size = new System.Drawing.Size(121, 20);
            this.Podatak3.TabIndex = 6;
            this.Podatak3.Text = "Podatak3";
            // 
            // Podatak4
            // 
            this.Podatak4.FormattingEnabled = true;
            this.Podatak4.Items.AddRange(new object[] {
            "M",
            "Ž"});
            this.Podatak4.Location = new System.Drawing.Point(12, 177);
            this.Podatak4.Name = "Podatak4";
            this.Podatak4.Size = new System.Drawing.Size(121, 21);
            this.Podatak4.TabIndex = 7;
            this.Podatak4.Text = "Podatak4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.Podatak4);
            this.Controls.Add(this.Podatak3);
            this.Controls.Add(this.Podatak2);
            this.Controls.Add(this.Podatak1);
            this.Controls.Add(this.TextKutija);
            this.Controls.Add(this.Ispisi);
            this.Controls.Add(this.Obradi);
            this.Controls.Add(this.Unesi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Unesi;
        private System.Windows.Forms.Button Obradi;
        private System.Windows.Forms.Button Ispisi;
        private System.Windows.Forms.RichTextBox TextKutija;
        private System.Windows.Forms.TextBox Podatak1;
        private System.Windows.Forms.TextBox Podatak2;
        private System.Windows.Forms.TextBox Podatak3;
        private System.Windows.Forms.ComboBox Podatak4;
    }
}

