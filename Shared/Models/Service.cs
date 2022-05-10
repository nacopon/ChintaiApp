using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ChintaiApp.Shared.Models
{
    public class Service
    {
        [Display(Name = "サービスID")]
        public int ServiceId { get; set; }
        [Display(Name = "借主ID")]
        public int? RenterId   { get; set; }
        public Renter? Renter { get; set; }
        [Display(Name = "建物ID")]
        public int? BuildingId { get; set; }
        public Building? Building { get; set; }
        [Display(Name = "部屋ID")]
        public int? RoomId { get; set; }
        public Room? Room { get; set; }
        [Display(Name = "サービス年月")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM}", ApplyFormatInEditMode = true)]
        public DateTime?  ServicedDate { get; set; }
        [Display(Name = "支払期日")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DeadlineDate { get; set; }
        [Display(Name = "実際支払日")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? PaymentDate { get; set; }
        [Display(Name = "想定支払額")]
        public int? AssumptionPayment { get; set; }
        [Display(Name = "実際支払額")]
        public int? RealPayment { get; set; }
        [Display(Name = "手数料")]
        public int? Commission { get; set; }
        [Display(Name = "備考1")]
        public string? Memo1{ get; set; }
        [Display(Name = "備考2")]
        public string? Memo2 { get; set; }
        [Display(Name = "作成日時")]
        public DateTime? CreatedAt { get; set; }
        [Display(Name = "更新日時")]
        public DateTime? UpdatedAt { get; set; }


        public Service(int serviceId)
        {
           ServiceId = serviceId;
        }
    }
}
