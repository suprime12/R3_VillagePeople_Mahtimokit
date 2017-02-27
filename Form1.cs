using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R3_VillagePeople_Mahtimokit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void asiakkkaatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void varauksetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Varaus_uusi lomake = new Varaus_uusi();
            lomake.Show();
        }
    }
}
