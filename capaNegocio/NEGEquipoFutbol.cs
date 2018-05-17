using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using CapaPersistencia;

namespace capaNegocio
{
    public class NEGEquipoFutbol
    {
        public List<EquipoFutbol> listarLosEquiposDeFutbol(out string error)
        {
            error = "";
            try
            {
                DAOEquipoFutbol accEquipo = new DAOEquipoFutbol();
                return accEquipo.listarTodosLosEquipos(out error);
            }
            catch (Exception ex)
            {
                error += "/n" + ex.Message;
                return null;
            }
        }
    }
}
