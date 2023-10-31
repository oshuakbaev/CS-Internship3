using System;


namespace Module8PracticeWithEvgeni
{
    class Program
    {
        static void Main(string[] args) { 
            
         /*  RangeOfArray rangeOfArray = new RangeOfArray();

            Console.WriteLine(rangeOfArray.ToString());

            Console.WriteLine(rangeOfArray[0]); */


            SuperMarket superMarket = new SuperMarket();

            Console.WriteLine(superMarket[1]);

        }


    }

    class Products
    {

        public int categories { get; set; }
        public double price { get; set; }
        public string name { get; set; }


    }

    class SuperMarket
    {
        
        List<Products> products = null;

        public SuperMarket() {
        
            products = new List<Products>();
            products.Add(new Products()
            {
                price = 1000, categories = 1
            });
            products.Add(new Products()
            {
                price = 1000,
                categories = 2
            });

        }    

        public double this[int category]
        {
            get
            {
                double sum = 0;

                TimeSpan start = new TimeSpan(8,0,0);
                TimeSpan end = new TimeSpan(12,0,0);


                foreach (Products p in products.Where(w=>w.categories == category))
                {
                    sum += p.price;
                }

                if (DateTime.Now.TimeOfDay > start && DateTime.Now.TimeOfDay < end)
                {
                    return sum * 0.95;
                }
                else
                {
                    return sum; 
                }
            }
        }
    }
    class Sentence
    {
        string[] words = "The quick brown fox.".Split();


        public string this[int wNum]
        {
            get
            {
                return words[wNum];
            }

            set
            {
                words[wNum] = value;
            }
        }
    }

    class RangeOfArray
    {
        int[] arr1 = null; 
       

        public RangeOfArray()
        {
            arr1 = new int[10];

            Random random = new Random();

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = random.Next(1,20);
            }

        }

        public override string ToString()
        {

            string result = "";

            for (int i = 0; i < arr1.Length; i++)
            {
                result += arr1[i] + " ";
            }
            return result;

        }
        public int this[int wNum]
        {

            get
            {
                if (wNum < 0 ||  wNum > arr1.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                return arr1[wNum];
            }

        }

    }
}