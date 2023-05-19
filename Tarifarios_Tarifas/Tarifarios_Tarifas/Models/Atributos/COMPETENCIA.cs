using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tarifarios_Tarifas.Models.Atributos
{
    internal class COMPETENCIA
    {
        public int Id { get; set; }
        public string Nombre {get; set;}

        public float Flete { get; set; }
        public float Cargos_Destino { get; set; }
        public float Otros_Cargos { get; set; }
        public float IVA { get; set; }

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
