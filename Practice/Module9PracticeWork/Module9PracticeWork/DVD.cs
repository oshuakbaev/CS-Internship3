using System;
using System.Reflection;

namespace Module9PracticeWork
{
	public class DVD : Storage
    {
		public int SpeedOfReadWrite { get; set; }
		protected string Type { get; set; }
        protected int FreeSpace { get; set; }
        protected int VolumeOfDVDDisk { get; set; }

        public DVD(int VolumeOfDVDDisk, int FreeSpace,int SpeedOfReadWrite, string Type,string NameOfDrive, string Model) :base(NameOfDrive,Model)
		{
			this.SpeedOfReadWrite = SpeedOfReadWrite;
			this.Type = Type;
            this.FreeSpace = FreeSpace;
            this.VolumeOfDVDDisk = VolumeOfDVDDisk;
        }

        public string VolumeOfDVD(string type)
        {
            if (type == "one type")
            {
                return "4.7GB";
            }
            else
            {
                return "9GB";
            }
        }

        public override int Volume()
        {
            return VolumeOfDVDDisk;
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

            Console.WriteLine($"Name: {NameOfDrive}, Volume of date: {Volume()}" +
                $"Free Space:{FreeSpace},Speed: {SpeedOfReadWrite},Model:{Model}");

        }
    }
}

