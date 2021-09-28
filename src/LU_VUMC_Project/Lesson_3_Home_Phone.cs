using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace LU_VUMC_Project
{
    class Lesson_3_Home_Phone
    {


        public void Phone()
        {
            var prop = new Lesson_3_Properties("Elvins");

            Console.Write("Enter Phone Brand: ");
            prop.brand = Console.ReadLine();
            Console.Write("Enter Phone Model: ");
            prop.modelPhone = Console.ReadLine();

            Console.Write("Enter Phone size X: ");
            prop.sizeX = int.Parse(Console.ReadLine());
            Console.Write("Enter Phone size Y: ");
            prop.sizeY = int.Parse(Console.ReadLine());

            Console.Write("Enter 'Y' if required for calls: ");
            prop.funcCall = Console.ReadLine();
            Console.Write("Enter 'Y' if required for SMS: ");
            prop.funcSMS = Console.ReadLine();

            Console.WriteLine($"You choice is {prop.brand}, model {prop.modelPhone} with size {prop.sizeX}X{prop.sizeY}, required for Calls: {prop.funcCall} and SMS: {prop.funcSMS}");




        }



       







    }
}
