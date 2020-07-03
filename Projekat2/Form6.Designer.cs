namespace Projekat2
{
    partial class Form6
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
            this.btnKasa = new System.Windows.Forms.Button();
            this.btnGrupe = new System.Windows.Forms.Button();
            this.btnArtikli = new System.Windows.Forms.Button();
            this.btnRacuni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKasa
            // 
            this.btnKasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKasa.Location = new System.Drawing.Point(13, 13);
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.Size = new System.Drawing.Size(371, 55);
            this.btnKasa.TabIndex = 0;
            this.btnKasa.Text = "Kasa";
            this.btnKasa.UseVisualStyleBackColor = true;
            this.btnKasa.Click += new System.EventHandler(this.BtnKasa_Click);
            // 
            // btnGrupe
            // 
            this.btnGrupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrupe.Location = new System.Drawing.Point(13, 76);
            this.btnGrupe.Name = "btnGrupe";
            this.btnGrupe.Size = new System.Drawing.Size(371, 55);
            this.btnGrupe.TabIndex = 1;
            this.btnGrupe.Text = "Grupe";
            this.btnGrupe.UseVisualStyleBackColor = true;
            this.btnGrupe.Click += new System.EventHandler(this.BtnGrupe_Click);
            // 
            // btnArtikli
            // 
            this.btnArtikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtikli.Location = new System.Drawing.Point(12, 137);
            this.btnArtikli.Name = "btnArtikli";
            this.btnArtikli.Size = new System.Drawing.Size(371, 55);
            this.btnArtikli.TabIndex = 2;
            this.btnArtikli.Text = "Artikli";
            this.btnArtikli.UseVisualStyleBackColor = true;
            this.btnArtikli.Click += new System.EventHandler(this.BtnArtikli_Click);
            // 
            // btnRacuni
            // 
            this.btnRacuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRacuni.Location = new System.Drawing.Point(12, 198);
            this.btnRacuni.Name = "btnRacuni";
            this.btnRacuni.Size = new System.Drawing.Size(371, 55);
            this.btnRacuni.TabIndex = 3;
            this.btnRacuni.Text = "Racuni";
            this.btnRacuni.UseVisualStyleBackColor = true;
            this.btnRacuni.Click += new System.EventHandler(this.BtnRacuni_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 267);
            this.Controls.Add(this.btnRacuni);
            this.Controls.Add(this.btnArtikli);
            this.Controls.Add(this.btnGrupe);
            this.Controls.Add(this.btnKasa);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKasa;
        private System.Windows.Forms.Button btnGrupe;
        private System.Windows.Forms.Button btnArtikli;
        private System.Windows.Forms.Button btnRacuni;
    }
}