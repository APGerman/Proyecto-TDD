using System;
using System.Collections.Generic;
using System.Text;

namespace Maquina_de_cafe
{
    public class Cafetera
    {
        private int cantidadCafe;

        public Cafetera(int cantidadcafe)
        {
            this.cantidadCafe = cantidadcafe;
        }
             
        public void setCantidaDeCafe(int cantidadecafe)
        {
            this.cantidadCafe = cantidadecafe;
        }

        public int getCantidadDeCafe()
        {
            return cantidadCafe;
        }

        public bool hasCafe(int cantidadcafe)
        {
            if(this.cantidadCafe >= cantidadcafe)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void giveCafe(int cantidadcafe)
        {
            cantidadCafe -= cantidadcafe;
        }
    }
}
