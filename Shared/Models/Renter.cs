using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ChintaiApp.Shared.Models
{
    [Flags]
    public enum RenterTypeEnum
    {
        [Display(Name = "勤め人")]
        Worker = 1,
        [Display(Name = "パート")]
        Part = 2,
        [Display(Name = "年金暮らし")]
        Pension = 3,
        [Display(Name = "学生")]
        Student = 4,
        [Display(Name = "無職")]
        NoJob = 5,
        [Display(Name = "生活保護")]
        Welfare = 6,
        [Display(Name = "その他")]
        Other = 7,
    }

    public class Renter
    {
        [Display(Name = "借主ID")]
        public int RenterId { get; set; }
        [Display(Name = "借主名")]
        public string? RenterName { get; set; }
        [Display(Name = "顔写真")]
        [Url]
        public string? Photo { get; set; }
        [Display(Name = "電話番号")]
        [Phone]
        public string? Phone { get; set; }
        [Display(Name = "生年月日")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? BirthDate { get; set; }
        // RenterTypeでよかったかも
        [Display(Name = "属性")]
        public RenterTypeEnum? RenterType { get; set; }
        [Display(Name = "お勤め会社")]
        public string? CompanyName { get; set; }
        [Display(Name = "月収")]
        public int? MonthlySalary { get; set; }
        [Display(Name = "引越理由")]
        public string? MoveReason { get; set; }
        [Display(Name = "保証人")]
        public string? Guarantor { get; set; }
        [Display(Name = "保証人住所")]
        public string? GuarantorAddress { get; set; }
        [Display(Name = "保証人電話番号")]
        [Phone]
        public string? GuarantorPhone { get; set; }
        [Display(Name = "希望予算")]
        public int? Budget{ get; set; }
        [Display(Name = "借りるとき重要とするポイント")]
        public string? Importance { get; set; }
        [Display(Name = "借りる際の期待するポイント")]
        public string? Exception { get; set; }
        [Display(Name = "銀行名")]
        public string? Bank { get; set; }
        [Display(Name = "支店名")]
        public string? Branch { get; set; }
        [Display(Name = "口座番号")]
        public string? Account { get; set; }
        [Display(Name = "クレジット会社")]
        public string? CreditCardName { get; set; }
        [Display(Name = "クレジットカード番号")]
        [CreditCard]
        public string? CreditCardNumber { get; set; }
        [Display(Name = "クレジットセキュア")]
        public string? CreditCardSecure { get; set; }
        [Display(Name = "保証会社")]
        public string? GuaranteeCompany { get; set; }
        [Display(Name = "備考1")]
        public string? Memo1 { get; set; }
        [Display(Name = "備考2")]
        public string? Memo2 { get; set; }
        [Display(Name = "作成日時")]
        public DateTime? CreatedAt { get; set; }
        [Display(Name = "更新日時")]
        public DateTime? UpdatedAt { get; set; }

        public Renter(int renterId)
        {
            RenterId = renterId;
        }
    }
}
