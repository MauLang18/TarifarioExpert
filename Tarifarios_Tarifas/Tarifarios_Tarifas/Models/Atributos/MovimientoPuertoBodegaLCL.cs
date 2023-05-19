using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Tarifarios_Tarifas.Models.Atributos
{
    internal class MovimientoPuertoBodegaLCL
    {
        public int Id { get; set; }
        public string Proveedor { get; set; }
        public float Transporte_bodega { get; set; }
        public int rodman { get; set; }
        public int cristobal { get; set; }
        public int manzanillo { get; set; }
        public int balboa { get; set; }
    }
}
