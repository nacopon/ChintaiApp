using System.ComponentModel.DataAnnotations;

namespace ChintaiApp.Shared.Models
{
    public enum BuildingTypeEnum : byte
    {
        [Display(Name = "戸建て")]
        DetachedHouse = 0,
        [Display(Name = "集合住宅")]
        HousingComplex = 1,
    }

    public class Building
    {
        [Display(Name="建物ID")]
        public int BuildingId { get; set; }
        [Display(Name = "オーナーID")]
        public int? OwnerId { get; set; }
        public User? Owner { get; set; }
        [Display(Name = "管理会社ID")]
        public int? ManagementCompanyId { get; set; }
        public User? ManagementCompany { get; set; }
        [Display(Name = "建物名")]
        public string? BuildingName { get; set; }
        [Display(Name = "建物タイプ")]
        public BuildingTypeEnum? BuildingType { get; set; }
        [Display(Name = "建築日")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? BuildedDate { get; set; }
        [Display(Name = "建物詳細")]
        public string? BuildingDetail { get; set; }
        [Display(Name = "郵便番号")]
        [RegularExpression(@"^[0-9]{7}$")]
        public string? PostCode { get; set; }
        [Display(Name = "住所")]
        public string? Address { get; set; }
        [Display(Name = "最寄駅")]
        public int? NearStation { get; set; }
        [Display(Name = "徒歩時間")]
        public int? WalkTime { get; set; }
        [Display(Name = "駐車場有無")]
        public bool? HasPark { get; set; }
        [Display(Name = "駐車場詳細")]
        public string? ParkDetail { get; set; }
        [Display(Name = "緯度")]
        public float? Longitude { get; set; }
        [Display(Name = "経度")]
        public float? Latutude { get; set; }
        [Display(Name = "写真1")]
        [Url]
        public string? Photo1 { get; set; }
        [Display(Name = "写真2")]
        [Url]
        public string? Photo2 { get; set; }
        [Display(Name = "写真3")]
        [Url]
        public string? Photo3 { get; set; }
        [Display(Name = "写真4")]
        [Url]
        public string? Photo4 { get; set; }
        [Display(Name = "写真5")]
        [Url]
        public string? Photo5 { get; set; }
        [Display(Name = "備考1")]
        public string? Memo1 { get; set; }
        [Display(Name = "備考1")]
        public string? Memo2 { get; set; }
        [Display(Name = "公開フラグ")]
        public bool? IsPublished { get; set; }
        [Display(Name = "作成日時")]
        public DateTime? CreatedAt{ get; set; }
        [Display(Name = "更新日時")]
        public DateTime? UpdatedAt { get; set; }



        public Building(int buildingId)
        {
            BuildingId = buildingId;
        }
    }
}
