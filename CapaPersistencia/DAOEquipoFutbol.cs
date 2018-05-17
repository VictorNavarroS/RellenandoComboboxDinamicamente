using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace CapaPersistencia
{
    public class DAOEquipoFutbol
    {
        public List<EquipoFutbol> listarTodosLosEquipos(out string error)
        {
            try
            {
                error = "";

                ConexionBD conecta = new ConexionBD();
                string query = "SELECT * FROM EQUIPO";
                DataTable miTabla = conecta.selecData(query, out error);

                if (miTabla != null)
                {
                    List<EquipoFutbol> listaDeEquipos = new List<EquipoFutbol>();

                    for (int i = 0; i < miTabla.Rows.Count; i++)
                    {
                        EquipoFutbol equipo = new EquipoFutbol();

                        equipo.Id = int.Parse(miTabla.Rows[i]["id"].ToString());
                        equipo.Nombre = miTabla.Rows[i]["nombre"].ToString();
                        equipo.Pais = miTabla.Rows[i]["pais"].ToString();
                        equipo.CantCopas = int.Parse(miTabla.Rows[i]["cantidad_copas"].ToString());

                        listaDeEquipos.Add(equipo);
                    }

                    return listaDeEquipos;
                }

                return null;

            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return null;
            }
        }
    }
}
