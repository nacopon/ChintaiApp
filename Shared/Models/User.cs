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
    public enum UserTypeEnum
    {
        [Display(Name = "システムユーザ")]
        SystemUser = 0,
        [Display(Name = "大家")]
        Owner = 1,
        [Display(Name = "管理会社")]
        ManagementCompany = 2,
        [Display(Name = "施工会社")]
        ConstructionCompany = 3,
    }

    public class User
    {
        [Display(Name = "利用者ID")]
        public int UserId { get; set; }
        [Display(Name = "利用者名")]
        public string? UserName { get; set; }
        [Display(Name = "会社名")]
        public string? CompanyName { get; set; }
        [Display(Name = "利用者タイプ")]
        public UserTypeEnum? UserType { get; set; }
        [Display(Name = "郵便番号")]
        public string? PostCode { get; set; }
        [Display(Name = "住所")]
        public string? Address { get; set; }
        [Display(Name = "電話番号")]
        [Phone]
        public string? Tel { get; set; }
        [Display(Name = "携帯番号")]
        [Phone]
        public string? Phone { get; set; }
        [Display(Name = "メールアドレス")]
        [EmailAddress]
        public string? Mail { get; set; }
        [Display(Name = "銀行名")]
        public string? Bank { get; set; }
        [Display(Name = "支店名")]
        public string? Branch { get; set; }
        [Display(Name = "口座番号")]
        public string? Account { get; set; }
        [Display(Name = "備考1")]
        public string? Memo1 { get; set; }
        [Display(Name = "備考2")]
        public string? Memo2 { get; set; }
        // ToDo availableフラグとかに名前を変える
        [Display(Name = "公開フラグ")]
        public bool? IsPublished { get; set; }
        [Display(Name = "作成日時")]
        public DateTime? CreatedAt { get; set; }
        [Display(Name = "更新日時")]
        public DateTime? UpdatedAt { get; set; }

        public User(int userId)
        {
            UserId = userId;
        }
    }
}
