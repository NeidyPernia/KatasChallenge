using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numer_to_letter_02
{
    class Program
    {
        

        public void Main(string[] args)
        {
            
            string[] unit = { "", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
            string[] dozen = { "diez", "once", "doce", "trece", "catorce", "quince", "dieciseis", "diecisiete", "dieciocho", "diecinueve", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
            string[] hundred = { "ciento", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos" };
            string[] thousand = { "mil"};

            Console.WriteLine("Menú\n 1) Convertir número a letra.\n 2) Convertir letra a número");
            int opc = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (opc)
            {
                case 1:
                    Console.WriteLine("Digite el número que quiere convertir a letras: ");
                    int num;
                    num = Convert.ToInt32(Console.ReadLine());
                    UnitNumber(num);
                    break;
                case 2:
                    Console.WriteLine("Escriba el número que quiere convertir: ");

                    break;

            }
            Console.ReadKey();
        }
        public int UnitNumber(int a)
        {
            if (a == 1) Console.WriteLine("El número " + a + " se escribe uno");
            if (a == 2) Console.WriteLine("El número " + a + " se escribe dos");
            if (a == 3) Console.WriteLine("El número " + a + " se escribe tres");
            if (a == 4) Console.WriteLine("El número " + a + " se escribe cuatro");
            if (a == 5) Console.WriteLine("El número " + a + " se escribe cinco");
            if (a == 6) Console.WriteLine("El número " + a + " se escribe seis");
            if (a == 7) Console.WriteLine("El número " + a + " se escribe siete");
            if (a == 8) Console.WriteLine("El número " + a + " se escribe ocho");
            if (a == 9) Console.WriteLine("El número " + a + " se escribe nueve");
            return 0;
        }
        

    }
}
