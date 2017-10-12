﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MuhendislerBurada.Model.Models;

namespace MuhendislerBurada.Data.Configuration
{
    public class GoalStatusConfiguration: EntityTypeConfiguration<GoalStatus>
    {
        public GoalStatusConfiguration()
        {
            Property(g => g.GoalStatusType).HasMaxLength(50);
        }
    }
}
