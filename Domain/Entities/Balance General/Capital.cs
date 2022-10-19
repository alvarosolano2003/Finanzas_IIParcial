using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Balance_General
{
    public class Capital
    {
        public double CapitalSocial { get; set; }
        public double AccionesDeCadaCapitalSuscrito { get; set; }
        public double AportacionesParaFuturosAumentosDeCapital { get; set; }
        public double PrimaDeVentaDeAcciones { get; set; }
        public double Donaciones { get; set; }
        public double ReservaLegal { get; set; }
        public double ReservaDeReinversionesDeUtilidades { get; set; }
        public double UtilidadesAcumuladas { get; set; }
        public double PerdidaAcumulada { get; set; }
        public double CapitalContable { get; set; }
        public double Otros { get; set; }
        public double Total => CapitalSocial + AccionesDeCadaCapitalSuscrito +
            AportacionesParaFuturosAumentosDeCapital + PrimaDeVentaDeAcciones +
            Donaciones + ReservaLegal + ReservaDeReinversionesDeUtilidades +
            UtilidadesAcumuladas + PerdidaAcumulada + CapitalContable + Otros;
    }
}
