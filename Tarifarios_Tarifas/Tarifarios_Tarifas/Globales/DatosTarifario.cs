using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarifarios_Tarifas.Globales
{
    public class DatosTarifario
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
        static public string total;
        // AGENTE ORIGEN

        // FLETE INTERNACIONAL
        static public string naviero;
        static public string flete;
        static public string thc;
        static public string doc_fee;
        static public string security;
        static public string impresion_bl;
        static public string port_facility;
        static public string canal_fee;
        static public string vac;
        static public string impdoc;
        static public string merchant;
        static public string total_flete;
        static public string total_cargos_destino;
        // FLETE INTERNACIONAL

        // TRANSBORDO
        static public string gastos_portuarios_proveedor;
        static public string gastos_portuarios;
        static public string movimiento_puerto_bodega_proveedor;
        static public string movimiento_puerto_bodega;
        static public string otras_categorias_total;
        static public string otras_categorias_producto1;
        static public string otras_categorias_producto2;
        static public string otras_categorias_producto3;
        static public string otros_servicios_producto1;
        static public string otros_servicios_producto2;
        static public string otros_servicios_producto3;
        static public string otros_servicios_total;
        static public string transbordo_total;
        // TRANSBORDO

        // CARGOS DESTINO
        static public string proveedor_cargos_destino1;
        static public string proveedor_cargos_destino2;
        static public string proveedor_cargos_destino3;
        static public string flete_cargo_destino;
        // CARGOS DESTINO

        static public string TotalTarifario="0";

        // ID
        static public int id_agente_origen=1;
        static public int id_naviero=1;
        static public int id_gastos_portuarios=1;
        static public int id_movimiento_puerto_bodega=1;
        static public int id_otras_categorias1=1;
        static public int id_otras_categorias2=1;
        static public int id_otras_categorias3=1;
        static public int id_otros_servicios1=1;
        static public int id_otros_servicios2=1;
        static public int id_otros_servicios3=1;
        static public int id_cargos_destino1=1;
        static public int id_cargos_destino2=1;
        static public int id_cargos_destino3=1;
        static public int id_modalidad;
        static public int id_equipo;
        // ID
    }
}
