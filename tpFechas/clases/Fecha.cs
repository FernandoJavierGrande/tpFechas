using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpFechas.clases
{
    internal class Fecha
    {
        private int dia;
        private int mes;
        private int anio;
        private bool controlError;

        public int Dia { get => dia; set => dia = value; }
        public int Mes { get => mes; set => mes = value; }
        public int Anio { get => anio; set => anio = value; }
        public bool ControlError { get => controlError; set => controlError = value; }
    }
}
