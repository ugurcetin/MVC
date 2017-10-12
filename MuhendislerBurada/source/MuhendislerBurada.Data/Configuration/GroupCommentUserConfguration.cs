﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MuhendislerBurada.Model.Models;

namespace MuhendislerBurada.Data.Configuration
{
    public class GroupCommentUserConfguration:EntityTypeConfiguration<GroupCommentUser>
    {
        public GroupCommentUserConfguration()
        {
            Property(g => g.GroupCommentId).IsRequired();
            Property(g => g.UserId).IsRequired();
        }
    }
}
