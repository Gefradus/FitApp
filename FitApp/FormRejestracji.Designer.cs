using System;

namespace FitApp
{
    partial class FormRejestracji
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblPotwierdz = new System.Windows.Forms.Label();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.lblHaslo = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass1 = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.MintCream;
            this.button1.Location = new System.Drawing.Point(176, 313);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 51);
            this.button1.TabIndex = 15;
            this.button1.Text = "Załóż konto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // lblPotwierdz
            // 
            this.lblPotwierdz.AutoSize = true;
            this.lblPotwierdz.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPotwierdz.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPotwierdz.Location = new System.Drawing.Point(172, 222);
            this.lblPotwierdz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPotwierdz.Name = "lblPotwierdz";
            this.lblPotwierdz.Size = new System.Drawing.Size(128, 19);
            this.lblPotwierdz.TabIndex = 14;
            this.lblPotwierdz.Text = "Potwierdź hasło:";
            // 
            // txtPass2
            // 
            this.txtPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPass2.Location = new System.Drawing.Point(176, 244);
            this.txtPass2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass2.MaxLength = 15;
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.PasswordChar = '*';
            this.txtPass2.Size = new System.Drawing.Size(249, 30);
            this.txtPass2.TabIndex = 13;
            this.txtPass2.TextChanged += new System.EventHandler(this.NiePozwalajNaBialeZnaki);
            // 
            // lblHaslo
            // 
            this.lblHaslo.AutoSize = true;
            this.lblHaslo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHaslo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblHaslo.Location = new System.Drawing.Point(173, 158);
            this.lblHaslo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHaslo.Name = "lblHaslo";
            this.lblHaslo.Size = new System.Drawing.Size(54, 19);
            this.lblHaslo.TabIndex = 12;
            this.lblHaslo.Text = "Hasło:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblLogin.Location = new System.Drawing.Point(172, 95);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(54, 19);
            this.lblLogin.TabIndex = 11;
            this.lblLogin.Text = "Login:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(153, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "Załóż konto w FitApp";
            // 
            // txtPass1
            // 
            this.txtPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPass1.Location = new System.Drawing.Point(176, 181);
            this.txtPass1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass1.MaxLength = 15;
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.PasswordChar = '*';
            this.txtPass1.Size = new System.Drawing.Size(249, 30);
            this.txtPass1.TabIndex = 9;
            this.txtPass1.TextChanged += new System.EventHandler(this.NiePozwalajNaBialeZnaki);
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLogin.Location = new System.Drawing.Point(176, 118);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.MaxLength = 15;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(249, 30);
            this.txtLogin.TabIndex = 8;
            this.txtLogin.TextChanged += new System.EventHandler(this.NiePozwalajNaBialeZnaki);
            // 
            // FormRejestracji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(604, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPotwierdz);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.lblHaslo);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass1);
            this.Controls.Add(this.txtLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormRejestracji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FitnessApp - załóż konto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPotwierdz;
        private System.Windows.Forms.TextBox txtPass2;
        private System.Windows.Forms.Label lblHaslo;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass1;
        private System.Windows.Forms.TextBox txtLogin;
    }
}