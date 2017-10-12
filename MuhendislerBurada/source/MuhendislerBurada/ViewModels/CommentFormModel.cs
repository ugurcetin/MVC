using System.ComponentModel.DataAnnotations;
using MuhendislerBurada.Model.Models;

namespace MuhendislerBurada.Web.ViewModels
{
    public class CommentFormModel
    {
        [Required(ErrorMessage = "Required")]
        public string CommentText { get; set; }

        public int UpdateId { get; set; }

        public int UserId { get; set; }

        public ApplicationUser User { get; set; }

    }
}