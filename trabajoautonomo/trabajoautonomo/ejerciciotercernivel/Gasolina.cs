using System;
using System.Collections.Generic;
using System.Text;

namespace trabajoautonomo.ejerciciotercernivel
{
    //La aplicación debe solicitar los datos de la Gasolina, que son Tipo, Cantidad de Galones y Precio de Venta
    public class Gasolina : Cliente
    {

        public Gasolina(string tipo, string cant_galones, string precioVenta, string apellidos,
            string nombres, string cI, string direccion) : base(apellidos, nombres, cI, direccion)
        {
            Tipo = tipo;
            Cant_galones = cant_galones;
            PrecioVenta = precioVenta;

        }

        private string Tipo;
        public string tipo
        {

            get { return Tipo; }
            set { Tipo = value; }
        }
       
        private string Cant_galones;
        public string cant_galones
        {
            get { return Cant_galones; }
            set { Cant_galones = value; }
        }
        private string PrecioVenta;
        private object precioVenta1;
        private string v1;
        private string v2;
        private string v3;

        public string precioventa
        {
            get { return PrecioVenta; }
            set { PrecioVenta = value; }
        }
      
        }
    }
        