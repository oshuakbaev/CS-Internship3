using System;
namespace Module9PracticeWork
{
	public class HDD : Storage
	{
		public int Speed { get; set; }
		protected int CountOfPartition { get; set; }
		protected int VolumeOfPartition { get; set; }
        protected int FreeSpace { get; set; }

        
        public HDD(int FreeSpace, int Speed, int CountOfPartition, int VolumeOfPartition,string NameOfDrive,string Model) : base(NameOfDrive,Model)
		{
			this.Speed = Speed;
			this.CountOfPartition = CountOfPartition;
			this.VolumeOfPartition = VolumeOfPartition;
            this.FreeSpace = FreeSpace;
            
        }

        public override int Volume()
        {
            return this.CountOfPartition * this.VolumeOfPartition;
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

            Console.WriteLine($"Name: {NameOfDrive}, Volume of date: {CountOfPartition*VolumeOfPartition}" +
                $"Free Space:{FreeSpace},Speed: {Speed},Model:{Model}");

        }
    }
}

