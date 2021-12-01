using System;

namespace Maquina_de_cafe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cafetera cafetera = new Cafetera(50);
            Vaso vasosPequeno = new Vaso(5, 10);
            Vaso vasosMediano = new Vaso(5, 20);
            Vaso vasosGrande = new Vaso(5, 30);
            Azucarero azucarero = new Azucarero(20);

            Maquina_de_Cafe maquinaDeCafe = new Maquina_de_Cafe();
            maquinaDeCafe.setCafetera(cafetera);
            maquinaDeCafe.setVasosPequeno(vasosPequeno);
            maquinaDeCafe.setVasosMediano(vasosMediano);
            maquinaDeCafe.setVasosGrande(vasosGrande);
            maquinaDeCafe.setAzucarero(azucarero);
            bool continuar = true;
            int eleccion = 0;
            int cantidadvasos;
            int cantidadazucar;
            do
            {
                Console.WriteLine("Saludos, bienvenido a tu maquina de cafe");
                Console.WriteLine("Cantidad de vasos pequeños " + maquinaDeCafe.getTipoVaso("pequeno").getCantidadVasos());
                Console.WriteLine("Cantidad de vasos medianos " + maquinaDeCafe.getTipoVaso("mediano").getCantidadVasos());
                Console.WriteLine("Cantidad de vasos grandes " + maquinaDeCafe.getTipoVaso("grande").getCantidadVasos());
                Console.WriteLine("Cantidad de azucar " + maquinaDeCafe.getAzucarero().getCantidadDeAzucar());
                Console.WriteLine("Cantidad de cafe " + maquinaDeCafe.getCafetera().getCantidadDeCafe());
                Console.WriteLine("\n");
                Console.WriteLine("Eliga un tipo de paso");
                Console.WriteLine("1-> Vaso pequeno");
                Console.WriteLine("2-> Vaso mediano");
                Console.WriteLine("3-> Vaso grande");
                Console.WriteLine("0-> Salir");
                Console.WriteLine("Debe seleccionar una opcion");
                eleccion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Vaso vaso = null;
                switch (eleccion)
                {
                    case 0:
                        continuar = false;
                        break;
                    case 1:
                        vaso = maquinaDeCafe.getTipoVaso("pequeno");
                        break;
                    case 2:
                        vaso = maquinaDeCafe.getTipoVaso("mediano");
                        break;
                    case 3:
                        vaso = maquinaDeCafe.getTipoVaso("grande");
                        break;
                    default:
                        Console.WriteLine("Eleccion no valida");
                        Console.WriteLine("Presione Enter para continuar");
                        Console.ReadLine();
                        break;
                        
                }
                if(vaso != null) {
                Console.WriteLine("Digite el numero de vasos: ");
                cantidadvasos = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Digite la cantidad de azucar: ");
                cantidadazucar = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine(maquinaDeCafe.getVasoDeCafe(vaso, cantidadvasos, cantidadazucar));
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadLine();

                }
                Console.Clear();

            }
            while (continuar == true);





        }
    }
}
