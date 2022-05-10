using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ChintaiApp.Shared.Models
{

    public class Construction
    {
        [Display(Name = "施工ID")]
        public int ConstructionId { get; set; }
        [Display(Name = "建物ID")]
        public int? BuildingId { get; set; }
        public Building? Building { get; set; }
        [Display(Name = "部屋ID")]
        public int? RoomId { get; set; }
        public Room? Room{ get; set; }
        // TODO: 業者ID追加
        [Display(Name = "施工日")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? ConstructedDate { get; set; }
        [Display(Name = "施工タイトル")]
        public string? ConstructionTitle { get; set; }
        [Display(Name = "施工費")]
        public int? ConstructionFee { get; set; }
        [Display(Name = "施工詳細")]
        public string? ConstructionDetail { get; set; }
        [Display(Name = "評価値")]
        [Range(0,5)]
        public int? Evalution { get; set; }
        [Display(Name = "評価詳細")]
        public string? EvalutionDetail { get; set; }
        [Display(Name = "施工前写真1")]
        [Url]
        public string? BPhoto1 { get; set; }
        [Display(Name = "施工前写真2")]
        [Url]
        public string? BPhoto2 { get; set; }
        [Display(Name = "施工前写真3")]
        [Url]
        public string? BPhoto3 { get; set; }
        [Display(Name = "施工前写真4")]
        [Url]
        public string? BPhoto4 { get; set; }
        [Display(Name = "施工前写真5")]
        [Url]
        public string? BPhoto5 { get; set; }
        [Display(Name = "施工後写真1")]
        [Url]
        public string? APhoto1 { get; set; }
        [Display(Name = "施工後写真2")]
        [Url]
        public string? APhoto2 { get; set; }
        [Display(Name = "施工後写真3")]
        [Url]
        public string? APhoto3 { get; set; }
        [Display(Name = "施工後写真4")]
        [Url]
        public string? APhoto4 { get; set; }
        [Display(Name = "施工後写真5")]
        [Url]
        public string? APhoto5 { get; set; }
        [Display(Name = "備考1")]
        public string? Memo1 { get; set; }
        [Display(Name = "備考2")]
        public string? Memo2 { get; set; }
        [Display(Name = "公開フラグ")]
        public bool? IsPublished { get; set; }
        [Display(Name = "作成日時")]
        public DateTime? CreatedAt { get; set; }
        [Display(Name = "更新日時")]
        public DateTime? UpdatedAt { get; set; }

        public Construction(int constructionId)
        {
            ConstructionId = constructionId;

        }
    }
}
