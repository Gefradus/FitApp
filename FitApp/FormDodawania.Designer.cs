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
            this.panelGorny = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnHidden = new System.Windows.Forms.Button();
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
            this.panelGlowny.Location = new System.Drawing.Point(0, 149);
            this.panelGlowny.Name = "panelGlowny";
            this.panelGlowny.Size = new System.Drawing.Size(589, 499);
            this.panelGlowny.TabIndex = 0;
            // 
            // panelGorny
            // 
            this.panelGorny.Controls.Add(this.NazwaPosilku);
            this.panelGorny.Location = new System.Drawing.Point(0, 0);
            this.panelGorny.Name = "panelGorny";
            this.panelGorny.Size = new System.Drawing.Size(589, 78);
            this.panelGorny.TabIndex = 1;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.txtBoxSearch);
            this.panelSearch.Controls.Add(this.btnHidden);
            this.panelSearch.Location = new System.Drawing.Point(0, 75);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(589, 76);
            this.panelSearch.TabIndex = 2;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxSearch.Location = new System.Drawing.Point(106, 23);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(106, 23, 3, 3);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(378, 30);
            this.txtBoxSearch.TabIndex = 1;
            // 
            // btnHidden
            // 
            this.btnHidden.Location = new System.Drawing.Point(490, 3);
            this.btnHidden.Name = "btnHidden";
            this.btnHidden.Size = new System.Drawing.Size(1, 0);
            this.btnHidden.TabIndex = 0;
            this.btnHidden.Text = "button1";
            this.btnHidden.UseVisualStyleBackColor = true;
            // 
            // FormDodawania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 646);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelGorny);
            this.Controls.Add(this.panelGlowny);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormDodawania";
            this.Text = "FormDodawania";
            this.Load += new System.EventHandler(this.FormDodawania_Load);
            this.panelGorny.ResumeLayout(false);
            this.panelGorny.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NazwaPosilku;
        private System.Windows.Forms.FlowLayoutPanel panelGlowny;
        private System.Windows.Forms.FlowLayoutPanel panelGorny;
        private System.Windows.Forms.FlowLayoutPanel panelSearch;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnHidden;
    }
}