using System;
using System.Collections.Generic;
using System.Text;

namespace Programacion_Lenguaje1_.NET
{
    class Puntos
    {
        //------------------------------------------------------------ Punto #1
        public void Punto1()
        {
            Console.WriteLine(" ╠════════════════════════════════════════════╣");
            Console.WriteLine(" ║                  PUNTO #1                  ║");
            Console.WriteLine(" ║    Digite un numero para saber si es       ║");
            Console.Write(    " ║    PAR o IMPAR : ");            
            int punto1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ╠═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─╣");

            if ((punto1 % 2) == 0)
            {                
                Console.WriteLine(" ║    Es Par                                  ║");
            }
            else
            {
                Console.WriteLine(" ║    Es Impar                                ║");
            }            
        }
        //------------------------------------------------------------ Punto #2
        public void Punto2()
        {
            Console.WriteLine(" ╠════════════════════════════════════════════╣");
            Console.WriteLine(" ║                  PUNTO #2                  ║");
            Console.WriteLine(" ║    Digite un numero para generar la        ║");
            Console.Write(    " ║    TABLA del numero : ");
            int punto2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ╠═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─╣");
            Console.WriteLine(" ║                                            ║");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(" ║             " + punto2 + " x " + i + " = " + (punto2 * i)+ "                    ║");
            }
            Console.WriteLine(" ║                                            ║");            
        }
        //------------------------------------------------------------ Punto #3
        public void Punto3()
        {
            Console.WriteLine(" ╠════════════════════════════════════════════╣");
            Console.WriteLine(" ║                  PUNTO #3                  ║");
            Console.WriteLine(" ║      Generador de tablas del 2 - 9.        ║");
            

            for (int m = 2; m <= 9; m++)
            {
                Console.WriteLine(" ╠═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─╣");
                Console.WriteLine(" ║                                            ║");
                for (int l = 1; l <= 10; l++)
                {                    
                    Console.WriteLine(" ║             " + m + " x " + l + " = " + (m * l)+ "                     ║");
                }
                Console.WriteLine(" ║                                            ║");
            }                    
        }
        //------------------------------------------------------------ Punto #4
        public void Punto4()
        {
            Console.WriteLine(" ╠════════════════════════════════════════════╣");
            Console.WriteLine(" ║                  PUNTO #4                  ║");
            Console.WriteLine(" ║    Digite un numero para saber si es       ║");
            Console.Write(    " ║    PRIMO o NO : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(" ╠═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─╣");
            bool esPrimo = true;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }

            if (esPrimo)
            {                
                Console.WriteLine(" ║    Es primo                                ║");
            }
            else
            {
                Console.WriteLine(" ║    No es primo                             ║");
            }            
        }
        //------------------------------------------------------------ Punto #5
        public void Punto5()
        {
            Console.WriteLine(" ╠════════════════════════════════════════════╣");
            Console.WriteLine(" ║                  PUNTO #5                  ║");
            Console.WriteLine(" ║    Datos ordenados de forma acendente.     ║");
            Console.WriteLine(" ╠═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─╣");
            Console.WriteLine(" ║                                            ║");
            Console.WriteLine(" ║                Ordenado - Original         ║");

            int[] edad = new int[] { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };
            int[] edad_ori = new int[] { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };
            for (int k = 0; k < edad.Length - 1; k++)
            {
                for (int i = 0; i < edad.Length - 1 - k; i++)
                {
                    if (edad[i] > edad[i + 1])
                    {
                        int num;
                        num = edad[i];
                        edad[i] = edad[i + 1];
                        edad[i + 1] = num;
                    }
                }
            }

            for (int im = 0; im < edad.Length; im++)
            {
                Console.WriteLine(" ║      Pos #" + im + "  ----->  " + edad[im] + " - " + edad_ori[im] + "               ║");
            }
            Console.WriteLine(" ║                                            ║");            
        }
        //------------------------------------------------------------ Punto #6
        public void Punto6()
        {
            Console.WriteLine(" ╠════════════════════════════════════════════╣");
            Console.WriteLine(" ║                  PUNTO #6                  ║");
            Console.WriteLine(" ║    Digite un nombre para buscar y          ║");
            Console.Write(    " ║    verificar si existe : ");

            int[] edad = new int[] { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };
            string[] nombre = new string[] { "Juan", "Maria", "Tereza", "Pedro", "Javier", "Ana", "Diana", "Jorge", "Dayana", "Lady" };
            bool exis = false;            
            string nom_cap = Console.ReadLine();
            Console.WriteLine(" ╠═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─╣");

            for (int i = 0; i < edad.Length; i++)
            {
                if (nom_cap == nombre[i])
                {
                    Console.WriteLine(" ║      El usuario " + nom_cap + " existe                ║");
                    Console.WriteLine(" ║      Su edad es : " + edad[i] + " años                  ║");
                    exis = true;
                }
            }
            if (exis == false)
            {
                Console.WriteLine(" ║      El usuario " + nom_cap + " no existe             ║");
            }
        }
        //------------------------------------------------------------ Punto #7
        public void Punto7()
        {
            Console.WriteLine(" ╠════════════════════════════════════════════╣");
            Console.WriteLine(" ║                  PUNTO #7                  ║");
            Console.WriteLine(" ║    Busqueda del usuario con menor edad     ║");
            Console.WriteLine(" ║    y con mayor edad en el vector.          ║");
            Console.WriteLine(" ╠═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─╣");

            int edad_ma = 0, edad_me = 100, pos_ma = 0, pos_me = 0;
            int[] edad = new int[] { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };
            string[] nombre = new string[] { "Juan", "Maria", "Tereza", "Pedro", "Javier", "Ana", "Diana", "Jorge", "Dayana", "Lady" };

            for (int i = 0; i < edad.Length; i++)
            {
                if (edad[i] > edad_ma)
                {
                    edad_ma = edad[i];
                    pos_ma = i;
                }
                if (edad[i] < edad_me)
                {
                    edad_me = edad[i];
                    pos_me = i;
                }

            }
            Console.WriteLine(" ║   /\\                                       ║ ");
            Console.WriteLine(" ║  /──\\    El usuario " + nombre[pos_ma]+ "                  ║");
            Console.WriteLine(" ║   ║║     Edad mayor con " + edad_ma + " años            ║ ");
            Console.WriteLine(" ║   ──                                       ║ ");
            Console.WriteLine(" ╠═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─╣");
            Console.WriteLine(" ║   ──                                       ║ ");
            Console.WriteLine(" ║   ║║    El usuario " + nombre[pos_me] + "                   ║");
            Console.WriteLine(" ║  \\──/   Edad menor con " + edad_me + " años             ║ ");
            Console.WriteLine(" ║   \\/                                       ║ ");
        }
        //------------------------------------------------------------ Punto #8
        public void Punto8()
        {
            Console.WriteLine(" ╠════════════════════════════════════════════╣");
            Console.WriteLine(" ║                  PUNTO #8                  ║");
            Console.WriteLine(" ╠═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─╣");
            Console.WriteLine(" ║    Digite una palabra para determinar si   ║");
            Console.Write(    " ║    es PALINDROME o no lo es : ");
            string str = "";            
            string s = Console.ReadLine();
            Console.WriteLine(" ╠═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─╣");
            int i = s.Length;
            for (int c = i - 1; c >= 0; c--)
            {
                str = str + s[c];
            }
            if (str == s)
            {                
                Console.WriteLine(" ║         » " + s + " « es Palindrome");
            }
            else
            {                
                Console.WriteLine(" ║         » " + s + " « no es Palindrome");
            }
            Console.WriteLine(" ╠═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─╣");
            Console.WriteLine(" ║         Palabra inversa ---> " + str);
        }
        //------------------------------------------------------------ Punto #9
        public void Punto9()
        {
            Console.WriteLine(" ╠════════════════════════════════════════════╣");
            Console.WriteLine(" ║                  PUNTO #9                  ║");
            Console.WriteLine(" ║    Digite el limite de la Sucesion de      ║");
            Console.Write(    " ║    Fibonachi : ");
            int Ant = 0, Sig = 1, Res = 0, num = 0;
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(" ╠═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─╣");
            Console.WriteLine(" ║    » " + Res + "                                     ║");
            for (int i = num; i > Res; i--)
            {                
                Res = Ant + Sig;
                Ant = Sig;
                Sig = Res;
                Console.WriteLine(" ║    » " + Res + "                                     ║");
            }
            if (num == Res)
            {
                Console.WriteLine(" ║    » " + num );
                Console.WriteLine(" ╠═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─╣");
                Console.WriteLine(" ║    #" + num + " Pretenece a la Sucecion de Fibonachi║");
            }
            else
            {
                Console.WriteLine(" ║    » " + num);
                Console.WriteLine(" ╠═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─╣");
                Console.WriteLine(" ║    #" + num + " No pretenece a la Sucecion de Fibonachi║");
            }
        }
        //------------------------------------------------------------ Punto #10 
        public void Punto10()
        {            
            Impresion impre = new Impresion();
            String nom = "";
            String ape = "";
            String ced = "";
            Int32 sal_net = 0;
            double porcent = 0;
            int sal_min = 1014980;
            double salud = 0;
            double pension = 0;
            double arl = 0;

            string caj_com;
            string caj_comp;
            double caja_comp = 0;

            Console.WriteLine(" ╠════════════════════════════════════════════╣");
            Console.WriteLine(" ║                  PUNTO #10                 ║");
            Console.WriteLine(" ╠════════════════════════════════════════════╣");
            Console.WriteLine(" ║             PAGO DE PARAFISCALES           ║");
            Console.WriteLine(" ╠═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─╣");
            Console.WriteLine(" ║                                            ║");
            Console.WriteLine(" ║   Ingrese los datos solicitados para       ║");
            Console.WriteLine(" ║   realizar su respectiva cuenta de cobro.  ║");
            Console.WriteLine(" ║                                            ║");
            Console.WriteLine(" ╠═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─╣");
            Console.WriteLine(" ║                                            ║");            
            do
            {
                Console.Write(" ║   Digite su Nombre : ");
                nom = Console.ReadLine();
            } while (nom==String.Empty);

            do
            {               
                Console.Write(" ║   Digite su Apellido : ");
                ape = Console.ReadLine();
            } while (ape==String.Empty);

            do
            {
                Console.Write(" ║   Digite su Cedula : ");
                ced = Console.ReadLine();
            } while (ced == String.Empty);

            do
            {
                Console.Write(" ║   Digite su Salario neto : ");
                sal_net = Int32.Parse(Console.ReadLine());
            } while (sal_net == 0);

            porcent = sal_net * 0.4;
            if (porcent <= sal_min)
            {
                salud = (sal_net * 12.5) / 100;
                pension = sal_net * 0.16;
                arl = sal_net * 0.522;
                impre.imprimir();
                caj_com = Console.ReadLine();
                Console.WriteLine(" ╠═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─╣");

                if (caj_com == "S" || caj_com == "s")
                {
                    Console.WriteLine("        Aporta");
                    caja_comp = sal_net * 0.4;
                    caj_comp = "Aporta";
                }
                else
                {
                    Console.WriteLine("       No aporta");
                    caj_comp = "No aporta";
                }
            }            
            else
            {
                salud = (porcent * 12.5) / 100;
                pension = porcent * 0.16;
                arl = porcent * 0.255;
                impre.imprimir();
                caj_com = Console.ReadLine();
                Console.WriteLine(" ╠═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─╣");

                if (caj_com == "S" || caj_com == "s")
                {
                    Console.WriteLine("                      Aporta");
                    caja_comp = porcent * 0.4;
                    caj_comp = "Aporta";
                }
                else
                {
                    Console.WriteLine("       No aporta");
                    caj_comp = "No aporta";
                }
                
                Console.WriteLine(" ╠═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─╣");
                Console.WriteLine(" ║                                            ║");
                Console.WriteLine(" ║   Señor/a " + nom + " " + ape + " ");
                Console.WriteLine(" ║   Identificado con C.C. " + ced); 
                Console.WriteLine(" ║                                            ║");
                Console.WriteLine(" ║   Segun su salario neto su aporte a        ║");
                Console.WriteLine(" ║   parafiscales es de la siguiente manera:  ║");
                Console.WriteLine(" ║                                            ║");
                Console.WriteLine(" ║   Salario neto:               "+sal_net);
                Console.WriteLine(" ║   Salud:                      "+salud);
                Console.WriteLine(" ║   Pension                     "+pension);
                Console.WriteLine(" ║   ARL                         "+arl);
                Console.WriteLine(" ║   Caja de compensacion :      "+caj_com);
                Console.WriteLine(" ║                                            ║");
            }
        }
    }
}
