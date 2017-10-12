﻿using System.ComponentModel.DataAnnotations;
using MuhendislerBurada.Model.Models;

namespace MuhendislerBurada.Web.ViewModels
{
    public class UpdateFormModel
    {
        public int UpdateId { get; set; }
        [Required(ErrorMessage = "*")]
        public string Updatemsg { get; set; }
        
        
        public double? status { get; set; }

        public int GoalId { get; set; }

        public virtual Goal Goal { get; set; }
    }
}