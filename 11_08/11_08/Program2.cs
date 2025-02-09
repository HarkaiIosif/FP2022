﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_08
{
    public class Program2
    {
        static void Main(string[] args)
        {
            //int n = 23;
            //Console.WriteLine($"Numarul de cifre al lui {n} este {NumarCifre(n)}");
            //Console.WriteLine($"Numarul de cifre al lui {n} este {NumarCifreR(n)}");

            //fractie2();

            //F1(5);
            F2(10);
        }

        // TODO: Tema
        /// <summary>
        /// Afisez primele n elemente ale secventei
        /// 1 2 3 3 4 5 4 5 6 7 ... 
        /// </summary>
        /// <param name="v"></param>
        /// <exception cref="NotImplementedException"></exception>
        private static void F2(int v)
        { Console.WriteLine("Introduceti numarul n");
            int contor = 0;
            int n=int.Parse(Console.ReadLine());
            for(int i = 1; i <= v; i++)
            {
                for(int j = i; j <= 2 * i - 1; j++)
                {
                    if (contor < n)
                    {
                        Console.Write($"{j} ");
                        contor++;
                    }
                    else break;
                    
                }
            }
        }

        /// <summary>
        /// pt. n = 4 se afiseaza 
        /// 1
        /// 2 3 
        /// 3 4 5
        /// 4 5 6 7
        /// </summary>
        private static void F1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= 2 * i - 1; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

        private static void fractie2()
        {
            int m = 13, n = 30;
            // TODO aducem fractia la forma ireductibila. 
            int parteInt, parteFract;
            parteInt = m / n; // 0
            parteFract = m % n; // 13
            Console.Write($"{parteInt},");
            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFract);
            bool periodic = false;
            do
            {
                cifra = parteFract * 10 / n;
                cifre.Add(cifra);
                //Console.Write($"{cifra}");
                rest = parteFract * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFract = rest;
            } while (rest != 0);

            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
        }
        private static int NumarCifreR(int n)
        {
            if (n < 10)
                return 1;
            else
                return 1 + NumarCifreR(n / 10);
        }

        public static int NumarCifre(int n)
        {
            int contor = 0;
            if (n == 0)
            {
                return 1;
            }
            n = Math.Abs(n);
            while (n > 0)
            {
                contor++;
                n /= 10;
            }
            return contor;
        }
    }
}


