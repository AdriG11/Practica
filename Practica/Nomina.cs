using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Nomina
    {
        private int diasLaborados;
        public int DiasLaborados { get; set; }

        //Metodo para calcular Nomina

        public decimal CalcularNomina(int diasLab,decimal valorDia)
        {
            decimal totalSalario = diasLab * valorDia;
            return totalSalario;
        }
    }
}
