using System;
using System.Collections.Generic;
using MuhendislerBurada.Model.Models;
using System.Linq;
using System.Web;

namespace MuhendislerBurada.Web.ViewModels
{
    public class GroupUpdateListViewModel
    {
        public IEnumerable<GroupUpdateViewModel> GroupUpdates { get; set; }

        public double? Target { get; set; }

        public Metric Metric { get; set; }
    }
}