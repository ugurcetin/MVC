using System.Collections.Generic;

namespace MuhendislerBurada.Web.ViewModels
{
    public class HomeViewModel
    {

        public IEnumerable<NotificationsViewModel> Notification { get; set; }
        public int? Count { get; set; }

    }
}
