using System;
using trabajoautonomo.ejerciciotercernivel;
using System.Collections.Generic;
using System.Text;


namespace trabajoautonomo
{
    //La aplicación debe solicitar los datos del Cliente, que son Apellidos, Nombres, Número de Cédula de
    //identidad y Dirección
    public class Cliente
    {

        public Cliente(string apellidos, string nombres, string cI, string direccion) 
        {
            Apellidos = apellidos;
            Nombres = nombres;
            CI = cI;
            Direccion = direccion;          
        }

        public Cliente(string v1, string v2, string v3)
        {
        }

        private string Apellidos;

        public string apellidos
        {
            get { return Apellidos; }
            set { Apellidos = value; }
        }
        private string Nombres;

        public string nombres
        {
            get { return Nombres; }
            set { Nombres = value; }
        }
        private string CI;

        public string cedula
        {
            get { return CI; }
            set { CI = value; }
        }
        private string  Direccion;
        public string direccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }

    }
}

