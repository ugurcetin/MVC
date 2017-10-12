using System.Collections.Generic;
using MuhendislerBurada.Model.Models;

namespace MuhendislerBurada.Web.ViewModels
{
    public class UpdateSupportersViewModel
    {
        public int UpdateId { get; set; }

        public Update Update { get; set; }

        public IEnumerable<ApplicationUser> Users { get; set; }
    }
}