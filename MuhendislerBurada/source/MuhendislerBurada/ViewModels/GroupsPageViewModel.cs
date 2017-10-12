using PagedList;
using MuhendislerBurada.Service;

namespace MuhendislerBurada.Web.ViewModels
{
    public class GroupsPageViewModel
    {
        public IPagedList<GroupsItemViewModel> GroupList { get; set; }

        public GroupFilter Filter { get; set; }
    }
}