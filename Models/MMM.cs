using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models
{
    [Table("MMM")]
    public class MMM
    {
        [Key]
        [DataType("varchar")]
        [Display(Name ="ID")]
        [StringLength(20)]
        public string MMMID { get; set; }
        [DataType("nvarchar")]
        [Display(Name ="Họ và tên")]
        [StringLength(50)]
        [Required]
        public string MMMName { get; set; }
        [Required]
        public bool MMMGender { get; set; }
    }
}