namespace FitApp
{
    partial class FormNowyProdukt
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
            this.lblNazwa = new System.Windows.Forms.Label();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.txtKcal = new System.Windows.Forms.TextBox();
            this.lblKcal = new System.Windows.Forms.Label();
            this.txtBialko = new System.Windows.Forms.TextBox();
            this.lblBialko = new System.Windows.Forms.Label();
            this.lblWegle = new System.Windows.Forms.Label();
            this.txtWegl = new System.Windows.Forms.TextBox();
            this.lblTluszcze = new System.Windows.Forms.Label();
            this.txtTluszcz = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwa.Location = new System.Drawing.Point(119, 35);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(134, 20);
            this.lblNazwa.TabIndex = 0;
            this.lblNazwa.Text = "Nazwa produktu:";
            // 
            // txtNazwa
            // 
            this.txtNazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwa.Location = new System.Drawing.Point(124, 62);
            this.txtNazwa.MaxLength = 15;
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(285, 26);
            this.txtNazwa.TabIndex = 1;
            // 
            // txtKcal
            // 
            this.txtKcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKcal.Location = new System.Drawing.Point(122, 136);
            this.txtKcal.MaxLength = 5;
            this.txtKcal.Name = "txtKcal";
            this.txtKcal.Size = new System.Drawing.Size(131, 26);
            this.txtKcal.TabIndex = 2;
            this.txtKcal.TextChanged += new System.EventHandler(this.TextBoxKcal_TextChanged);
            // 
            // lblKcal
            // 
            this.lblKcal.AutoSize = true;
            this.lblKcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKcal.Location = new System.Drawing.Point(116, 110);
            this.lblKcal.Name = "lblKcal";
            this.lblKcal.Size = new System.Drawing.Size(98, 20);
            this.lblKcal.TabIndex = 3;
            this.lblKcal.Text = "Kcal / 100g:";
            // 
            // txtBialko
            // 
            this.txtBialko.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBialko.Location = new System.Drawing.Point(280, 136);
            this.txtBialko.MaxLength = 5;
            this.txtBialko.Name = "txtBialko";
            this.txtBialko.Size = new System.Drawing.Size(129, 26);
            this.txtBialko.TabIndex = 4;
            this.txtBialko.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // lblBialko
            // 
            this.lblBialko.AutoSize = true;
            this.lblBialko.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBialko.Location = new System.Drawing.Point(275, 110);
            this.lblBialko.Name = "lblBialko";
            this.lblBialko.Size = new System.Drawing.Size(111, 20);
            this.lblBialko.TabIndex = 5;
            this.lblBialko.Text = "Białko / 100g:";
            // 
            // lblWegle
            // 
            this.lblWegle.AutoSize = true;
            this.lblWegle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWegle.Location = new System.Drawing.Point(117, 184);
            this.lblWegle.Name = "lblWegle";
            this.lblWegle.Size = new System.Drawing.Size(107, 20);
            this.lblWegle.TabIndex = 7;
            this.lblWegle.Text = "Węgl. / 100g:";
            // 
            // txtWegl
            // 
            this.txtWegl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWegl.Location = new System.Drawing.Point(122, 211);
            this.txtWegl.MaxLength = 5;
            this.txtWegl.Name = "txtWegl";
            this.txtWegl.Size = new System.Drawing.Size(131, 26);
            this.txtWegl.TabIndex = 6;
            this.txtWegl.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // lblTluszcze
            // 
            this.lblTluszcze.AutoSize = true;
            this.lblTluszcze.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTluszcze.Location = new System.Drawing.Point(273, 184);
            this.lblTluszcze.Name = "lblTluszcze";
            this.lblTluszcze.Size = new System.Drawing.Size(133, 20);
            this.lblTluszcze.TabIndex = 9;
            this.lblTluszcze.Text = "Tłuszcze / 100g:";
            // 
            // txtTluszcz
            // 
            this.txtTluszcz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTluszcz.Location = new System.Drawing.Point(280, 211);
            this.txtTluszcz.MaxLength = 5;
            this.txtTluszcz.Name = "txtTluszcz";
            this.txtTluszcz.Size = new System.Drawing.Size(129, 26);
            this.txtTluszcz.TabIndex = 8;
            this.txtTluszcz.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(122, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Dodaj nowy produkt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // FormNowyProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTluszcze);
            this.Controls.Add(this.txtTluszcz);
            this.Controls.Add(this.lblWegle);
            this.Controls.Add(this.txtWegl);
            this.Controls.Add(this.lblBialko);
            this.Controls.Add(this.txtBialko);
            this.Controls.Add(this.lblKcal);
            this.Controls.Add(this.txtKcal);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.lblNazwa);
            this.Name = "FormNowyProdukt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FitnessApp - dodawanie produktu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.TextBox txtKcal;
        private System.Windows.Forms.Label lblKcal;
        private System.Windows.Forms.TextBox txtBialko;
        private System.Windows.Forms.Label lblBialko;
        private System.Windows.Forms.Label lblWegle;
        private System.Windows.Forms.TextBox txtWegl;
        private System.Windows.Forms.Label lblTluszcze;
        private System.Windows.Forms.TextBox txtTluszcz;
        private System.Windows.Forms.Button button1;
    }
}