using System;
using System.Collections.Generic;
using System.Text;

namespace Maquina_de_cafe
{
    public class Azucarero
    {
        private int cantidadDeAzucar;

        public Azucarero(int cantidadeazucar)
        {
            this.cantidadDeAzucar = cantidadeazucar;
        }

        public void setCantidadDeAzucar(int cantidadeazucar)
        {
            this.cantidadDeAzucar = cantidadeazucar;
        }

        public int getCantidadDeAzucar()
        {
            return this.cantidadDeAzucar;
        }

        public bool hasAzucar(int cantidadeazucar)
        {
            if(this.cantidadDeAzucar >= cantidadeazucar)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void giveAzucar(int cantidadDeAzucar)
        {
            this.cantidadDeAzucar -= cantidadDeAzucar;
        }
    }
}
