using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Balance_General
{
    public class BalanceGeneral
    {
        public string? NombreDeLaEmpresa { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public Activo? Activo { get; set; }
        public Pasivo? Pasivo { get; set; }
        public Capital? Capital { get; set; }
    }
}
