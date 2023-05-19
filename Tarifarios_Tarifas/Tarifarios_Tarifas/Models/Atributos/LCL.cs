using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tarifarios_Tarifas.Models.Atributos
{
    internal class LCLtarifarios
    {
        public int Id { get; set; }

        public string Proveedor_Agente_Origen { get; set; }
        public float Manejos_Agente_Origen { get; set; }
        public float Hbl_Agente_Origen { get; set; }

        public string Proveedor_Flete_Internacional { get; set; }
        public float Thc_Cbm_Flete_Internacional { get; set; }
        public float Thc_Minimo_Flete_Internacional { get; set; }
        public float Vgm_Minimo_Flete_Internacional { get; set; }
        public float Bunker_Cbm_Flete_Internacional { get; set; }
        public float Bunker_Minimo_Flete_Internacional { get; set; }
        public float Sed_Minimo_Flete_Internacional { get; set; }
        public float Tica_Minimo_Flete_Internacional { get; set; }
        public float Forwarding_Minimo_Flete_Internacional { get; set; }
        public float Manejos_Minimo_Flete_Internacional { get; set; }
        public float Carga_Peligrosa_Flete_Internacional { get; set; }

        public string Proveedor_Cargos_En_Destino { get; set; }
        public float Costos_Cargos_En_Destino { get; set; }

        public string Proveedor_Movimiento_Bodega { get; set; }
        public float Transporte_Bodega_Movimiento_Bodega { get; set; }

        public string Proveedor_Otras_Categorias1 { get; set; }
        public string Producto_Otras_Categorias1 { get; set; }
        public float Costos_Otras_Categorias1 { get; set; }
        public string Proveedor_Otras_Categorias2 { get; set; }
        public string Producto_Otras_Categorias2 { get; set; }
        public float Costos_Otras_Categorias2 { get; set; }
        public string Proveedor_Otras_Categorias3 { get; set; }
        public string Producto_Otras_Categorias3 { get; set; }
        public float Costos_Otras_Categorias3 { get; set; }

        public string Proveedor_Cargos_Destino1 { get; set; }
        public string Proveedor_Cargos_Destino2 { get; set; }
        public string Proveedor_Cargos_Destino3 { get; set; }
        public float Costo_Cargos_Destino1 { get; set; }
        public float Costo_Cargos_Destino2 { get; set; }
        public float Costo_Cargos_Destino3 { get; set; }

        public int Id_Agente_Origen { get; set; }
        public int Id_Naviero { get; set; }
        public int Id_Gastos_Portuarios { get; set; }
        public int Id_Movimiento_Puerto_Bodega { get; set; }
        public int Id_Otras_Categorias1 { get; set; }
        public int Id_Otras_Categorias2 { get; set; }
        public int Id_Otras_Categorias3 { get; set; }
        public int Id_Cargos_Destino1 { get; set; }
        public int Id_Cargos_Destino2 { get; set; }
        public int Id_Cargos_Destino3 { get; set; }

        public string Desde { get; set; }
        public string Hasta { get; set; }

        public string Modalidad { get; set; }
        public string Equipo { get; set; }
        public int Id_Modalidad { get; set; }
        public int Id_Equipo { get; set; }
        public string Ruta { get; set; }

        public float Total_Flete_Cbm { get; set; }
        public float Total_Flete_Minimo { get; set; }
        public float Total_Otros_Costos_Cbm { get; set; }
        public float Total_Otros_Costos_Minimos { get; set; }
        public float Total_Otros_Costos_Flat { get; set; }
    }
}
