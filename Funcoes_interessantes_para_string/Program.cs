﻿using System;

namespace Funcoes_interessantes_para_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde  FGHIJ ABC abc DEFG";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);

            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = string.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");// ToUpper deixa todas as letras em caixa alta
            Console.WriteLine("ToLower: -" + s2 + "-");//ToLower deixa todas as letras em caixa baixa
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOff('bc'): -" + n1 + "-");
            Console.WriteLine("LastIndexOff('bc'): -" + n2 + "-");
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3,5): -" + s5 + "-");
            Console.WriteLine("Replace('a','x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc','xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}
