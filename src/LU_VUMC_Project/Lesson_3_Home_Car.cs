using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LU_VUMC_Project
{
    class Lesson_3_Home_Car
    {

        public void Car()
        {
            var prop = new Lesson_3_Properties("Elvins");

            Console.Write("Enter Car Model: ");
            prop.modelCar = Console.ReadLine();

            Console.WriteLine($"Your car is: {prop.modelCar}");
        }


    }
}
