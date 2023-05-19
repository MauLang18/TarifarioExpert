using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarifarios_Tarifas.Models.Atributos;

namespace Tarifarios_Tarifas.Models.Metodos
{
    internal class GastosPortariosLCLConsultas
    {
        private ConexionMySql conexionMySql;
        private List<GastosPortuariosLCL> mConsulta;

        public GastosPortariosLCLConsultas()
        {
            conexionMySql = new ConexionMySql();
            mConsulta = new List<GastosPortuariosLCL>();
        }

        public List<GastosPortuariosLCL> getGastosPortuarios(string filtro)
        {
            string QUERY = "SELECT * FROM tb_cargos_en_destino_lcl ";
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

                GastosPortuariosLCL mDatos = null;
                while (mReader.Read())
                {
                    mDatos = new GastosPortuariosLCL();
                    mDatos.Id = mReader.GetInt32("id");
                    mDatos.Proveedor = mReader.GetString("proveedor");
                    mDatos.Cargos = mReader.GetFloat("cargos");
                    mConsulta.Add(mDatos);
                }

                mReader.Close();
            }
            catch (Exception e)
            {

            }

            return mConsulta;
        }

        public List<GastosPortuariosLCL> getGastosPortuarios1()
        {
            string QUERY = "SELECT * FROM tb_cargos_en_destino_lcl;";
            MySqlDataReader mReader = null;
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(QUERY);
                mySqlCommand.Connection = conexionMySql.GetConnection();
                mReader = mySqlCommand.ExecuteReader();

                GastosPortuariosLCL mDatos = null;
                while (mReader.Read())
                {
                    mDatos = new GastosPortuariosLCL();
                    mDatos.Id = mReader.GetInt32("id");
                    mDatos.Proveedor = mReader.GetString("proveedor");
                    mDatos.Cargos = mReader.GetFloat("cargos");
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

        internal bool agregarGastosPortuarios(GastosPortuariosLCL mGastosPortuarios)
        {
            string QUERY = "CALL agregarCeD_LCL(@proveedor,@gastos_portuarios,@rodman,@manzanillo,@cristobal,@balboa);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@proveedor", mGastosPortuarios.Proveedor));
            mySqlCommand.Parameters.Add(new MySqlParameter("@gastos_portuarios", mGastosPortuarios.Cargos));
            mySqlCommand.Parameters.Add(new MySqlParameter("@rodman", mGastosPortuarios.rodman));
            mySqlCommand.Parameters.Add(new MySqlParameter("@manzanillo", mGastosPortuarios.manzanillo));
            mySqlCommand.Parameters.Add(new MySqlParameter("@cristobal", mGastosPortuarios.cristobal));
            mySqlCommand.Parameters.Add(new MySqlParameter("@balboa", mGastosPortuarios.balboa));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool eliminarGastosPortuarios(GastosPortuariosLCL mGastosPortuarios)
        {
            string QUERY = "CALL eliminarCeD_LCL(@id);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mGastosPortuarios.Id));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool modificarGastosPortuarios(GastosPortuariosLCL mGastosPortuarios)
        {
            string QUERY = "CALL modificarCeD_LCL(@id,@proveedor,@gastos_portuarios,@rodman,@manzanillo,@cristobal,@balboa);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mGastosPortuarios.Id));
            mySqlCommand.Parameters.Add(new MySqlParameter("@proveedor", mGastosPortuarios.Proveedor));
            mySqlCommand.Parameters.Add(new MySqlParameter("@gastos_portuarios", mGastosPortuarios.Cargos));
            mySqlCommand.Parameters.Add(new MySqlParameter("@rodman", mGastosPortuarios.rodman));
            mySqlCommand.Parameters.Add(new MySqlParameter("@manzanillo", mGastosPortuarios.manzanillo));
            mySqlCommand.Parameters.Add(new MySqlParameter("@cristobal", mGastosPortuarios.cristobal));
            mySqlCommand.Parameters.Add(new MySqlParameter("@balboa", mGastosPortuarios.balboa));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }
    }
}
