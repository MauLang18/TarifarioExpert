using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarifarios_Tarifas.Models.Atributos;

namespace Tarifarios_Tarifas.Models.Metodos
{
    internal class PaisConsultas
    {
        private ConexionMySql conexionMySql;
        private List<PAIS> mPaiss;

        public PaisConsultas()
        {
            conexionMySql = new ConexionMySql();
            mPaiss = new List<PAIS>();
        }

        public List<PAIS> getPais()
        {
            string QUERY = "SELECT * FROM tb_pais;";
            MySqlDataReader mReader = null;
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(QUERY);
                mySqlCommand.Connection = conexionMySql.GetConnection();
                mReader = mySqlCommand.ExecuteReader();

                PAIS mPais = null;
                while (mReader.Read())
                {
                    mPais = new PAIS();
                    mPais.Id = mReader.GetInt32("id");
                    mPais.Pais = mReader.GetString("pais");
                    mPaiss.Add(mPais);
                }

                mReader.Close();
            }
            catch (Exception e)
            {

            }

            return mPaiss;
        }

        internal bool agregarDestino(PAIS mDestino)
        {
            string QUERY = "CALL agregarPAIS(@destino);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@destino", mDestino.Pais));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool eliminarDestino(PAIS mDestino)
        {
            string QUERY = "CALL elimianrPAIS(@id);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mDestino.Id));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool modificarDestino(PAIS mDestino)
        {
            string QUERY = "CALL modificarPAIS(@id,@destino);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mDestino.Id));
            mySqlCommand.Parameters.Add(new MySqlParameter("@destino", mDestino.Pais));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }
    }
}
