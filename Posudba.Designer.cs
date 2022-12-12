
namespace ZadatakXML
{
    partial class Posudba
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
            this.textBoxKorisnik = new System.Windows.Forms.TextBox();
            this.textBoxKnjiga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPosudi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxKorisnik
            // 
            this.textBoxKorisnik.Location = new System.Drawing.Point(25, 46);
            this.textBoxKorisnik.Name = "textBoxKorisnik";
            this.textBoxKorisnik.Size = new System.Drawing.Size(100, 20);
            this.textBoxKorisnik.TabIndex = 0;
            // 
            // textBoxKnjiga
            // 
            this.textBoxKnjiga.Location = new System.Drawing.Point(214, 46);
            this.textBoxKnjiga.Name = "textBoxKnjiga";
            this.textBoxKnjiga.Size = new System.Drawing.Size(100, 20);
            this.textBoxKnjiga.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID korisnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID knjige";
            // 
            // buttonPosudi
            // 
            this.buttonPosudi.Location = new System.Drawing.Point(25, 102);
            this.buttonPosudi.Name = "buttonPosudi";
            this.buttonPosudi.Size = new System.Drawing.Size(75, 23);
            this.buttonPosudi.TabIndex = 4;
            this.buttonPosudi.Text = "Posudi";
            this.buttonPosudi.UseVisualStyleBackColor = true;
            this.buttonPosudi.Click += new System.EventHandler(this.buttonPosudi_Click);
            // 
            // Posudba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 143);
            this.Controls.Add(this.buttonPosudi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKnjiga);
            this.Controls.Add(this.textBoxKorisnik);
            this.Name = "Posudba";
            this.Text = "Posudba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKorisnik;
        private System.Windows.Forms.TextBox textBoxKnjiga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPosudi;
    }
}