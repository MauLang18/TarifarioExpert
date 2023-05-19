using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tarifarios_Tarifas.Models.Atributos
{
    internal class COMPETIDORES
    {
        public int Id { get; set; }

        public string Proveedor_Agente_Origen { get; set; }
        public float Manejos_Agente_Origen { get; set; }
        public float Hbl_Agente_Origen { get; set; }
        public float Agente_Origen_Total { get; set; }

        public string Proveedor_Flete_Internacional { get; set; }
        public float Thc_Flete_Internacional { get; set; }
        public float Doc_Fee_Flete_Internacional { get; set; }
        public float Security_Flete_Internacional { get; set; }
        public float Impresion_Bl_Flete_Internacional { get; set; }
        public float Port_Facility_Flete_Internacional { get; set; }
        public float Canal_Fee_Flete_Internacional { get; set; }
        public float Vac_Flete_Internacional { get; set; }
        public float Impdo_Flete_Internacional { get; set; }
        public float Merchant_Flete_Internacional { get; set; }
        public float Flete_Internacional_Total { get; set; }
        public float Flete_Internacional_Destino { get; set; }

        public string Proveedor_Gastos_Portuarios { get; set; }
        public float Manejos_Puerto_Gastos_Portuarios { get; set; }
        public float Gastos_Portuarios_Total { get; set; }

        public string Proveedor_Movimiento_Puerto_Bodega { get; set; }
        public float Transporte_Puerto_Movimiento_Puerto_Bodega { get; set; }
        public float Movimiento_Puerto_Bodega_Total { get; set; }

        public string Proveedor_Otras_Categorias1 { get; set; }
        public string Producto_Otras_Categorias1 { get; set; }
        public float Costos_Otras_Categorias1 { get; set; }
        public string Proveedor_Otras_Categorias2 { get; set; }
        public string Producto_Otras_Categorias2 { get; set; }
        public float Costos_Otras_Categorias2 { get; set; }
        public string Proveedor_Otras_Categorias3 { get; set; }
        public string Producto_Otras_Categorias3 { get; set; }
        public float Costos_Otras_Categorias3 { get; set; }
        public float Otras_Categorias_Total { get; set; }

        public string Proveedor_Otros_Servicios1 { get; set; }
        public string Producto_Otros_Servicios1 { get; set; }
        public float Costos_Otros_Servicios1 { get; set; }
        public string Proveedor_Otros_Servicios2 { get; set; }
        public string Producto_Otros_Servicios2 { get; set; }
        public float Costos_Otros_Servicios2 { get; set; }
        public string Proveedor_Otros_Servicios3 { get; set; }
        public string Producto_Otros_Servicios3 { get; set; }
        public float Costos_Otros_Servicios3 { get; set; }
        public float Otros_Servicios_Total { get; set; }

        public string Proveedor_Cargos_Destino1 { get; set; }
        public string Proveedor_Cargos_Destino2 { get; set; }
        public string Proveedor_Cargos_Destino3 { get; set; }
        public float Costo_Cargos_Destino1 { get; set; }
        public float Costo_Cargos_Destino2 { get; set; }
        public float Costo_Cargos_Destino3 { get; set; }
        public float Cargos_Detino_Total { get; set; }

        public int Id_Agente_Origen { get; set; }
        public int Id_Naviero { get; set; }
        public int Id_Gastos_Portuarios { get; set; }
        public int Id_Movimiento_Puerto_Bodega { get; set; }
        public int Id_Otras_Categorias1 { get; set; }
        public int Id_Otras_Categorias2 { get; set; }
        public int Id_Otras_Categorias3 { get; set; }
        public int Id_Otros_Servicios1 { get; set; }
        public int Id_Otros_Servicios2 { get; set; }
        public int Id_Otros_Servicios3 { get; set; }
        public int Id_Cargos_Destino1 { get; set; }
        public int Id_Cargos_Destino2 { get; set; }
        public int Id_Cargos_Destino3 { get; set; }

        public string Desde { get; set; }
        public string Hasta { get; set; }
        public float Total { get; set; }

        public string Modalidad { get; set; }
        public string Equipo { get; set; }
        public int Id_Modalidad { get; set; }
        public int Id_Equipo { get; set; }
        public string Ruta { get; set; }
    }
}
