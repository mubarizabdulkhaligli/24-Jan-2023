using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 8, 9, 90};

            int value = 5;

            AddNewElement(ref array, value);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        // Task 1.  - Verilmiş int array-ə verilmiş int dəyəri əlavə edən metod.
        // Misalçün metodu çağırıb array elementimi və 5 dəyəri göndərsəm,
        // arrayim dəyişilməli və arrayin  içində əvəlki elementləri,
        // əlavə olaraq son indexində isə 5 elementi olmalıdır və arrayin uzunluğu 1 vahid artmış olmalıdır.

        static void AddNewElement(ref int[] array, int value)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                count++;
            }

            int [] newArray=new int [count+1];
            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                newArray[j] = array[i];
                j++;
            }

            newArray[newArray.Length - 1] = value;

            array = newArray;
        }
    }
}

