using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expo_del_dia_sabado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingresa el costo inicial del artículo: ");
            double costoInicial = double.Parse(Console.ReadLine());
            Console.Write("ingresa la vida útil en meses: ");
            int vidaUtil = int.Parse(Console.ReadLine());
            Console.Write("ingresa el mes para calcular la depreciación: ");
            int mes = int.Parse(Console.ReadLine());

            // usando Math.Pow para calcular la depreciación
            double depreciacion = costoInicial * Math.Pow(1 - 1.0 / vidaUtil, mes);

            // calcula la calificacion
            string calificacion = "";

            if (depreciacion <= 500)
            {
                calificacion = "A";
            }
            else if (depreciacion <= 750)
            {
                calificacion = "B";
            }
            else if (depreciacion > 750)
            {
                calificacion = "C";
            }
            else
            {
                calificacion = "intente denuev";
            }

            Console.WriteLine("el valorr depreciado es: " + depreciacion);
            Console.WriteLine("la calificación es: " + calificacion);
            Console.ReadKey();
        }
    }
}
