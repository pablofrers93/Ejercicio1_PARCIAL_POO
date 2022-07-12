using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ejercicio1_PARCIAL_POO
{
    public class Fecha
    {
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }

        public static explicit operator Fecha(string fecha)
        {
            string[] numeros = fecha.Split(',');

            return new Fecha(Convert.ToInt32(numeros[0]), Convert.ToInt32(numeros[1]), Convert.ToInt32(numeros[2]));
        }
        public Fecha(int dia, int mes, int anio)
        {
            Dia = dia;
            Mes = mes;
            Anio = anio;
        }

        public Fecha()
        {
            Dia = DateTime.Now.Day;
            Mes = DateTime.Now.Month;
            Anio = DateTime.Now.Year;
        }

        public void MostrarFecha()
        {
            Console.WriteLine($"{Dia}/{Mes}/{Anio}");
        }

        public void MostrarFechaMesPalabra()
        {
            string nombreMes = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Mes);
            Console.WriteLine(Dia.ToString() + "/" + nombreMes + "/" + Anio.ToString());
        }
        //<>
        public bool Validar()
        {
            // Todos los meses con 31 dias
            if(Mes==01 || Mes==03 || Mes==05 || Mes==07 || Mes==08 || Mes==10 || Mes==12)
            {
                if (Dia >= 1 && Dia <= 31)
                {
                    if (Anio >= 1 && Anio <= DateTime.Now.Year)
                        return true;
                }
                // Todos los meses con 30 dias
                else if (Mes==04 || Mes==06 || Mes==09 || Mes==11)
                {
                    if (Dia >= 1 && Dia <= 30)
                    {
                        if (Anio >= 1 && Anio <= DateTime.Now.Year)
                            return true;
                    }
                }
                // Febrero con 28 dias
                else if (Mes==02)
                {
                    if (Dia >= 1 && Dia <= 28)
                    {
                        if (Anio >= 1 && Anio <= DateTime.Now.Year)
                            return true;
                    }
                }
            }

            return false;              
        }
        //
        public static bool operator ==(Fecha fecha1, Fecha fecha2)
        {
            return (fecha1.Anio == fecha2.Anio && 
                    fecha1.Mes == fecha2.Mes && 
                    fecha1.Dia == fecha2.Dia);
        }
        public static bool operator !=(Fecha fecha1, Fecha fecha2)
        {
            {
                return (fecha1.Anio != fecha2.Anio ||
                        fecha1.Mes != fecha2.Mes ||
                        fecha1.Dia != fecha2.Dia);
            }
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Fecha))
            {
                return false;
            }

            return this.Dia == ((Fecha)obj).Dia &&
                   this.Mes == ((Fecha)obj).Mes &&
                   this.Anio == ((Fecha)obj).Anio;
        }

        public static void CompararFechas(Fecha fecha1, Fecha fecha2)
        {
            if (fecha1 == fecha2)
                Console.WriteLine("Las fechas son iguales");
            else
                Console.WriteLine("Las fechas son distintas");
        }
    }
}
