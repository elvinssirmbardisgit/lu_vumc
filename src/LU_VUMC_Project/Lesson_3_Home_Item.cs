using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LU_VUMC_Project
{
    class Lesson_3_Home_Item
    {

        public void Item()
        {
            var prop = new Lesson_3_Properties("Elvins");

            Console.Write("Enter Item Name: ");
            prop.itemName = Console.ReadLine();

            Console.Write("Enter Item Size X: ");
            prop.itemSizeX = Console.ReadLine();
            Console.Write("Enter Item Size Y: ");
            prop.itemSizeY = Console.ReadLine();
            Console.Write("Enter Item Size Z: ");
            prop.itemSizeZ = Console.ReadLine();
            Console.Write("Enter Item Weight: ");
            prop.itemWeight = Console.ReadLine();

            Console.WriteLine($"Your Item is: {prop.itemName} with dimensions: {prop.itemSizeX}X{prop.itemSizeY}X{prop.itemSizeZ} and weight: {prop.itemWeight}");
        }









    }
}
