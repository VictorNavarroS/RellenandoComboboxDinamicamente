using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class EquipoFutbol
    {
        // Atributos
        private int id;
        private string nombre;
        private string pais;
        private int cantCopas;
        //Constructor
        public EquipoFutbol()
        {

        }
        //Accesadores: Interfaz publica

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public int CantCopas
        {
            get { return cantCopas; }
            set { cantCopas = value; }
        }
    }
}
