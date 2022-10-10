using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214078
{
    internal class DVD_1214078 : Product_1214078
    {
        protected string duration;

        public DVD_1214078(string title, string duration) //method constructor
        {
            this.MyTitle = title;
            this.MyType = "DVD";
            this.duration = duration;
  
        }
        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }
    }
}
