using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarifarios_Tarifas.Globales
{
    public class DatosTarifarioLCL
    {
        //BASICO TARIFARIOS
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

        // AGENTE ORIGEN
        static public string proveedor;
        static public string manejos;
        static public string hbl;
        static public string total = "0";
        // AGENTE ORIGEN

        // FLETE INTERNACIONAL
        static public string naviero;
        static public string flete = "0";
        static public string flete2 = "0";
        static public string thc;
        static public string doc_fee;
        static public string security;
        static public string impresion_bl;
        static public string port_facility;
        static public string canal_fee;
        static public string vac;
        static public string impdoc;
        static public string merchant;
        static public string carga_peli;
        static public string total_flete = "0";
        static public string total_cargos_destino = "0";
        static public string total_flete2 = "0";
        // FLETE INTERNACIONAL

        // TRANSBORDO
        static public string cargos_en_destino_proveedor;
        static public string cargos_en_destino;
        static public string movimiento_bodega_proveedor;
        static public string movimiento_bodega;
        static public string otras_categorias_total = "0";
        static public string otras_categorias_producto1;
        static public string otras_categorias_producto2;
        static public string otras_categorias_producto3;
        static public string transbordo_total = "0";
        // TRANSBORDO

        // CARGOS DESTINO
        static public string proveedor_cargos_destino1;
        static public string proveedor_cargos_destino2;
        static public string proveedor_cargos_destino3;
        static public string flete_cargo_destino = "0";
        // CARGOS DESTINO

        static public string total_flete_cbm = "0";
        static public string total_otros_costos_cbm = "0";
        static public string total_flete_minimo = "0";
        static public string total_otros_costos_minimos = "0";
        static public string total_otros_costos_flat = "0";
        static public string TotalTarifario = "0";

        // ID
        static public int id_agente_origen=1;
        static public int id_naviero=1;
        static public int id_cargos_en_destino=1;
        static public int id_movimiento_bodega=1;
        static public int id_otras_categorias1=1;
        static public int id_otras_categorias2=1;
        static public int id_otras_categorias3=1;
        static public int id_cargos_destino1=1;
        static public int id_cargos_destino2=1;
        static public int id_cargos_destino3=1;
        static public int id_modalidad;
        static public int id_equipo;
        // ID
    }
}
