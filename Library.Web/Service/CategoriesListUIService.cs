using Library.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Library.Web.Service
{
    /// <summary>
    /// Denna klass agerar som hjälpklasser åt vårat UI.
    /// </summary>
    public class CategoriesListUIService
    {
        // Denna sträng håller ett meddelande om nyligen lyckade eller misslyckade operationer som visas i UIt.
        public string Message { get; set; }

        public List<Category> Categories { get; set; }

        public List<LibraryItem> LibraryItems { get; set; }

        public event Action RefreshRequested;
        public void CallRequestRefresh()
        {
            RefreshRequested?.Invoke();
        }
    }
}
