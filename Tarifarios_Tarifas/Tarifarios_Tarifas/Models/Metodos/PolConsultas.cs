using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarifarios_Tarifas.Models.Atributos;

namespace Tarifarios_Tarifas.Models.Metodos
{
    internal class PolConsultas
    {
        private ConexionMySql conexionMySql;
        private List<POL> mPols;

        public PolConsultas()
        {
            conexionMySql = new ConexionMySql();
            mPols = new List<POL>();
        }

        public List<POL> getPol()
        {
            string QUERY = "SELECT * FROM tb_pol";
            MySqlDataReader mReader = null;
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(QUERY);
                mySqlCommand.Connection = conexionMySql.GetConnection();
                mReader = mySqlCommand.ExecuteReader();

                POL mPol = null;
                while (mReader.Read())
                {
                    mPol = new POL();
                    mPol.Id = mReader.GetInt32("id");
                    mPol.Pol = mReader.GetString("pol");
                    mPols.Add(mPol);
                }

                mReader.Close();
            }
            catch (Exception e)
            {

            }

            return mPols;
        }

        internal bool agregarPol(POL mPol)
        {
            string QUERY = "CALL agregarPOL(@pol);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@pol", mPol.Pol));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool eliminarPol(POL mPol)
        {
            string QUERY = "CALL eliminarPOL(@id);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mPol.Id));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool modificarPol(POL mPol)
        {
            string QUERY = "CALL modificarPOL(@id,@origen);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mPol.Id));
            mySqlCommand.Parameters.Add(new MySqlParameter("@origen", mPol.Pol));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }
    }
}
