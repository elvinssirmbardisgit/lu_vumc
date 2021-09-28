using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LU_VUMC_Project
{
    class Lesson_5
    {
        public void Lesson_5_Method()
        {

            int[] nums = new int[3];
            string[] texts = new string[2];

            nums[0] = 14;
            nums[1] = 27;


            int[] nums2 = { 14, 27, 0 };

            foreach (var num in nums)
            {
                Console.WriteLine($"Massive number: {num}");
            }


            for (int i = 0; i < nums2.Length; i++)
            {
                int num = nums2[i];
                Console.WriteLine($"Hello from for: {num}");
            }

            Console.WriteLine("==================================");

            int j = 0;
            while (j < nums2.Length)
            {
                int num = nums2[j];
                Console.WriteLine($"Hello from while: {num}");

                j++;
            }

            Console.ReadKey();
        }

        private static int GetSafeUserNumber()
        {
            int number;
            bool isCorrectNumber;

            do
            {
                Console.WriteLine("Ievadi skaitli?");

                string numberText = Console.ReadLine();

                isCorrectNumber = int.TryParse(numberText, out number);

            } while (!isCorrectNumber);

            return number;
        }






    }
}
