using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarifarios_Tarifas.Models.Atributos;

namespace Tarifarios_Tarifas.Models.Metodos
{
    internal class OtrosServiciosConsultas
    {
        private ConexionMySql conexionMySql;
        private List<OtroServicios> mConsulta;

        public OtrosServiciosConsultas()
        {
            conexionMySql = new ConexionMySql();
            mConsulta = new List<OtroServicios>();
        }

        public List<OtroServicios> getOtrosServicios(string filtro)
        {
            string QUERY = "SELECT * FROM tb_otros_servicios ";
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

                OtroServicios mDatos = null;
                while (mReader.Read())
                {
                    mDatos = new OtroServicios();
                    mDatos.Id = mReader.GetInt32("id");
                    mDatos.Proveedor = mReader.GetString("proveedor");
                    mDatos.Producto = mReader.GetString("producto");
                    mDatos.Costo = mReader.GetFloat("costo");
                    mConsulta.Add(mDatos);
                }

                mReader.Close();
            }
            catch (Exception e)
            {

            }

            return mConsulta;
        }

        public List<OtroServicios> getOtrosServicios1()
        {
            string QUERY = "SELECT * FROM tb_otros_servicios;";
            MySqlDataReader mReader = null;
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(QUERY);
                mySqlCommand.Connection = conexionMySql.GetConnection();
                mReader = mySqlCommand.ExecuteReader();

                OtroServicios mDatos = null;
                while (mReader.Read())
                {
                    mDatos = new OtroServicios();
                    mDatos.Id = mReader.GetInt32("id");
                    mDatos.Proveedor = mReader.GetString("proveedor");
                    mDatos.Producto = mReader.GetString("producto");
                    mDatos.Costo = mReader.GetFloat("costo");
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

        internal bool agregarOtrosServicios(OtroServicios mOtrosServicios)
        {
            string QUERY = "CALL agregarOS(@proveedor,@producto,@costo,@rodman,@manzanillo,@cristobal,@balboa);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@proveedor", mOtrosServicios.Proveedor));
            mySqlCommand.Parameters.Add(new MySqlParameter("@producto", mOtrosServicios.Producto));
            mySqlCommand.Parameters.Add(new MySqlParameter("@costo", mOtrosServicios.Costo));
            mySqlCommand.Parameters.Add(new MySqlParameter("@rodman", mOtrosServicios.rodman));
            mySqlCommand.Parameters.Add(new MySqlParameter("@manzanillo", mOtrosServicios.manzanillo));
            mySqlCommand.Parameters.Add(new MySqlParameter("@cristobal", mOtrosServicios.cristobal));
            mySqlCommand.Parameters.Add(new MySqlParameter("@balboa", mOtrosServicios.balboa));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool eliminarOtrosServicios(OtroServicios mOtrosServicios)
        {
            string QUERY = "CALL eliminarOS(@id);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mOtrosServicios.Id));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool modificarOtrosServicios(OtroServicios mOtrosServicios)
        {
            string QUERY = "CALL modificarOS(@id,@proveedor,@producto,@costo,@rodman,@manzanillo,@cristobal,@balboa);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mOtrosServicios.Id));
            mySqlCommand.Parameters.Add(new MySqlParameter("@proveedor", mOtrosServicios.Proveedor));
            mySqlCommand.Parameters.Add(new MySqlParameter("@producto", mOtrosServicios.Producto));
            mySqlCommand.Parameters.Add(new MySqlParameter("@costo", mOtrosServicios.Costo));
            mySqlCommand.Parameters.Add(new MySqlParameter("@rodman", mOtrosServicios.rodman));
            mySqlCommand.Parameters.Add(new MySqlParameter("@manzanillo", mOtrosServicios.manzanillo));
            mySqlCommand.Parameters.Add(new MySqlParameter("@cristobal", mOtrosServicios.cristobal));
            mySqlCommand.Parameters.Add(new MySqlParameter("@balboa", mOtrosServicios.balboa));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }
    }
}
