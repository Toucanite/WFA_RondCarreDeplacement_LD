using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_RondCarreDeplacement_LD
{
    public partial class Epreuve : Form
    {
        GrandCarre monCarre = new GrandCarre(new Point(50, 50));

        public Epreuve()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }

        private void Epreuve_Paint(object sender, PaintEventArgs e)
        {
            monCarre.Paint(sender, e);
        }

        private void tmrAffiche_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
