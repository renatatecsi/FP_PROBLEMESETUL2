using System;

namespace ProblemeSetul2
{
    class Program
    {
        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            //P6();
            //P7();
            //P8();
            //P9();
            //P10();
            
        }

        private static void P10()
        {
            //nr maxim de numere conscutive egale
            int a, b, c;
            string line;
            Console.WriteLine("Dati un sir de 3 numere:");
            line = Console.ReadLine();
            char[] sep = { ' ', ';', ',' };
            string[] tokens = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            a = int.Parse(tokens[0]);
            b = int.Parse(tokens[1]);
            c = int.Parse(tokens[2]);

            for (int i =0; i < tokens.Length; i++)
            {
                if (i == a || i == b || i == c)
                {
                    i++;
                }
                Console.WriteLine(i);
            }

        }

        private static void P9()
        {
            //secventa monoton crescatoare sau descrescatoare

            string secventa;

            Console.WriteLine("Dati un sir de 3 numere:");
            secventa = Console.ReadLine();

            var odineCrescatoare = string.Join("", secventa.OrderBy(i => int.Parse(i.ToString())));
            var ordineDescrescatoare = string.Join("", secventa.OrderByDescending(i => int.Parse(i.ToString())));
            if (secventa == odineCrescatoare)
            {
                Console.WriteLine("Secventa monoton crescatoare.");
            }
            else if(secventa == ordineDescrescatoare)
            {
                Console.WriteLine("Secventa monoton descrescatoare.");
            }
            else
            {
                Console.WriteLine("Nu este o secvenat monotona.");
            }
        }

        static int GetNthFibonacci(int n)
        {
            if (n <= 1) return 0;

            int First = 0, Second = 1, Current;

            for (int i = 3; i < n; i++)
            {
                Current = First + Second;
                First = Second;
                Second = Current;
            }

            return First + Second;
        }

        private static void P8()
        {
            //det. al n-lea nr dintr-o secventa Fibonacci
            int n;

            Console.WriteLine("Valoarea lui n: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numarul din sirul lui Fibonacci este la pozitia {0}: {1}", n, GetNthFibonacci(n));
        }

        private static void P7()
        {
            // cea mai mica si cea mai mare valoare din secventa
            int a, b, c;
            string line;
            Console.WriteLine("Dati un sir de 3 numere:");
            line = Console.ReadLine();
            char[] sep = { ' ', ';', ',' };
            string[] tokens = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            a = int.Parse(tokens[0]);
            b = int.Parse(tokens[1]);
            c = int.Parse(tokens[2]);

            int minim, maxim;
            minim = Math.Min(a, Math.Min(b, c));
            maxim = Math.Max(b, Math.Max(c, a));
            Console.WriteLine($"{minim} {a + b + c - minim - maxim} {maxim}");
        }

        private static void P6()
        {
            //ordine crescatoare
            
            string secventa;

            Console.WriteLine("Dati un sir de 3 numere:");
            secventa = Console.ReadLine();

            var odineCrescatoare = string.Join("", secventa.OrderBy(i => int.Parse(i.ToString())));

            if (secventa == odineCrescatoare)
            {
                Console.WriteLine("Ordonate crescator.");
            }
            else
            {
                Console.WriteLine("Nu sunt ordonate crescator.");
            }
        }

        private static void P5()
        {
            // cate dintre elem unei secv sunt = cu pozitia lor
            Console.WriteLine("Dati 3 numere:");
            string n = Console.ReadLine();

            int index = n.IndexOfAny("0123456789".ToCharArray());
            
            for (int i = 0; i <= index; i++)
            {
                if (i == index)
                {
                    i++;
                }
                Console.WriteLine(i);
            }
        }

        private static void P4()
        {
            // secventa de n numere, pozitia numar a, daca a nu este return -1

            Console.WriteLine("Dati 3 numere:");
            string n = Console.ReadLine();
            
            Console.WriteLine("a:");
            string a = Console.ReadLine();
            int index = n.IndexOf(a);
            Console.WriteLine(index);
        }

        private static void P3()
        {
            Console.WriteLine("Cel mai mic numar din secventa: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Cel mai mare numar din secventa: ");
            int b = int.Parse(Console.ReadLine());
            int suma = 0;
            for (int n = 1; n <= b; n++)
            {
                suma += n;
            }
            Console.WriteLine($"Suma numerelor de la 1 la n este: {suma}");
        }

        private static void P2()
        {
            Console.WriteLine("Cel mai mic numar din secventa: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Cel mai mare numar din secventa: ");
            int b = int.Parse(Console.ReadLine());
            int n = 0;
            int negativ = 0;
            int pozitiv = 0;
            int zero = 0;
            for (n = a; n <= b; n++)
            {
                if (n < 0)
                    negativ++;
                if (n > 0)
                    pozitiv++;
                if (n == 0)
                    zero++;
            }
            Console.WriteLine($"Total numere negative: {negativ} \nTotal numere pozitive: {pozitiv} \nToatal numere egale cu zero: {zero}");
        }

        private static void P1()
        {
            Console.WriteLine("Cel mai mic numar din secventa: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Cel mai mare numar din secventa: ");
            int b = int.Parse(Console.ReadLine());
            int n = 0;
            int par = 0;
            Console.WriteLine("Numere pare:");
            for (n = a; n <= b; n++)
            { 
                if (n % 2 == 0)
                    par++;
            }
            Console.Write($"{par}");
        }
    }
}