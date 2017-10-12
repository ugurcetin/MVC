using System;
using MuhendislerBurada.Model.Models;
using System.ComponentModel.DataAnnotations;

namespace MuhendislerBurada.Web.ViewModels
{
    public class FocusFormModel
    {
        public int FocusId { get; set; }
        [Required(ErrorMessage = "*")]
        [StringLength(50)]
        public string FocusName { get; set; }
        [Required(ErrorMessage = "*")]
        [StringLength(100)]
        public string Description { get; set; }

        public int GroupId { get; set; }

        public virtual Group Group { get; set; }

        public DateTime CreatedDate { get; set; }

        public FocusFormModel()
        {
            CreatedDate = DateTime.Now;
        }
    }
}