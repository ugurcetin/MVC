using System;
using System.Collections.Generic;
using MuhendislerBurada.Model.Models;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MuhendislerBurada.Web.ViewModels
{
    public class GoalsPageViewModel
    {
        public IEnumerable<GoalListViewModel> GoalList { get; set; }

        public IEnumerable<SelectListItem> FilterBy { get; set; }

        public IEnumerable<SelectListItem> SortBy { get; set; }

        public GoalsPageViewModel(string selectedFilter,string selectedSort)
        {
            FilterBy = new SelectList(new[]{
                       new SelectListItem{ Text="Tümü", Value="Tümü"},
                       new SelectListItem{ Text="İlanlarım", Value="İlanlarım"},
                       new SelectListItem{ Text="Takip ettiğim ilanlar", Value="My Followed Goals"},
                       new SelectListItem{ Text="My Followings Goals", Value="My Followings Goals"}
                       }, "Text", "Value", selectedFilter);
            SortBy = new SelectList(new[]{
                       new SelectListItem{ Text="Tarihe göre", Value="Date"},
                       new SelectListItem{ Text="Popülerliğe göre", Value="Popularity"}}, "Text", "Value", selectedSort);

        }
    }
    
}