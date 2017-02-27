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
    public partial class Tmp_Mokit_Palvelut : Form
    {
        public Tmp_Mokit_Palvelut()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void asiakkkaatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asiakkaat lomake = new Asiakkaat();
            lomake.Show();
        }

        private void toimipisteetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void varauksetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Varaus_uusi lomake = new Varaus_uusi();
            lomake.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
