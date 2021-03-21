using LibraryDomain.LibraryItemAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Components
{
    public class LibraryItemsPageData
    {
        public static string Message { get; set; } = "hejsan";

        public static List<LibraryItem> LibraryItems { get; set; }
    }
}
