using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MuhendislerBurada.Model.Models;

namespace MuhendislerBurada.Web.ViewModels
{
    public class GroupMemberViewModel
    {
        public int GroupId { get; set; }
        
        public Group Group { get; set; }

        public int? GroupUserId { get; set; }

        public IEnumerable<ApplicationUser> Users { get; set; }
    }
}