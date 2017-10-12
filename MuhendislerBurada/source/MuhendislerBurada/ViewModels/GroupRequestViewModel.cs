using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MuhendislerBurada.Model.Models;

namespace MuhendislerBurada.Web.ViewModels
{
    public class GroupRequestViewModel
    {
        public int GroupId { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual Group Group { get; set; }
    }
}