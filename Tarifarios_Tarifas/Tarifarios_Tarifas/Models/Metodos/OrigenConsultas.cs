using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarifarios_Tarifas.Models.Atributos;

namespace Tarifarios_Tarifas.Models.Metodos
{
    internal class OrigenConsultas
    {
        private ConexionMySql conexionMySql;
        private List<ORIGEN> mOrigens;

        public OrigenConsultas()
        {
            conexionMySql = new ConexionMySql();
            mOrigens = new List<ORIGEN>();
        }

        public List<ORIGEN> getOrigen()
        {
            string QUERY = "SELECT * FROM tb_origen;";
            MySqlDataReader mReader = null;
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(QUERY);
                mySqlCommand.Connection = conexionMySql.GetConnection();
                mReader = mySqlCommand.ExecuteReader();

                ORIGEN mOrigen = null;
                while (mReader.Read())
                {
                    mOrigen = new ORIGEN();
                    mOrigen.Id = mReader.GetInt32("id");
                    mOrigen.Origen = mReader.GetString("origen");
                    mOrigens.Add(mOrigen);
                }

                mReader.Close();
            }
            catch (Exception e)
            {

            }

            return mOrigens;
        }

        internal bool agregarOrigen(ORIGEN mOrigen)
        {
            string QUERY = "CALL agregarORIGEN(@origen);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@origen", mOrigen.Origen));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool eliminarOrigen(ORIGEN mOrigen)
        {
            string QUERY = "CALL eliminarORIGEN(@id);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mOrigen.Id));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool modificarOrigen(ORIGEN mOrigen)
        {
            string QUERY = "CALL modificarORIGEN(@id,@origen);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mOrigen.Id));
            mySqlCommand.Parameters.Add(new MySqlParameter("@origen", mOrigen.Origen));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }
    }
}
