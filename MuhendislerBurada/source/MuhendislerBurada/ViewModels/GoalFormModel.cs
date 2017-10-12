using MuhendislerBurada.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace MuhendislerBurada.Web.ViewModels
{
    public class GoalFormModel
    {
        //public GoalFormModel()
        //{
        //    StartDate = DateTime.Now;
        //    EndDate = DateTime.Now;

        //}
        public int GoalId { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(50)]
        [DisplayName("İlan başlığı")]
        public string GoalName { set; get; }

        [Required(ErrorMessage = "*")]
        [StringLength(100)]
        [DisplayName("İlan açıklaması")]
        public string Desc { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Başlangıç tarihi")]
        public DateTime? StartDate { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MMM-yyyy}")]
        [DisplayName("Bitiş tarihi")]
        public DateTime? EndDate { get; set; }

        [DisplayName("Alım sayısı")]
        public double? Target { get; set; }

        public bool GoalType { get; set; }

        public string UserId { get; set; }

        public int? MetricId { get; set; }

        //public IEnumerable<SelectListItem> MetricType { get; set; }

        //public IEnumerable<Metric> Metrics { get; set; }
        public IEnumerable<SelectListItem> Metrics{ get; set; }

        
    }
    
}