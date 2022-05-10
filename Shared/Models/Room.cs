using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ChintaiApp.Shared.Models
{
    public enum RoomStatusEnum : byte
    {
        [Display(Name = "募集中")]
        Open = 0,
        [Display(Name = "貸出中")]
        Lending = 1,
        [Display(Name = "退去予定")]
        MoveSoon = 2,
    }

    public class Room
    {
        [Display(Name = "部屋ID")]
        public int RoomId { get; set; }
        [Display(Name = "建物ID")]
        public int? BuildingId { get; set; }
        public Building? Building { get; set; }
        [Display(Name = "建物名")]
        public string? RoomTitle { get; set; }
        [Display(Name = "建物詳細")]
        public string? RoomDetail { get; set; }
        [Display(Name = "建物ステータス")]
        public RoomStatusEnum? RoomStatus { get; set; }
        [Display(Name = "家賃")]
        public int? RentFee { get; set; }
        [Display(Name = "管理費")]
        public int? ManagementFee { get; set; }
        [Display(Name = "敷金")]
        public int? Shikikin { get; set; }
        [Display(Name = "礼金")]
        public int? Reikin { get; set; }
        [Display(Name = "広さ")]
        public int? Size { get; set; }
        [Display(Name = "間取")]
        [Url]
        public string? Madori { get; set; }
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
        [Display(Name = "備考2")]
        public string? Memo2 { get; set; }
        [Display(Name = "公開フラグ")]
        public bool? IsPublished { get; set; }
        [Display(Name = "作成日時")]
        public DateTime? CreatedAt { get; set; }
        [Display(Name = "更新日時")]
        public DateTime? UpdatedAt { get; set; }

        public Room(int roomId)
        {
            RoomId = roomId;
            RoomId = roomId;
        }
    }
}
