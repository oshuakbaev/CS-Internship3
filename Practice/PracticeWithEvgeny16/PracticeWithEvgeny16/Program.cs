using System;

namespace PracticeWithEvgenii
{
    class Program
    {

        static void lab1()
        {
            string path = @"C:\Users\lucky\Downloads\TNSShort";
            DirectoryInfo dir = new DirectoryInfo(path);

            if (dir.Exists)
            {
                Console.WriteLine("Dir exist");
                Dictionary<string, int> dict = new Dictionary<string, int>();
                int count = 0;

                foreach (FileInfo item in dir.GetFiles())
                {
                    if (!dict.ContainsKey(item.Extension))
                    {
                        dict.Add(item.Extension, count++);
                    }


                }

                foreach (var item in dict)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }

                Console.WriteLine("choose file extens");
                string input = Console.ReadLine();


                List<string> list = new List<string>();

                list.AddRange(input.Split(','));

                Dictionary<char, char> dictChar = new Dictionary<char, char>();
                foreach(string item in list)
                {
                    foreach(FileInfo file in dir.GetFiles("," + item))
                    {
                        Console.WriteLine(file.FullName);

                        foreach(char letter in file.Name)
                        {
                            if(!(letter >= 192 && letter <= 255))
                            {
                                if(dictChar.Contains)
                                dictChar.Add(letter, '');
                            }
                        }
                    }
                }


            }
            else
            {
                Console.WriteLine("Dir doesnt exist");
            }

           


        }

        static void Main(string[] args)
        {
            lab1();
        }
    }
}