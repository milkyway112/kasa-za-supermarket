namespace Projekat2
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
            this.components = new System.ComponentModel.Container();
            this.lbxArtikli = new System.Windows.Forms.ListBox();
            this.btnDodajNaRacun = new System.Windows.Forms.Button();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblRacun = new System.Windows.Forms.Label();
            this.lblVreme = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.pnlRacun = new System.Windows.Forms.Panel();
            this.lblCenaRacuna = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnIzdajRacun = new System.Windows.Forms.Button();
            this.lblPuta = new System.Windows.Forms.Label();
            this.txtUplata = new System.Windows.Forms.TextBox();
            this.lblUplaceno = new System.Windows.Forms.Label();
            this.tmrSat = new System.Windows.Forms.Timer(this.components);
            this.rbtnDigitalni = new System.Windows.Forms.RadioButton();
            this.rbtnAnalogni = new System.Windows.Forms.RadioButton();
            this.pnlDugmici = new System.Windows.Forms.Panel();
            this.txtPretragaGrupa = new System.Windows.Forms.TextBox();
            this.lblPretragaGrupa = new System.Windows.Forms.Label();
            this.lblPretragaArtikala = new System.Windows.Forms.Label();
            this.txtPretragaArtikala = new System.Windows.Forms.TextBox();
            this.btnUkloniPretraguGrupa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblGrupa = new System.Windows.Forms.Label();
            this.pnlRacun.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxArtikli
            // 
            this.lbxArtikli.FormattingEnabled = true;
            this.lbxArtikli.Location = new System.Drawing.Point(268, 64);
            this.lbxArtikli.Name = "lbxArtikli";
            this.lbxArtikli.Size = new System.Drawing.Size(199, 225);
            this.lbxArtikli.TabIndex = 1;
            this.lbxArtikli.SelectedValueChanged += new System.EventHandler(this.lbxArtikli_SelectedValueChanged);
            // 
            // btnDodajNaRacun
            // 
            this.btnDodajNaRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNaRacun.Location = new System.Drawing.Point(268, 293);
            this.btnDodajNaRacun.Name = "btnDodajNaRacun";
            this.btnDodajNaRacun.Size = new System.Drawing.Size(107, 57);
            this.btnDodajNaRacun.TabIndex = 2;
            this.btnDodajNaRacun.Text = "Dodaj na racun";
            this.btnDodajNaRacun.UseVisualStyleBackColor = true;
            this.btnDodajNaRacun.Click += new System.EventHandler(this.btnDodajNaRacun_Click);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(402, 316);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(65, 20);
            this.txtKolicina.TabIndex = 3;
            this.txtKolicina.Click += new System.EventHandler(this.txtKolicina_Click);
            this.txtKolicina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKolicina_KeyPress);
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKolicina.Location = new System.Drawing.Point(399, 300);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(56, 13);
            this.lblKolicina.TabIndex = 4;
            this.lblKolicina.Text = "Kolicina:";
            // 
            // lblRacun
            // 
            this.lblRacun.AutoSize = true;
            this.lblRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRacun.Location = new System.Drawing.Point(-1, 0);
            this.lblRacun.Name = "lblRacun";
            this.lblRacun.Size = new System.Drawing.Size(66, 20);
            this.lblRacun.TabIndex = 5;
            this.lblRacun.Text = "Racun:";
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVreme.Location = new System.Drawing.Point(3, 10);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(0, 13);
            this.lblVreme.TabIndex = 6;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(3, 26);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(0, 13);
            this.lblDatum.TabIndex = 7;
            // 
            // pnlRacun
            // 
            this.pnlRacun.AutoScroll = true;
            this.pnlRacun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRacun.Controls.Add(this.lblCenaRacuna);
            this.pnlRacun.Controls.Add(this.lblRacun);
            this.pnlRacun.Location = new System.Drawing.Point(474, 69);
            this.pnlRacun.Name = "pnlRacun";
            this.pnlRacun.Size = new System.Drawing.Size(291, 281);
            this.pnlRacun.TabIndex = 8;
            // 
            // lblCenaRacuna
            // 
            this.lblCenaRacuna.AutoSize = true;
            this.lblCenaRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenaRacuna.Location = new System.Drawing.Point(71, 3);
            this.lblCenaRacuna.Name = "lblCenaRacuna";
            this.lblCenaRacuna.Size = new System.Drawing.Size(51, 16);
            this.lblCenaRacuna.TabIndex = 6;
            this.lblCenaRacuna.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblVreme);
            this.panel3.Controls.Add(this.lblDatum);
            this.panel3.Location = new System.Drawing.Point(647, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 50);
            this.panel3.TabIndex = 11;
            // 
            // btnIzdajRacun
            // 
            this.btnIzdajRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzdajRacun.Location = new System.Drawing.Point(556, 12);
            this.btnIzdajRacun.Name = "btnIzdajRacun";
            this.btnIzdajRacun.Size = new System.Drawing.Size(85, 50);
            this.btnIzdajRacun.TabIndex = 12;
            this.btnIzdajRacun.Text = "Izdaj racun";
            this.btnIzdajRacun.UseVisualStyleBackColor = true;
            this.btnIzdajRacun.Click += new System.EventHandler(this.btnIzdajRacun_Click);
            // 
            // lblPuta
            // 
            this.lblPuta.AutoSize = true;
            this.lblPuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuta.Location = new System.Drawing.Point(381, 316);
            this.lblPuta.Name = "lblPuta";
            this.lblPuta.Size = new System.Drawing.Size(15, 16);
            this.lblPuta.TabIndex = 13;
            this.lblPuta.Text = "x";
            // 
            // txtUplata
            // 
            this.txtUplata.Location = new System.Drawing.Point(478, 42);
            this.txtUplata.Name = "txtUplata";
            this.txtUplata.Size = new System.Drawing.Size(75, 20);
            this.txtUplata.TabIndex = 14;
            this.txtUplata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblUplaceno
            // 
            this.lblUplaceno.AutoSize = true;
            this.lblUplaceno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUplaceno.Location = new System.Drawing.Point(475, 23);
            this.lblUplaceno.Name = "lblUplaceno";
            this.lblUplaceno.Size = new System.Drawing.Size(65, 13);
            this.lblUplaceno.TabIndex = 15;
            this.lblUplaceno.Text = "Uplaceno:";
            // 
            // tmrSat
            // 
            this.tmrSat.Interval = 1000;
            this.tmrSat.Tick += new System.EventHandler(this.tmrSat_Tick);
            // 
            // rbtnDigitalni
            // 
            this.rbtnDigitalni.AutoSize = true;
            this.rbtnDigitalni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDigitalni.Location = new System.Drawing.Point(733, 23);
            this.rbtnDigitalni.Name = "rbtnDigitalni";
            this.rbtnDigitalni.Size = new System.Drawing.Size(32, 17);
            this.rbtnDigitalni.TabIndex = 16;
            this.rbtnDigitalni.TabStop = true;
            this.rbtnDigitalni.Text = "1";
            this.rbtnDigitalni.UseVisualStyleBackColor = true;
            this.rbtnDigitalni.CheckedChanged += new System.EventHandler(this.rbtnDigitalni_CheckedChanged);
            // 
            // rbtnAnalogni
            // 
            this.rbtnAnalogni.AutoSize = true;
            this.rbtnAnalogni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAnalogni.Location = new System.Drawing.Point(733, 40);
            this.rbtnAnalogni.Name = "rbtnAnalogni";
            this.rbtnAnalogni.Size = new System.Drawing.Size(32, 17);
            this.rbtnAnalogni.TabIndex = 17;
            this.rbtnAnalogni.TabStop = true;
            this.rbtnAnalogni.Text = "2";
            this.rbtnAnalogni.UseVisualStyleBackColor = true;
            this.rbtnAnalogni.CheckedChanged += new System.EventHandler(this.rbtnAnalogni_CheckedChanged);
            // 
            // pnlDugmici
            // 
            this.pnlDugmici.AutoScroll = true;
            this.pnlDugmici.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDugmici.Location = new System.Drawing.Point(13, 39);
            this.pnlDugmici.Name = "pnlDugmici";
            this.pnlDugmici.Size = new System.Drawing.Size(249, 311);
            this.pnlDugmici.TabIndex = 18;
            // 
            // txtPretragaGrupa
            // 
            this.txtPretragaGrupa.Location = new System.Drawing.Point(154, 14);
            this.txtPretragaGrupa.Name = "txtPretragaGrupa";
            this.txtPretragaGrupa.Size = new System.Drawing.Size(82, 20);
            this.txtPretragaGrupa.TabIndex = 19;
            this.txtPretragaGrupa.Click += new System.EventHandler(this.txtPretraga_Click);
            this.txtPretragaGrupa.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // lblPretragaGrupa
            // 
            this.lblPretragaGrupa.AutoSize = true;
            this.lblPretragaGrupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretragaGrupa.Location = new System.Drawing.Point(58, 17);
            this.lblPretragaGrupa.Name = "lblPretragaGrupa";
            this.lblPretragaGrupa.Size = new System.Drawing.Size(90, 13);
            this.lblPretragaGrupa.TabIndex = 20;
            this.lblPretragaGrupa.Text = "Pretrazi grupe:";
            // 
            // lblPretragaArtikala
            // 
            this.lblPretragaArtikala.AutoSize = true;
            this.lblPretragaArtikala.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretragaArtikala.Location = new System.Drawing.Point(265, 18);
            this.lblPretragaArtikala.Name = "lblPretragaArtikala";
            this.lblPretragaArtikala.Size = new System.Drawing.Size(93, 13);
            this.lblPretragaArtikala.TabIndex = 21;
            this.lblPretragaArtikala.Text = "Pretrazi artikle:";
            // 
            // txtPretragaArtikala
            // 
            this.txtPretragaArtikala.Location = new System.Drawing.Point(359, 14);
            this.txtPretragaArtikala.Name = "txtPretragaArtikala";
            this.txtPretragaArtikala.Size = new System.Drawing.Size(82, 20);
            this.txtPretragaArtikala.TabIndex = 22;
            this.txtPretragaArtikala.Click += new System.EventHandler(this.txtPretragaArtikala_Click);
            this.txtPretragaArtikala.TextChanged += new System.EventHandler(this.txtPretragaArtikala_TextChanged);
            // 
            // btnUkloniPretraguGrupa
            // 
            this.btnUkloniPretraguGrupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniPretraguGrupa.Location = new System.Drawing.Point(242, 14);
            this.btnUkloniPretraguGrupa.Name = "btnUkloniPretraguGrupa";
            this.btnUkloniPretraguGrupa.Size = new System.Drawing.Size(20, 20);
            this.btnUkloniPretraguGrupa.TabIndex = 23;
            this.btnUkloniPretraguGrupa.Text = "X";
            this.btnUkloniPretraguGrupa.UseVisualStyleBackColor = true;
            this.btnUkloniPretraguGrupa.Click += new System.EventHandler(this.btnUkloniPretraguGrupa_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(447, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 24;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblGrupa
            // 
            this.lblGrupa.AutoSize = true;
            this.lblGrupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupa.Location = new System.Drawing.Point(269, 40);
            this.lblGrupa.Name = "lblGrupa";
            this.lblGrupa.Size = new System.Drawing.Size(45, 13);
            this.lblGrupa.TabIndex = 25;
            this.lblGrupa.Text = "Grupa:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 362);
            this.Controls.Add(this.lblGrupa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUkloniPretraguGrupa);
            this.Controls.Add(this.txtPretragaArtikala);
            this.Controls.Add(this.lblPretragaArtikala);
            this.Controls.Add(this.lblPretragaGrupa);
            this.Controls.Add(this.txtPretragaGrupa);
            this.Controls.Add(this.pnlDugmici);
            this.Controls.Add(this.rbtnAnalogni);
            this.Controls.Add(this.rbtnDigitalni);
            this.Controls.Add(this.lblUplaceno);
            this.Controls.Add(this.txtUplata);
            this.Controls.Add(this.lblPuta);
            this.Controls.Add(this.btnIzdajRacun);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlRacun);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.btnDodajNaRacun);
            this.Controls.Add(this.lbxArtikli);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.pnlRacun.ResumeLayout(false);
            this.pnlRacun.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbxArtikli;
        private System.Windows.Forms.Button btnDodajNaRacun;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblRacun;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Panel pnlRacun;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnIzdajRacun;
        private System.Windows.Forms.Label lblPuta;
        private System.Windows.Forms.Label lblCenaRacuna;
        private System.Windows.Forms.TextBox txtUplata;
        private System.Windows.Forms.Label lblUplaceno;
        private System.Windows.Forms.Timer tmrSat;
        private System.Windows.Forms.RadioButton rbtnDigitalni;
        private System.Windows.Forms.RadioButton rbtnAnalogni;
        private System.Windows.Forms.Panel pnlDugmici;
        private System.Windows.Forms.TextBox txtPretragaGrupa;
        private System.Windows.Forms.Label lblPretragaGrupa;
        private System.Windows.Forms.Label lblPretragaArtikala;
        private System.Windows.Forms.TextBox txtPretragaArtikala;
        private System.Windows.Forms.Button btnUkloniPretraguGrupa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblGrupa;
    }
}

