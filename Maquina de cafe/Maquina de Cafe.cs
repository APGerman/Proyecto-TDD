using System;
using System.Collections.Generic;
using System.Text;

namespace Maquina_de_cafe
{
    public class Maquina_de_Cafe
    {
        public Cafetera cafe;
        public Vaso vasosPequenos;
        public Vaso vasosMedianos;
        public Vaso vasosGrandes;
        public Azucarero azucarero;


        public Vaso getTipoVaso(string tipovaso)
        {
            if (tipovaso == "pequeno")
            {
                return vasosPequenos;
            }
            else if(tipovaso == "mediano")
            {
                return vasosMedianos;
            }

            else if(tipovaso == "grande")
            {
                return vasosGrandes;
            }

            else return null;
        }

        public string getVasoDeCafe(Vaso vaso, int cantidadevasos, int cantidadeazucar)
        {
            if(vaso.hasVasos(cantidadevasos) == false)
            {
                return "No hay Vasos";
            }

            if (cafe.hasCafe(vaso.getContenido()) == false)
            {
                return "No hay Cafe";
            }

            if(azucarero.hasAzucar(cantidadeazucar) == false)
            {
                return "No hay Azucar";
            }

            vaso.giveVasos(cantidadevasos);
            cafe.giveCafe(vaso.getContenido());
            azucarero.giveAzucar(cantidadeazucar);
            return "Felicitaciones";

            
        }

        public void setVasosPequeno(Vaso vasospequeno)
        {
            this.vasosPequenos = vasospequeno;
        }

        public void setVasosMediano(Vaso vasosmediano)
        {
            this.vasosMedianos = vasosmediano;
        }

        public void setVasosGrande(Vaso vasosgrande)
        {
            this.vasosGrandes = vasosgrande;
        }

        public void setAzucarero(Azucarero azucarero)
        {
            this.azucarero = azucarero;
        }

        public void setCafetera(Cafetera cafetera)
        {
            this.cafe = cafetera;
        }

        public Vaso getVasosPequenos()
        {
            return this.vasosPequenos;
        }

        public Vaso getVasosMedianos()
        {
            return this.vasosMedianos;
        }

        public Vaso getVasosGrandes()
        {
            return this.vasosGrandes;
        }

        public Azucarero getAzucarero()
        {
            return this.azucarero;
        }

        public Cafetera getCafetera()
        {
            return this.cafe;
        }

        
    }
}
