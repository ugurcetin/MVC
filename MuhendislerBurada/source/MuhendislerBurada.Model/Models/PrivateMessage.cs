using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhendislerBurada.Model.Models {
    public class PrivateMessage {

        public int PrivateMessageId { get; set; }

        public string SenderUserId { get; set; }

        public string ReceiverUserId { get; set; }

        public bool DeletedBySender { get; set; }
        public bool DeletedByReceiver { get; set; }
        public DateTime MessageDate { get; set; }

        public string Message { get; set; }


        public PrivateMessage() {
            MessageDate = DateTime.Now;
            DeletedByReceiver = false;
            DeletedBySender = false;
        }
    }
}
