using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WFA_RondCarreDeplacement_LD
{
    class GrandCarre
    {
        int tailleTraj = 400;
        Size tailleForme = new Size(50, 50);
        Rectangle trajectoire;
        ObjetAvecObjectif[] objetsTournant = new ObjetAvecObjectif[4];
        Point[] coinsGrandCarre = new Point[4], objectifs = new Point[4];

        public GrandCarre(Point position)
        {
            trajectoire = new Rectangle(position, new Size(400, 400));
            

            coinsGrandCarre[0] = trajectoire.Location;
            coinsGrandCarre[1] = new Point(trajectoire.Right, trajectoire.Top);
            coinsGrandCarre[2] = new Point(trajectoire.Right, trajectoire.Bottom);
            coinsGrandCarre[3] = new Point(trajectoire.Left, trajectoire.Bottom);

            objectifs[0] = coinsGrandCarre[1];
            objectifs[1] = coinsGrandCarre[2];
            objectifs[2] = coinsGrandCarre[3];
            objectifs[3] = coinsGrandCarre[0];


            objetsTournant[0] = new ObjetAvecObjectif(new Rectangle(coinsGrandCarre[0], tailleForme), objectifs[0], 0);
            objetsTournant[1] = new ObjetAvecObjectif(new Rectangle(coinsGrandCarre[1], tailleForme), objectifs[1], 1);
            objetsTournant[2] = new ObjetAvecObjectif(new Rectangle(coinsGrandCarre[2], tailleForme), objectifs[2], 0);
            objetsTournant[3] = new ObjetAvecObjectif(new Rectangle(coinsGrandCarre[3], tailleForme), objectifs[3], 1);
        }

        public void ChangementObjectif()
        {
            
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            foreach (ObjetAvecObjectif forme in objetsTournant)
            {
                forme.Paint(sender, e);
                forme.AvanceVersObectif();
            }
        }
    }
}
