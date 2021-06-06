using System;
using System.Collections.Generic;
using System.Text;

namespace NewEnumTest
{
    class Car
    {
       
        //private string mark;
        //private string model;
        private int weight;
        private int power;
        private DateTime productionDate;
        private DateTime firstRegistrationDate;

        public string Mark { get; set; }
        public string Model { get; set; }



        public void printEverything()
        {
            Console.WriteLine($"Car: {Mark} {Model}");
            Console.WriteLine($"Power: {Power} HP");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Production date: {ProductionDate.ToString()}");
            Console.WriteLine($"First registration date: {FirstRegistrationDate}");
        }








        // Getters and Setters
        public DateTime FirstRegistrationDate
        {
            get { return firstRegistrationDate; }
            set
            {
                if (value > DateTime.Now || value < ProductionDate)
                {
                    Console.WriteLine("Wrong production Date!");
                }
                else
                {
                   firstRegistrationDate = value;
                }
            }

        }
     
        //public string Mark
        //{
        //    get { return mark; }
        //    set { mark = value; }
        //}

        //public string Model
        //{
        //    get { return model; }
        //    set { model = value; }
        //}

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Power
        {
            get { return power; }
            set { power = value; }
        }

        public DateTime ProductionDate
        {
            get { return productionDate; }
            set
            {
                if (value > DateTime.Now)
                {
                    Console.WriteLine("Wrong production Date!");
                }
                else
                {
                    productionDate = value;
                }
            }
        }
     


    }
}
