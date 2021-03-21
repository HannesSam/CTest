using LibraryDomain.LibraryItemAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDomain.DTOs
{
    public class LibraryItemDTO
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

    }
}
