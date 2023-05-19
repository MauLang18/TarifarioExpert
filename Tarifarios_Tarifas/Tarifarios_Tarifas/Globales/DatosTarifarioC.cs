using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Tarifarios_Tarifas.Globales
{
    public class DatosTarifarioC
    {
        //BASICO TARIFARIOS
        static public string nombre;
        static public string ruta;
        static public string origen;
        static public string pol;
        static public string pod;
        static public string via;
        static public string destino;
        static public string modalidad;
        static public string equipo;
        static public string desde;
        static public string hasta;
        //BASICO TARIFARIOS

        //COSTOS
        static public string flete;
        static public string cargos_destino;
        static public string otros_costos;
        static public string iva;
        //COSTOS

        static public string TotalTarifario = "0";

        // ID
        static public int id_modalidad;
        static public int id_equipo;
        // ID
    }
}
