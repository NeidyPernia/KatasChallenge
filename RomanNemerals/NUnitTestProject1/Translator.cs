using System;

namespace Tests
{
    internal class Translator
    {
        internal static string Convert(int v)
        {
            int i;
            int[] num = {1,2,3};
            string[] rom = {"I","II","III"};
            for (i = 0; i <= 2; i++)
                if (v == num[i]) return rom[i];
            int[] num1 = { 10, 20, 30 };
            string[] rom1 = { "X", "XX", "XXX" };
            for (i = 0; i <= 2; i++)
                if (v == num1[i]) return rom1[i];
            return rom[i];
        }
    }
}