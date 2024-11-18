namespace Vozila
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
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtGodinaProizvodnje = new System.Windows.Forms.TextBox();
            this.txtKilometraza = new System.Windows.Forms.TextBox();
            this.txtSortiranaLista = new System.Windows.Forms.TextBox();
            this.cmbSortiranje = new System.Windows.Forms.ComboBox();
            this.lstVozila = new System.Windows.Forms.ListBox();
            this.rbUzlazno = new System.Windows.Forms.RadioButton();
            this.rbSilazno = new System.Windows.Forms.RadioButton();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnSpremiXML = new System.Windows.Forms.Button();
            this.btnUcitajXML = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(36, 55);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(195, 20);
            this.txtMarka.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(36, 103);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(195, 20);
            this.txtModel.TabIndex = 1;
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(36, 165);
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(195, 20);
            this.txtGodinaProizvodnje.TabIndex = 2;
            // 
            // txtKilometraza
            // 
            this.txtKilometraza.Location = new System.Drawing.Point(36, 230);
            this.txtKilometraza.Name = "txtKilometraza";
            this.txtKilometraza.Size = new System.Drawing.Size(195, 20);
            this.txtKilometraza.TabIndex = 3;
            // 
            // txtSortiranaLista
            // 
            this.txtSortiranaLista.Location = new System.Drawing.Point(337, 103);
            this.txtSortiranaLista.Multiline = true;
            this.txtSortiranaLista.Name = "txtSortiranaLista";
            this.txtSortiranaLista.Size = new System.Drawing.Size(195, 147);
            this.txtSortiranaLista.TabIndex = 4;
            // 
            // cmbSortiranje
            // 
            this.cmbSortiranje.FormattingEnabled = true;
            this.cmbSortiranje.Location = new System.Drawing.Point(348, 53);
            this.cmbSortiranje.Name = "cmbSortiranje";
            this.cmbSortiranje.Size = new System.Drawing.Size(168, 21);
            this.cmbSortiranje.TabIndex = 5;
            // 
            // lstVozila
            // 
            this.lstVozila.FormattingEnabled = true;
            this.lstVozila.Location = new System.Drawing.Point(587, 55);
            this.lstVozila.Name = "lstVozila";
            this.lstVozila.Size = new System.Drawing.Size(201, 199);
            this.lstVozila.TabIndex = 6;
            // 
            // rbUzlazno
            // 
            this.rbUzlazno.AutoSize = true;
            this.rbUzlazno.Location = new System.Drawing.Point(596, 282);
            this.rbUzlazno.Name = "rbUzlazno";
            this.rbUzlazno.Size = new System.Drawing.Size(63, 17);
            this.rbUzlazno.TabIndex = 7;
            this.rbUzlazno.TabStop = true;
            this.rbUzlazno.Text = "Uzlazno";
            this.rbUzlazno.UseVisualStyleBackColor = true;
            // 
            // rbSilazno
            // 
            this.rbSilazno.AutoSize = true;
            this.rbSilazno.Location = new System.Drawing.Point(596, 315);
            this.rbSilazno.Name = "rbSilazno";
            this.rbSilazno.Size = new System.Drawing.Size(59, 17);
            this.rbSilazno.TabIndex = 8;
            this.rbSilazno.TabStop = true;
            this.rbSilazno.Text = "Silazno";
            this.rbSilazno.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(36, 292);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(137, 23);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj vozilo";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(219, 292);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(137, 23);
            this.btnSortiraj.TabIndex = 10;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(395, 292);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(137, 23);
            this.btnObrisi.TabIndex = 11;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnSpremiXML
            // 
            this.btnSpremiXML.Location = new System.Drawing.Point(120, 359);
            this.btnSpremiXML.Name = "btnSpremiXML";
            this.btnSpremiXML.Size = new System.Drawing.Size(137, 23);
            this.btnSpremiXML.TabIndex = 12;
            this.btnSpremiXML.Text = "Spremi u XML";
            this.btnSpremiXML.UseVisualStyleBackColor = true;
            // 
            // btnUcitajXML
            // 
            this.btnUcitajXML.Location = new System.Drawing.Point(323, 359);
            this.btnUcitajXML.Name = "btnUcitajXML";
            this.btnUcitajXML.Size = new System.Drawing.Size(137, 23);
            this.btnUcitajXML.TabIndex = 13;
            this.btnUcitajXML.Text = " Učitaj iz XML-a ";
            this.btnUcitajXML.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "GodinaProizvodnje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kilometraza";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUcitajXML);
            this.Controls.Add(this.btnSpremiXML);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.rbSilazno);
            this.Controls.Add(this.rbUzlazno);
            this.Controls.Add(this.lstVozila);
            this.Controls.Add(this.cmbSortiranje);
            this.Controls.Add(this.txtSortiranaLista);
            this.Controls.Add(this.txtKilometraza);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtGodinaProizvodnje;
        private System.Windows.Forms.TextBox txtKilometraza;
        private System.Windows.Forms.TextBox txtSortiranaLista;
        private System.Windows.Forms.ComboBox cmbSortiranje;
        private System.Windows.Forms.ListBox lstVozila;
        private System.Windows.Forms.RadioButton rbUzlazno;
        private System.Windows.Forms.RadioButton rbSilazno;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnSpremiXML;
        private System.Windows.Forms.Button btnUcitajXML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

