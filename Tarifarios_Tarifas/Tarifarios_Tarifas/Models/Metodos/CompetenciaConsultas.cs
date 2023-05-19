using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarifarios_Tarifas.Models.Atributos;

namespace Tarifarios_Tarifas.Models.Metodos
{
    internal class CompetenciaConsultas
    {
        private ConexionMySql conexionMySql;
        private List<COMPETENCIA> mConsulta;

        public CompetenciaConsultas()
        {
            conexionMySql = new ConexionMySql();
            mConsulta = new List<COMPETENCIA>();
        }

        public List<COMPETENCIA> getCompetencia(string filtro, string filtro2)
        {
            string QUERY = "SELECT t.id AS id,t.nombre AS nombre,t.ruta AS ruta,t.flete AS flete,t.cargos_destino AS cargos_destino,t.otros_costos AS otros_costos,t.iva AS iva,m.modalidad AS modalidad,e.equipo AS equipo,t.desde AS desde,t.hasta AS hasta,t.total AS total FROM tb_competencia AS t INNER JOIN tb_modalidad AS m ON t.id_modalidad=m.id INNER JOIN tb_equipo AS e ON t.id_equipo=e.id ";
            MySqlDataReader mReader = null;
            try
            {
                if (filtro != "" && filtro2 != "")
                {
                    QUERY += " WHERE desde >= '" + filtro + "' AND hasta <= '" + filtro2 + "';";
                }
                else if (filtro != "")
                {
                    QUERY += " WHERE t.id LIKE '%" + filtro + "%' OR t.ruta LIKE '%" + filtro + "%' OR t.flete LIKE '%" + filtro + "%' OR t.cargos_destinos LIKE '%" + filtro + "%' OR t.otros_costos LIKE '%" + filtro + "%' OR t.iva LIKE '%" + filtro + "%' OR m.modalidad LIKE '%" + filtro + "%' OR e.equipo LIKE '%" + filtro + "%' OR t.desde LIKE '%" + filtro + "%' OR t.hasta LIKE '%" + filtro + "%' OR t.total LIKE '%" + filtro + "%';";
                }
                

                MySqlCommand mySqlCommand = new MySqlCommand(QUERY);
                mySqlCommand.Connection = conexionMySql.GetConnection();
                mReader = mySqlCommand.ExecuteReader();

                COMPETENCIA mDatos = null;
                while (mReader.Read())
                {
                    mDatos = new COMPETENCIA();
                    mDatos.Id = mReader.GetInt32("id");
                    mDatos.Ruta = mReader.GetString("ruta");
                    mDatos.Nombre = mReader.GetString("nombre");

                    mDatos.Flete = mReader.GetFloat("flete");
                    mDatos.Cargos_Destino = mReader.GetFloat("cargos_destino");
                    mDatos.Otros_Cargos = mReader.GetFloat("otros_costos");
                    mDatos.IVA = mReader.GetFloat("iva");

                    mDatos.Modalidad = mReader.GetString("modalidad");
                    mDatos.Equipo = mReader.GetString("equipo");
                    mDatos.Desde = mReader.GetString("desde");
                    mDatos.Hasta = mReader.GetString("hasta");
                    mDatos.Total = mReader.GetFloat("total");
                    mConsulta.Add(mDatos);
                }

                mReader.Close();
            }
            catch (Exception e)
            {

            }

            return mConsulta;
        }

        internal bool agregarCompetencia(COMPETENCIA mTarifarios)
        {
            string QUERY = "CALL agregarC(@nombre,@ruta,@desde,@hasta,@flete,@cargos_destino,@otros_costos,@iva,@total,@id_modalidad,@id_equipo);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@nombre", mTarifarios.Nombre));
            mySqlCommand.Parameters.Add(new MySqlParameter("@flete", mTarifarios.Flete));
            mySqlCommand.Parameters.Add(new MySqlParameter("@cargos_destino", mTarifarios.Cargos_Destino));
            mySqlCommand.Parameters.Add(new MySqlParameter("@otros_costos", mTarifarios.Otros_Cargos));
            mySqlCommand.Parameters.Add(new MySqlParameter("@iva", mTarifarios.IVA));
            mySqlCommand.Parameters.Add(new MySqlParameter("@desde", mTarifarios.Desde));
            mySqlCommand.Parameters.Add(new MySqlParameter("@hasta", mTarifarios.Hasta));
            mySqlCommand.Parameters.Add(new MySqlParameter("@total", mTarifarios.Total));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_modalidad", mTarifarios.Id_Modalidad));
            mySqlCommand.Parameters.Add(new MySqlParameter("@id_equipo", mTarifarios.Id_Equipo));
            mySqlCommand.Parameters.Add(new MySqlParameter("@ruta", mTarifarios.Ruta));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool eliminarCompetencia(COMPETENCIA mTarifarios)
        {
            string QUERY = "CALL eliminarC(@id);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mTarifarios.Id));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool eliminarTodoCompetencia()
        {
            string QUERY = "CALL eliminarTodoC();";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            return mySqlCommand.ExecuteNonQuery() > 0;
        }
    }
}
