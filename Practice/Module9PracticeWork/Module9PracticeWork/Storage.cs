using System;
namespace Module9PracticeWork
{
	public abstract class Storage
	{
		protected string NameOfDrive { get; set; }
        protected string Model { get; set; }


		public Storage(string NameOfDrive, string Model)
		{
			this.NameOfDrive = NameOfDrive;
			this.Model = Model;
		}

		public abstract int Volume();
        public abstract string CopyData();
        public abstract int FreeSpaceInfo();
        public abstract void FullInfoAboutDevice();
    }
}

