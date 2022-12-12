
namespace ZadatakXML
{
    partial class Unos_knjiga
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
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Autor = new System.Windows.Forms.Label();
            this.buttonUnesi = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(33, 42);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(100, 20);
            this.textBoxNaziv.TabIndex = 0;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(177, 41);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(100, 20);
            this.textBoxAutor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv";
            // 
            // Autor
            // 
            this.Autor.AutoSize = true;
            this.Autor.Location = new System.Drawing.Point(177, 22);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(32, 13);
            this.Autor.TabIndex = 3;
            this.Autor.Text = "Autor";
            // 
            // buttonUnesi
            // 
            this.buttonUnesi.Location = new System.Drawing.Point(33, 91);
            this.buttonUnesi.Name = "buttonUnesi";
            this.buttonUnesi.Size = new System.Drawing.Size(75, 23);
            this.buttonUnesi.TabIndex = 4;
            this.buttonUnesi.Text = "Unesi";
            this.buttonUnesi.UseVisualStyleBackColor = true;
            this.buttonUnesi.Click += new System.EventHandler(this.buttonUnesi_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(180, 91);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(97, 20);
            this.textBoxID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // Unos_knjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 139);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonUnesi);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxNaziv);
            this.Name = "Unos_knjiga";
            this.Text = "Unos_knjiga";
            this.Load += new System.EventHandler(this.Unos_knjiga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Autor;
        private System.Windows.Forms.Button buttonUnesi;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
    }
}