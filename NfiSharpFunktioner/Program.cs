using System;

namespace NfiSharpFunktioner
{
    class Program
    {
        static string GetBestPlayerEverInThatJersey(int jerseyNumber)
        {
            if (jerseyNumber == 13) return "Mats Sundin";
            if (jerseyNumber == 19) return "Bäckis";
            if (jerseyNumber == 21) return "Foppa";
            return "";
        }



        static int CalculateSalary(int hourlySalary, int hoursWorked, int age)
        {
            if (age > 47)
                hourlySalary = 120;
            int mySalary = hourlySalary * hoursWorked;
            return mySalary;
        }

        static void RitaHuvudmeny()
        {
            Console.WriteLine("1. 342234");
            Console.WriteLine("2. dasjk");
            Console.WriteLine("3. Avsluta");
        }

        //static void Test(int i)
        //{
        //    i = i + 1;
        //}


        static string PrintMessage()
        {
            return "Hello World!";
        }


        static decimal CalculateVat(decimal priceWithoutVat)
        {
            return priceWithoutVat * 0.25m;
        }


        static string ConcatenateStrings(string s1, string s2)
        {
            if (s1 == "Stefan ")
            {
                s1 = "Stefan Superstar ";
            }
            string resultat = s1 + s2;
            return resultat;
        }

        static void Main(string[] args)
        {
            string namn = "Stefan ";
            string namn2 = "Holmberg";
            string fillname = ConcatenateStrings(namn,namn2);


            decimal d = 123;

            decimal vat = d *0.25m;
            decimal vat2 = CalculateVat(d);


            int aa = 12+12;
            int bb = aa;
            string s = PrintMessage();





            int i = 123;
//            Test(i);
            Console.WriteLine(i);


            RitaHuvudmeny();


            while (true)
            {
                Console.WriteLine("Hurt gammal ör du");
                int stefanAge = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Hurt mycket tjänar du i timmen");
                int hourlySalary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hurt många timmar");
                int hoursWorked = Convert.ToInt32(Console.ReadLine());

                int mySalary = CalculateSalary(hourlySalary, hoursWorked, stefanAge);
                Console.WriteLine($"Salary:{mySalary}");

            }



            // 10000000

            Console.WriteLine("Hello World!");
        }
    }
}
