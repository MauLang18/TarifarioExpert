using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarifarios_Tarifas.Models.Atributos;

namespace Tarifarios_Tarifas.Models.Metodos
{
    internal class PodConsultas
    {
        private ConexionMySql conexionMySql;
        private List<POD> mPods;

        public PodConsultas()
        {
            conexionMySql = new ConexionMySql();
            mPods = new List<POD>();
        }

        public List<POD> getPod()
        {
            string QUERY = "SELECT * FROM tb_poe";
            MySqlDataReader mReader = null;
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(QUERY);
                mySqlCommand.Connection = conexionMySql.GetConnection();
                mReader = mySqlCommand.ExecuteReader();

                POD mPod = null;
                while (mReader.Read())
                {
                    mPod = new POD();
                    mPod.Id = mReader.GetInt32("id");
                    mPod.Pod = mReader.GetString("poe");
                    mPods.Add(mPod);
                }

                mReader.Close();
            }
            catch (Exception e)
            {

            }

            return mPods;
        }

        internal bool agregarPod(POD mPod)
        {
            string QUERY = "CALL agregarPOE(@pod);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@pod", mPod.Pod));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool eliminarPod(POD mPod)
        {
            string QUERY = "CALL eliminarPOE(@id);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mPod.Id));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool modificarPod(POD mPod)
        {
            string QUERY = "CALL modificarPOE(@id,@pod);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mPod.Id));
            mySqlCommand.Parameters.Add(new MySqlParameter("@pod", mPod.Pod));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }
    }
}
