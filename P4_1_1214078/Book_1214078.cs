using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214078
{
    internal class Book_1214078 : Product_1214078 //INI BASE CLASS
    {
        protected string pageCount;

        public Book_1214078(string type, string title, string pagecount) : base(type, title)
        {
            //this.MyType = type;
            //this.MyTitle = title;
            this.pageCount = pagecount;

            
        }

        public string PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }
    }
}
