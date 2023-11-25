using System;


namespace Module9PracticeWork
{
    class Program
    {
        public static void Main(string[] args)
        {
            // общий обьем данных
            HDD hdd = new HDD(300, 100, 4, 30000, "C", "ApacerS2345");
            Flash flash = new Flash(322, 244, 7000, "Fleshka", "hyperSuperKZ-444");
            DVD dvd = new DVD(3000, 1000, 100, "one type", "DVDDisk", "nikon");


            // копирование данных
            Console.WriteLine("Расчет количество всех устройства:" + hdd.Volume(), dvd.Volume(), flash.Volume());
            Console.WriteLine($"Копирование информаций на жестком :{hdd.CopyData()}" +
                $"\n Копирование информаций на диске: {dvd.CopyData()}" +
                $"\n Копирование информаций на флешку {flash.CopyData()}\n");

            // расчет времени для копирование

            Console.WriteLine($"расчет времени для hdd:{hdd.Volume()/hdd.Speed} sec");
            Console.WriteLine($"расчет времени для hdd:{dvd.Volume()/dvd.SpeedOfReadWrite} sec");
            Console.WriteLine($"расчет времени для hdd:{flash.Volume()/flash.USB3_0} sec");

            // расчет носителей 
            List<object> list = new List<object>();

            list.Add(hdd);
            list.Add(dvd);
            list.Add(flash);

            Console.WriteLine(list.Count);





        }
    }
}