using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarifarios_Tarifas.Forms.Tarifarios;
using Tarifarios_Tarifas.Models.Atributos;

namespace Tarifarios_Tarifas.Models.Metodos
{
    internal class CargosDestinoConsultas
    {
        private ConexionMySql conexionMySql;
        private List<CargosDestino> mConsulta;

        public CargosDestinoConsultas()
        {
            conexionMySql = new ConexionMySql();
            mConsulta = new List<CargosDestino>();
        }

        public List<CargosDestino> getCargosDestino(string filtro, string filtro2)
        {
            string QUERY = "SELECT * FROM tb_cargos_destino ";
            MySqlDataReader mReader = null;
            try
            {
                if ((filtro != null && filtro2 != null) || (filtro != "" && filtro2 != ""))
                {
                    switch (filtro)
                    {
                        case "CHINA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE china = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE china = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE china = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE china = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE china = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE china = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE china = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "INDIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE india = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE india = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE india = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE india = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE india = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE india = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE india = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "JAPON":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE japon = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE japon = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE japon = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE japon = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE japon = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE japon = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE japon = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "KOREA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE korea = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE korea = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE korea = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE korea = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE korea = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE korea = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE korea = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "COSTA RICA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE crc = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE crc = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE crc = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE crc = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE crc = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE crc = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE crc = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "INDONESIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE indonesia = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE indonesia = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE indonesia = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE indonesia = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE indonesia = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE indonesia = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE indonesia = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "ESPAÑA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE espana = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE espana = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE espana = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE espana = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE espana = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE espana = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE espana = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "ITALIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE italia = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE italia = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE italia = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE italia = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE italia = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE italia = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE italia = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "FRANCIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE francia = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE francia = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE francia = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE francia = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE francia = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE francia = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE francia = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "ALEMANIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE alemania = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE alemania = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE alemania = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE alemania = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE alemania = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE alemania = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE alemania = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "DUBAI":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE dubai = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE dubai = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE dubai = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE dubai = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE dubai = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE dubai = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE dubai = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "SUDAFRICA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE sudafrica = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE sudafrica = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE sudafrica = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE sudafrica = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE sudafrica = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE sudafrica = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE sudafrica = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "THAILANDIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE thailandia = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE thailandia = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE thailandia = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE thailandia = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE thailandia = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE thailandia = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE thailandia = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "TAIWAN":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE taiwan = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE taiwan = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE taiwan = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE taiwan = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE taiwan = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE taiwan = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE taiwan = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "HOLANDA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE holanda = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE holanda = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE holanda = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE holanda = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE holanda = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE holanda = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE holanda = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "CANADA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE canada = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE canada = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE canada = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE canada = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE canada = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE canada = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE canada = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "USA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE usa = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE usa = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE usa = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE usa = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE usa = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE usa = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE usa = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "MEXICO":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE mexico = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE mexico = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE mexico = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE mexico = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE mexico = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE mexico = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE mexico = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "GUATEMALA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE guatemala = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE guatemala = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE guatemala = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE guatemala = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE guatemala = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE guatemala = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE guatemala = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "PANAMA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE panama = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE panama = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE panama = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE panama = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE panama = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE panama = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE panama = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "NICARAGUA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE nicaragua = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE nicaragua = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE nicaragua = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE nicaragua = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE nicaragua = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE nicaragua = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE nicaragua = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "EL SALVADOR":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE salvador = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE salvador = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE salvador = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE salvador = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE salvador = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE salvador = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE salvador = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "HONDURAS":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE honduras = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE honduras = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE honduras = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE honduras = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE honduras = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE honduras = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE honduras = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "COLOMBIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE colombia = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE colombia = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE colombia = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE colombia = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE colombia = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE colombia = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE colombia = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "ECUADOR":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE ecuador = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE ecuador = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE ecuador = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE ecuador = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE ecuador = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE ecuador = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE ecuador = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "PERU":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE peru = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE peru = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE peru = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE peru = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE peru = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE peru = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE peru = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "BRASIL":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE brasil = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE brasil = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE brasil = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE brasil = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE brasil = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE brasil = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE brasil = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "ARGENTINA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE argentina = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE argentina = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE argentina = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE argentina = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE argentina = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE argentina = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE argentina = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "CHILE":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE chile = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE chile = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE chile = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE chile = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE chile = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE chile = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE chile = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "URUGUAY":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE uruguay = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE uruguay = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE uruguay = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE uruguay = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE uruguay = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE uruguay = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE uruguay = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "PARAGUAY":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE paraguay = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE paraguay = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE paraguay = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE paraguay = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE paraguay = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE paraguay = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE paraguay = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "SUIZA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE suiza = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE suiza = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE suiza = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE suiza = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE suiza = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE suiza = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE suiza = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "ARABIA SAUDITA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE arabia_saudi = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE arabia_saudi = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE arabia_saudi = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE arabia_saudi = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE arabia_saudi = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE arabia_saudi = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE arabia_saudi = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "ARGELIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE argelia = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE argelia = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE argelia = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE argelia = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE argelia = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE argelia = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE argelia = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "AUSTRALIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE australia = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE australia = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE australia = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE australia = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE australia = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE australia = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE australia = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "AUSTRIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE austria = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE austria = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE austria = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE austria = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE austria = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE austria = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE austria = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "BAHAMAS":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE bahamas = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE bahamas = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE bahamas = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE bahamas = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE bahamas = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE bahamas = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE bahamas = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "BANGLADESH":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE bangladesh = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE bangladesh = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE bangladesh = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE bangladesh = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE bangladesh = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE bangladesh = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE bangladesh = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "BARBADOS":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE barbados = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE barbados = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE barbados = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE barbados = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE barbados = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE barbados = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE barbados = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "BELGICA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE belgica = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE belgica = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE belgica = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE belgica = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE belgica = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE belgica = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE belgica = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "BELICE":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE belice = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE belice = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE belice = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE belice = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE belice = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE belice = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE belice = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "BOLIVIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE bolivia = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE bolivia = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE bolivia = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE bolivia = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE bolivia = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE bolivia = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE bolivia = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "CROACIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE croacia = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE croacia = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE croacia = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE croacia = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE croacia = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE croacia = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE croacia = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "CUBA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE cuba = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE cuba = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE cuba = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE cuba = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE cuba = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE cuba = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE cuba = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "DINAMARCA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE dinamarca = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE dinamarca = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE dinamarca = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE dinamarca = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE dinamarca = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE dinamarca = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE dinamarca = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "DOMINICA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE dominica = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE dominica = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE dominica = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE dominica = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE dominica = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE dominica = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE dominica = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "EGIPTO":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE egipto = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE egipto = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE egipto = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE egipto = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE egipto = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE egipto = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE egipto = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "ESLOVAQUIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE eslovaquia = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE eslovaquia = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE eslovaquia = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE eslovaquia = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE eslovaquia = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE eslovaquia = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE eslovaquia = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "ESLOVENIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE eslovenia = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE eslovenia = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE eslovenia = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE eslovenia = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE eslovenia = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE eslovenia = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE eslovenia = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "RUSIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE rusia = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE rusia = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE rusia = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE rusia = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE rusia = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE rusia = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE rusia = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "FILIPINAS":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE filipinas = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE filipinas = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE filipinas = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE filipinas = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE filipinas = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE filipinas = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE filipinas = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "FINLANDIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE finlandia = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE finlandia = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE filandia = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE finlandia = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE finlandia = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE finlandia = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE finlandia = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "GRECIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE greacia = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE grecia = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE grecia = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE grecia = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE grecia = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE grecia = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE grecia = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "HAITI":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE haiti = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE haiti = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE haiti = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE haiti = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE haiti = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE haiti = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE haiti = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "HUNGRIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE hungria = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE hungria = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE hungria = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE hungria = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE hungria = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE hungria = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE hungria = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "IRLANDIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE irlandia = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE irlandia = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE irlandia = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE irlandia = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE irlandia = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE irlandia = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE irlandia = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "ISLANDIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE islandia = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE islandia = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE islandia = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE islandia = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE islandia = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE islandia = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE islandia = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "ISRAEL":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE israel = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE israel = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE israel = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE israel = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE israel = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE israel = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE israel = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "JAMAICA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE jamaica = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE jamaica = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE jamaica = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE jamaica = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE jamaica = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE jamaica = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE jamaica = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "LUXEMBURGO":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE luxemburgo = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE luxemburgo = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE luxemburgo = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE luxemburgo = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE luxemburgo = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE luxemburgo = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE luxemburgo = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "MALASIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE malasia = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE malasia = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE malasia = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE malasia = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE malasia = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE malasia = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE malasia = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "MALDIVAS":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE maldivas = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE maldivas = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE maldivas = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE maldivas = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE maldivas = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE maldivas = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE maldivas = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "MARRUECOS":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE marruecos = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE marruecos = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE marruecos = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE marruecos = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE marruecos = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE marruecos = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE marruecos = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "MONACO":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE monaco = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE monaco = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE monaco = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE monaco = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE monaco = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE monaco = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE monaco = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "MONGOLIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE mongolia = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE mongolia = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE mongolia = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE mongolia = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE mongolia = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE mongolia = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE mongolia = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "NEPAL":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE nepal = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE nepal = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE nepal = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE nepal = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE nepal = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE nepal = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE nepal = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "NORUEGA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE noruega = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE noruega = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE noruega = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE noruega = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE noruega = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE noruega = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE noruega = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "NUEVA ZELANDA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE nueva_zelanda = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE nueva_zelanda = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE nueva_zelanda = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE nueva_zelanda = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE nueva_zelanda = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE nueva_zelanda = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE nueva_zelanda = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "POLONIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE polonia = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE polonia = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE polonia = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE polonia = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE polonia = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE polonia = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE polonia = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "PORTUGAL":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE portugal = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE portugal = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE portugal = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE portugal = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE portugal = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE portugal = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE portugal = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "QATAR":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE qatar = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE qatar = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE qatar = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE qatar = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE qatar = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE qatar = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE qatar = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "REINO UNIDO":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE reino_unido = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE reino_unido = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE reino_unido = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE reino_unido = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE reino_unido = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE reino_unido = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE reino_unido = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "REPUBLICA DOMINICANA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE republica_dominicana = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE republica_dominicana = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE republica_dominicana = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE republica_dominicana = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE republica_dominicana = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE republia_dominicana = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE republica_dominicana = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "SINGAPUR":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE singapur = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE singapur = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE singapur = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE singapur = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE singapur = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE singapur = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE singapur = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "SUECIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE suecia = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE suecia = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE suecia = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE suecia = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE suecia = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE suecia = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE suecia = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "TUNEZ":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE tunez = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE tunez = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE tunez = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE tunez = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE tunez = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE tunez = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE tunez = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "TURQUIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE turquia = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE turquia = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE turquia = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE turquia = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE turquia = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE turquia = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE turquia = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "UCRANIA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE ucrania = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE ucrania = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE ucrania = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE ucrania = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE ucrania = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE ucrania = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE ucrania = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "VENEZUELA":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE venezuela = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE venezuela = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE venezuela = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE venezuela = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE venezuela = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE venezuela = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE venezuela = 1 and no_aplica = 1;";
                                    break;
                            }
                            break;
                        case "VIETNAM":
                            switch (filtro2)
                            {
                                case "RODMAN":
                                    QUERY += " WHERE vietnam = 1 and rodman = 1;";
                                    break;
                                case "CRISTOBAL":
                                    QUERY += " WHERE vietnam = 1 and cristobal = 1;";
                                    break;
                                case "MANZANILLO":
                                    QUERY += " WHERE vietnam = 1 and manzanillo = 1;";
                                    break;
                                case "BALBOA":
                                    QUERY += " WHERE vietnam = 1 and balboa = 1;";
                                    break;
                                case "MOIN":
                                    QUERY += " WHERE vietnam = 1 and moin = 1;";
                                    break;
                                case "CALDERA":
                                    QUERY += " WHERE vietnam = 1 and caldera = 1;";
                                    break;
                                case "NO APLICA":
                                    QUERY += " WHERE vietnam = 1 and no_aplica = 1;";
                                    break;
                            }
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

                CargosDestino mDatos = null;
                while (mReader.Read())
                {
                    mDatos = new CargosDestino();
                    mDatos.Id = mReader.GetInt32("id");
                    mDatos.Proveedor = mReader.GetString("proveedor");
                    mDatos.Flete = mReader.GetFloat("flete");
                    mConsulta.Add(mDatos);
                }

                mReader.Close();
            }
            catch (Exception e)
            {

            }

            return mConsulta;
        }

        public List<CargosDestino> getCargosDestino1()
        {
            string QUERY = "SELECT * FROM tb_cargos_destino;";
            MySqlDataReader mReader = null;
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(QUERY);
                mySqlCommand.Connection = conexionMySql.GetConnection();
                mReader = mySqlCommand.ExecuteReader();

                CargosDestino mDatos = null;
                while (mReader.Read())
                {
                    mDatos = new CargosDestino();
                    mDatos.Id = mReader.GetInt32("id");
                    mDatos.Proveedor = mReader.GetString("proveedor");
                    mDatos.Flete = mReader.GetFloat("flete");
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
                    mDatos.rodman = mReader.GetInt32("rodman");
                    mDatos.manzanillo = mReader.GetInt32("manzanillo");
                    mDatos.cristobal = mReader.GetInt32("cristobal");
                    mDatos.balboa = mReader.GetInt32("balboa");
                    mDatos.moin = mReader.GetInt32("moin");
                    mDatos.caldera = mReader.GetInt32("caldera");
                    mDatos.no_aplica = mReader.GetInt32("no_aplica");
                    mConsulta.Add(mDatos);
                }

                mReader.Close();
            }
            catch (Exception e)
            {

            }

            return mConsulta;
        }

        internal bool agregarCargosDestino(CargosDestino mCargosDestino)
        {
            string QUERY = "CALL agregarCD(@proveedor,@flete,@china,@india,@japon,@korea,@crc,@indonesia,@espana,@italia,@francia,@alemania,@dubai,@sudafrica,@thailandia,@taiwan,@holanda,@canada,@usa,@mexico,@guatemala,@panama,@nicaragua,@salvador,@honduras,@colombia,@ecuador,@peru,@brasil,@argentina,@chile,@uruguay,@paraguay,@suiza,@arabia,@argelia,@australia,@austria,@bahamas,@bangladesh,@barbados,@belgica,@belice,@bolivia,@croacia,@cuba,@dinamarca,@dominica,@egipto,@eslovaquia,@eslovenia,@rusia,@filipinas,@finlandia,@grecia,@haiti,@hungria,@irlandia,@islandia,@israel,@jamaica,@luxemburgo,@malasia,@maldivas,@marruecos,@monaco,@mongolia,@nepal,@noruega,@zelanda,@polonia,@portugal,@qatar,@uk,@rd,@singapur,@suecia,@tunez,@turquia,@ucrania,@venezuela,@vietnam,@rodman,@cristobal,@manzanillo,@balboa,@moin,@caldera,@no_aplica);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@proveedor", mCargosDestino.Proveedor));
            mySqlCommand.Parameters.Add(new MySqlParameter("@flete", mCargosDestino.Flete));
            mySqlCommand.Parameters.Add(new MySqlParameter("@china", mCargosDestino.china));
            mySqlCommand.Parameters.Add(new MySqlParameter("@india", mCargosDestino.india));
            mySqlCommand.Parameters.Add(new MySqlParameter("@japon", mCargosDestino.japon));
            mySqlCommand.Parameters.Add(new MySqlParameter("@korea", mCargosDestino.korea));
            mySqlCommand.Parameters.Add(new MySqlParameter("@crc", mCargosDestino.crc));
            mySqlCommand.Parameters.Add(new MySqlParameter("@indonesia", mCargosDestino.indonesia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@espana", mCargosDestino.espana));
            mySqlCommand.Parameters.Add(new MySqlParameter("@italia", mCargosDestino.italia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@francia", mCargosDestino.francia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@alemania", mCargosDestino.alemania));
            mySqlCommand.Parameters.Add(new MySqlParameter("@dubai", mCargosDestino.dubai));
            mySqlCommand.Parameters.Add(new MySqlParameter("@sudafrica", mCargosDestino.sudafrica));
            mySqlCommand.Parameters.Add(new MySqlParameter("@thailandia", mCargosDestino.thailandia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@taiwan", mCargosDestino.taiwan));
            mySqlCommand.Parameters.Add(new MySqlParameter("@holanda", mCargosDestino.holanda));
            mySqlCommand.Parameters.Add(new MySqlParameter("@canada", mCargosDestino.canada));
            mySqlCommand.Parameters.Add(new MySqlParameter("@usa", mCargosDestino.usa));
            mySqlCommand.Parameters.Add(new MySqlParameter("@mexico", mCargosDestino.maxico));
            mySqlCommand.Parameters.Add(new MySqlParameter("@guatemala", mCargosDestino.guatemala));
            mySqlCommand.Parameters.Add(new MySqlParameter("@panama", mCargosDestino.panama));
            mySqlCommand.Parameters.Add(new MySqlParameter("@nicaragua", mCargosDestino.nicaragua));
            mySqlCommand.Parameters.Add(new MySqlParameter("@salvador", mCargosDestino.salvador));
            mySqlCommand.Parameters.Add(new MySqlParameter("@honduras", mCargosDestino.honduras));
            mySqlCommand.Parameters.Add(new MySqlParameter("@colombia", mCargosDestino.colombia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@ecuador", mCargosDestino.ecuador));
            mySqlCommand.Parameters.Add(new MySqlParameter("@peru", mCargosDestino.peru));
            mySqlCommand.Parameters.Add(new MySqlParameter("@brasil", mCargosDestino.brasil));
            mySqlCommand.Parameters.Add(new MySqlParameter("@argentina", mCargosDestino.argentina));
            mySqlCommand.Parameters.Add(new MySqlParameter("@chile", mCargosDestino.chile));
            mySqlCommand.Parameters.Add(new MySqlParameter("@uruguay", mCargosDestino.uruguay));
            mySqlCommand.Parameters.Add(new MySqlParameter("@paraguay", mCargosDestino.paraguay));
            mySqlCommand.Parameters.Add(new MySqlParameter("@suiza", mCargosDestino.suiza));
            mySqlCommand.Parameters.Add(new MySqlParameter("@arabia", mCargosDestino.arabia_saudi));
            mySqlCommand.Parameters.Add(new MySqlParameter("@argelia", mCargosDestino.argelia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@australia", mCargosDestino.australia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@austria", mCargosDestino.austria));
            mySqlCommand.Parameters.Add(new MySqlParameter("@bahamas", mCargosDestino.bahamas));
            mySqlCommand.Parameters.Add(new MySqlParameter("@bangladesh", mCargosDestino.bangladesh));
            mySqlCommand.Parameters.Add(new MySqlParameter("@barbados", mCargosDestino.barbados));
            mySqlCommand.Parameters.Add(new MySqlParameter("@belgica", mCargosDestino.belgica));
            mySqlCommand.Parameters.Add(new MySqlParameter("@belice", mCargosDestino.belice));
            mySqlCommand.Parameters.Add(new MySqlParameter("@bolivia", mCargosDestino.bolivia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@croacia", mCargosDestino.croacia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@cuba", mCargosDestino.cuba));
            mySqlCommand.Parameters.Add(new MySqlParameter("@dinamarca", mCargosDestino.dinamarca));
            mySqlCommand.Parameters.Add(new MySqlParameter("@dominica", mCargosDestino.dominica));
            mySqlCommand.Parameters.Add(new MySqlParameter("@egipto", mCargosDestino.egipto));
            mySqlCommand.Parameters.Add(new MySqlParameter("@eslovaquia", mCargosDestino.eslovaquia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@eslovenia", mCargosDestino.eslovenia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@rusia", mCargosDestino.rusia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@filipinas", mCargosDestino.flipinas));
            mySqlCommand.Parameters.Add(new MySqlParameter("@finlandia", mCargosDestino.finlandia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@grecia", mCargosDestino.grecia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@haiti", mCargosDestino.haiti));
            mySqlCommand.Parameters.Add(new MySqlParameter("@hungria", mCargosDestino.hungria));
            mySqlCommand.Parameters.Add(new MySqlParameter("@irlandia", mCargosDestino.irlandia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@islandia", mCargosDestino.islandia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@israel", mCargosDestino.israel));
            mySqlCommand.Parameters.Add(new MySqlParameter("@jamaica", mCargosDestino.jamaica));
            mySqlCommand.Parameters.Add(new MySqlParameter("@luxemburgo", mCargosDestino.luxemburgo));
            mySqlCommand.Parameters.Add(new MySqlParameter("@malasia", mCargosDestino.malasia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@maldivas", mCargosDestino.maldivas));
            mySqlCommand.Parameters.Add(new MySqlParameter("@marruecos", mCargosDestino.marruecos));
            mySqlCommand.Parameters.Add(new MySqlParameter("@monaco", mCargosDestino.monaco));
            mySqlCommand.Parameters.Add(new MySqlParameter("@mongolia", mCargosDestino.mongolia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@nepal", mCargosDestino.nepal));
            mySqlCommand.Parameters.Add(new MySqlParameter("@noruega", mCargosDestino.noruega));
            mySqlCommand.Parameters.Add(new MySqlParameter("@zelanda", mCargosDestino.nueva_zelanda));
            mySqlCommand.Parameters.Add(new MySqlParameter("@polonia", mCargosDestino.polonia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@portugal", mCargosDestino.portugal));
            mySqlCommand.Parameters.Add(new MySqlParameter("@qatar", mCargosDestino.qatar));
            mySqlCommand.Parameters.Add(new MySqlParameter("@uk", mCargosDestino.reino_unido));
            mySqlCommand.Parameters.Add(new MySqlParameter("@rd", mCargosDestino.republica_dominicana));
            mySqlCommand.Parameters.Add(new MySqlParameter("@singapur", mCargosDestino.singapur));
            mySqlCommand.Parameters.Add(new MySqlParameter("@suecia", mCargosDestino.suecia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@tunez", mCargosDestino.tunez));
            mySqlCommand.Parameters.Add(new MySqlParameter("@turquia", mCargosDestino.turquia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@ucrania", mCargosDestino.ucrania));
            mySqlCommand.Parameters.Add(new MySqlParameter("@venezuela", mCargosDestino.venezuela));
            mySqlCommand.Parameters.Add(new MySqlParameter("@vietnam", mCargosDestino.vietnam));
            mySqlCommand.Parameters.Add(new MySqlParameter("@rodman", mCargosDestino.rodman));
            mySqlCommand.Parameters.Add(new MySqlParameter("@cristobal", mCargosDestino.cristobal));
            mySqlCommand.Parameters.Add(new MySqlParameter("@manzanillo", mCargosDestino.manzanillo));
            mySqlCommand.Parameters.Add(new MySqlParameter("@balboa", mCargosDestino.balboa));
            mySqlCommand.Parameters.Add(new MySqlParameter("@moin", mCargosDestino.moin));
            mySqlCommand.Parameters.Add(new MySqlParameter("@caldera", mCargosDestino.caldera));
            mySqlCommand.Parameters.Add(new MySqlParameter("@no_aplica", mCargosDestino.no_aplica));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool eliminarCargosDestino(CargosDestino mCargosDestino)
        {
            string QUERY = "CALL eliminarCD(@id);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mCargosDestino.Id));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        internal bool modificarCargosDestino(CargosDestino mCargosDestino)
        {
            string QUERY = "CALL modificarCD(@id,@proveedor,@flete,@china,@india,@japon,@korea,@crc,@indonesia,@espana,@italia,@francia,@alemania,@dubai,@sudafrica,@thailandia,@taiwan,@holanda,@canada,@usa,@mexico,@guatemala,@panama,@nicaragua,@salvador,@honduras,@colombia,@ecuador,@peru,@brasil,@argentina,@chile,@uruguay,@paraguay,@suiza,@arabia,@argelia,@australia,@austria,@bahamas,@bangladesh,@barbados,@belgica,@belice,@bolivia,@croacia,@cuba,@dinamarca,@dominica,@egipto,@eslovaquia,@eslovenia,@rusia,@filipinas,@finlandia,@grecia,@haiti,@hungria,@irlandia,@islandia,@israel,@jamaica,@luxemburgo,@malasia,@maldivas,@marruecos,@monaco,@mongolia,@nepal,@noruega,@zelanda,@polonia,@portugal,@qatar,@uk,@rd,@singapur,@suecia,@tunez,@turquia,@ucrania,@venezuela,@vietnam,@rodman,@cristobal,@manzanillo,@balboa,@moin,@caldera,@no_aplica);";

            MySqlCommand mySqlCommand = new MySqlCommand(QUERY, conexionMySql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@id", mCargosDestino.Id));
            mySqlCommand.Parameters.Add(new MySqlParameter("@proveedor", mCargosDestino.Proveedor));
            mySqlCommand.Parameters.Add(new MySqlParameter("@flete", mCargosDestino.Flete));
            mySqlCommand.Parameters.Add(new MySqlParameter("@china", mCargosDestino.china));
            mySqlCommand.Parameters.Add(new MySqlParameter("@india", mCargosDestino.india));
            mySqlCommand.Parameters.Add(new MySqlParameter("@japon", mCargosDestino.japon));
            mySqlCommand.Parameters.Add(new MySqlParameter("@korea", mCargosDestino.korea));
            mySqlCommand.Parameters.Add(new MySqlParameter("@crc", mCargosDestino.crc));
            mySqlCommand.Parameters.Add(new MySqlParameter("@indonesia", mCargosDestino.indonesia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@espana", mCargosDestino.espana));
            mySqlCommand.Parameters.Add(new MySqlParameter("@italia", mCargosDestino.italia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@francia", mCargosDestino.francia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@alemania", mCargosDestino.alemania));
            mySqlCommand.Parameters.Add(new MySqlParameter("@dubai", mCargosDestino.dubai));
            mySqlCommand.Parameters.Add(new MySqlParameter("@sudafrica", mCargosDestino.sudafrica));
            mySqlCommand.Parameters.Add(new MySqlParameter("@thailandia", mCargosDestino.thailandia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@taiwan", mCargosDestino.taiwan));
            mySqlCommand.Parameters.Add(new MySqlParameter("@holanda", mCargosDestino.holanda));
            mySqlCommand.Parameters.Add(new MySqlParameter("@canada", mCargosDestino.canada));
            mySqlCommand.Parameters.Add(new MySqlParameter("@usa", mCargosDestino.usa));
            mySqlCommand.Parameters.Add(new MySqlParameter("@mexico", mCargosDestino.maxico));
            mySqlCommand.Parameters.Add(new MySqlParameter("@guatemala", mCargosDestino.guatemala));
            mySqlCommand.Parameters.Add(new MySqlParameter("@panama", mCargosDestino.panama));
            mySqlCommand.Parameters.Add(new MySqlParameter("@nicaragua", mCargosDestino.nicaragua));
            mySqlCommand.Parameters.Add(new MySqlParameter("@salvador", mCargosDestino.salvador));
            mySqlCommand.Parameters.Add(new MySqlParameter("@honduras", mCargosDestino.honduras));
            mySqlCommand.Parameters.Add(new MySqlParameter("@colombia", mCargosDestino.colombia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@ecuador", mCargosDestino.ecuador));
            mySqlCommand.Parameters.Add(new MySqlParameter("@peru", mCargosDestino.peru));
            mySqlCommand.Parameters.Add(new MySqlParameter("@brasil", mCargosDestino.brasil));
            mySqlCommand.Parameters.Add(new MySqlParameter("@argentina", mCargosDestino.argentina));
            mySqlCommand.Parameters.Add(new MySqlParameter("@chile", mCargosDestino.chile));
            mySqlCommand.Parameters.Add(new MySqlParameter("@uruguay", mCargosDestino.uruguay));
            mySqlCommand.Parameters.Add(new MySqlParameter("@paraguay", mCargosDestino.paraguay));
            mySqlCommand.Parameters.Add(new MySqlParameter("@suiza", mCargosDestino.suiza));
            mySqlCommand.Parameters.Add(new MySqlParameter("@arabia", mCargosDestino.arabia_saudi));
            mySqlCommand.Parameters.Add(new MySqlParameter("@argelia", mCargosDestino.argelia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@australia", mCargosDestino.australia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@austria", mCargosDestino.austria));
            mySqlCommand.Parameters.Add(new MySqlParameter("@bahamas", mCargosDestino.bahamas));
            mySqlCommand.Parameters.Add(new MySqlParameter("@bangladesh", mCargosDestino.bangladesh));
            mySqlCommand.Parameters.Add(new MySqlParameter("@barbados", mCargosDestino.barbados));
            mySqlCommand.Parameters.Add(new MySqlParameter("@belgica", mCargosDestino.belgica));
            mySqlCommand.Parameters.Add(new MySqlParameter("@belice", mCargosDestino.belice));
            mySqlCommand.Parameters.Add(new MySqlParameter("@bolivia", mCargosDestino.bolivia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@croacia", mCargosDestino.croacia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@cuba", mCargosDestino.cuba));
            mySqlCommand.Parameters.Add(new MySqlParameter("@dinamarca", mCargosDestino.dinamarca));
            mySqlCommand.Parameters.Add(new MySqlParameter("@dominica", mCargosDestino.dominica));
            mySqlCommand.Parameters.Add(new MySqlParameter("@egipto", mCargosDestino.egipto));
            mySqlCommand.Parameters.Add(new MySqlParameter("@eslovaquia", mCargosDestino.eslovaquia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@eslovenia", mCargosDestino.eslovenia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@rusia", mCargosDestino.rusia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@filipinas", mCargosDestino.flipinas));
            mySqlCommand.Parameters.Add(new MySqlParameter("@finlandia", mCargosDestino.finlandia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@grecia", mCargosDestino.grecia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@haiti", mCargosDestino.haiti));
            mySqlCommand.Parameters.Add(new MySqlParameter("@hungria", mCargosDestino.hungria));
            mySqlCommand.Parameters.Add(new MySqlParameter("@irlandia", mCargosDestino.irlandia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@islandia", mCargosDestino.islandia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@israel", mCargosDestino.israel));
            mySqlCommand.Parameters.Add(new MySqlParameter("@jamaica", mCargosDestino.jamaica));
            mySqlCommand.Parameters.Add(new MySqlParameter("@luxemburgo", mCargosDestino.luxemburgo));
            mySqlCommand.Parameters.Add(new MySqlParameter("@malasia", mCargosDestino.malasia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@maldivas", mCargosDestino.maldivas));
            mySqlCommand.Parameters.Add(new MySqlParameter("@marruecos", mCargosDestino.marruecos));
            mySqlCommand.Parameters.Add(new MySqlParameter("@monaco", mCargosDestino.monaco));
            mySqlCommand.Parameters.Add(new MySqlParameter("@mongolia", mCargosDestino.mongolia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@nepal", mCargosDestino.nepal));
            mySqlCommand.Parameters.Add(new MySqlParameter("@noruega", mCargosDestino.noruega));
            mySqlCommand.Parameters.Add(new MySqlParameter("@zelanda", mCargosDestino.nueva_zelanda));
            mySqlCommand.Parameters.Add(new MySqlParameter("@polonia", mCargosDestino.polonia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@portugal", mCargosDestino.portugal));
            mySqlCommand.Parameters.Add(new MySqlParameter("@qatar", mCargosDestino.qatar));
            mySqlCommand.Parameters.Add(new MySqlParameter("@uk", mCargosDestino.reino_unido));
            mySqlCommand.Parameters.Add(new MySqlParameter("@rd", mCargosDestino.republica_dominicana));
            mySqlCommand.Parameters.Add(new MySqlParameter("@singapur", mCargosDestino.singapur));
            mySqlCommand.Parameters.Add(new MySqlParameter("@suecia", mCargosDestino.suecia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@tunez", mCargosDestino.tunez));
            mySqlCommand.Parameters.Add(new MySqlParameter("@turquia", mCargosDestino.turquia));
            mySqlCommand.Parameters.Add(new MySqlParameter("@ucrania", mCargosDestino.ucrania));
            mySqlCommand.Parameters.Add(new MySqlParameter("@venezuela", mCargosDestino.venezuela));
            mySqlCommand.Parameters.Add(new MySqlParameter("@vietnam", mCargosDestino.vietnam));
            mySqlCommand.Parameters.Add(new MySqlParameter("@rodman", mCargosDestino.rodman));
            mySqlCommand.Parameters.Add(new MySqlParameter("@cristobal", mCargosDestino.cristobal));
            mySqlCommand.Parameters.Add(new MySqlParameter("@manzanillo", mCargosDestino.manzanillo));
            mySqlCommand.Parameters.Add(new MySqlParameter("@balboa", mCargosDestino.balboa));
            mySqlCommand.Parameters.Add(new MySqlParameter("@moin", mCargosDestino.moin));
            mySqlCommand.Parameters.Add(new MySqlParameter("@caldera", mCargosDestino.caldera));
            mySqlCommand.Parameters.Add(new MySqlParameter("@no_aplica", mCargosDestino.no_aplica));

            return mySqlCommand.ExecuteNonQuery() > 0;
        }
    }
}
