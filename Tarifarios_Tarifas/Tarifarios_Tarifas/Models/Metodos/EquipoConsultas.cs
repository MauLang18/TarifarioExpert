using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarifarios_Tarifas.Models.Atributos;

namespace Tarifarios_Tarifas.Models.Metodos
{
    internal class EquipoConsultas
    {
        private ConexionMySql conexionMySql;
        private List<Equipo> mEquipos;

        public EquipoConsultas()
        {
            conexionMySql = new ConexionMySql();
            mEquipos = new List<Equipo>();
        }

        public List<Equipo> getEquipo()
        {
            string QUERY = "SELECT * FROM tb_equipo;";
            MySqlDataReader mReader = null;
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(QUERY);
                mySqlCommand.Connection = conexionMySql.GetConnection();
                mReader = mySqlCommand.ExecuteReader();

                Equipo mEquipo = null;
                while (mReader.Read())
                {
                    mEquipo = new Equipo();
                    mEquipo.Id = mReader.GetInt32("id");
                    mEquipo.Equipos = mReader.GetString("equipo");
                    mEquipos.Add(mEquipo);
                }

                mReader.Close();
            }
            catch (Exception e)
            {

            }

            return mEquipos;
        }

        internal bool agregarEquipo(Equipo mEquipo)
        {
            string QUERY = "CALL agregarEQUIPO(@equipo);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@equipo", mEquipo.Equipos));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool eliminarEquipo(Equipo mEquipo)
        {
            string QUERY = "CALL eliminarEQUIPO(@id);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mEquipo.Id));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool modificarEquipo(Equipo mEquipo)
        {
            string QUERY = "CALL modificarEQUIPO(@id,@equipo);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mEquipo.Id));
            mySqlCommand.Parameters.Add(new MySqlParameter("@equipo", mEquipo.Equipos));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }
    }
}
