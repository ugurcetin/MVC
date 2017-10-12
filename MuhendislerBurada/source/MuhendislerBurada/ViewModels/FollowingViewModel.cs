using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MuhendislerBurada.Model.Models;

namespace MuhendislerBurada.Web.ViewModels
{
    public class FollowingViewModel
    {
        public string UserId { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ProfilePicUrl { get; set; }

        public string UserName { get; set; }
    }
}