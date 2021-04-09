using System;

namespace Programacion_Lenguaje1_.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Puntos puntos = new Puntos();
            Impresion imprimir = new Impresion();
            int op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(" ╔════════════════════════════════════════════╗");
                Console.WriteLine(" ║                 BIENVENIDO                 ║");
                Console.WriteLine(" ╠════════════════════════════════════════════╣");
                Console.WriteLine(" ║ ■  1 «-- Par o Impar                       ║");
                Console.WriteLine(" ║ ■  2 «-- Tabla de multiplicar              ║");
                Console.WriteLine(" ║ ■  3 «-- Tablas del 2 al 9                 ║");
                Console.WriteLine(" ║ ■  4 «-- Primo o no Primo                  ║");
                Console.WriteLine(" ║ ■  5 «-- Ordenar vector                    ║");
                Console.WriteLine(" ║ ■  6 «-- Leer un nombre si existe          ║");
                Console.WriteLine(" ║ ■  7 «-- Menor y mayor edad del vector     ║");
                Console.WriteLine(" ║ ■  8 «-- Palindromo                        ║");
                Console.WriteLine(" ║ ■  9 «-- Sucecion de Fibonachi             ║");
                Console.WriteLine(" ║ ■ 10 «-- Parafiscales                      ║");
                Console.WriteLine(" ╠═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─╣");
                Console.WriteLine(" ║ ■ 11 «-- Salir                             ║");
                Console.WriteLine(" ╠════════════════════════════════════════════╣");
                Console.WriteLine(" ║ Digite una de las opciones mostradas       ║");
                Console.Write(    " ║ anteriormente : ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        puntos.Punto1();
                        imprimir.Limpiar();
                        break;
                    case 2:
                        puntos.Punto2();
                        imprimir.Limpiar();
                        break;
                    case 3:
                        puntos.Punto3();
                        imprimir.Limpiar();
                        break;
                    case 4:
                        puntos.Punto4();
                        imprimir.Limpiar();
                        break;
                    case 5:
                        puntos.Punto5();
                        imprimir.Limpiar();
                        break;
                    case 6:
                        puntos.Punto6();
                        imprimir.Limpiar();
                        break;
                    case 7:
                        puntos.Punto7();
                        imprimir.Limpiar();
                        break;
                    case 8:
                        puntos.Punto8();
                        imprimir.Limpiar();
                        break;
                    case 9:
                        puntos.Punto9();
                        imprimir.Limpiar();
                        break;
                    case 10:
                        puntos.Punto10();
                        imprimir.Limpiar();
                        break;
                    default:

                        break;
                }
            } while (op != 11);
        }
    }
}
