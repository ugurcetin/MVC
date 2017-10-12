using System.Web.Mvc;
using MuhendislerBurada.Web.Core.Helpers;

namespace MuhendislerBurada.Web.Core.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static UserHtmlHelper User(this HtmlHelper html)
        {
            return new UserHtmlHelper(html, new UrlHelper(html.ViewContext.RequestContext));
        }
    }
}