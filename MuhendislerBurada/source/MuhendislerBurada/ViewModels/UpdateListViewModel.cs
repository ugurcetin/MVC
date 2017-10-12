using System.Collections.Generic;
using MuhendislerBurada.Model.Models;

namespace MuhendislerBurada.Web.ViewModels
{
    public class UpdateListViewModel
    {
        public IEnumerable<UpdateViewModel> Updates { get; set; }

        public double? Target { get; set; }

        public Metric Metric { get; set; }

    }
}