using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;

namespace TRCAplicacion.Models
{
    internal class ConexionModel
    {
        private static NpgsqlConnection conexion = null;
        private static NpgsqlCommand comando = null;
        private static NpgsqlDataAdapter da = null;
        private static System.Data.DataTable dt = null;
        private static string cadenaConexion = String.Empty;

        // Varialbles privadas para la cadena de conexion
        private static string servidor = "tienda-cris.postgres.database.azure.com";
        private string bd = "Tienda_Cris";
        private string usuario = "Axel1";
        private string contrasena = "123";
        private string puerto = "5432";

        public string Servidor { get => servidor; set => servidor = value; }
        public string Bd { get => bd; set => bd = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Puerto { get => puerto; set => puerto = value; }

        public ConexionModel()
        {
            cadenaConexion =
            "server = " + Servidor +
            "; port = " + Puerto +
            "; user id = " + Usuario +
            "; password = " + Contrasena +
            "; database = " + Bd +
            "; SSLMode = Prefer";
        }

        // Insertar, Actualzar, Eliminar
        public void ejecutarFuncion(NpgsqlParameter[] parametros, string nombreFuncion)
        {
            try
            {
                // Se instancia el objeto conexion a la cadena de conexion
                conexion = new NpgsqlConnection(cadenaConexion);
                // Se instancia el objeto comando
                comando = new NpgsqlCommand();
                // Se asigna la conexion
                comando.Connection = conexion;
                // Se abre la conexion
                conexion.Open();
                // Se indica que es una funcion
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Se indica el nombre de la funcion
                comando.CommandText = nombreFuncion;
                // Se agregan los aprametros
                comando.Parameters.AddRange(parametros);
                // Se ejecuta el comando
                comando.ExecuteNonQuery();
            }

            catch (Exception excepcion)
            {
                System.Windows.Forms.MessageBox.Show(excepcion.Message);
                // throw new Exception(excepcion.Message);
            }

            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
        }

        //public System.Data.DataTable ratornarTabla(NpgsqlParameter[] parametros, string consulta)
        public System.Data.DataTable ratornarTabla(string nombreFuncion)
        {
            dt = null;

            try
            {
                dt = new System.Data.DataTable();
                // Se instancia el objeto conexion a la cadena de conexion
                conexion = new NpgsqlConnection(cadenaConexion);
                // Se instancia el objeto comando
                comando = new NpgsqlCommand();
                // Se asigna la conexion
                comando.Connection = conexion;
                // Se abre la conexion
                conexion.Open();
                // Se indica que es una funcion
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Se indica el nombre de la funcion
                comando.CommandText = nombreFuncion;
                // Se instancia el adaptador con el comando
                da = new NpgsqlDataAdapter(comando);
                // Se llena el dataset con el adaprtador de datos
                da.Fill(dt);
            }

            catch (Exception excepcion)
            {
                System.Windows.Forms.MessageBox.Show(excepcion.Message);
                //throw new Exception(excepcion.Message);
            }

            finally
            {
                conexion.Dispose();
                comando.Dispose();
                da.Dispose();
            }

            return dt;
        }


        public System.Data.DataTable ratornarTabla(NpgsqlParameter[] parametros, string nombreFuncion)
        {
            dt = null;

            try
            {
                dt = new System.Data.DataTable();
                // Se instancia el objeto conexion a la cadena de conexion
                conexion = new NpgsqlConnection(cadenaConexion);
                // Se instancia el objeto comando
                comando = new NpgsqlCommand();
                // Se asigna la conexion
                comando.Connection = conexion;
                // Se abre la conexion
                conexion.Open();
                // Se indica que es una funcion
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Se indica el nombre de la funcion
                comando.CommandText = nombreFuncion;
                // Se agregan los parametros
                comando.Parameters.AddRange(parametros);
                // Se instancia el adaptador con el comando
                da = new NpgsqlDataAdapter(comando);
                // Se llena el dataset con el adaprtador de datos
                da.Fill(dt);
            }

            catch (Exception excepcion)
            {
                System.Windows.Forms.MessageBox.Show(excepcion.Message);
                //throw new Exception(excepcion.Message);
            }

            finally
            {
                conexion.Dispose();
                comando.Dispose();
                da.Dispose();
            }

            return dt;
        }


    }
}
