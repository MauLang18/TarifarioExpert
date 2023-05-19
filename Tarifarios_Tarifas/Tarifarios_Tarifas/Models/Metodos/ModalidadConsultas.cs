using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarifarios_Tarifas.Models.Atributos;

namespace Tarifarios_Tarifas.Models.Metodos
{
    internal class ModalidadConsultas
    {
        private ConexionMySql conexionMySql;
        private List<Modalidad> mModalidads;

        public ModalidadConsultas()
        {
            conexionMySql = new ConexionMySql();
            mModalidads = new List<Modalidad>();
        }

        public List<Modalidad> getModalidad()
        {
            string QUERY = "SELECT * FROM tb_modalidad;";
            MySqlDataReader mReader = null;
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(QUERY);
                mySqlCommand.Connection = conexionMySql.GetConnection();
                mReader = mySqlCommand.ExecuteReader();

                Modalidad mModalidad = null;
                while (mReader.Read())
                {
                    mModalidad = new Modalidad();
                    mModalidad.Id = mReader.GetInt32("id");
                    mModalidad.Modalidades = mReader.GetString("modalidad");
                    mModalidads.Add(mModalidad);
                }

                mReader.Close();
            }
            catch (Exception e)
            {

            }

            return mModalidads;
        }

        internal bool agregarModalidad(Modalidad mModalidad)
        {
            string QUERY = "CALL agregarMODALIDAD(@modalidad);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@modalidad", mModalidad.Modalidades));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool eliminarModalidad(Modalidad mModalidad)
        {
            string QUERY = "CALL eliminarMODALIDAD(@id);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mModalidad.Id));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool modificarModalidad(Modalidad mModalidad)
        {
            string QUERY = "CALL modificarMODALIDAD(@id,@modalidad);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mModalidad.Id));
            mySqlCommand.Parameters.Add(new MySqlParameter("@modalidad", mModalidad.Modalidades));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }
    }
}
