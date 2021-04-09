using System;
using System.Collections.Generic;
using System.Text;

namespace Programacion_Lenguaje1_.NET
{
    class Impresion
    {
        public void Limpiar()
        {
            Console.WriteLine(" ╠═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─╣");
            Console.WriteLine(" ║    Presione enter para salir al menu       ║");
            Console.WriteLine(" ╚════════════════════════════════════════════╝");
            Console.ReadLine();
        }

        public void imprimir()
        {
            Console.WriteLine(" ╠═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─╣");
            Console.WriteLine(" ║  ¿ Usted aporta a Caja de Compenzacion ?   ║");
            Console.WriteLine(" ║  ■  S/s «-- SI                             ║");
            Console.WriteLine(" ║  ■  N/n «-- NO                             ║");
            Console.WriteLine(" ╠═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─╣");
            Console.Write(" ║  ■  ");
        }
    }
}
