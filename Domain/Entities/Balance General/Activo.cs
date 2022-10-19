using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Balance_General
{
    public class Activo
    {
        // Activos Circulantes
        public double Caja { get; set; }
        public double Banco { get; set; }
        public double Deudores { get; set; }
        public double CuentasDeExistencia { get; set; }
        public double ValoresNegociales { get; set; }
        public double Inversiones { get; set; }
        public double TotalAC => Caja + Banco + Deudores + CuentasDeExistencia +
            ValoresNegociales + Inversiones;

        // Activos No Circulantes
        public double Terrenos { get; set; }
        public double Construcciones { get; set; }
        public double Maquinaria { get; set; }
        public double Mobiliario { get; set; }
        public double Equipos { get; set; }
        public double ElementosDeTransporte { get; set; }
        public double TotalANC => Terrenos + Construcciones + Maquinaria +
            Mobiliario + Equipos + ElementosDeTransporte;

        // Otros Activo
        public double Otros { get; set; }

        // Suma Total
        public double Total => TotalAC + TotalANC;
    }
}
    
