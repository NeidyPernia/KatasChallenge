using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_to_letters_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] unit = { "", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
            string[] dozen = { "diez", "once", "doce", "trece", "catorce", "quince", "dieciseis", "diecisiete", "dieciocho", "diecinueve", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
            string[] hundred = { "ciento", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos" };
            string[] thousand = { "mil", "dos mil", "tres mil", "cuatro mil", "cinco mil" };

            
            Console.WriteLine("Menu:\n 1) Convertir el números a letras\n 2) Convertir de letras a números");
            int opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine("Digite el número que desea convertir a letras: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num > 0 && num <= 9)
                    {

                    }
                    break;
                case 2:
                    Console.WriteLine("Escriba el número que desea convertir a números: ");
                    break;
            }

        }
    }
}
