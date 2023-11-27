using System;

namespace PracticeWithEvgenii
{
    class Program
    {
        
        static void lab1()
        {
            string path = @"C:\Users\lucky\Downloads\TNSShort";
            DirectoryInfo dir = new DirectoryInfo(path);

            if(dir.Exists ) {
                Console.WriteLine("Dir exist");
            }
            else
            {
                Console.WriteLine("Dir doesnt exist");
            }

            Dictionary<string,int> dict = new Dictionary<string,int>();
            int count = 0;

            foreach (FileInfo item in dir.GetFiles())
            {
                if(dict.ContainsKey(item.Extension))
                {
                    dict.Add(item.Extension, count++);
                }

               
            }

            foreach(var item in dict)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            
        }

        static void main(string[] args)
        {
            lab1();
        }
    }
}