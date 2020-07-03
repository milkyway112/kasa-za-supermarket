namespace Projekat2
{
    partial class Form5
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
            this.dgwRacuni = new System.Windows.Forms.DataGridView();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.lblDatumDo = new System.Windows.Forms.Label();
            this.lblDatumOd = new System.Windows.Forms.Label();
            this.btnIzlistajRacune = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRacuni)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwRacuni
            // 
            this.dgwRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRacuni.Location = new System.Drawing.Point(13, 87);
            this.dgwRacuni.Name = "dgwRacuni";
            this.dgwRacuni.Size = new System.Drawing.Size(462, 325);
            this.dgwRacuni.TabIndex = 0;
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Location = new System.Drawing.Point(12, 22);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumOd.TabIndex = 1;
            this.dtpDatumOd.ValueChanged += new System.EventHandler(this.DtpDatumOd_ValueChanged);
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Location = new System.Drawing.Point(12, 61);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumDo.TabIndex = 2;
            this.dtpDatumDo.ValueChanged += new System.EventHandler(this.DtpDatumDo_ValueChanged);
            // 
            // lblDatumDo
            // 
            this.lblDatumDo.AutoSize = true;
            this.lblDatumDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumDo.Location = new System.Drawing.Point(12, 45);
            this.lblDatumDo.Name = "lblDatumDo";
            this.lblDatumDo.Size = new System.Drawing.Size(65, 13);
            this.lblDatumDo.TabIndex = 3;
            this.lblDatumDo.Text = "Datum do:";
            // 
            // lblDatumOd
            // 
            this.lblDatumOd.AutoSize = true;
            this.lblDatumOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumOd.Location = new System.Drawing.Point(12, 6);
            this.lblDatumOd.Name = "lblDatumOd";
            this.lblDatumOd.Size = new System.Drawing.Size(65, 13);
            this.lblDatumOd.TabIndex = 4;
            this.lblDatumOd.Text = "Datum od:";
            // 
            // btnIzlistajRacune
            // 
            this.btnIzlistajRacune.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzlistajRacune.Location = new System.Drawing.Point(228, 22);
            this.btnIzlistajRacune.Name = "btnIzlistajRacune";
            this.btnIzlistajRacune.Size = new System.Drawing.Size(247, 59);
            this.btnIzlistajRacune.TabIndex = 5;
            this.btnIzlistajRacune.Text = "Izlistaj racune";
            this.btnIzlistajRacune.UseVisualStyleBackColor = true;
            this.btnIzlistajRacune.Click += new System.EventHandler(this.BtnIzlistajRacune_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 424);
            this.Controls.Add(this.btnIzlistajRacune);
            this.Controls.Add(this.lblDatumOd);
            this.Controls.Add(this.lblDatumDo);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.dgwRacuni);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRacuni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwRacuni;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.Label lblDatumDo;
        private System.Windows.Forms.Label lblDatumOd;
        private System.Windows.Forms.Button btnIzlistajRacune;
    }
}