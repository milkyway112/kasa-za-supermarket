namespace Projekat2
{
    partial class Form4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnDodavanje = new System.Windows.Forms.RadioButton();
            this.rbtnMenjanje = new System.Windows.Forms.RadioButton();
            this.lblProcenat = new System.Windows.Forms.Label();
            this.lblRsd = new System.Windows.Forms.Label();
            this.cbxGrupeIzmena = new System.Windows.Forms.ComboBox();
            this.btnIzmeniGrupu = new System.Windows.Forms.Button();
            this.btnIzmeniArtikal = new System.Windows.Forms.Button();
            this.lblPopust = new System.Windows.Forms.Label();
            this.lblCena = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblIdArtikla = new System.Windows.Forms.Label();
            this.txtPopustArtikla = new System.Windows.Forms.TextBox();
            this.txtCenaArtikla = new System.Windows.Forms.TextBox();
            this.txtNazivArtikla = new System.Windows.Forms.TextBox();
            this.txtIdArtikla = new System.Windows.Forms.TextBox();
            this.cbxGrupe = new System.Windows.Forms.ComboBox();
            this.lbxArtikli = new System.Windows.Forms.ListBox();
            this.lblArtikli = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnDodavanje);
            this.panel1.Controls.Add(this.rbtnMenjanje);
            this.panel1.Controls.Add(this.lblProcenat);
            this.panel1.Controls.Add(this.lblRsd);
            this.panel1.Controls.Add(this.cbxGrupeIzmena);
            this.panel1.Controls.Add(this.btnIzmeniGrupu);
            this.panel1.Controls.Add(this.btnIzmeniArtikal);
            this.panel1.Controls.Add(this.lblPopust);
            this.panel1.Controls.Add(this.lblCena);
            this.panel1.Controls.Add(this.lblNaziv);
            this.panel1.Controls.Add(this.lblIdArtikla);
            this.panel1.Controls.Add(this.txtPopustArtikla);
            this.panel1.Controls.Add(this.txtCenaArtikla);
            this.panel1.Controls.Add(this.txtNazivArtikla);
            this.panel1.Controls.Add(this.txtIdArtikla);
            this.panel1.Controls.Add(this.cbxGrupe);
            this.panel1.Controls.Add(this.lbxArtikli);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 201);
            this.panel1.TabIndex = 0;
            // 
            // rbtnDodavanje
            // 
            this.rbtnDodavanje.AutoSize = true;
            this.rbtnDodavanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDodavanje.Location = new System.Drawing.Point(110, 10);
            this.rbtnDodavanje.Name = "rbtnDodavanje";
            this.rbtnDodavanje.Size = new System.Drawing.Size(58, 17);
            this.rbtnDodavanje.TabIndex = 17;
            this.rbtnDodavanje.TabStop = true;
            this.rbtnDodavanje.Text = "Dodaj";
            this.rbtnDodavanje.UseVisualStyleBackColor = true;
            this.rbtnDodavanje.CheckedChanged += new System.EventHandler(this.rbtnDodavanje_CheckedChanged);
            // 
            // rbtnMenjanje
            // 
            this.rbtnMenjanje.AutoSize = true;
            this.rbtnMenjanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMenjanje.Location = new System.Drawing.Point(6, 10);
            this.rbtnMenjanje.Name = "rbtnMenjanje";
            this.rbtnMenjanje.Size = new System.Drawing.Size(61, 17);
            this.rbtnMenjanje.TabIndex = 16;
            this.rbtnMenjanje.TabStop = true;
            this.rbtnMenjanje.Text = "Izmeni";
            this.rbtnMenjanje.UseVisualStyleBackColor = true;
            this.rbtnMenjanje.CheckedChanged += new System.EventHandler(this.rbtnMenjanje_CheckedChanged);
            // 
            // lblProcenat
            // 
            this.lblProcenat.AutoSize = true;
            this.lblProcenat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcenat.Location = new System.Drawing.Point(177, 110);
            this.lblProcenat.Name = "lblProcenat";
            this.lblProcenat.Size = new System.Drawing.Size(16, 13);
            this.lblProcenat.TabIndex = 15;
            this.lblProcenat.Text = "%";
            // 
            // lblRsd
            // 
            this.lblRsd.AutoSize = true;
            this.lblRsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRsd.Location = new System.Drawing.Point(177, 84);
            this.lblRsd.Name = "lblRsd";
            this.lblRsd.Size = new System.Drawing.Size(24, 13);
            this.lblRsd.TabIndex = 14;
            this.lblRsd.Text = "rsd";
            // 
            // cbxGrupeIzmena
            // 
            this.cbxGrupeIzmena.FormattingEnabled = true;
            this.cbxGrupeIzmena.Location = new System.Drawing.Point(95, 137);
            this.cbxGrupeIzmena.Name = "cbxGrupeIzmena";
            this.cbxGrupeIzmena.Size = new System.Drawing.Size(100, 21);
            this.cbxGrupeIzmena.TabIndex = 13;
            this.cbxGrupeIzmena.SelectedValueChanged += new System.EventHandler(this.cbxGrupeIzmena_SelectedValueChanged);
            // 
            // btnIzmeniGrupu
            // 
            this.btnIzmeniGrupu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniGrupu.Location = new System.Drawing.Point(6, 133);
            this.btnIzmeniGrupu.Name = "btnIzmeniGrupu";
            this.btnIzmeniGrupu.Size = new System.Drawing.Size(87, 27);
            this.btnIzmeniGrupu.TabIndex = 12;
            this.btnIzmeniGrupu.Text = "Izmeni grupu";
            this.btnIzmeniGrupu.UseVisualStyleBackColor = true;
            this.btnIzmeniGrupu.Click += new System.EventHandler(this.btnIzmeniGrupu_Click);
            // 
            // btnIzmeniArtikal
            // 
            this.btnIzmeniArtikal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniArtikal.Location = new System.Drawing.Point(6, 166);
            this.btnIzmeniArtikal.Name = "btnIzmeniArtikal";
            this.btnIzmeniArtikal.Size = new System.Drawing.Size(189, 23);
            this.btnIzmeniArtikal.TabIndex = 10;
            this.btnIzmeniArtikal.Text = "Izmeni";
            this.btnIzmeniArtikal.UseVisualStyleBackColor = true;
            this.btnIzmeniArtikal.Click += new System.EventHandler(this.btnIzmeniArtikal_Click);
            // 
            // lblPopust
            // 
            this.lblPopust.AutoSize = true;
            this.lblPopust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopust.Location = new System.Drawing.Point(3, 108);
            this.lblPopust.Name = "lblPopust";
            this.lblPopust.Size = new System.Drawing.Size(55, 15);
            this.lblPopust.TabIndex = 9;
            this.lblPopust.Text = "Popust:";
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCena.Location = new System.Drawing.Point(3, 82);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(44, 15);
            this.lblCena.TabIndex = 8;
            this.lblCena.Text = "Cena:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(3, 56);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(90, 15);
            this.lblNaziv.TabIndex = 7;
            this.lblNaziv.Text = "Naziv artikla:";
            // 
            // lblIdArtikla
            // 
            this.lblIdArtikla.AutoSize = true;
            this.lblIdArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdArtikla.Location = new System.Drawing.Point(3, 30);
            this.lblIdArtikla.Name = "lblIdArtikla";
            this.lblIdArtikla.Size = new System.Drawing.Size(69, 15);
            this.lblIdArtikla.TabIndex = 6;
            this.lblIdArtikla.Text = "ID artikla:";
            // 
            // txtPopustArtikla
            // 
            this.txtPopustArtikla.Location = new System.Drawing.Point(95, 107);
            this.txtPopustArtikla.Name = "txtPopustArtikla";
            this.txtPopustArtikla.Size = new System.Drawing.Size(76, 20);
            this.txtPopustArtikla.TabIndex = 5;
            this.txtPopustArtikla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPopustArtikla_KeyPress);
            // 
            // txtCenaArtikla
            // 
            this.txtCenaArtikla.Location = new System.Drawing.Point(95, 81);
            this.txtCenaArtikla.Name = "txtCenaArtikla";
            this.txtCenaArtikla.Size = new System.Drawing.Size(76, 20);
            this.txtCenaArtikla.TabIndex = 4;
            this.txtCenaArtikla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCenaArtikla_KeyPress);
            // 
            // txtNazivArtikla
            // 
            this.txtNazivArtikla.Location = new System.Drawing.Point(95, 55);
            this.txtNazivArtikla.Name = "txtNazivArtikla";
            this.txtNazivArtikla.Size = new System.Drawing.Size(100, 20);
            this.txtNazivArtikla.TabIndex = 3;
            // 
            // txtIdArtikla
            // 
            this.txtIdArtikla.Location = new System.Drawing.Point(95, 29);
            this.txtIdArtikla.Name = "txtIdArtikla";
            this.txtIdArtikla.Size = new System.Drawing.Size(100, 20);
            this.txtIdArtikla.TabIndex = 2;
            this.txtIdArtikla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdArtikla_KeyPress);
            // 
            // cbxGrupe
            // 
            this.cbxGrupe.FormattingEnabled = true;
            this.cbxGrupe.Location = new System.Drawing.Point(202, 2);
            this.cbxGrupe.Name = "cbxGrupe";
            this.cbxGrupe.Size = new System.Drawing.Size(219, 21);
            this.cbxGrupe.TabIndex = 1;
            this.cbxGrupe.SelectedValueChanged += new System.EventHandler(this.cbxGrupe_SelectedValueChanged);
            // 
            // lbxArtikli
            // 
            this.lbxArtikli.FormattingEnabled = true;
            this.lbxArtikli.Location = new System.Drawing.Point(201, 29);
            this.lbxArtikli.Name = "lbxArtikli";
            this.lbxArtikli.Size = new System.Drawing.Size(220, 160);
            this.lbxArtikli.TabIndex = 0;
            this.lbxArtikli.SelectedValueChanged += new System.EventHandler(this.lbxArtikli_SelectedValueChanged);
            // 
            // lblArtikli
            // 
            this.lblArtikli.AutoSize = true;
            this.lblArtikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtikli.Location = new System.Drawing.Point(8, 9);
            this.lblArtikli.Name = "lblArtikli";
            this.lblArtikli.Size = new System.Drawing.Size(54, 20);
            this.lblArtikli.TabIndex = 19;
            this.lblArtikli.Text = "Artikli";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 247);
            this.Controls.Add(this.lblArtikli);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Shown += new System.EventHandler(this.Form4_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxGrupe;
        private System.Windows.Forms.ListBox lbxArtikli;
        private System.Windows.Forms.Button btnIzmeniArtikal;
        private System.Windows.Forms.Label lblPopust;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblIdArtikla;
        private System.Windows.Forms.TextBox txtPopustArtikla;
        private System.Windows.Forms.TextBox txtCenaArtikla;
        private System.Windows.Forms.TextBox txtNazivArtikla;
        private System.Windows.Forms.TextBox txtIdArtikla;
        private System.Windows.Forms.ComboBox cbxGrupeIzmena;
        private System.Windows.Forms.Button btnIzmeniGrupu;
        private System.Windows.Forms.Label lblProcenat;
        private System.Windows.Forms.Label lblRsd;
        private System.Windows.Forms.RadioButton rbtnDodavanje;
        private System.Windows.Forms.RadioButton rbtnMenjanje;
        private System.Windows.Forms.Label lblArtikli;
    }
}