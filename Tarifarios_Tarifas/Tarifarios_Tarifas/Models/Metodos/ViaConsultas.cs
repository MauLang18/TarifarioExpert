using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarifarios_Tarifas.Models.Atributos;

namespace Tarifarios_Tarifas.Models.Metodos
{
    internal class ViaConsultas
    {
        private ConexionMySql conexionMySql;
        private List<VIA> mVias;

        public ViaConsultas()
        {
            conexionMySql = new ConexionMySql();
            mVias = new List<VIA>();
        }

        public List<VIA> getVia()
        {
            string QUERY = "SELECT * FROM tb_via";
            MySqlDataReader mReader = null;
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(QUERY);
                mySqlCommand.Connection = conexionMySql.GetConnection();
                mReader = mySqlCommand.ExecuteReader();

                VIA mVia = null;
                while (mReader.Read())
                {
                    mVia = new VIA();
                    mVia.Id = mReader.GetInt32("id");
                    mVia.Via = mReader.GetString("via");
                    mVias.Add(mVia);
                }

                mReader.Close();
            }
            catch (Exception e)
            {

            }

            return mVias;
        }

        internal bool agregarVia(VIA mVia)
        {
            string QUERY = "CALL agregarVIA(@via);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@via", mVia.Via));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool eliminarVia(VIA mVia)
        {
            string QUERY = "CALL eliminarVIA(@id);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mVia.Id));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool modificarVia(VIA mVia)
        {
            string QUERY = "CALL modificarVIA(@id,@via);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mVia.Id));
            mySqlCommand.Parameters.Add(new MySqlParameter("@via", mVia.Via));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }
    }
}
