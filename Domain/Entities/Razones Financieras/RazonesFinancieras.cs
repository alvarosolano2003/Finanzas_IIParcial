using Domain.Entities.Balance_General;
using Domain.Entities.Estado_de_Resultados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Razones_Financieras
{
    public class RazonesFinancieras
    {
        public double CapitalDeTrabajo { get; set; }
        public double RazonCirculante { get; set; }
        public double RazonRapida { get; set; }
        public double RazonDeInventarios { get; set; }
        public double RotacionDeCuentasPorCobrar { get; set; }
        public double RotacionDeActivosFijos { get; set; }
        public double RotacionDeActivosTotales { get; set; }
        public double RazonDeDeudaTotal { get; set; }
        public double CapacidadDePagoDeInteres { get; set; }
        public double MargenDeUtilidadBruta { get; set; }
        public double MargenDeUtilidadOperativa { get; set; }
        public double MargenDeUtilidadNeta { get; set; }
        public double RendimientoDeLosActivos { get; set; }
        public double RendimientoSobreElCapitalContable { get; set; }
        //public double RazonPrecioUtilidades { get; set; }
        //public double UtilidadesPorAccion { get; set; }
        //public double ValorEnLibros { get; set; }
    }
}
