using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MuhendislerBurada.ViewModels {
    public class PrivateMessageFormModel {

        [Required(ErrorMessage = "*")]
        public string ReceiverUsername { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(100)]
        public string Message { get; set; }

    }
}