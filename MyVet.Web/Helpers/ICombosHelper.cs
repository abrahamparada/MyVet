using Microsoft.AspNetCore.Mvc.Rendering;
using MyVet.Web.Data;
using System.Collections.Generic;

namespace MyVet.Web.Helpers
{
    public interface ICombosHelper
    {
        DataContext DataContext { get; }

        IEnumerable<SelectListItem> GetComboPetTypes();

        IEnumerable<SelectListItem> GetComboServiceTypes();
    }
}