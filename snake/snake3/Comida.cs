using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake3
{
    class Comida : objeto
    {
        public Comida()
        {
            this.x = generar(78);
            this.y = generar(39);
        }
        public void dibujar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Red), this.x, this.y, this.ancho, this.ancho);
        }
        public void colocar()
        {
            this.x = generar(78);
            this.y = generar(39);
        }
        public int generar(int n)
        {
            Random random = new Random();
            int num = random.Next(0, n) * 10;
            return num;
        }
    }
}
