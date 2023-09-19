
using System;
 
namespace PracticeM3{

	public class Program{

		static void Main(string[] args){
			// 1Напечатать весь массив целых чисе
			// StringAndMassive.Numbers();

			// 2Найти индекс максимального значения в массиве (воспользоваться функцией)
			// Console.WriteLine(StringAndMassive.Max());
			
			// 3 Найти индекс максимального четного значения в массив
			// Console.WriteLine(StringAndMassive.MaxEven());




		}
	}

	// основная функций где находятся задачи  
	public class StringAndMassive{

		// Напечатать весь массив целых чисе
		public static void Numbers(){
			int[] numbers = {50,54,44,55,677,4466,7778};
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.Write(numbers[i]+" "); 
			}
		}

		// 2 Найти индекс максимального значения в массиве (воспользоваться функцией)

		public static int Max(){
			int[] numbers = {50,54,44,55,677,4466,7778};
			int max = numbers[0];

			for (int i = 0; i < numbers.Length; i++)
			{
				if(numbers[i]>max){
					max = numbers[i];
				}
			}
			return max; 
		}

		/*
		3 Найти индекс максимального четного значения в массив
		*/

		public static int MaxEven(){
			int[] numbers = {50,54,44,55,677,4466,7778};
			int max = numbers[0];

			for (int i = 0; i < numbers.Length; i++)
			{
				if(numbers[i]>max && numbers[i]%2==0){
					max = numbers[i];
				}
			}
			return max; 
		}

		// 4 Удалить элемент из массива по индексу.
		/* к сожалению это невозможно,
		 мы создаем еще один массив и вставляем без этого элементы
		 но это не выгодно с одной стороны. 
		*/

		// public static void DeleteElementFromArray(){
			
		// }


   
    }
}


