using System;

namespace uppgift4_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj ett av följande alternativ.(skriv nummer)");
            Console.WriteLine("1. Subtrahera ett tal med ett annat");
            Console.WriteLine("2. Dividera ett tal med ett annat");
            Console.WriteLine("3. Avsluta programmet");
            int val = int.Parse(Console.ReadLine());
            int tal1;
            int tal2;

            Console.WriteLine("Skriv din första tal");
            tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv din andra tal");
            tal2 = int.Parse(Console.ReadLine());

            switch (val)
            {
                case 1:
                    int summa = tal1 - tal2;
                    Console.WriteLine(summa);
                    break;
                case 2:
                    summa = tal1 / tal2;
                    Console.WriteLine(summa);
                    break;
                case 3:
                    Console.WriteLine("Du avslutade programet");
                    break;
            }
            Console.WriteLine("Om du vill försäta skriv 1 eller 2 om du avsluta skirv 3");
            val = int.Parse(Console.ReadLine());

            while (val != 3)
            {
                if (val == 1 || val == 2)
                {
                    Console.WriteLine("Skriv din första tal");
                    tal1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv din andra tal");
                    tal2 = int.Parse(Console.ReadLine());

                    switch (val)
                    {
                        case 1:
                            int summa = tal1 - tal2;
                            Console.WriteLine("Summan är " + summa + ".");
                            break;
                        case 2:
                            summa = tal1 / tal2;
                            Console.WriteLine("Summan är " + summa + ".");
                            break;
                        case 3:
                            Console.WriteLine("Du avslutade programet");
                            break;
                    }
                    Console.WriteLine("1. Subtrahera ett tal med ett annat");
                    Console.WriteLine("2. Dividera ett tal med ett annat");
                    Console.WriteLine("3. Avsluta programmet");
                    val = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}