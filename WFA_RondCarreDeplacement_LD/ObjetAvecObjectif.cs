using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WFA_RondCarreDeplacement_LD
{
    class ObjetAvecObjectif
    {
        Rectangle moi;
        Point position, objectif;
        int type; 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="obj"></param>
        /// <param name="type">Type de forme, le 0 est un Rond, le 1 est un carre</param>
        public ObjetAvecObjectif(Rectangle rect, Point obj, int type)
        {
            moi = rect;
            objectif = obj;
            this.type = type;
            position = moi.Location;
        }

        public Point Position
        {
            get {
                position = moi.Location;
                return position; 
            }
            set { 
                position = value;
                moi.Location = position;
            }
        }

        public Point Objectif
        {
            get { return objectif; }
            set { objectif = value; }
        }

        public void AvanceVersObectif()
        {

        }

        public void Paint(object sender, PaintEventArgs e)
        {
            if (type == 0)
            {
                e.Graphics.FillEllipse(Brushes.DarkSlateBlue, moi);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.DarkMagenta, moi);
            }
        }
    }
}
