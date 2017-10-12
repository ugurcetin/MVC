﻿using System.Collections.Generic;
using MuhendislerBurada.Model.Models;

namespace MuhendislerBurada.Web.ViewModels
{
    public class GroupUpdateSupportersViewModel
    {
        public int GroupUpdateId { get; set; }

        public GroupUpdate GroupUpdate { get; set; }

        public IEnumerable<ApplicationUser> Users { get; set; }
    }
}