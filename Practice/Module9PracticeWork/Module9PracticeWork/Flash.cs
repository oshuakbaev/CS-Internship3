using System;
using System.Reflection;

namespace Module9PracticeWork
{
    public class Flash : Storage
    {
        public int USB3_0 { get; set; }
        protected int VolumeOfDate { get; set; }
        protected int FreeSpace { get; set; }

        public Flash(int FreeSpace, int USB3_0, int VolumeOfDate, string NameOfDrive, string Model) : base(NameOfDrive, Model)
        {
            this.USB3_0 = USB3_0;
            this.VolumeOfDate = VolumeOfDate;
            this.FreeSpace = FreeSpace;
        }

        public override int Volume()
        {
            return VolumeOfDate;
        }

        public override string CopyData()
        {
            return "данные скопированы";
        }

        public override int FreeSpaceInfo()
        {
            return FreeSpace;
        }

        public override void FullInfoAboutDevice()
        {

            Console.WriteLine($"Name: {NameOfDrive}, Volume of date: {VolumeOfDate}" +
                $"Free Space:{FreeSpace},Speed: {USB3_0},Model:{Model}");

        }


    }

}