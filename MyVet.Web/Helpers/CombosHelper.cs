using Microsoft.AspNetCore.Mvc.Rendering;
using MyVet.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _dataContext;
        public CombosHelper(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public DataContext DataContext { get; }

        public IEnumerable<SelectListItem> GetComboPetTypes()
        {
            var list = _dataContext.PetTypes.Select(pt => new SelectListItem

            {
                Text = pt.Name,                       // Cargar ListBox LINQ
                Value = $"{pt.Id}"
            })

                .OrderBy(pt => pt.Text)
                .ToList();
            list.Insert(0, new SelectListItem

            {
                Text = "[Select a Pet Type...]",
                Value = "0"
            }
                );

            return list;
        }

        public IEnumerable<SelectListItem> GetComboServiceTypes()
        {
            var list = _dataContext.ServiceTypes.Select(pt => new SelectListItem

            {
                Text = pt.Name,                       // Cargar ListBox LINQ
                Value = $"{pt.Id}"
            })

                  .OrderBy(pt => pt.Text)
                  .ToList();
            list.Insert(0, new SelectListItem

            {
                Text = "[Select a Service Type...]",
                Value = "0"
            }
                );

            return list;

        }
    }
}
