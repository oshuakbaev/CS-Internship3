using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13HW
{
    internal class Client
    {
        private int id; 
        public string Name { get; set; }
        public string TypeOfWork { get; set; }

        public int Id
        {
            get { return id; }
            private set
            {
                id = value;
            }
        }

        public Client(string name, string typeOfWork) {
            
            this.Name = name;
            this.TypeOfWork = typeOfWork;
            id += 1;
        }


         


    }
}
