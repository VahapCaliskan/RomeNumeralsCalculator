using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomeNumeralsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arabische Zahlen zu Römischen Zahlen: 1");
            Console.WriteLine("Römische Zahlen zu Arabischen Zahlen: 2");
            string sInput = Console.ReadLine();
            if (sInput == "1")
            {
                Console.WriteLine("Bitte gebe die gewünschte arabische Zahl ein:");
                Console.WriteLine(ToRome(Int32.Parse(Console.ReadLine())));
            }
            else if (sInput == "2")
            {
                Console.WriteLine("Bitte gebe die gewünschte römische Zahl ein:");
                Console.WriteLine(ToArabic(Console.ReadLine()).ToString());
            }
            else { return; }
        }
        public static string ToRome(int iArabicNumeral)
        {
            if ((iArabicNumeral < 1) || (iArabicNumeral >= Int32.MaxValue)) { return ""; }
            string sResult = "";

            while (iArabicNumeral >= 1000) { iArabicNumeral -= 1000; sResult += "M"; }
            if (iArabicNumeral >= 900) { iArabicNumeral -= 500; sResult += "CM"; }
            while (iArabicNumeral >= 500) { iArabicNumeral -= 500; sResult += "D"; }
            if (iArabicNumeral >= 400) { iArabicNumeral -= 400; sResult += "CD"; }
            while (iArabicNumeral >= 100) { iArabicNumeral -= 100; sResult += "C"; }
            if (iArabicNumeral >= 90) { iArabicNumeral -= 90; sResult += "XC"; }
            while (iArabicNumeral >= 50) { iArabicNumeral -= 50; sResult += "L"; }
            if (iArabicNumeral >= 40) { iArabicNumeral -= 40; sResult += "XL"; }
            while (iArabicNumeral >= 10) { iArabicNumeral -= 10; sResult += "X"; }
            if (iArabicNumeral >= 9) { iArabicNumeral -= 9; sResult += "IX"; }
            while (iArabicNumeral >= 5) { iArabicNumeral -= 5; sResult += "V"; }
            if (iArabicNumeral >= 4) { iArabicNumeral -= 4; sResult += "IV"; }
            while (iArabicNumeral >= 1) { iArabicNumeral -= 1; sResult += "I"; }

            return sResult;
        }

        public static int ToArabic(string sRomeNumeral)
        {
            if (String.IsNullOrEmpty(sRomeNumeral)) { return 0; }
            int iResult = 0;

            while (sRomeNumeral.StartsWith("M")) { iResult += 1000; sRomeNumeral = sRomeNumeral.Substring(1); }
            if (sRomeNumeral.StartsWith("CM")) { iResult += 900; sRomeNumeral = sRomeNumeral.Substring(2); }
            while (sRomeNumeral.StartsWith("D")) { iResult += 500; sRomeNumeral = sRomeNumeral.Substring(1); }
            if (sRomeNumeral.StartsWith("CD")) { iResult += 400; sRomeNumeral = sRomeNumeral.Substring(2); }
            while (sRomeNumeral.StartsWith("C")) { iResult += 100; sRomeNumeral = sRomeNumeral.Substring(1); }
            if (sRomeNumeral.StartsWith("XC")) { iResult += 90; sRomeNumeral = sRomeNumeral.Substring(2); }
            while (sRomeNumeral.StartsWith("L")) { iResult += 50; sRomeNumeral = sRomeNumeral.Substring(1); }
            if (sRomeNumeral.StartsWith("XL")) { iResult += 40; sRomeNumeral = sRomeNumeral.Substring(2); }
            while (sRomeNumeral.StartsWith("X")) { iResult += 10; sRomeNumeral = sRomeNumeral.Substring(1); }
            if (sRomeNumeral.StartsWith("IX")) { iResult += 9; sRomeNumeral = sRomeNumeral.Substring(2); }
            while (sRomeNumeral.StartsWith("V")) { iResult += 5; sRomeNumeral = sRomeNumeral.Substring(1); }
            if (sRomeNumeral.StartsWith("IV")) { iResult += 4; sRomeNumeral = sRomeNumeral.Substring(2); }
            while (sRomeNumeral.StartsWith("I")) { iResult += 1; sRomeNumeral = sRomeNumeral.Substring(1); }

            return iResult;
        }
    }
}
