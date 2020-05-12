namespace FitApp
{
    partial class FormDodawania
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
            this.NazwaPosilku = new System.Windows.Forms.Label();
            this.panelGlowny = new System.Windows.Forms.FlowLayoutPanel();
            this.panelGorny = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lblDzien = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnHidden = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Border = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelGorny.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // NazwaPosilku
            // 
            this.NazwaPosilku.AutoSize = true;
            this.NazwaPosilku.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwaPosilku.Location = new System.Drawing.Point(200, 5);
            this.NazwaPosilku.Margin = new System.Windows.Forms.Padding(200, 5, 0, 0);
            this.NazwaPosilku.Name = "NazwaPosilku";
            this.NazwaPosilku.Size = new System.Drawing.Size(181, 35);
            this.NazwaPosilku.TabIndex = 0;
            this.NazwaPosilku.Text = "Nazwa posiłku";
            // 
            // panelGlowny
            // 
            this.panelGlowny.AutoScroll = true;
            this.panelGlowny.Location = new System.Drawing.Point(0, 149);
            this.panelGlowny.Name = "panelGlowny";
            this.panelGlowny.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panelGlowny.Size = new System.Drawing.Size(589, 432);
            this.panelGlowny.TabIndex = 0;
            // 
            // panelGorny
            // 
            this.panelGorny.AutoSize = true;
            this.panelGorny.Controls.Add(this.button2);
            this.panelGorny.Controls.Add(this.NazwaPosilku);
            this.panelGorny.Controls.Add(this.lblDzien);
            this.panelGorny.Location = new System.Drawing.Point(0, 0);
            this.panelGorny.Name = "panelGorny";
            this.panelGorny.Size = new System.Drawing.Size(589, 78);
            this.panelGorny.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::FitApp.Properties.Resources.back;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(18, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 51);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblDzien
            // 
            this.lblDzien.AutoSize = true;
            this.lblDzien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDzien.Location = new System.Drawing.Point(260, 47);
            this.lblDzien.Margin = new System.Windows.Forms.Padding(260, 5, 3, 0);
            this.lblDzien.Name = "lblDzien";
            this.lblDzien.Size = new System.Drawing.Size(69, 25);
            this.lblDzien.TabIndex = 1;
            this.lblDzien.Text = "Dzisiaj";
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.txtBoxSearch);
            this.panelSearch.Controls.Add(this.btnHidden);
            this.panelSearch.Location = new System.Drawing.Point(0, 75);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(589, 76);
            this.panelSearch.TabIndex = 2;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxSearch.Location = new System.Drawing.Point(104, 23);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(104, 23, 0, 0);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(378, 30);
            this.txtBoxSearch.TabIndex = 1;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.TxtBoxSearch_TextChanged);
            // 
            // btnHidden
            // 
            this.btnHidden.Location = new System.Drawing.Point(485, 3);
            this.btnHidden.Name = "btnHidden";
            this.btnHidden.Size = new System.Drawing.Size(1, 0);
            this.btnHidden.TabIndex = 0;
            this.btnHidden.Text = "button1";
            this.btnHidden.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(217, 593);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.label2.Size = new System.Drawing.Size(210, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dodaj nowy produkt";
            this.label2.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // Border
            // 
            this.Border.Location = new System.Drawing.Point(0, 584);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(589, 1);
            this.Border.TabIndex = 0;
            this.Border.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintBorder);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::FitApp.Properties.Resources.add;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(175, 593);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 42);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // FormDodawania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 646);
            this.Controls.Add(this.Border);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelGorny);
            this.Controls.Add(this.panelGlowny);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormDodawania";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FItApp - dodaj posiłek";
            this.Load += new System.EventHandler(this.FormDodawania_Load);
            this.panelGorny.ResumeLayout(false);
            this.panelGorny.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NazwaPosilku;
        private System.Windows.Forms.FlowLayoutPanel panelGlowny;
        private System.Windows.Forms.Panel panelGorny;
        private System.Windows.Forms.FlowLayoutPanel panelSearch;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnHidden;
        private System.Windows.Forms.Label lblDzien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Border;
        private System.Windows.Forms.Button button2;
    }
}