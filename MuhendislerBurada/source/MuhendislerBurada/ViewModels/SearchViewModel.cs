using System.Collections.Generic;
using MuhendislerBurada.Model.Models;

namespace MuhendislerBurada.Web.ViewModels
{
    public class SearchViewModel
    {
        public IEnumerable<GoalViewModel> Goals { get; set; }
        public IEnumerable<ApplicationUser> Users { get; set; }
        public IEnumerable<GroupViewModel> Groups { get; set;}
        public string SearchText { get; set; }
    }
}