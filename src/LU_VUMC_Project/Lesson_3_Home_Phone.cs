using System;

namespace LU_VUMC_Project
{
    class Lesson_3_Home_Phone
    {
        public string brand { get; set; } //variable/property
        public string model { get; set; }
        public int sizeX { get; set; }
        public int sizeY { get; set; }
        public string funcCall { get; set; }
        public string funcSMS { get; set; }



        public void getSetBrandFromUser() //Method
        {
            Console.Write("Enter Phone Brand: ");
            brand = Console.ReadLine();
        }

        public void getSetModelFromUser() //Method
        {
            Console.Write("Enter Phone Brand: ");
            model = Console.ReadLine();
        }


        public bool callStart()
        {


            return true;
        }










    }
}
