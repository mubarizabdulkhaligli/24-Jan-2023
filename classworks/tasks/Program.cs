using System;

namespace tasks
{
    class Program
    {
        static void Main(string[] args)
        {

            // Task 1.

            int number = 30;
            AddTen(ref number);
            Console.WriteLine(number);



            // Task 2.

            int num2 = 30;
            CorrectPoint(ref num2);
            Console.WriteLine(num2);



            // Task 3.

            int[] array1 = { 1, 2, 8, 5, 18 };
            MakeEvenNums(ref array1);
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }

        }

        // Task 1. Verilmis ededi 10 vahid artiran metod
        static void AddTen(ref int number)
        {
            number = number + 10;
        }

        // Task 2. Gonderilmis deyer menfidirse 0, 100-den coxdursa 100 eden metod
        // 0 - 100 araligindadirsa oldugu kimi qalsin
        static void CorrectPoint(ref int num)
        {
            if (num < 0)
            {
                num = 0;
            }
            if (num > 100)
            {
                num = 100;
            }
        }

        // Task 3. Verilmis ededler siyahisini yalniz cut deyerler qalan yeni bir
        // array-e ceviren metod
        static void MakeEvenNums(ref int[] nums)
        {
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    count++;
                }
            }
            int[] newArray = new int[count];
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    newArray[j] = nums[i];
                    j++;
                }
            }

            nums = newArray;
        }

    }
}
