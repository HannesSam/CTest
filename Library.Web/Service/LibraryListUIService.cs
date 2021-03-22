using Library.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Web.Service
{
    /// <summary>
    /// Denna klass agerar som hjälpklasser åt vårat UI.
    /// </summary>
    public class LibraryListUIService
    {
        // Denna sträng håller ett meddelande om nyligen lyckade eller misslyckade operationer som visas i UIt.
        public string Message { get; set; }

        public List<LibraryItem> LibraryItems { get; set; }

        public List<Category> Categories { get; set; }

        public event Action RefreshRequested;

        // Denna funktion ger alla LibraryItems ett kategori namn. 
        public void AssignCategoryNamesToLibraryItems()
        {
            foreach (var LibraryItem in LibraryItems)
            {
                LibraryItem.CategoryName = Categories.Where(c => c.Id == LibraryItem.CategoryId).Select(c => c.CategoryName).FirstOrDefault();
            }
        }

        public void CallRequestRefresh()
        {
            RefreshRequested?.Invoke();
        }

    }
}
