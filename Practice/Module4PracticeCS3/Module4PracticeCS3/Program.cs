using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace Module4
{
    public class Program
    {
        // пункт d,e
        public static void WriteToFile(List<Animal> animals, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var animal in animals)
                {
                    writer.WriteLine($"{animal.Id},{animal.Name},{animal.Type},{animal.CalculateFoodAmount()}");
                }
            }
        }

        public static List<Animal> ReadFromFile(string fileName)
        {
            List<Animal> animals = new List<Animal>();

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length != 4) // Проверка количества элементов
                        {
                            Console.WriteLine("Incorrect line format.");
                            continue;
                        }

                        if (!int.TryParse(parts[0], out int id)) // Проверка id
                        {
                            Console.WriteLine("Incorrect id format.");
                            continue;
                        }

                        string name = parts[1];
                        string type = parts[2];

                        if (type != "Carnivore" && type != "Omnivore" && type != "Herbivore") // Проверка type
                        {
                            Console.WriteLine("Incorrect animal type.");
                            continue;
                        }

                        Animal animal = null;
                        switch (type)
                        {
                            case "Carnivore":
                                animal = new Carnivore { Id = id, Name = name, Type = type };
                                break;
                            case "Omnivore":
                                animal = new Omnivore { Id = id, Name = name, Type = type };
                                break;
                            case "Herbivore":
                                animal = new Herbivore { Id = id, Name = name, Type = type };
                                break;
                        }

                        if (animal != null)
                        {
                            animals.Add(animal);
                        }

                    }

                    


                }


            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }

            return animals;
        }


        static void Main(string[] args)
        {
            /*
             * 
             * Это задание 1
            Student student1 = new Student("Евгений", "Герцин", 1, new int[] { 5, 5, 5 });
            Console.Write("Name: "+student1.fname);
            Console.WriteLine();
            Console.Write("Surname: "+student1.surname);
            Console.WriteLine();
            Console.Write("Group Number: "+student1.GroupNumber);
            Console.WriteLine();
            Console.Write("academic performance: " + string.Join(",",student1.academicPerf));
            */

            List<Animal> animals = new List<Animal>
            {
                new Carnivore { Id = 1, Name = "Lion", Type = "Carnivore" },
                new Omnivore { Id = 2, Name = "Bear", Type = "Omnivore" },
                new Herbivore { Id = 3, Name = "Cow", Type = "Herbivore" },
                new Carnivore { Id = 4, Name = "Tiger", Type = "Carnivore" },
                new Herbivore { Id = 5, Name = "Zebra", Type = "Herbivore" }
            };

            
            // пункт a
            animals.Sort((a, b) =>
            {
                int foodAmountComparison = b.CalculateFoodAmount().CompareTo(a.CalculateFoodAmount());
                if (foodAmountComparison == 0)
                {
                    return a.Name.CompareTo(b.Name);
                }
                return foodAmountComparison;
            });

           
            Console.WriteLine("Первые 5 животные и их имена:");
            for (int i = 0; i < Math.Min(5, animals.Count); i++)
            {
                Console.WriteLine($"Name: {animals[i].Name}");
            }
            Console.WriteLine();



            // пункт c
            Console.WriteLine("последние 3 животные и их идентификаторы");
            for (int i = Math.Max(0, animals.Count - 3); i < animals.Count; i++)
            {
                Console.WriteLine($"ID: {animals[i].Id}");
            }

            //WriteToFile(animals, "animals.txt");
            animals = ReadFromFile("ReadAnimal.txt");

            // вывод всех животных 
            Console.WriteLine("Все животные: ");
            foreach (var animal in animals)
            {
                Console.WriteLine($"ID: {animal.Id}, Name: {animal.Name}, " +
                    $"Type: {animal.Type}, Food: {animal.CalculateFoodAmount()}");

            }
            Console.WriteLine();

            
        }
    }
    // задание 1
    public class Student
    {
        // создали переменные
        public string fname, surname;
        public int GroupNumber;
        public int[] academicPerf;

        // created constructorс
        public Student(string fname, string surname, int GroupNumber, int[] academicPerf)
        {
            this.fname = fname;
            this.surname = surname;
            this.GroupNumber = GroupNumber;
            this.academicPerf = academicPerf;

        }








    }

    public abstract class Animal
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }


        public abstract int CalculateFoodAmount(); 

    }

    public class Carnivore : Animal{

        public override int CalculateFoodAmount()
        {
            return 10; // Например, хищники едят 10 кг еды в день
        }

    }

    public class Omnivore : Animal {

        public override int CalculateFoodAmount()
        {
            return 5; // Всеядные животные едят 5 кг еды в день
        }
    }

    public class Herbivore : Animal{

        public override int CalculateFoodAmount()
        {
            return 7; // Травоядные животные едят 7 кг еды в день
        }

    }





}