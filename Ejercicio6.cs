using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_5
{
    class Práctica_5_6
    {
        static double Promedio(double[] calificaciones)
        {

            foreach (double a in calificaciones)
            {
                Console.WriteLine(a);
            }

        }
        static void Main(string[] args)
        {
            double[] notas;
            int cantidad, i;
            Console.WriteLine("Ingrese la cantidad de estudiantes:");
            cantidad = Convert.ToInt32(Console.ReadLine());
            notas = new double[cantidad];
            for (i = 1; i <= cantidad; i++)
            {
                Console.WriteLine("Ingrese la nota del estudiante #{0}", i);
                double valor = Convert.ToDouble(Console.ReadLine());
                notas[i] = valor;
            }

        }
    }
}

