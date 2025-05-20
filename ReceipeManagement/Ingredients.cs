using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poedraft
{
   public class Ingredients
    {
        // Declarations
        private string name;
        private double quantity;
        private string unitOfMeasurement;
        private int calories;
        private string foodGroup;

        /* creating get and set methodsfor the variables declared in the beginning*/
        public string Name
        {
            get { return name; }
            set { name = value; }
        } // (Troelsen & Japikse, 2021)
        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public string UnitOfMeasurement
        {
            get { return unitOfMeasurement; }
            set { unitOfMeasurement = value; }
        }
        public int Calories
        {
            get { return calories; }
            set { calories = value; }
        }// (Troelsen & Japikse, 2021)
        public string FoodGroup
        {
            get { return foodGroup; }
            set { foodGroup = value; }
        }
    }
}

