﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MuhendislerBurada.Model.Models;

namespace MuhendislerBurada.Data.Configuration
{
    public class SupportConfiguration:EntityTypeConfiguration<Support>
    {
        public SupportConfiguration()
        {
            Property(s => s.SupportedDate).IsRequired();
            Property(s => s.GoalId).IsRequired();
            Property(s => s.UserId).IsMaxLength();
    }
    }
}
