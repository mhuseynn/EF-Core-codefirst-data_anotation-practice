using EF_Core_practice2.Entities.Abstracts;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace EF_Core_practice2.Entities.Concretes;

public class Department : BaseEntity
{
    [Required]
    [Range(1, 5)]
    public int Building { get; set; }

    
    [Column(TypeName =("money"))]
    [Required]
    [Range(0, double.MaxValue, ErrorMessage = "0 ola bilmez")]
    public double Financing { get; set; }

   
    [Column(TypeName = "nvarchar(100)")]
    [Required]
    public string Name { get; set; }


    [ForeignKey("Faculty")]
    [Required]

    public int FacultyId { get; set; }


    public Faculty Faculty { get; set; }
}
