﻿using System;

namespace NewEnumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("What is your gender? 1 - Male, 2 - Female, 3 - If you dont know (WTF?)");
            string userinput = Console.ReadLine();

            Gender userGender = (Gender)Enum.Parse(typeof(Gender),userinput);

            if(userGender == Gender.Male)
            {
                Console.WriteLine("Only Man Allowed!");
            }else if(userGender == Gender.Female)
            {
                Console.WriteLine("Only Woman Allowed!");
            }
            else
            {
                Console.WriteLine("??");
            }*/

            Car myCar = new Car();
            myCar.Mark = "Fiat";
            myCar.Model = "Bravo II";
            myCar.Weight = 1300;
            myCar.Power = 120;
            myCar.ProductionDate = new DateTime(2009, 6, 12);
            myCar.FirstRegistrationDate = new DateTime(2010, 6, 12);

            myCar.printEverything();

        }
    }
}
