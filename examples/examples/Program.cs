using System;

namespace examples
{
	class Program
	{
		static void Main(string[] args)
		{
			string str = "      Hello World!   ";
			string str1 = "Hello World!";

			// clone - stringi klonlayir
			Console.WriteLine(str.Clone());

			// Compare to - stringleri muqayise edir, eynidirse 0, ferqlidirse 1 qaytarir
			Console.WriteLine(str1.CompareTo(str));

			// Contains - verilen yazinin stringin icinde olub olmadigini yoxlayir
			Console.WriteLine(str.Contains("ell"));


			// EndWith - stringin sonu verilen yazi ile bitib bitmediyini yoxlayir
			Console.WriteLine(str.EndsWith("orld!"));

			// Equals - stringleri muqayise edir, eynidirse true, ferqlidirse false qaytarir
			Console.WriteLine(str.Equals(str1));

			// GetHashCode - stringin HashCode nu qaytarir
			Console.WriteLine(str.GetHashCode());


			// GetType - tipini qaytarir (system.string)
			Console.WriteLine(str.GetType());

			// GetTypeCode - tipini qaytarir (string)
			Console.WriteLine(str.GetTypeCode());

			// IndexOf - axtarilan deyer stringde ilk hansi indeksde varsa hemin indeksi qaytarir
			Console.WriteLine(str.IndexOf("e"));

			//To Lower - stringi kicik herflerle qaytarir
			Console.WriteLine(str.ToLower());

			//To Upper - stringi boyuk herflerle qaytarir
			Console.WriteLine(str.ToUpper());

			//Insert - stringe substring elave edir
			Console.WriteLine(str.Insert(12, "Salam"));

			// LastIndexOf - axtarilan deyer stringde son hansi indeksde varsa hemin indeksi qaytarir
			Console.WriteLine(str.LastIndexOf("o"));

			// Length - stringin uzunlugunu qaytarir
			Console.WriteLine(str.Length);

			//Remove - verilen indexden verilen index-e qeder silib geri qalan stringi qaytarir
			Console.WriteLine(str.Remove(1, 5));

			//Replace - verilen yazilari deyisir
			Console.WriteLine(str.Replace("Hello", "Salam"));

			//Split - stringi verilen deyere gore bolur

			string[] strings = str.Split(new char[] { ' ' } );

			Console.WriteLine(strings[0]);
			Console.WriteLine(strings[1]);


			// StartsWith - stringin evveli verilen yazi ile basladigini yoxlayir
			Console.WriteLine(str.StartsWith("Hell"));

			// Substring - verilen indeksden verilen indeks qeder kesib qaytarir
			Console.WriteLine(str.Substring(1,5));


			// ToCharArray - char arrayine cevirir
			Console.WriteLine(str.ToCharArray());

			// Trim - stringin evvelinde ve sonunda olan elave bosluqlari silir
			Console.WriteLine(str.Trim());

			
			Console.WriteLine(char.IsDigit('1'));

			Console.WriteLine(char.IsLetter('A'));

			Console.WriteLine(char.IsLetterOrDigit('-'));

			Console.WriteLine(char.IsLower('A'));

			Console.WriteLine(char.ToUpper('a'));

			Console.WriteLine(char.IsNumber('A'));


			int[] numbers = { 23, 46, 89, 87, 46};

			int index = Array.IndexOf(numbers, 89);

			Console.WriteLine(index);


			int indexx = Array.LastIndexOf(numbers, 46);

			Console.WriteLine(indexx);

			Array.Reverse(numbers);

			for (int i = 0; i < numbers.Length; i++)
			{
				Console.WriteLine(numbers[i]);
			}

			Array.Sort(numbers);
			Array.Clear(numbers, 0, 1);

			for (int i = 0; i < numbers.Length; i++)
			{
				Console.WriteLine(numbers[i]);
			}
		}
	}
}

