using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalificacionesArreg
{
    class Program
    {
        //Funcion que calcula y devuelve el promedio
        static double PromedioCalificaciones(double [][] calific, int cantSalones)
        {
            double promedio = 0.0f, suma = 0.0f;
            int contador = 0;

            for(int i = 0; i < cantSalones; i++)
            {
                for(int j = 0; j < calific[i].GetLength(0); j++)
                {
                    suma += calific[i][j];  
                }
               contador += calific[i].GetLength(0);

            }

            promedio = suma / contador;
            return promedio;
        }

        // Funcion que devuelve la minima calificacion
        static double CalificacionMinima(double[][] calific, int cantSalones)
        {
            double minima = 10.0f;

            for (int i = 0; i < cantSalones; i++)
            {
                for (int j = 0; j < calific[i].GetLength(0); j++)
                {
                    if (calific[i][j] < minima)
                    {
                        minima = calific[i][j];
                    }
                }
                
            }

            return minima;
        }

        //Funcion que devuelve la calificacion maxima
        static double CalificacionMaxima(double[][] calific, int cantSalones)
        {
            double maxima = 0.0f;

            for (int i = 0; i < cantSalones; i++)
            {
                for (int j = 0; j < calific[i].GetLength(0); j++)
                {
                    if (calific[i][j] > maxima)
                    {
                        maxima = calific[i][j];
                    }
                }

            }

            return maxima;
        }
        //Funcion principal
        static void Main(string[] args)
        {
            int salones = 0, alumnos = 0;
            double p = 0.0f, max = 0.0f, min = 0.0f;

            //Pedir salones
            Console.Write("Escriba la cantidad de salones de la escuela: ");
            salones = Convert.ToInt32(Console.ReadLine());

            //Creo el arreglo jagged
            double[][] calificaciones = new double[salones][];

            Console.WriteLine();

            //Doy dimensiones al arreglo
            for (int i = 0; i < salones; i++)
            {
                Console.WriteLine("Salon {0}", i + 1);
                Console.Write("Escriba la cantidad de alumnos del salon: ");
                alumnos = Convert.ToInt32(Console.ReadLine());
                calificaciones[i] = new double[alumnos];
            }

            Console.WriteLine();

            //Llenando el arreglo de calificaciones
            for(int i = 0; i < salones; i++)
            {
                Console.WriteLine("Salon {0}", i + 1);
                for(int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    Console.Write("Escriba la calificacion del alumno {0}: ", j + 1);
                    calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine();
            }

            p = PromedioCalificaciones(calificaciones, salones);
            Console.WriteLine("El promedio de calificaciones es: {0}", p);
            Console.WriteLine();

            max = CalificacionMaxima(calificaciones, salones);
            Console.WriteLine("La calificacion maxima es: {0}", max);
            Console.WriteLine();

            min = CalificacionMinima(calificaciones, salones);
            Console.WriteLine("La calificacion minima es: {0}", min);
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
