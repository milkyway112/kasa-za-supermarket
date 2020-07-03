namespace Projekat2
{
    partial class Form3
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
            this.lbxGrupe = new System.Windows.Forms.ListBox();
            this.btnPrikazeGrupe = new System.Windows.Forms.Button();
            this.btnIzbrisiGrupe = new System.Windows.Forms.Button();
            this.pnlBrisanjeGrupa = new System.Windows.Forms.Panel();
            this.lblNazivSelektovaneGrupe = new System.Windows.Forms.Label();
            this.txtNazivSelektovaneGrupe = new System.Windows.Forms.TextBox();
            this.btnPromeniNaziv = new System.Windows.Forms.Button();
            this.lblNazivNoveGrupe = new System.Windows.Forms.Label();
            this.txtNazivNoveGrupe = new System.Windows.Forms.TextBox();
            this.btnDodajGrupu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBrisanjeGrupa.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxGrupe
            // 
            this.lbxGrupe.FormattingEnabled = true;
            this.lbxGrupe.Location = new System.Drawing.Point(209, 12);
            this.lbxGrupe.Name = "lbxGrupe";
            this.lbxGrupe.Size = new System.Drawing.Size(166, 303);
            this.lbxGrupe.TabIndex = 0;
            this.lbxGrupe.SelectedValueChanged += new System.EventHandler(this.lbxGrupe_SelectedValueChanged);
            // 
            // btnPrikazeGrupe
            // 
            this.btnPrikazeGrupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazeGrupe.Location = new System.Drawing.Point(13, 13);
            this.btnPrikazeGrupe.Name = "btnPrikazeGrupe";
            this.btnPrikazeGrupe.Size = new System.Drawing.Size(165, 41);
            this.btnPrikazeGrupe.TabIndex = 1;
            this.btnPrikazeGrupe.Text = "Izlistaj grupe";
            this.btnPrikazeGrupe.UseVisualStyleBackColor = true;
            this.btnPrikazeGrupe.Click += new System.EventHandler(this.btnPrikazeGrupe_Click);
            // 
            // btnIzbrisiGrupe
            // 
            this.btnIzbrisiGrupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisiGrupe.Location = new System.Drawing.Point(13, 60);
            this.btnIzbrisiGrupe.Name = "btnIzbrisiGrupe";
            this.btnIzbrisiGrupe.Size = new System.Drawing.Size(165, 42);
            this.btnIzbrisiGrupe.TabIndex = 2;
            this.btnIzbrisiGrupe.Text = "Izbrisi grupu";
            this.btnIzbrisiGrupe.UseVisualStyleBackColor = true;
            this.btnIzbrisiGrupe.Click += new System.EventHandler(this.btnIzbrisiGrupe_Click);
            // 
            // pnlBrisanjeGrupa
            // 
            this.pnlBrisanjeGrupa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBrisanjeGrupa.Controls.Add(this.lblNazivSelektovaneGrupe);
            this.pnlBrisanjeGrupa.Controls.Add(this.txtNazivSelektovaneGrupe);
            this.pnlBrisanjeGrupa.Controls.Add(this.btnIzbrisiGrupe);
            this.pnlBrisanjeGrupa.Controls.Add(this.btnPromeniNaziv);
            this.pnlBrisanjeGrupa.Controls.Add(this.btnPrikazeGrupe);
            this.pnlBrisanjeGrupa.Location = new System.Drawing.Point(12, 12);
            this.pnlBrisanjeGrupa.Name = "pnlBrisanjeGrupa";
            this.pnlBrisanjeGrupa.Size = new System.Drawing.Size(191, 198);
            this.pnlBrisanjeGrupa.TabIndex = 3;
            // 
            // lblNazivSelektovaneGrupe
            // 
            this.lblNazivSelektovaneGrupe.AutoSize = true;
            this.lblNazivSelektovaneGrupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivSelektovaneGrupe.Location = new System.Drawing.Point(10, 105);
            this.lblNazivSelektovaneGrupe.Name = "lblNazivSelektovaneGrupe";
            this.lblNazivSelektovaneGrupe.Size = new System.Drawing.Size(152, 13);
            this.lblNazivSelektovaneGrupe.TabIndex = 6;
            this.lblNazivSelektovaneGrupe.Text = "Naziv selektovane grupe:";
            // 
            // txtNazivSelektovaneGrupe
            // 
            this.txtNazivSelektovaneGrupe.Location = new System.Drawing.Point(13, 121);
            this.txtNazivSelektovaneGrupe.Name = "txtNazivSelektovaneGrupe";
            this.txtNazivSelektovaneGrupe.Size = new System.Drawing.Size(165, 20);
            this.txtNazivSelektovaneGrupe.TabIndex = 4;
            this.txtNazivSelektovaneGrupe.Click += new System.EventHandler(this.txtNazivSelektovaneGrupe_Click);
            // 
            // btnPromeniNaziv
            // 
            this.btnPromeniNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromeniNaziv.Location = new System.Drawing.Point(13, 147);
            this.btnPromeniNaziv.Name = "btnPromeniNaziv";
            this.btnPromeniNaziv.Size = new System.Drawing.Size(165, 42);
            this.btnPromeniNaziv.TabIndex = 10;
            this.btnPromeniNaziv.Text = "Promeni naziv";
            this.btnPromeniNaziv.UseVisualStyleBackColor = true;
            this.btnPromeniNaziv.Click += new System.EventHandler(this.BtnPromeniNaziv_Click_1);
            // 
            // lblNazivNoveGrupe
            // 
            this.lblNazivNoveGrupe.AutoSize = true;
            this.lblNazivNoveGrupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivNoveGrupe.Location = new System.Drawing.Point(9, 6);
            this.lblNazivNoveGrupe.Name = "lblNazivNoveGrupe";
            this.lblNazivNoveGrupe.Size = new System.Drawing.Size(111, 13);
            this.lblNazivNoveGrupe.TabIndex = 13;
            this.lblNazivNoveGrupe.Text = "Naziv nove grupe:";
            // 
            // txtNazivNoveGrupe
            // 
            this.txtNazivNoveGrupe.Location = new System.Drawing.Point(12, 22);
            this.txtNazivNoveGrupe.Name = "txtNazivNoveGrupe";
            this.txtNazivNoveGrupe.Size = new System.Drawing.Size(165, 20);
            this.txtNazivNoveGrupe.TabIndex = 12;
            // 
            // btnDodajGrupu
            // 
            this.btnDodajGrupu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajGrupu.Location = new System.Drawing.Point(12, 48);
            this.btnDodajGrupu.Name = "btnDodajGrupu";
            this.btnDodajGrupu.Size = new System.Drawing.Size(165, 42);
            this.btnDodajGrupu.TabIndex = 11;
            this.btnDodajGrupu.Text = "Dodaj grupu";
            this.btnDodajGrupu.UseVisualStyleBackColor = true;
            this.btnDodajGrupu.Click += new System.EventHandler(this.BtnDodajGrupu_Click_1);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtNazivNoveGrupe);
            this.panel1.Controls.Add(this.lblNazivNoveGrupe);
            this.panel1.Controls.Add(this.btnDodajGrupu);
            this.panel1.Location = new System.Drawing.Point(13, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 100);
            this.panel1.TabIndex = 14;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 326);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBrisanjeGrupa);
            this.Controls.Add(this.lbxGrupe);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Shown += new System.EventHandler(this.Form3_Shown);
            this.pnlBrisanjeGrupa.ResumeLayout(false);
            this.pnlBrisanjeGrupa.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxGrupe;
        private System.Windows.Forms.Button btnPrikazeGrupe;
        private System.Windows.Forms.Button btnIzbrisiGrupe;
        private System.Windows.Forms.Panel pnlBrisanjeGrupa;
        private System.Windows.Forms.Label lblNazivSelektovaneGrupe;
        private System.Windows.Forms.TextBox txtNazivSelektovaneGrupe;
        private System.Windows.Forms.Button btnPromeniNaziv;
        private System.Windows.Forms.Label lblNazivNoveGrupe;
        private System.Windows.Forms.TextBox txtNazivNoveGrupe;
        private System.Windows.Forms.Button btnDodajGrupu;
        private System.Windows.Forms.Panel panel1;
    }
}