namespace FitApp
{
    partial class FormEdytujPosilek
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblKcal = new System.Windows.Forms.Label();
            this.lblMakro = new System.Windows.Forms.Label();
            this.panelParametrow = new System.Windows.Forms.Panel();
            this.panelParametrow.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.Font = new System.Drawing.Font("Arimo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwa.Location = new System.Drawing.Point(107, 9);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(163, 24);
            this.lblNazwa.TabIndex = 12;
            this.lblNazwa.Text = "Nazwa produktu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(118, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "g";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(15, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 26);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.PodajLiczbeTextBox_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PodajLiczbeTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Podaj ilość:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodaj.Location = new System.Drawing.Point(121, 149);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(0);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(139, 34);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Zapisz";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.BtnEdytuj_Click);
            // 
            // lblKcal
            // 
            this.lblKcal.AutoSize = true;
            this.lblKcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKcal.Location = new System.Drawing.Point(3, 4);
            this.lblKcal.Name = "lblKcal";
            this.lblKcal.Size = new System.Drawing.Size(80, 18);
            this.lblKcal.TabIndex = 5;
            this.lblKcal.Text = "Kcal: 0kcal";
            // 
            // lblMakro
            // 
            this.lblMakro.AutoSize = true;
            this.lblMakro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMakro.Location = new System.Drawing.Point(170, 85);
            this.lblMakro.Name = "lblMakro";
            this.lblMakro.Size = new System.Drawing.Size(130, 18);
            this.lblMakro.TabIndex = 13;
            this.lblMakro.Text = "B: 0g, W: 0g, T: 0g";
            // 
            // panelParametrow
            // 
            this.panelParametrow.Controls.Add(this.lblKcal);
            this.panelParametrow.Location = new System.Drawing.Point(165, 58);
            this.panelParametrow.Name = "panelParametrow";
            this.panelParametrow.Size = new System.Drawing.Size(206, 49);
            this.panelParametrow.TabIndex = 14;
            // 
            // FormEdytujPosilek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 195);
            this.Controls.Add(this.lblNazwa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblMakro);
            this.Controls.Add(this.panelParametrow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormEdytujPosilek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edycja posiłku";
            this.Load += new System.EventHandler(this.FormEdytujPosilek_Load);
            this.panelParametrow.ResumeLayout(false);
            this.panelParametrow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblKcal;
        private System.Windows.Forms.Label lblMakro;
        private System.Windows.Forms.Panel panelParametrow;
    }
}