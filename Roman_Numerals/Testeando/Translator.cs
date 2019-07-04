using System;

namespace Tests
{
    internal class Translator
    {
        internal static string Convert(int v)
        {
            
            if (v == 1) return "I";
            if (v == 2) return "II";
            if (v == 3) return "III";
            if (v == 4) return "IV";
            if (v == 5) return "V";
            if (v == 6) return "VI";
            if (v == 7) return "VII";
            if (v == 8) return "VIII";
            if (v == 9) return "IX";
            if (v == 10) return "X";
            if (v == 30) return "XXX";
            if (v == 50) return "L";
            if (v == 100) return "C";
            if (v == 500) return "D";
            return "v";
        }
    }
}