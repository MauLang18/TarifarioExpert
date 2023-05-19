using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarifarios_Tarifas.Models.Atributos;

namespace Tarifarios_Tarifas.Models.Metodos
{
    internal class AgenteOrigenLCLConsultas
    {
        private ConexionMySql conexionMySql;
        private List<AgenteOrigenLCL> mConsulta;

        public AgenteOrigenLCLConsultas()
        {
            conexionMySql = new ConexionMySql();
            mConsulta = new List<AgenteOrigenLCL>();
        }

        public List<AgenteOrigenLCL> getAgenteOrigen(string filtro)
        {
            string QUERY = "SELECT * FROM tb_agente_origen_lcl ";
            MySqlDataReader mReader = null;
            try
            {
                if(filtro != null || filtro != "")
                {
                    switch (filtro)
                    {
                        case "CHINA":
                            QUERY += " WHERE china = 1;";
                            break;
                        case "INDIA":
                            QUERY += " WHERE india = 1;";
                            break;
                        case "JAPON":
                            QUERY += " WHERE japon = 1;";
                            break;
                        case "KOREA":
                            QUERY += " WHERE korea = 1;";
                            break;
                        case "COSTA RICA":
                            QUERY += " WHERE crc = 1;";
                            break;
                        case "INDONESIA":
                            QUERY += " WHERE indonesia = 1;";
                            break;
                        case "ESPAÑA":
                            QUERY += " WHERE espana = 1;";
                            break;
                        case "ITALIA":
                            QUERY += " WHERE italia = 1;";
                            break;
                        case "FRANCIA":
                            QUERY += " WHERE francia = 1;";
                            break;
                        case "ALEMANIA":
                            QUERY += " WHERE alemania = 1;";
                            break;
                        case "DUBAI":
                            QUERY += " WHERE dubai = 1;";
                            break;
                        case "SUDAFRICA":
                            QUERY += " WHERE sudafrica = 1;";
                            break;
                        case "THAILANDIA":
                            QUERY += " WHERE thailandia = 1;";
                            break;
                        case "TAIWAN":
                            QUERY += " WHERE taiwan = 1;";
                            break;
                        case "HOLANDA":
                            QUERY += " WHERE holanda = 1;";
                            break;
                        case "CANADA":
                            QUERY += " WHERE canada = 1;";
                            break;
                        case "USA":
                            QUERY += " WHERE usa = 1;";
                            break;
                        case "MEXICO":
                            QUERY += " WHERE mexico = 1;";
                            break;
                        case "GUATEMALA":
                            QUERY += " WHERE guatemala = 1;";
                            break;
                        case "PANAMA":
                            QUERY += " WHERE panama = 1;";
                            break;
                        case "NICARAGUA":
                            QUERY += " WHERE nicaragua = 1;";
                            break;
                        case "EL SALVADOR":
                            QUERY += " WHERE salvador = 1;";
                            break;
                        case "HONDURAS":
                            QUERY += " WHERE honduras = 1;";
                            break;
                        case "COLOMBIA":
                            QUERY += " WHERE colombia = 1;";
                            break;
                        case "ECUADOR":
                            QUERY += " WHERE ecuador = 1;";
                            break;
                        case "PERU":
                            QUERY += " WHERE peru = 1;";
                            break;
                        case "BRASIL":
                            QUERY += " WHERE brasil = 1;";
                            break;
                        case "ARGENTINA":
                            QUERY += " WHERE argentina = 1;";
                            break;
                        case "CHILE":
                            QUERY += " WHERE chile = 1;";
                            break;
                        case "URUGUAY":
                            QUERY += " WHERE uruguay = 1;";
                            break;
                        case "PARAGUAY":
                            QUERY += " WHERE paraguay = 1;";
                            break;
                        case "SUIZA":
                            QUERY += " WHERE suiza = 1;";
                            break;
                        case "ARABIA SAUDITA":
                            QUERY += " WHERE arabia_saudi = 1";
                            break;
                        case "ARGELIA":
                            QUERY += " WHERE argelia = 1;";
                            break;
                        case "AUSTRALIA":
                            QUERY += " WHERE australia = 1;";
                            break;
                        case "AUSTRIA":
                            QUERY += " WHERE austria = 1;";
                            break;
                        case "BAHAMAS":
                            QUERY += " WHERE bahamas = 1;";
                            break;
                        case "BANGLADESH":
                            QUERY += " WHERE bangladesh = 1;";
                            break;
                        case "BARBADOS":
                            QUERY += " WHERE barbados = 1;";
                            break;
                        case "BELGICA":
                            QUERY += " WHERE belgica = 1;";
                            break;
                        case "BELICE":
                            QUERY += " WHERE belice = 1;";
                            break;
                        case "BOLIVIA":
                            QUERY += " WHERE bolivia = 1;";
                            break;
                        case "CROACIA":
                            QUERY += " WHERE croacia = 1";
                            break;
                        case "CUBA":
                            QUERY += " WHERE cuba = 1;";
                            break;
                        case "DINAMARCA":
                            QUERY += " WHERE dinamarca = 1;";
                            break;
                        case "DOMINICA":
                            QUERY += " WHERE dominica = 1;";
                            break;
                        case "EGIPTO":
                            QUERY += " WHERE egipto = 1;";
                            break;
                        case "ESLOVAQUIA":
                            QUERY += " WHERE eslovaquia = 1;";
                            break;
                        case "ESLOVENIA":
                            QUERY += " WHERE eslovenia = 1;";
                            break;
                        case "RUSIA":
                            QUERY += " WHERE rusia = 1;";
                            break;
                        case "FILIPINAS":
                            QUERY += " WHERE filipinas = 1;";
                            break;
                        case "FINLANDIA":
                            QUERY += " WHERE finlandia = 1;";
                            break;
                        case "GRECIA":
                            QUERY += " WHERE grecia = 1";
                            break;
                        case "HAITI":
                            QUERY += " WHERE haiti = 1;";
                            break;
                        case "HUNGRIA":
                            QUERY += " WHERE hungria = 1;";
                            break;
                        case "IRLANDIA":
                            QUERY += " WHERE irlandia = 1;";
                            break;
                        case "ISLANDIA":
                            QUERY += " WHERE islandia = 1;";
                            break;
                        case "ISRAEL":
                            QUERY += " WHERE israel = 1;";
                            break;
                        case "JAMAICA":
                            QUERY += " WHERE jamaica = 1;";
                            break;
                        case "LUXEMBURGO":
                            QUERY += " WHERE luxemburgo = 1;";
                            break;
                        case "MALASIA":
                            QUERY += " WHERE malasia = 1;";
                            break;
                        case "MALDIVAS":
                            QUERY += " WHERE maldivas = 1;";
                            break;
                        case "MARRUECOS":
                            QUERY += " WHERE marruecos = 1";
                            break;
                        case "MONACO":
                            QUERY += " WHERE monaco = 1;";
                            break;
                        case "MONGOLIA":
                            QUERY += " WHERE mongolia = 1;";
                            break;
                        case "NEPAL":
                            QUERY += " WHERE nepal = 1;";
                            break;
                        case "NORUEGA":
                            QUERY += " WHERE noruega = 1;";
                            break;
                        case "NUEVA ZELANDA":
                            QUERY += " WHERE nueva_zelanda = 1;";
                            break;
                        case "POLONIA":
                            QUERY += " WHERE polonia = 1;";
                            break;
                        case "PORTUGAL":
                            QUERY += " WHERE portugal = 1;";
                            break;
                        case "QATAR":
                            QUERY += " WHERE qatar = 1;";
                            break;
                        case "REINO UNIDO":
                            QUERY += " WHERE reino_unido = 1;";
                            break;
                        case "REPUBLICA DOMINICANA":
                            QUERY += " WHERE republica_dominicana = 1";
                            break;
                        case "SINGAPUR":
                            QUERY += " WHERE singapur = 1;";
                            break;
                        case "SUECIA":
                            QUERY += " WHERE suecia = 1;";
                            break;
                        case "TUNEZ":
                            QUERY += " WHERE tunez = 1;";
                            break;
                        case "TURQUIA":
                            QUERY += " WHERE turquia = 1;";
                            break;
                        case "UCRANIA":
                            QUERY += " WHERE ucrania = 1;";
                            break;
                        case "VENEZUELA":
                            QUERY += " WHERE venezuela = 1;";
                            break;
                        case "VIETNAM":
                            QUERY += " WHERE vietnam = 1;";
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

                AgenteOrigenLCL mDatos = null;
                while (mReader.Read())
                {
                    mDatos = new AgenteOrigenLCL();
                    mDatos.Id = mReader.GetInt32("id");
                    mDatos.Proveedor = mReader.GetString("proveedor");
                    mDatos.Manejos = mReader.GetFloat("manejos");
                    mDatos.Hbl = mReader.GetFloat("hbl");
                    mConsulta.Add(mDatos);
                }

                mReader.Close();
            }
            catch (Exception e)
            {

            }

            return mConsulta;
        }

        public List<AgenteOrigenLCL> getAgenteOrigen1()
        {
            string QUERY = "SELECT * FROM tb_agente_origen_lcl;";
            MySqlDataReader mReader = null;
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(QUERY);
                mySqlCommand.Connection = conexionMySql.GetConnection();
                mReader = mySqlCommand.ExecuteReader();

                AgenteOrigenLCL mDatos = null;
                while (mReader.Read())
                {
                    mDatos = new AgenteOrigenLCL();
                    mDatos.Id = mReader.GetInt32("id");
                    mDatos.Proveedor = mReader.GetString("proveedor");
                    mDatos.Manejos = mReader.GetFloat("manejos");
                    mDatos.Hbl = mReader.GetFloat("hbl");
                    mDatos.alemania = mReader.GetInt32("alemania");
                    mDatos.arabia_saudi = mReader.GetInt32("arabia_saudi");
                    mDatos.argelia = mReader.GetInt32("argelia");
                    mDatos.argentina = mReader.GetInt32("argentina");
                    mDatos.australia = mReader.GetInt32("australia");
                    mDatos.austria = mReader.GetInt32("austria");
                    mDatos.bahamas = mReader.GetInt32("bahamas");
                    mDatos.bangladesh = mReader.GetInt32("bangladesh");
                    mDatos.barbados = mReader.GetInt32("barbados");
                    mDatos.belgica = mReader.GetInt32("belgica");
                    mDatos.belice = mReader.GetInt32("belice");
                    mDatos.bolivia = mReader.GetInt32("bolivia");
                    mDatos.brasil = mReader.GetInt32("brasil");
                    mDatos.canada = mReader.GetInt32("canada");
                    mDatos.chile = mReader.GetInt32("chile");
                    mDatos.china = mReader.GetInt32("china");
                    mDatos.colombia = mReader.GetInt32("colombia");
                    mDatos.crc = mReader.GetInt32("crc");
                    mDatos.croacia = mReader.GetInt32("croacia");
                    mDatos.cuba = mReader.GetInt32("cuba");
                    mDatos.dinamarca = mReader.GetInt32("dinamarca");
                    mDatos.dominica = mReader.GetInt32("dominica");
                    mDatos.dubai = mReader.GetInt32("dubai");
                    mDatos.ecuador = mReader.GetInt32("ecuador");
                    mDatos.egipto = mReader.GetInt32("egipto");
                    mDatos.eslovaquia = mReader.GetInt32("eslovaquia");
                    mDatos.eslovenia = mReader.GetInt32("eslovenia");
                    mDatos.espana = mReader.GetInt32("espana");
                    mDatos.finlandia = mReader.GetInt32("finlandia");
                    mDatos.flipinas = mReader.GetInt32("filipinas");
                    mDatos.francia = mReader.GetInt32("francia");
                    mDatos.grecia = mReader.GetInt32("grecia");
                    mDatos.guatemala = mReader.GetInt32("guatemala");
                    mDatos.haiti = mReader.GetInt32("haiti");
                    mDatos.holanda = mReader.GetInt32("holanda");
                    mDatos.honduras = mReader.GetInt32("honduras");
                    mDatos.hungria = mReader.GetInt32("hungria");
                    mDatos.india = mReader.GetInt32("india");
                    mDatos.indonesia = mReader.GetInt32("indonesia");
                    mDatos.irlandia = mReader.GetInt32("irlandia");
                    mDatos.islandia = mReader.GetInt32("islandia");
                    mDatos.israel = mReader.GetInt32("israel");
                    mDatos.italia = mReader.GetInt32("italia");
                    mDatos.jamaica = mReader.GetInt32("jamaica");
                    mDatos.japon = mReader.GetInt32("japon");
                    mDatos.korea = mReader.GetInt32("korea");
                    mDatos.luxemburgo = mReader.GetInt32("luxemburgo");
                    mDatos.malasia = mReader.GetInt32("malasia");
                    mDatos.maldivas = mReader.GetInt32("maldivas");
                    mDatos.marruecos = mReader.GetInt32("marruecos");
                    mDatos.maxico = mReader.GetInt32("mexico");
                    mDatos.monaco = mReader.GetInt32("monaco");
                    mDatos.mongolia = mReader.GetInt32("mongolia");
                    mDatos.nepal = mReader.GetInt32("nepal");
                    mDatos.nicaragua = mReader.GetInt32("nicaragua");
                    mDatos.noruega = mReader.GetInt32("noruega");
                    mDatos.nueva_zelanda = mReader.GetInt32("nueva_zelanda");
                    mDatos.panama = mReader.GetInt32("panama");
                    mDatos.paraguay = mReader.GetInt32("paraguaY");
                    mDatos.peru = mReader.GetInt32("peru");
                    mDatos.polonia = mReader.GetInt32("polonia");
                    mDatos.portugal = mReader.GetInt32("portugal");
                    mDatos.qatar = mReader.GetInt32("qatar");
                    mDatos.reino_unido = mReader.GetInt32("reino_unido");
                    mDatos.republica_dominicana = mReader.GetInt32("republica_dominicana");
                    mDatos.rusia = mReader.GetInt32("rusia");
                    mDatos.salvador = mReader.GetInt32("salvador");
                    mDatos.singapur = mReader.GetInt32("singapur");
                    mDatos.sudafrica = mReader.GetInt32("sudafrica");
                    mDatos.suecia = mReader.GetInt32("suecia");
                    mDatos.suiza = mReader.GetInt32("suiza");
                    mDatos.thailandia = mReader.GetInt32("thailandia");
                    mDatos.taiwan = mReader.GetInt32("taiwan");
                    mDatos.tunez = mReader.GetInt32("tunez");
                    mDatos.turquia = mReader.GetInt32("turquia");
                    mDatos.ucrania = mReader.GetInt32("ucrania");
                    mDatos.uruguay = mReader.GetInt32("uruguay");
                    mDatos.usa = mReader.GetInt32("usa");
                    mDatos.venezuela = mReader.GetInt32("venezuela");
                    mDatos.vietnam = mReader.GetInt32("vietnam");
                    mConsulta.Add(mDatos);
                }

                mReader.Close();
            }
            catch (Exception e)
            {

            }

            return mConsulta;
        }

        internal bool agregarAgenteOrigen(AgenteOrigenLCL mAgenteOrigen)
        {
            string QUERY = "CALL agregarAO_LCL(@proveedor,@manejos,@hbl,@china,@india,@japon,@korea,@crc,@indonesia,@espana,@italia,@francia,@alemania,@dubai,@sudafrica,@thailandia,@taiwan,@holanda,@canada,@usa,@mexico,@guatemala,@panama,@nicaragua,@salvador,@honduras,@colombia,@ecuador,@peru,@brasil,@argentina,@chile,@uruguay,@paraguay,@suiza,@arabia,@argelia,@australia,@austria,@bahamas,@bangladesh,@barbados,@belgica,@belice,@bolivia,@croacia,@cuba,@dinamarca,@dominica,@egipto,@eslovaquia,@eslovenia,@rusia,@filipinas,@finlandia,@grecia,@haiti,@hungria,@irlandia,@islandia,@israel,@jamaica,@luxemburgo,@malasia,@maldivas,@marruecos,@monaco,@mongolia,@nepal,@noruega,@zelanda,@polonia,@portugal,@qatar,@uk,@rd,@singapur,@suecia,@tunez,@turquia,@ucrania,@venezuela,@vietnam);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@proveedor", mAgenteOrigen.Proveedor));
            mySqlCommand.Parameters.Add(new MySqlParameter("@manejos", mAgenteOrigen.Manejos));
            mySqlCommand.Parameters.Add(new MySqlParameter("@hbl", mAgenteOrigen.Hbl));
            mySqlCommand.Parameters.Add(new MySqlParameter("@china", mAgenteOrigen.china));
            mySqlCommand.Parameters.Add(new MySqlParameter("@india", mAgenteOrigen.india));
            mySqlCommand.Parameters.Add(new MySqlParameter("@japon", mAgenteOrigen.japon));
            mySqlCommand.Parameters.Add(new MySqlParameter("@korea", mAgenteOrigen.korea));
            mySqlCommand.Parameters.Add(new MySqlParameter("@crc", mAgenteOrigen.crc));
            mySqlCommand.Parameters.Add(new MySqlParameter("@indonesia", mAgenteOrigen.indonesia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@espana", mAgenteOrigen.espana));
            mySqlCommand.Parameters.Add(new MySqlParameter("@italia", mAgenteOrigen.italia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@francia", mAgenteOrigen.francia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@alemania", mAgenteOrigen.alemania));
            mySqlCommand.Parameters.Add(new MySqlParameter("@dubai", mAgenteOrigen.dubai));
            mySqlCommand.Parameters.Add(new MySqlParameter("@sudafrica", mAgenteOrigen.sudafrica));
            mySqlCommand.Parameters.Add(new MySqlParameter("@thailandia", mAgenteOrigen.thailandia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@taiwan", mAgenteOrigen.taiwan));
            mySqlCommand.Parameters.Add(new MySqlParameter("@holanda", mAgenteOrigen.holanda));
            mySqlCommand.Parameters.Add(new MySqlParameter("@canada", mAgenteOrigen.canada));
            mySqlCommand.Parameters.Add(new MySqlParameter("@usa", mAgenteOrigen.usa));
            mySqlCommand.Parameters.Add(new MySqlParameter("@mexico", mAgenteOrigen.maxico));
            mySqlCommand.Parameters.Add(new MySqlParameter("@guatemala", mAgenteOrigen.guatemala));
            mySqlCommand.Parameters.Add(new MySqlParameter("@panama", mAgenteOrigen.panama));
            mySqlCommand.Parameters.Add(new MySqlParameter("@nicaragua", mAgenteOrigen.nicaragua));
            mySqlCommand.Parameters.Add(new MySqlParameter("@salvador", mAgenteOrigen.salvador));
            mySqlCommand.Parameters.Add(new MySqlParameter("@honduras", mAgenteOrigen.honduras));
            mySqlCommand.Parameters.Add(new MySqlParameter("@colombia", mAgenteOrigen.colombia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@ecuador", mAgenteOrigen.ecuador));
            mySqlCommand.Parameters.Add(new MySqlParameter("@peru", mAgenteOrigen.peru));
            mySqlCommand.Parameters.Add(new MySqlParameter("@brasil", mAgenteOrigen.brasil));
            mySqlCommand.Parameters.Add(new MySqlParameter("@argentina", mAgenteOrigen.argentina));
            mySqlCommand.Parameters.Add(new MySqlParameter("@chile", mAgenteOrigen.chile));
            mySqlCommand.Parameters.Add(new MySqlParameter("@uruguay", mAgenteOrigen.uruguay));
            mySqlCommand.Parameters.Add(new MySqlParameter("@paraguay", mAgenteOrigen.paraguay));
            mySqlCommand.Parameters.Add(new MySqlParameter("@suiza", mAgenteOrigen.suiza));
            mySqlCommand.Parameters.Add(new MySqlParameter("@arabia", mAgenteOrigen.arabia_saudi));
            mySqlCommand.Parameters.Add(new MySqlParameter("@argelia", mAgenteOrigen.argelia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@australia", mAgenteOrigen.australia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@austria", mAgenteOrigen.austria));
            mySqlCommand.Parameters.Add(new MySqlParameter("@bahamas", mAgenteOrigen.bahamas));
            mySqlCommand.Parameters.Add(new MySqlParameter("@bangladesh", mAgenteOrigen.bangladesh));
            mySqlCommand.Parameters.Add(new MySqlParameter("@barbados", mAgenteOrigen.barbados));
            mySqlCommand.Parameters.Add(new MySqlParameter("@belgica", mAgenteOrigen.belgica));
            mySqlCommand.Parameters.Add(new MySqlParameter("@belice", mAgenteOrigen.belice));
            mySqlCommand.Parameters.Add(new MySqlParameter("@bolivia", mAgenteOrigen.bolivia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@croacia", mAgenteOrigen.croacia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@cuba", mAgenteOrigen.cuba));
            mySqlCommand.Parameters.Add(new MySqlParameter("@dinamarca", mAgenteOrigen.dinamarca));
            mySqlCommand.Parameters.Add(new MySqlParameter("@dominica", mAgenteOrigen.dominica));
            mySqlCommand.Parameters.Add(new MySqlParameter("@egipto", mAgenteOrigen.egipto));
            mySqlCommand.Parameters.Add(new MySqlParameter("@eslovaquia", mAgenteOrigen.eslovaquia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@eslovenia", mAgenteOrigen.eslovenia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@rusia", mAgenteOrigen.rusia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@filipinas", mAgenteOrigen.flipinas));
            mySqlCommand.Parameters.Add(new MySqlParameter("@finlandia", mAgenteOrigen.finlandia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@grecia", mAgenteOrigen.grecia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@haiti", mAgenteOrigen.haiti));
            mySqlCommand.Parameters.Add(new MySqlParameter("@hungria", mAgenteOrigen.hungria));
            mySqlCommand.Parameters.Add(new MySqlParameter("@irlandia", mAgenteOrigen.irlandia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@islandia", mAgenteOrigen.islandia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@israel", mAgenteOrigen.israel));
            mySqlCommand.Parameters.Add(new MySqlParameter("@jamaica", mAgenteOrigen.jamaica));
            mySqlCommand.Parameters.Add(new MySqlParameter("@luxemburgo", mAgenteOrigen.luxemburgo));
            mySqlCommand.Parameters.Add(new MySqlParameter("@malasia", mAgenteOrigen.malasia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@maldivas", mAgenteOrigen.maldivas));
            mySqlCommand.Parameters.Add(new MySqlParameter("@marruecos", mAgenteOrigen.marruecos));
            mySqlCommand.Parameters.Add(new MySqlParameter("@monaco", mAgenteOrigen.monaco));
            mySqlCommand.Parameters.Add(new MySqlParameter("@mongolia", mAgenteOrigen.mongolia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@nepal", mAgenteOrigen.nepal));
            mySqlCommand.Parameters.Add(new MySqlParameter("@noruega", mAgenteOrigen.noruega));
            mySqlCommand.Parameters.Add(new MySqlParameter("@zelanda", mAgenteOrigen.nueva_zelanda));
            mySqlCommand.Parameters.Add(new MySqlParameter("@polonia", mAgenteOrigen.polonia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@portugal", mAgenteOrigen.portugal));
            mySqlCommand.Parameters.Add(new MySqlParameter("@qatar", mAgenteOrigen.qatar));
            mySqlCommand.Parameters.Add(new MySqlParameter("@uk", mAgenteOrigen.reino_unido));
            mySqlCommand.Parameters.Add(new MySqlParameter("@rd", mAgenteOrigen.republica_dominicana));
            mySqlCommand.Parameters.Add(new MySqlParameter("@singapur", mAgenteOrigen.singapur));
            mySqlCommand.Parameters.Add(new MySqlParameter("@suecia", mAgenteOrigen.suecia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@tunez", mAgenteOrigen.tunez));
            mySqlCommand.Parameters.Add(new MySqlParameter("@turquia", mAgenteOrigen.turquia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@ucrania", mAgenteOrigen.ucrania));
            mySqlCommand.Parameters.Add(new MySqlParameter("@venezuela", mAgenteOrigen.venezuela));
            mySqlCommand.Parameters.Add(new MySqlParameter("@vietnam", mAgenteOrigen.vietnam));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool eliminarAgenteOrigen(AgenteOrigenLCL mAgenteOrigen)
        {
            string QUERY = "CALL eliminarAO_LCL(@id);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mAgenteOrigen.Id));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool modificarAgenteOrigen(AgenteOrigenLCL mAgenteOrigen)
        {
            string QUERY = "CALL modificarAO_LCL(@id,@proveedor,@manejos,@hbl,@china,@india,@japon,@korea,@crc,@indonesia,@espana,@italia,@francia,@alemania,@dubai,@sudafrica,@thailandia,@taiwan,@holanda,@canada,@usa,@mexico,@guatemala,@panama,@nicaragua,@salvador,@honduras,@colombia,@ecuador,@peru,@brasil,@argentina,@chile,@uruguay,@paraguay,@suiza,@arabia,@argelia,@australia,@austria,@bahamas,@bangladesh,@barbados,@belgica,@belice,@bolivia,@croacia,@cuba,@dinamarca,@dominica,@egipto,@eslovaquia,@eslovenia,@rusia,@filipinas,@finlandia,@grecia,@haiti,@hungria,@irlandia,@islandia,@israel,@jamaica,@luxemburgo,@malasia,@maldivas,@marruecos,@monaco,@mongolia,@nepal,@noruega,@zelanda,@polonia,@portugal,@qatar,@uk,@rd,@singapur,@suecia,@tunez,@turquia,@ucrania,@venezuela,@vietnam);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mAgenteOrigen.Id));
            mySqlCommand.Parameters.Add(new MySqlParameter("@proveedor", mAgenteOrigen.Proveedor));
            mySqlCommand.Parameters.Add(new MySqlParameter("@manejos", mAgenteOrigen.Manejos));
            mySqlCommand.Parameters.Add(new MySqlParameter("@hbl", mAgenteOrigen.Hbl));
            mySqlCommand.Parameters.Add(new MySqlParameter("@china", mAgenteOrigen.china));
            mySqlCommand.Parameters.Add(new MySqlParameter("@india", mAgenteOrigen.india));
            mySqlCommand.Parameters.Add(new MySqlParameter("@japon", mAgenteOrigen.japon));
            mySqlCommand.Parameters.Add(new MySqlParameter("@korea", mAgenteOrigen.korea));
            mySqlCommand.Parameters.Add(new MySqlParameter("@crc", mAgenteOrigen.crc));
            mySqlCommand.Parameters.Add(new MySqlParameter("@indonesia", mAgenteOrigen.indonesia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@espana", mAgenteOrigen.espana));
            mySqlCommand.Parameters.Add(new MySqlParameter("@italia", mAgenteOrigen.italia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@francia", mAgenteOrigen.francia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@alemania", mAgenteOrigen.alemania));
            mySqlCommand.Parameters.Add(new MySqlParameter("@dubai", mAgenteOrigen.dubai));
            mySqlCommand.Parameters.Add(new MySqlParameter("@sudafrica", mAgenteOrigen.sudafrica));
            mySqlCommand.Parameters.Add(new MySqlParameter("@thailandia", mAgenteOrigen.thailandia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@taiwan", mAgenteOrigen.taiwan));
            mySqlCommand.Parameters.Add(new MySqlParameter("@holanda", mAgenteOrigen.holanda));
            mySqlCommand.Parameters.Add(new MySqlParameter("@canada", mAgenteOrigen.canada));
            mySqlCommand.Parameters.Add(new MySqlParameter("@usa", mAgenteOrigen.usa));
            mySqlCommand.Parameters.Add(new MySqlParameter("@mexico", mAgenteOrigen.maxico));
            mySqlCommand.Parameters.Add(new MySqlParameter("@guatemala", mAgenteOrigen.guatemala));
            mySqlCommand.Parameters.Add(new MySqlParameter("@panama", mAgenteOrigen.panama));
            mySqlCommand.Parameters.Add(new MySqlParameter("@nicaragua", mAgenteOrigen.nicaragua));
            mySqlCommand.Parameters.Add(new MySqlParameter("@salvador", mAgenteOrigen.salvador));
            mySqlCommand.Parameters.Add(new MySqlParameter("@honduras", mAgenteOrigen.honduras));
            mySqlCommand.Parameters.Add(new MySqlParameter("@colombia", mAgenteOrigen.colombia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@ecuador", mAgenteOrigen.ecuador));
            mySqlCommand.Parameters.Add(new MySqlParameter("@peru", mAgenteOrigen.peru));
            mySqlCommand.Parameters.Add(new MySqlParameter("@brasil", mAgenteOrigen.brasil));
            mySqlCommand.Parameters.Add(new MySqlParameter("@argentina", mAgenteOrigen.argentina));
            mySqlCommand.Parameters.Add(new MySqlParameter("@chile", mAgenteOrigen.chile));
            mySqlCommand.Parameters.Add(new MySqlParameter("@uruguay", mAgenteOrigen.uruguay));
            mySqlCommand.Parameters.Add(new MySqlParameter("@paraguay", mAgenteOrigen.paraguay));
            mySqlCommand.Parameters.Add(new MySqlParameter("@suiza", mAgenteOrigen.suiza));
            mySqlCommand.Parameters.Add(new MySqlParameter("@arabia", mAgenteOrigen.arabia_saudi));
            mySqlCommand.Parameters.Add(new MySqlParameter("@argelia", mAgenteOrigen.argelia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@australia", mAgenteOrigen.australia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@austria", mAgenteOrigen.austria));
            mySqlCommand.Parameters.Add(new MySqlParameter("@bahamas", mAgenteOrigen.bahamas));
            mySqlCommand.Parameters.Add(new MySqlParameter("@bangladesh", mAgenteOrigen.bangladesh));
            mySqlCommand.Parameters.Add(new MySqlParameter("@barbados", mAgenteOrigen.barbados));
            mySqlCommand.Parameters.Add(new MySqlParameter("@belgica", mAgenteOrigen.belgica));
            mySqlCommand.Parameters.Add(new MySqlParameter("@belice", mAgenteOrigen.belice));
            mySqlCommand.Parameters.Add(new MySqlParameter("@bolivia", mAgenteOrigen.bolivia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@croacia", mAgenteOrigen.croacia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@cuba", mAgenteOrigen.cuba));
            mySqlCommand.Parameters.Add(new MySqlParameter("@dinamarca", mAgenteOrigen.dinamarca));
            mySqlCommand.Parameters.Add(new MySqlParameter("@dominica", mAgenteOrigen.dominica));
            mySqlCommand.Parameters.Add(new MySqlParameter("@egipto", mAgenteOrigen.egipto));
            mySqlCommand.Parameters.Add(new MySqlParameter("@eslovaquia", mAgenteOrigen.eslovaquia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@eslovenia", mAgenteOrigen.eslovenia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@rusia", mAgenteOrigen.rusia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@filipinas", mAgenteOrigen.flipinas));
            mySqlCommand.Parameters.Add(new MySqlParameter("@finlandia", mAgenteOrigen.finlandia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@grecia", mAgenteOrigen.grecia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@haiti", mAgenteOrigen.haiti));
            mySqlCommand.Parameters.Add(new MySqlParameter("@hungria", mAgenteOrigen.hungria));
            mySqlCommand.Parameters.Add(new MySqlParameter("@irlandia", mAgenteOrigen.irlandia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@islandia", mAgenteOrigen.islandia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@israel", mAgenteOrigen.israel));
            mySqlCommand.Parameters.Add(new MySqlParameter("@jamaica", mAgenteOrigen.jamaica));
            mySqlCommand.Parameters.Add(new MySqlParameter("@luxemburgo", mAgenteOrigen.luxemburgo));
            mySqlCommand.Parameters.Add(new MySqlParameter("@malasia", mAgenteOrigen.malasia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@maldivas", mAgenteOrigen.maldivas));
            mySqlCommand.Parameters.Add(new MySqlParameter("@marruecos", mAgenteOrigen.marruecos));
            mySqlCommand.Parameters.Add(new MySqlParameter("@monaco", mAgenteOrigen.monaco));
            mySqlCommand.Parameters.Add(new MySqlParameter("@mongolia", mAgenteOrigen.mongolia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@nepal", mAgenteOrigen.nepal));
            mySqlCommand.Parameters.Add(new MySqlParameter("@noruega", mAgenteOrigen.noruega));
            mySqlCommand.Parameters.Add(new MySqlParameter("@zelanda", mAgenteOrigen.nueva_zelanda));
            mySqlCommand.Parameters.Add(new MySqlParameter("@polonia", mAgenteOrigen.polonia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@portugal", mAgenteOrigen.portugal));
            mySqlCommand.Parameters.Add(new MySqlParameter("@qatar", mAgenteOrigen.qatar));
            mySqlCommand.Parameters.Add(new MySqlParameter("@uk", mAgenteOrigen.reino_unido));
            mySqlCommand.Parameters.Add(new MySqlParameter("@rd", mAgenteOrigen.republica_dominicana));
            mySqlCommand.Parameters.Add(new MySqlParameter("@singapur", mAgenteOrigen.singapur));
            mySqlCommand.Parameters.Add(new MySqlParameter("@suecia", mAgenteOrigen.suecia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@tunez", mAgenteOrigen.tunez));
            mySqlCommand.Parameters.Add(new MySqlParameter("@turquia", mAgenteOrigen.turquia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@ucrania", mAgenteOrigen.ucrania));
            mySqlCommand.Parameters.Add(new MySqlParameter("@venezuela", mAgenteOrigen.venezuela));
            mySqlCommand.Parameters.Add(new MySqlParameter("@vietnam", mAgenteOrigen.vietnam));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }
    }
}
