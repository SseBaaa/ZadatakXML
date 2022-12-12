
namespace ZadatakXML
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
            this.buttonUnesi = new System.Windows.Forms.Button();
            this.buttonKorisnici = new System.Windows.Forms.Button();
            this.buttonPosudba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUnesi
            // 
            this.buttonUnesi.Location = new System.Drawing.Point(12, 12);
            this.buttonUnesi.Name = "buttonUnesi";
            this.buttonUnesi.Size = new System.Drawing.Size(155, 56);
            this.buttonUnesi.TabIndex = 0;
            this.buttonUnesi.Text = "Unesi knjige";
            this.buttonUnesi.UseVisualStyleBackColor = true;
            this.buttonUnesi.Click += new System.EventHandler(this.buttonUnesi_Click);
            // 
            // buttonKorisnici
            // 
            this.buttonKorisnici.Location = new System.Drawing.Point(195, 13);
            this.buttonKorisnici.Name = "buttonKorisnici";
            this.buttonKorisnici.Size = new System.Drawing.Size(155, 55);
            this.buttonKorisnici.TabIndex = 1;
            this.buttonKorisnici.Text = "Unesi korisnike";
            this.buttonKorisnici.UseVisualStyleBackColor = true;
            this.buttonKorisnici.Click += new System.EventHandler(this.buttonKorisnici_Click);
            // 
            // buttonPosudba
            // 
            this.buttonPosudba.Location = new System.Drawing.Point(13, 93);
            this.buttonPosudba.Name = "buttonPosudba";
            this.buttonPosudba.Size = new System.Drawing.Size(154, 65);
            this.buttonPosudba.TabIndex = 2;
            this.buttonPosudba.Text = "Posudi knjigu";
            this.buttonPosudba.UseVisualStyleBackColor = true;
            this.buttonPosudba.Click += new System.EventHandler(this.buttonPosudba_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPosudba);
            this.Controls.Add(this.buttonKorisnici);
            this.Controls.Add(this.buttonUnesi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUnesi;
        private System.Windows.Forms.Button buttonKorisnici;
        private System.Windows.Forms.Button buttonPosudba;
    }
}

