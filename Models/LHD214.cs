using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models
{
    [Table("LHD214s")]
    public class LHD214
    {
        [Key]
        [DataType("varchar")]
        [Display(Name ="ID")]
        [StringLength(20)]
        public string LHDID { get; set; }
        [DataType("nvarchar")]
        [Display(Name ="Họ và tên")]
        [StringLength(50)]
        [Required]
        public string LHDName { get; set; }
        [Required]
        public bool LHDGender { get; set; }
    }
}