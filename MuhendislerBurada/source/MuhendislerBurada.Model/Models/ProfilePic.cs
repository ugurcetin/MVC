using System.Web;

namespace MuhendislerBurada.Model.Models
{
    public class ProfilePic
    {
        public HttpPostedFileBase fileData { get; set; }

        public string SecurityToken { get; set; }

        public string Filename { get; set; }
    }
}
