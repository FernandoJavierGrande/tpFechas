using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpFechas.clases
{
    internal class ModificarFecha
    {
        Fecha fecha;
        int dia, mes, anio, sigDia, sigMes, sigAnio;

        public ModificarFecha()
        {
            fecha = new Fecha();
            fecha.Dia = 01;
            fecha.Mes = 01;
            fecha.Anio = 1900;
            fecha.ControlError = true;
        }

        public Fecha AumentarUnDia(Fecha fechaIngresada)
        {
            int maxDias;
            dia = fechaIngresada.Dia;
            mes = fechaIngresada.Mes;
            anio = fechaIngresada.Anio;
            

            switch (mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    maxDias = 31;
                    break;
                case 04:
                case 06:
                case 09:
                case 11:
                    maxDias = 30;
                    break;
                case 02:
                    maxDias = 28;
                    if ( anio%4 == 0)
                    {
                        maxDias = 29;
                    }
                    break;
                default:
                    maxDias = 0;
                    fecha.ControlError = false;
                    break;
            }

            if (dia == maxDias)
            {
                dia = 1;
                if (mes == 12)
                {
                    mes = 1;
                    anio ++;
                }
                else
                {
                    mes++;
                }
            }
            else if(dia<maxDias && dia > 0)
            {
                dia++;
            }
            else
            {
                fecha.ControlError = false; 
            }

            fecha.Mes = mes;
            fecha.Dia = dia;
            fecha.Anio = anio;


            return fecha;
        }
    }
}
