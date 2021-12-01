using System;
using System.Collections.Generic;
using System.Text;

namespace Maquina_de_cafe
{
    public class Vaso
    {
        private int cantidadVasos;
        private int contenido;

        public Vaso(int cantidadvasos, int contenido)
        {
            this.cantidadVasos = cantidadvasos;
            this.contenido = contenido;
        }

        public void setCantidadVasos(int cantidadvasos)
        {
            this.cantidadVasos = cantidadvasos;
        }

        public int getCantidadVasos()
        {
            return this.cantidadVasos;
        }

        public void setContenido(int contenido)
        {
            this.contenido = contenido;
        }

        public int getContenido()
        {
            return this.contenido;
        }

        public bool hasVasos(int cantidadvasos)
        {
            if(cantidadVasos >= cantidadvasos)
            {
                return true;
            }
            else
            {
                
                return false;
                
            }
        } 

        public void giveVasos(int cantidadvasos)
        {
            cantidadVasos = cantidadVasos - cantidadvasos;
        }
    }
}
