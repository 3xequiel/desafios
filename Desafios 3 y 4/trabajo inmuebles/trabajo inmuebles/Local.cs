using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_inmuebles
{
    class Local : inmueble 
    {
        private int nventanas;


        public Local(String Direccion, int mt2, double precioinicial, bool estado, int nventanas) : base(Direccion, mt2,precioinicial ,estado )
        {
            this.nventanas = nventanas;
        }

        public int Nventanas
        {
            get
            {
                return nventanas;
            }

            set
            {
                nventanas = value;
            }
        }

        public double calcularp(int precioinicial)
        {
            double preciofinal;
            double E = 0.0;
            double MT = 0.0;
            double V = 0.0;

            if (estado == true)
            {
                E = E - (precioinicial * 1) / 100;
            }
            else
            {
                E = E - (precioinicial * 2) / 100;
            }
            if (MT > 50)
            {
               MT = MT + (precioinicial * 1) / 100;
            }
            if(V <= 1)
            {
                V = V - (precioinicial * 2) / 100;
            }
            else
            if(V > 4)
            {
                V = V + (precioinicial * 2) / 100;
            }

            preciofinal = precioinicial + MT + V + E;
            return preciofinal; 
        }





           








    }





}
