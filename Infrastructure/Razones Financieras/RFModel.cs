using Domain.Entities.Balance_General;
using Domain.Entities.Estado_de_Resultados;
using Domain.Entities.Razones_Financieras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Razones_Financieras
{
    public class RFModel : BaseModel<RazonesFinancieras>
    {
        public RazonesFinancieras CalcularRazones(BalanceGeneral bg, CuentasER re)
        {
            Activo act = bg.Activo;
            Pasivo pas = bg.Pasivo;
            Capital cap = bg.Capital;

            RazonesFinancieras rf = new RazonesFinancieras();

            rf.CapitalDeTrabajo = act.TotalAC - pas.TotalPC;

            rf.RazonCirculante = act.TotalAC / pas.TotalPC;

            rf.RazonRapida = (act.TotalAC - act.Caja) / pas.TotalPC;

            rf.RotacionDeCuentasPorCobrar = re.Ventas / act.CuentasDeExistencia;

            rf.RotacionDeActivosFijos = re.Ventas / act.TotalANC;

            rf.RotacionDeActivosTotales = re.Ventas / act.Total;

            rf.RazonDeDeudaTotal = pas.Total / act.Total;

            rf.CapacidadDePagoDeInteres = re.UtilidadAntesDeImpuestos / re.GastosIntereses;

            rf.MargenDeUtilidadBruta = (re.Ventas - re.CostoDeVentas) / re.Ventas;

            rf.MargenDeUtilidadOperativa = (re.Ventas - re.CostoDeVentas - re.GastosOperativos) / re.Ventas;

            rf.MargenDeUtilidadNeta = re.UtilidadNeta / re.Ventas;

            rf.RendimientoDeLosActivos = re.UtilidadBruta / act.Total;

            rf.RendimientoSobreElCapitalContable = re.UtilidadNeta / cap.CapitalContable;

            return rf;
        }
    }
}
