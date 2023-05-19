using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarifarios_Tarifas.Models.Atributos;

namespace Tarifarios_Tarifas.Models.Metodos
{
    internal class OtrasCategoriasLCLConsultas
    {
        private ConexionMySql conexionMySql;
        private List<OtrasCategoriasLCL> mConsulta;

        public OtrasCategoriasLCLConsultas()
        {
            conexionMySql = new ConexionMySql();
            mConsulta = new List<OtrasCategoriasLCL>();
        }

        public List<OtrasCategoriasLCL> getOtrasCategorias(string filtro)
        {
            string QUERY = "SELECT * FROM tb_otras_categorias_lcl ";
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

                OtrasCategoriasLCL mDatos = null;
                while (mReader.Read())
                {
                    mDatos = new OtrasCategoriasLCL();
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

        public List<OtrasCategoriasLCL> getOtrasCategorias1()
        {
            string QUERY = "SELECT * FROM tb_otras_categorias_lcl;";
            MySqlDataReader mReader = null;
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(QUERY);
                mySqlCommand.Connection = conexionMySql.GetConnection();
                mReader = mySqlCommand.ExecuteReader();

                OtrasCategoriasLCL mDatos = null;
                while (mReader.Read())
                {
                    mDatos = new OtrasCategoriasLCL();
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

        internal bool agregarOtrasCategorias(OtrasCategoriasLCL mOtrasCategorias)
        {
            string QUERY = "CALL agregarOC_LCL(@proveedor,@producto,@costo,@rodman,@manzanillo,@cristobal,@balboa);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@proveedor", mOtrasCategorias.Proveedor));
            mySqlCommand.Parameters.Add(new MySqlParameter("@producto", mOtrasCategorias.Producto));
            mySqlCommand.Parameters.Add(new MySqlParameter("@costo", mOtrasCategorias.Costo));
            mySqlCommand.Parameters.Add(new MySqlParameter("@rodman", mOtrasCategorias.rodman));
            mySqlCommand.Parameters.Add(new MySqlParameter("@manzanillo", mOtrasCategorias.manzanillo));
            mySqlCommand.Parameters.Add(new MySqlParameter("@cristobal", mOtrasCategorias.cristobal));
            mySqlCommand.Parameters.Add(new MySqlParameter("@balboa", mOtrasCategorias.balboa));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool eliminarOtrasCategorias(OtrasCategoriasLCL mOtrasCategorias)
        {
            string QUERY = "CALL eliminarOC_LCL(@id);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mOtrasCategorias.Id));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool modificarOtrasCategorias(OtrasCategoriasLCL mOtrasCategorias)
        {
            string QUERY = "CALL modificarOC_LCL(@id,@proveedor,@producto,@costo,@rodman,@manzanillo,@cristobal,@balboa);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mOtrasCategorias.Id));
            mySqlCommand.Parameters.Add(new MySqlParameter("@proveedor", mOtrasCategorias.Proveedor));
            mySqlCommand.Parameters.Add(new MySqlParameter("@producto", mOtrasCategorias.Producto));
            mySqlCommand.Parameters.Add(new MySqlParameter("@costo", mOtrasCategorias.Costo));
            mySqlCommand.Parameters.Add(new MySqlParameter("@rodman", mOtrasCategorias.rodman));
            mySqlCommand.Parameters.Add(new MySqlParameter("@manzanillo", mOtrasCategorias.manzanillo));
            mySqlCommand.Parameters.Add(new MySqlParameter("@cristobal", mOtrasCategorias.cristobal));
            mySqlCommand.Parameters.Add(new MySqlParameter("@balboa", mOtrasCategorias.balboa));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }
    }
}
