using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Model
{
    public class DisplayBook : DisplayLibraryItem
    {
        [Required]
        public string Author { get; set; }
        [Required]
        public int Pages { get; set; }

    }
}
