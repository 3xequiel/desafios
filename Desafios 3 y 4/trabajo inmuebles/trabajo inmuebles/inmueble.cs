using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_inmuebles
{
    abstract class inmueble
    {
        protected String Direccion;
        protected int mt2;
        protected double precioinicial;
        protected bool estado;

        protected inmueble(String Direccion,int mt2,double precioinicial,bool estado)
        {
            this.Direccion = Direccion;
            this.mt2 = mt2;
            this.precioinicial = precioinicial;
            this.estado = estado;
        } 

    }
}
