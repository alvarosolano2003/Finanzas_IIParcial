using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Estado_de_Resultados
{
    public class CuentasER
    {
        public double Ventas { get; set; }
        public double CostoDeVentas { get; set; }
        public double UtilidadBruta => Ventas - CostoDeVentas;
        public double GastosDeVenta { get; set; }
        public double GastosAdministrativos { get; set; }
        public double GastosFinancieros { get; set; }
        public double GastosIntereses { get; set; }
        public double GastosOperativos => GastosDeVenta + GastosAdministrativos +
            GastosFinancieros + GastosIntereses;
        public double UtilidadAntesDeImpuestos => UtilidadBruta - GastosOperativos;
        public double ImpuestosSobreLaRenta => UtilidadAntesDeImpuestos * 0.3;
        public double UtilidadNeta => UtilidadAntesDeImpuestos - ImpuestosSobreLaRenta;
    }
}
