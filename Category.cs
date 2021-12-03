using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oros_Anamaria_Lab8
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
    }
}
