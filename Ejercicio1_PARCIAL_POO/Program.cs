using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio1_PARCIAL_POO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fecha fecha1 = new Fecha();
            Fecha fecha2 = new Fecha(15,08,2021);
            string fechaString = "15,08,2022";

            fecha1.MostrarFecha();
            fecha2.MostrarFecha();

            fecha1.MostrarFechaMesPalabra();
            Fecha.CompararFechas(fecha1, fecha2);

            fecha2 = (Fecha)fechaString;
            fecha2.MostrarFecha();

            Console.ReadLine();

        }
    }
}
