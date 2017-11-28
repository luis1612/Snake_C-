using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake3
{
    class objeto
    {
        protected int x, y, ancho;
        public objeto()
        {
            ancho = 10;
        }
        public Boolean interseccion(objeto o)
        {
            int difx = Math.Abs(this.x - o.x);
            int dify = Math.Abs(this.y - o.y);
            if(difx >= 0 && difx < ancho && dify >= 0 && dify < ancho)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
