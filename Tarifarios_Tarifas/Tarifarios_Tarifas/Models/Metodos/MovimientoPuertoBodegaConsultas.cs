using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarifarios_Tarifas.Models.Atributos;

namespace Tarifarios_Tarifas.Models.Metodos
{
    internal class MovimientoPuertoBodegaConsultas
    {
        private ConexionMySql conexionMySql;
        private List<MovimientoPuertoBodega> mConsulta;

        public MovimientoPuertoBodegaConsultas()
        {
            conexionMySql = new ConexionMySql();
            mConsulta = new List<MovimientoPuertoBodega>();
        }

        public List<MovimientoPuertoBodega> getMovimientoPuertoBodega(string filtro)
        {
            string QUERY = "SELECT * FROM tb_movimiento_puerto_bodega ";
            MySqlDataReader mReader = null;
            try
            {
                if(filtro != null || filtro != "")
                {
                    switch (filtro)
                    {
                        case "RODMAN":
                            QUERY += " WHERE rodman = 1;";
                            break;
                        case "MANZANILLO":
                            QUERY += " WHERE manzanillo = 1;";
                            break;
                        case "CRISTOBAL":
                            QUERY += " WHERE cristobal = 1;";
                            break;
                        case "BALBOA":
                            QUERY += " WHERE balboa = 1;";
                            break;
                    }
                }
                else
                {
                    QUERY += " WHERE id = 1";
                }

                MySqlCommand mySqlCommand = new MySqlCommand(QUERY);
                mySqlCommand.Connection = conexionMySql.GetConnection();
                mReader = mySqlCommand.ExecuteReader();

                MovimientoPuertoBodega mDatos = null;
                while (mReader.Read())
                {
                    mDatos = new MovimientoPuertoBodega();
                    mDatos.Id = mReader.GetInt32("id");
                    mDatos.Proveedor = mReader.GetString("proveedor");
                    mDatos.Transporte_puerto = mReader.GetFloat("transporte_puerto");
                    mConsulta.Add(mDatos);
                }

                mReader.Close();
            }
            catch (Exception e)
            {

            }

            return mConsulta;
        }

        public List<MovimientoPuertoBodega> getMovimientoPuertoBodega1()
        {
            string QUERY = "SELECT * FROM tb_movimiento_puerto_bodega;";
            MySqlDataReader mReader = null;
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(QUERY);
                mySqlCommand.Connection = conexionMySql.GetConnection();
                mReader = mySqlCommand.ExecuteReader();

                MovimientoPuertoBodega mDatos = null;
                while (mReader.Read())
                {
                    mDatos = new MovimientoPuertoBodega();
                    mDatos.Id = mReader.GetInt32("id");
                    mDatos.Proveedor = mReader.GetString("proveedor");
                    mDatos.Transporte_puerto = mReader.GetFloat("transporte_puerto");
                    mDatos.rodman = mReader.GetInt32("rodman");
                    mDatos.manzanillo = mReader.GetInt32("manzanillo");
                    mDatos.cristobal = mReader.GetInt32("cristobal");
                    mDatos.balboa = mReader.GetInt32("balboa");
                    mConsulta.Add(mDatos);
                }

                mReader.Close();
            }
            catch (Exception e)
            {

            }

            return mConsulta;
        }

        internal bool agregarMovimientoPuertoBodega(MovimientoPuertoBodega mMovimientoPuertoBodega)
        {
            string QUERY = "CALL agregarMPB(@proveedor,@movimiento,@rodman,@manzanillo,@cristobal,@balboa);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@proveedor", mMovimientoPuertoBodega.Proveedor));
            mySqlCommand.Parameters.Add(new MySqlParameter("@movimiento", mMovimientoPuertoBodega.Transporte_puerto));
            mySqlCommand.Parameters.Add(new MySqlParameter("@rodman", mMovimientoPuertoBodega.rodman));
            mySqlCommand.Parameters.Add(new MySqlParameter("@manzanillo", mMovimientoPuertoBodega.manzanillo));
            mySqlCommand.Parameters.Add(new MySqlParameter("@cristobal", mMovimientoPuertoBodega.cristobal));
            mySqlCommand.Parameters.Add(new MySqlParameter("@balboa", mMovimientoPuertoBodega.balboa));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool eliminarMovimientoPuertoBodega(MovimientoPuertoBodega mMovimientoPuertoBodega)
        {
            string QUERY = "CALL eliminarMPB(@id);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mMovimientoPuertoBodega.Id));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool modificarMovimientoPuertoBodega(MovimientoPuertoBodega mMovimientoPuertoBodega)
        {
            string QUERY = "CALL modificarMPB(@id,@proveedor,@movimiento,@rodman,@manzanillo,@cristobal,@balboa);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mMovimientoPuertoBodega.Id));
            mySqlCommand.Parameters.Add(new MySqlParameter("@proveedor", mMovimientoPuertoBodega.Proveedor));
            mySqlCommand.Parameters.Add(new MySqlParameter("@movimiento", mMovimientoPuertoBodega.Transporte_puerto));
            mySqlCommand.Parameters.Add(new MySqlParameter("@rodman", mMovimientoPuertoBodega.rodman));
            mySqlCommand.Parameters.Add(new MySqlParameter("@manzanillo", mMovimientoPuertoBodega.manzanillo));
            mySqlCommand.Parameters.Add(new MySqlParameter("@cristobal", mMovimientoPuertoBodega.cristobal));
            mySqlCommand.Parameters.Add(new MySqlParameter("@balboa", mMovimientoPuertoBodega.balboa));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }
    }
}
