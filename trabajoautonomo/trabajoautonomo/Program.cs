using System;
using trabajoautonomo.ejerciciotercernivel;

namespace trabajoautonomo
{
    class Program
    // La salida por pantalla debe mostrar los datos del Cliente, los datos de la Gasolina y el valor final a cancelar
    //(Subtotal, IVA y Total).//
    //**//
    {
        public static Gasolina cant_gal;

        static void Main(string[] args)
        {
            Cliente tipog = new Cliente("extra" ,"o","super");
            if (cant_gal==tipog)
            {
              Console.WriteLine("la gasolina es extra", 1.50+0.12);
        }
                else 
                    Console.WriteLine("la gasolina es super",2.00+0.12);
            }
        }
    }



