using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_to_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] unit = { "", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
            string[] dozen = { "diez", "", "doce", "trece", "catorce", "quince", "dieci", "veinte", "venti", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa"};
            string[] hundred = { "cien", "ciento", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos" };
            string[] thousand = { "mil", "dos mil", "tres mil", "cuatro mil", "cinco mil", "seis mil", "siete mil", "ocho mil", "nueve mil" };
            string[] million = { "un millon", "millones"};

            int number, option;

            string letter;
            Console.WriteLine("Menú");
            Console.WriteLine("1. Convertir número a letra");
            Console.WriteLine("2. Convertir letra a número");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Inserte el número que desea cambiar a letras: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    switch (number)
                    { 
                        case 1:
                            Console.WriteLine("Este número se escribe de la siguiente manera:\n{0}", unit[1]);
                            break;

                    }
                    break;
                case 2:
                    Console.WriteLine("Escriba en letras el número que desea vizalizar: ");
                    letter = Console.ReadLine();

                    break;
            }

            Console.ReadKey();


        }
    }
}
