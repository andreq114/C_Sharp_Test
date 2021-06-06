using System;
using System.Collections.Generic;
using System.Text;

namespace NewEnumTest
{
    class Car
    {
       
        private string mark;
        private string model;
        private int weight;
        private int power;
        private DateTime productionDate;
        private string firstRegistrationDate;

        public string FirstRegistrationDate
        {
            get { return firstRegistrationDate; }
            set { firstRegistrationDate = value; }

        }
     
        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

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
        /*

        // Setters
        public void setMark(string carMark)
        {
            mark = carMark;
        }
        public void setModel(string carModel)
        {
            model = carModel;
        }
        public void setWeight(int carWeight)
        {
            if(carWeight <= 0)
            {
                Console.WriteLine("Wrong weight!");
            }
            else
            {
                weight = carWeight;
            }
           
        }
        public void setPower(int carPower)
        {
            if (carPower <= 0)
            {
                Console.WriteLine("Wrong weight!");
            }
            else
            {
                power = carPower;
            }
        }
        */
        public void setProductionDate(DateTime data)
        {
            if(data > DateTime.Now)
            {
                Console.WriteLine("Wrong production Date!");
            }
            else
            {
                productionDate = data;
            }
            
        }
        /*
        //Getters
        public string getMark()
        {
            return mark;
        }
        public string getModel()
        {
            return model;
        }

        public int getWeight()
        {
            return weight;
        }

        public int getPower()
        {
            return power;
        }
        */
        public DateTime getProductionDate()
        {
            return productionDate;
        }
        
     


    }
}
