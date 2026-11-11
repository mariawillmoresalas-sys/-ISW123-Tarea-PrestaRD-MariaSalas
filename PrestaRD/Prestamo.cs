using System;
using System.Collections.Generic;
using System.Text;

namespace PrestaRD
{
    public class Prestamo
    {

        public string Cliente { get; set; } = "";
        public string Tipo { get; set; } = "";
        public decimal Monto { get; set; }
        public int Plazo { get; set; }
        public decimal Cuota { get; set; }
        public bool Aprobado { get; set; }

        public override string ToString() =>
            $"{Cliente,-16} {Tipo,-11} RD$ {Monto,13:N2} {Plazo,3}m  {(Aprobado ? "APROBADO" : "RECHAZADO")}";
    }
}
