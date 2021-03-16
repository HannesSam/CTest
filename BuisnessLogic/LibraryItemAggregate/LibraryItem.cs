using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDomain.LibraryItemAggregate
{
    class LibraryItem
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
