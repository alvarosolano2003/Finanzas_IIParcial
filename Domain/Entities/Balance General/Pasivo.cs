using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Balance_General
{
    public class Pasivo
    {
        // Pasivos Circulantes
        public double Proveedores { get; set; }
        public double CuentasPorPagar { get; set; }
        public double ImpuestosAcumulados { get; set; }
        public double EfectosACortoPlazo { get; set; }
        public double Acreedores { get; set; }
        public double RemuneracionesPendientesDePago { get; set; }
        public double TotalPC => Proveedores + CuentasPorPagar +
            ImpuestosAcumulados + EfectosACortoPlazo + Acreedores +
            RemuneracionesPendientesDePago;

        // Pasivos No Circulantes
        public double ProvisionesLP { get; set; }
        public double DeudasLP { get; set; }
        public double DeudasConEntidadesDelGrupo { get; set; }
        public double Periodificaciones { get; set; }
        public double TotalPNC => ProvisionesLP + DeudasLP +
            DeudasConEntidadesDelGrupo + Periodificaciones;

        // Otros Pasivos
        public double Otros { get; set; }

        //Suma Total
        public double Total => TotalPC + TotalPNC + Otros;
    }
}
