using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        [DataType("varchar")]
        [Display(Name ="ID")]
        [StringLength(20)]
        public string MovieID { get; set; }
        [DataType("nvarchar")]
        [Display(Name ="Họ và tên")]
        [StringLength(50)]
        [Required]
        public string MovieName { get; set; }
        public bool MovieGender { get; set; }
    }
}