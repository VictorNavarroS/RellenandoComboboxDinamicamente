using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace CapaPersistencia
{
    public class ConexionBD
    {
        private string cadena = @"Data Source=DCAMACHO-PC\SQLEXPRESS;Initial Catalog=BDEquipoFutbol;Integrated Security=True";

        private SqlConnection conexion;
        private SqlCommand sqlComando;
        private SqlDataAdapter sqlAdaptador;

        public ConexionBD()
        {
            conexion = new SqlConnection(cadena);
        }

        public void probarConexion(out string estado)
        {
            try
            {
                conexion.Open();
                conexion.Close();
                estado = "Conectado";
            }
            catch (Exception ex)
            {
                estado = "Fallo en la conexión : " + ex.Message;
            }
        }

        public bool manipulaData(string manipulaSql, out string error)
        {
            try
            {
                error = "";
                DataTable miTablaDatos = new DataTable();

                sqlComando = new SqlCommand(manipulaSql, conexion);

                conexion.Open();

                int aux = sqlComando.ExecuteNonQuery();

                conexion.Close();

                if (aux > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return false;
            }
            
        }

        public DataTable selecData(string consultaSql, out string error)
        {
            try
            {
                error = "";
                DataTable miTablaDatos = new DataTable();

                sqlAdaptador = new SqlDataAdapter(consultaSql, conexion);

                conexion.Open();

                sqlAdaptador.Fill(miTablaDatos);

                conexion.Close();

                return miTablaDatos;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                return null;
            }
        }

        public bool ejecutaProcedimientoAlmacenadoManipulacion(SqlParameter[] parametros, string nombreSP)
        {
            try
            {
                DataTable miTablaDatos = new DataTable();

                sqlAdaptador = new SqlDataAdapter(nombreSP, conexion);
                sqlAdaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                foreach (SqlParameter sqlP in parametros)
	            {
                    sqlAdaptador.SelectCommand.Parameters.Add(sqlP);
	            }

                conexion.Open();

                int aux = sqlComando.ExecuteNonQuery();

                conexion.Close();

                if (aux > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable ejecutaProcedimientoAlmacenadoSeleccion(SqlParameter[] parametros, string nombreSP)
        {
            try
            {
                DataTable miTablaDatos = new DataTable();

                sqlAdaptador = new SqlDataAdapter(nombreSP, conexion);
                sqlAdaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                foreach (SqlParameter sqlP in parametros)
                {
                    sqlAdaptador.SelectCommand.Parameters.Add(sqlP);
                }

                conexion.Open();

                 sqlAdaptador.Fill(miTablaDatos);

                conexion.Close();

                return miTablaDatos;
            }
            catch (Exception)
            {
                return null;
            }
    
        }
        }
    }

