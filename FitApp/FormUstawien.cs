using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitApp
{
    public partial class FormUstawien : Form
    {
        private readonly ModelXML _context;
        public int KlientID { get; set; }
        public int DzienID { get; set; }

        public FormUstawien()
        {
            _context = new ModelXML();
            InitializeComponent();
            FormClosing += new FormClosingEventHandler(Form_Closing);
        }

        private void Form_Closing(object sender, EventArgs e)
        {
            Hide();
            Form form1 = new Form1()
            {
                KlientID = KlientID,
                DzienID = DzienID
            };

            form1.Show();
        }
    }
}
