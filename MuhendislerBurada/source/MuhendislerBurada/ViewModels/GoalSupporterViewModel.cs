﻿using System.Collections.Generic;
using MuhendislerBurada.Model.Models;

namespace MuhendislerBurada.Web.ViewModels
{
    public class GoalSupporterViewModel
    {
        public int GoalId { get; set; }

        public Goal Goal { get; set; }

        public IEnumerable<ApplicationUser> Users { get; set; }
    }
}