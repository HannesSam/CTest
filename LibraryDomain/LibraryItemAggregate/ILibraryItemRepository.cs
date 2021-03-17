﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDomain.LibraryItemAggregate
{
    public interface ILibraryItemRepository
    {
        IQueryable<LibraryItem> LibraryItems { get; }
        IQueryable<Category> Categories { get; }
        public bool AddLibraryItem(LibraryItem libraryItem);
    }
}
