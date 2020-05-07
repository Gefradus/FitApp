namespace FitApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Sniadanie = new System.Windows.Forms.Panel();
            this.btnSniadanie = new System.Windows.Forms.Button();
            this.lblSniadanieKcal = new System.Windows.Forms.Label();
            this.lblSniadanie = new System.Windows.Forms.Label();
            this.panelSniadanie = new System.Windows.Forms.FlowLayoutPanel();
            this.IISniadanie = new System.Windows.Forms.Panel();
            this.btn2Sniad = new System.Windows.Forms.Button();
            this.lbl2SniadKcal = new System.Windows.Forms.Label();
            this.lbl2Sniadanie = new System.Windows.Forms.Label();
            this.panel2Sniadanie = new System.Windows.Forms.FlowLayoutPanel();
            this.Obiad = new System.Windows.Forms.Panel();
            this.btnObiad = new System.Windows.Forms.Button();
            this.lblObiadKcal = new System.Windows.Forms.Label();
            this.lblObiad = new System.Windows.Forms.Label();
            this.panelObiad = new System.Windows.Forms.FlowLayoutPanel();
            this.Deser = new System.Windows.Forms.Panel();
            this.btnDeser = new System.Windows.Forms.Button();
            this.lblDeserKcal = new System.Windows.Forms.Label();
            this.lblDeser = new System.Windows.Forms.Label();
            this.panelDeser = new System.Windows.Forms.FlowLayoutPanel();
            this.Przekaska = new System.Windows.Forms.Panel();
            this.btnPrzekaska = new System.Windows.Forms.Button();
            this.lblPrzekaskaKcal = new System.Windows.Forms.Label();
            this.lblPrzekaska = new System.Windows.Forms.Label();
            this.panelPrzekaska = new System.Windows.Forms.FlowLayoutPanel();
            this.Kolacja = new System.Windows.Forms.Panel();
            this.btnKolacja = new System.Windows.Forms.Button();
            this.lblKolacjaKcal = new System.Windows.Forms.Label();
            this.lblKolacja = new System.Windows.Forms.Label();
            this.panelKolacja = new System.Windows.Forms.FlowLayoutPanel();
            this.panelGlowny = new System.Windows.Forms.Panel();
            this.panelDnia = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.Sniadanie.SuspendLayout();
            this.IISniadanie.SuspendLayout();
            this.Obiad.SuspendLayout();
            this.Deser.SuspendLayout();
            this.Przekaska.SuspendLayout();
            this.Kolacja.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.flowLayoutPanel1.Controls.Add(this.Sniadanie);
            this.flowLayoutPanel1.Controls.Add(this.panelSniadanie);
            this.flowLayoutPanel1.Controls.Add(this.IISniadanie);
            this.flowLayoutPanel1.Controls.Add(this.panel2Sniadanie);
            this.flowLayoutPanel1.Controls.Add(this.Obiad);
            this.flowLayoutPanel1.Controls.Add(this.panelObiad);
            this.flowLayoutPanel1.Controls.Add(this.Deser);
            this.flowLayoutPanel1.Controls.Add(this.panelDeser);
            this.flowLayoutPanel1.Controls.Add(this.Przekaska);
            this.flowLayoutPanel1.Controls.Add(this.panelPrzekaska);
            this.flowLayoutPanel1.Controls.Add(this.Kolacja);
            this.flowLayoutPanel1.Controls.Add(this.panelKolacja);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 90);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(40, 3, 21, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(586, 472);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // Sniadanie
            // 
            this.Sniadanie.BackColor = System.Drawing.SystemColors.Window;
            this.Sniadanie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sniadanie.Controls.Add(this.btnSniadanie);
            this.Sniadanie.Controls.Add(this.lblSniadanieKcal);
            this.Sniadanie.Controls.Add(this.lblSniadanie);
            this.Sniadanie.Location = new System.Drawing.Point(40, 15);
            this.Sniadanie.Margin = new System.Windows.Forms.Padding(40, 15, 0, 3);
            this.Sniadanie.Name = "Sniadanie";
            this.Sniadanie.Size = new System.Drawing.Size(500, 63);
            this.Sniadanie.TabIndex = 16;
            this.Sniadanie.Click += new System.EventHandler(this.Sniadanie_Click);
            this.Sniadanie.MouseHover += new System.EventHandler(this.MouseHand_Sniadanie);
            // 
            // btnSniadanie
            // 
            this.btnSniadanie.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSniadanie.FlatAppearance.BorderSize = 0;
            this.btnSniadanie.Font = new System.Drawing.Font("Microsoft Yi Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSniadanie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSniadanie.Location = new System.Drawing.Point(404, 14);
            this.btnSniadanie.Name = "btnSniadanie";
            this.btnSniadanie.Size = new System.Drawing.Size(81, 36);
            this.btnSniadanie.TabIndex = 10;
            this.btnSniadanie.Text = "Dodaj";
            this.btnSniadanie.UseVisualStyleBackColor = false;
            this.btnSniadanie.Click += new System.EventHandler(this.btnSniadanie_Click);
            // 
            // lblSniadanieKcal
            // 
            this.lblSniadanieKcal.AutoSize = true;
            this.lblSniadanieKcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSniadanieKcal.Location = new System.Drawing.Point(11, 36);
            this.lblSniadanieKcal.Name = "lblSniadanieKcal";
            this.lblSniadanieKcal.Size = new System.Drawing.Size(58, 24);
            this.lblSniadanieKcal.TabIndex = 9;
            this.lblSniadanieKcal.Text = "0 kcal";
            // 
            // lblSniadanie
            // 
            this.lblSniadanie.AutoSize = true;
            this.lblSniadanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSniadanie.Location = new System.Drawing.Point(4, 3);
            this.lblSniadanie.Name = "lblSniadanie";
            this.lblSniadanie.Size = new System.Drawing.Size(109, 25);
            this.lblSniadanie.TabIndex = 8;
            this.lblSniadanie.Text = "Śniadanie";
            // 
            // panelSniadanie
            // 
            this.panelSniadanie.AutoSize = true;
            this.panelSniadanie.BackColor = System.Drawing.SystemColors.Window;
            this.panelSniadanie.Location = new System.Drawing.Point(580, 0);
            this.panelSniadanie.Margin = new System.Windows.Forms.Padding(40, 0, 0, 3);
            this.panelSniadanie.Name = "panelSniadanie";
            this.panelSniadanie.Size = new System.Drawing.Size(0, 0);
            this.panelSniadanie.TabIndex = 17;
            // 
            // IISniadanie
            // 
            this.IISniadanie.BackColor = System.Drawing.SystemColors.Window;
            this.IISniadanie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IISniadanie.Controls.Add(this.btn2Sniad);
            this.IISniadanie.Controls.Add(this.lbl2SniadKcal);
            this.IISniadanie.Controls.Add(this.lbl2Sniadanie);
            this.IISniadanie.Location = new System.Drawing.Point(40, 81);
            this.IISniadanie.Margin = new System.Windows.Forms.Padding(40, 0, 0, 3);
            this.IISniadanie.Name = "IISniadanie";
            this.IISniadanie.Size = new System.Drawing.Size(500, 63);
            this.IISniadanie.TabIndex = 18;
            this.IISniadanie.Click += new System.EventHandler(this.IISniadanie_Click);
            this.IISniadanie.MouseHover += new System.EventHandler(this.MouseHand_2Sniadanie);
            // 
            // btn2Sniad
            // 
            this.btn2Sniad.BackColor = System.Drawing.Color.LimeGreen;
            this.btn2Sniad.FlatAppearance.BorderSize = 0;
            this.btn2Sniad.Font = new System.Drawing.Font("Microsoft Yi Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn2Sniad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2Sniad.Location = new System.Drawing.Point(404, 13);
            this.btn2Sniad.Name = "btn2Sniad";
            this.btn2Sniad.Size = new System.Drawing.Size(81, 36);
            this.btn2Sniad.TabIndex = 10;
            this.btn2Sniad.Text = "Dodaj";
            this.btn2Sniad.UseVisualStyleBackColor = false;
            this.btn2Sniad.Click += new System.EventHandler(this.btn2Sniad_Click);
            // 
            // lbl2SniadKcal
            // 
            this.lbl2SniadKcal.AutoSize = true;
            this.lbl2SniadKcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl2SniadKcal.Location = new System.Drawing.Point(11, 36);
            this.lbl2SniadKcal.Name = "lbl2SniadKcal";
            this.lbl2SniadKcal.Size = new System.Drawing.Size(58, 24);
            this.lbl2SniadKcal.TabIndex = 9;
            this.lbl2SniadKcal.Text = "0 kcal";
            // 
            // lbl2Sniadanie
            // 
            this.lbl2Sniadanie.AutoSize = true;
            this.lbl2Sniadanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl2Sniadanie.Location = new System.Drawing.Point(4, 3);
            this.lbl2Sniadanie.Name = "lbl2Sniadanie";
            this.lbl2Sniadanie.Size = new System.Drawing.Size(123, 25);
            this.lbl2Sniadanie.TabIndex = 28;
            this.lbl2Sniadanie.Text = "II śniadanie";
            // 
            // panel2Sniadanie
            // 
            this.panel2Sniadanie.AutoSize = true;
            this.panel2Sniadanie.BackColor = System.Drawing.SystemColors.Window;
            this.panel2Sniadanie.Location = new System.Drawing.Point(580, 81);
            this.panel2Sniadanie.Margin = new System.Windows.Forms.Padding(40, 0, 0, 3);
            this.panel2Sniadanie.Name = "panel2Sniadanie";
            this.panel2Sniadanie.Size = new System.Drawing.Size(0, 0);
            this.panel2Sniadanie.TabIndex = 19;
            // 
            // Obiad
            // 
            this.Obiad.BackColor = System.Drawing.SystemColors.Window;
            this.Obiad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Obiad.Controls.Add(this.btnObiad);
            this.Obiad.Controls.Add(this.lblObiadKcal);
            this.Obiad.Controls.Add(this.lblObiad);
            this.Obiad.Location = new System.Drawing.Point(40, 147);
            this.Obiad.Margin = new System.Windows.Forms.Padding(40, 0, 0, 3);
            this.Obiad.Name = "Obiad";
            this.Obiad.Size = new System.Drawing.Size(500, 63);
            this.Obiad.TabIndex = 20;
            this.Obiad.Click += new System.EventHandler(this.Obiad_Click);
            this.Obiad.MouseHover += new System.EventHandler(this.MouseHand_Obiad);
            // 
            // btnObiad
            // 
            this.btnObiad.BackColor = System.Drawing.Color.LimeGreen;
            this.btnObiad.FlatAppearance.BorderSize = 0;
            this.btnObiad.Font = new System.Drawing.Font("Microsoft Yi Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObiad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnObiad.Location = new System.Drawing.Point(404, 13);
            this.btnObiad.Name = "btnObiad";
            this.btnObiad.Size = new System.Drawing.Size(81, 36);
            this.btnObiad.TabIndex = 10;
            this.btnObiad.Text = "Dodaj";
            this.btnObiad.UseVisualStyleBackColor = false;
            this.btnObiad.Click += new System.EventHandler(this.btnObiad_Click);
            // 
            // lblObiadKcal
            // 
            this.lblObiadKcal.AutoSize = true;
            this.lblObiadKcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblObiadKcal.Location = new System.Drawing.Point(11, 36);
            this.lblObiadKcal.Name = "lblObiadKcal";
            this.lblObiadKcal.Size = new System.Drawing.Size(58, 24);
            this.lblObiadKcal.TabIndex = 9;
            this.lblObiadKcal.Text = "0 kcal";
            // 
            // lblObiad
            // 
            this.lblObiad.AutoSize = true;
            this.lblObiad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblObiad.Location = new System.Drawing.Point(4, 3);
            this.lblObiad.Name = "lblObiad";
            this.lblObiad.Size = new System.Drawing.Size(70, 25);
            this.lblObiad.TabIndex = 8;
            this.lblObiad.Text = "Obiad";
            // 
            // panelObiad
            // 
            this.panelObiad.AutoSize = true;
            this.panelObiad.BackColor = System.Drawing.SystemColors.Window;
            this.panelObiad.Location = new System.Drawing.Point(580, 147);
            this.panelObiad.Margin = new System.Windows.Forms.Padding(40, 0, 0, 3);
            this.panelObiad.Name = "panelObiad";
            this.panelObiad.Size = new System.Drawing.Size(0, 0);
            this.panelObiad.TabIndex = 21;
            // 
            // Deser
            // 
            this.Deser.BackColor = System.Drawing.SystemColors.Window;
            this.Deser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Deser.Controls.Add(this.btnDeser);
            this.Deser.Controls.Add(this.lblDeserKcal);
            this.Deser.Controls.Add(this.lblDeser);
            this.Deser.Location = new System.Drawing.Point(40, 213);
            this.Deser.Margin = new System.Windows.Forms.Padding(40, 0, 0, 3);
            this.Deser.Name = "Deser";
            this.Deser.Size = new System.Drawing.Size(500, 63);
            this.Deser.TabIndex = 22;
            this.Deser.Click += new System.EventHandler(this.Deser_Click);
            this.Deser.MouseHover += new System.EventHandler(this.MouseHand_Deser);
            // 
            // btnDeser
            // 
            this.btnDeser.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDeser.FlatAppearance.BorderSize = 0;
            this.btnDeser.Font = new System.Drawing.Font("Microsoft Yi Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeser.Location = new System.Drawing.Point(404, 13);
            this.btnDeser.Name = "btnDeser";
            this.btnDeser.Size = new System.Drawing.Size(81, 36);
            this.btnDeser.TabIndex = 10;
            this.btnDeser.Text = "Dodaj";
            this.btnDeser.UseVisualStyleBackColor = false;
            this.btnDeser.Click += new System.EventHandler(this.btnDeser_Click);
            // 
            // lblDeserKcal
            // 
            this.lblDeserKcal.AutoSize = true;
            this.lblDeserKcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDeserKcal.Location = new System.Drawing.Point(11, 36);
            this.lblDeserKcal.Name = "lblDeserKcal";
            this.lblDeserKcal.Size = new System.Drawing.Size(58, 24);
            this.lblDeserKcal.TabIndex = 9;
            this.lblDeserKcal.Text = "0 kcal";
            // 
            // lblDeser
            // 
            this.lblDeser.AutoSize = true;
            this.lblDeser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDeser.Location = new System.Drawing.Point(4, 3);
            this.lblDeser.Name = "lblDeser";
            this.lblDeser.Size = new System.Drawing.Size(69, 25);
            this.lblDeser.TabIndex = 8;
            this.lblDeser.Text = "Deser";
            // 
            // panelDeser
            // 
            this.panelDeser.AutoSize = true;
            this.panelDeser.BackColor = System.Drawing.SystemColors.Window;
            this.panelDeser.Location = new System.Drawing.Point(580, 213);
            this.panelDeser.Margin = new System.Windows.Forms.Padding(40, 0, 0, 3);
            this.panelDeser.Name = "panelDeser";
            this.panelDeser.Size = new System.Drawing.Size(0, 0);
            this.panelDeser.TabIndex = 23;
            // 
            // Przekaska
            // 
            this.Przekaska.BackColor = System.Drawing.SystemColors.Window;
            this.Przekaska.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Przekaska.Controls.Add(this.btnPrzekaska);
            this.Przekaska.Controls.Add(this.lblPrzekaskaKcal);
            this.Przekaska.Controls.Add(this.lblPrzekaska);
            this.Przekaska.Location = new System.Drawing.Point(40, 279);
            this.Przekaska.Margin = new System.Windows.Forms.Padding(40, 0, 0, 3);
            this.Przekaska.Name = "Przekaska";
            this.Przekaska.Size = new System.Drawing.Size(500, 63);
            this.Przekaska.TabIndex = 24;
            this.Przekaska.Click += new System.EventHandler(this.Przekaska_Click);
            this.Przekaska.MouseHover += new System.EventHandler(this.MouseHand_Przekaska);
            // 
            // btnPrzekaska
            // 
            this.btnPrzekaska.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPrzekaska.FlatAppearance.BorderSize = 0;
            this.btnPrzekaska.Font = new System.Drawing.Font("Microsoft Yi Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzekaska.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrzekaska.Location = new System.Drawing.Point(404, 14);
            this.btnPrzekaska.Name = "btnPrzekaska";
            this.btnPrzekaska.Size = new System.Drawing.Size(81, 36);
            this.btnPrzekaska.TabIndex = 10;
            this.btnPrzekaska.Text = "Dodaj";
            this.btnPrzekaska.UseVisualStyleBackColor = false;
            this.btnPrzekaska.Click += new System.EventHandler(this.btnPrzekaska_Click);
            // 
            // lblPrzekaskaKcal
            // 
            this.lblPrzekaskaKcal.AutoSize = true;
            this.lblPrzekaskaKcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrzekaskaKcal.Location = new System.Drawing.Point(11, 36);
            this.lblPrzekaskaKcal.Name = "lblPrzekaskaKcal";
            this.lblPrzekaskaKcal.Size = new System.Drawing.Size(58, 24);
            this.lblPrzekaskaKcal.TabIndex = 9;
            this.lblPrzekaskaKcal.Text = "0 kcal";
            // 
            // lblPrzekaska
            // 
            this.lblPrzekaska.AutoSize = true;
            this.lblPrzekaska.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrzekaska.Location = new System.Drawing.Point(4, 3);
            this.lblPrzekaska.Name = "lblPrzekaska";
            this.lblPrzekaska.Size = new System.Drawing.Size(113, 25);
            this.lblPrzekaska.TabIndex = 8;
            this.lblPrzekaska.Text = "Przekąska";
            // 
            // panelPrzekaska
            // 
            this.panelPrzekaska.AutoSize = true;
            this.panelPrzekaska.BackColor = System.Drawing.SystemColors.Window;
            this.panelPrzekaska.Location = new System.Drawing.Point(580, 279);
            this.panelPrzekaska.Margin = new System.Windows.Forms.Padding(40, 0, 0, 3);
            this.panelPrzekaska.Name = "panelPrzekaska";
            this.panelPrzekaska.Size = new System.Drawing.Size(0, 0);
            this.panelPrzekaska.TabIndex = 25;
            // 
            // Kolacja
            // 
            this.Kolacja.BackColor = System.Drawing.SystemColors.Window;
            this.Kolacja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Kolacja.Controls.Add(this.btnKolacja);
            this.Kolacja.Controls.Add(this.lblKolacjaKcal);
            this.Kolacja.Controls.Add(this.lblKolacja);
            this.Kolacja.Location = new System.Drawing.Point(40, 345);
            this.Kolacja.Margin = new System.Windows.Forms.Padding(40, 0, 0, 3);
            this.Kolacja.Name = "Kolacja";
            this.Kolacja.Size = new System.Drawing.Size(500, 63);
            this.Kolacja.TabIndex = 26;
            this.Kolacja.Click += new System.EventHandler(this.Kolacja_Click);
            this.Kolacja.MouseHover += new System.EventHandler(this.MouseHand_Kolacja);
            // 
            // btnKolacja
            // 
            this.btnKolacja.BackColor = System.Drawing.Color.LimeGreen;
            this.btnKolacja.FlatAppearance.BorderSize = 0;
            this.btnKolacja.Font = new System.Drawing.Font("Microsoft Yi Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKolacja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKolacja.Location = new System.Drawing.Point(404, 13);
            this.btnKolacja.Name = "btnKolacja";
            this.btnKolacja.Size = new System.Drawing.Size(81, 36);
            this.btnKolacja.TabIndex = 10;
            this.btnKolacja.Text = "Dodaj";
            this.btnKolacja.UseVisualStyleBackColor = false;
            this.btnKolacja.Click += new System.EventHandler(this.btnKolacja_Click);
            // 
            // lblKolacjaKcal
            // 
            this.lblKolacjaKcal.AutoSize = true;
            this.lblKolacjaKcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKolacjaKcal.Location = new System.Drawing.Point(11, 36);
            this.lblKolacjaKcal.Name = "lblKolacjaKcal";
            this.lblKolacjaKcal.Size = new System.Drawing.Size(58, 24);
            this.lblKolacjaKcal.TabIndex = 9;
            this.lblKolacjaKcal.Text = "0 kcal";
            // 
            // lblKolacja
            // 
            this.lblKolacja.AutoSize = true;
            this.lblKolacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKolacja.Location = new System.Drawing.Point(4, 3);
            this.lblKolacja.Name = "lblKolacja";
            this.lblKolacja.Size = new System.Drawing.Size(84, 25);
            this.lblKolacja.TabIndex = 8;
            this.lblKolacja.Text = "Kolacja";
            // 
            // panelKolacja
            // 
            this.panelKolacja.AutoSize = true;
            this.panelKolacja.BackColor = System.Drawing.SystemColors.Window;
            this.panelKolacja.Location = new System.Drawing.Point(580, 345);
            this.panelKolacja.Margin = new System.Windows.Forms.Padding(40, 0, 0, 3);
            this.panelKolacja.Name = "panelKolacja";
            this.panelKolacja.Size = new System.Drawing.Size(0, 0);
            this.panelKolacja.TabIndex = 27;
            // 
            // panelGlowny
            // 
            this.panelGlowny.BackColor = System.Drawing.SystemColors.Window;
            this.panelGlowny.Location = new System.Drawing.Point(1, 560);
            this.panelGlowny.Name = "panelGlowny";
            this.panelGlowny.Size = new System.Drawing.Size(586, 81);
            this.panelGlowny.TabIndex = 6;
            // 
            // panelDnia
            // 
            this.panelDnia.BackColor = System.Drawing.SystemColors.Window;
            this.panelDnia.Location = new System.Drawing.Point(1, 6);
            this.panelDnia.Name = "panelDnia";
            this.panelDnia.Size = new System.Drawing.Size(586, 81);
            this.panelDnia.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 646);
            this.Controls.Add(this.panelGlowny);
            this.Controls.Add(this.panelDnia);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.Sniadanie.ResumeLayout(false);
            this.Sniadanie.PerformLayout();
            this.IISniadanie.ResumeLayout(false);
            this.IISniadanie.PerformLayout();
            this.Obiad.ResumeLayout(false);
            this.Obiad.PerformLayout();
            this.Deser.ResumeLayout(false);
            this.Deser.PerformLayout();
            this.Przekaska.ResumeLayout(false);
            this.Przekaska.PerformLayout();
            this.Kolacja.ResumeLayout(false);
            this.Kolacja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGlowny;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel Sniadanie;
        private System.Windows.Forms.Button btnSniadanie;
        private System.Windows.Forms.Label lblSniadanieKcal;
        private System.Windows.Forms.Label lblSniadanie;
        private System.Windows.Forms.Panel IISniadanie;
        private System.Windows.Forms.Button btn2Sniad;
        private System.Windows.Forms.Label lbl2SniadKcal;
        private System.Windows.Forms.Panel Obiad;
        private System.Windows.Forms.Button btnObiad;
        private System.Windows.Forms.Label lblObiadKcal;
        private System.Windows.Forms.Label lblObiad;
        private System.Windows.Forms.Panel Deser;
        private System.Windows.Forms.Button btnDeser;
        private System.Windows.Forms.Label lblDeserKcal;
        private System.Windows.Forms.Label lblDeser;
        private System.Windows.Forms.Panel Przekaska;
        private System.Windows.Forms.Button btnPrzekaska;
        private System.Windows.Forms.Label lblPrzekaskaKcal;
        private System.Windows.Forms.Label lblPrzekaska;
        private System.Windows.Forms.Panel panelDnia;
        private System.Windows.Forms.Panel Kolacja;
        private System.Windows.Forms.Button btnKolacja;
        private System.Windows.Forms.Label lblKolacjaKcal;
        private System.Windows.Forms.Label lblKolacja;
        private System.Windows.Forms.FlowLayoutPanel panelSniadanie;
        private System.Windows.Forms.FlowLayoutPanel panel2Sniadanie;
        private System.Windows.Forms.FlowLayoutPanel panelObiad;
        private System.Windows.Forms.FlowLayoutPanel panelDeser;
        private System.Windows.Forms.FlowLayoutPanel panelPrzekaska;
        private System.Windows.Forms.FlowLayoutPanel panelKolacja;
        private System.Windows.Forms.Label lbl2Sniadanie;
    }
}

