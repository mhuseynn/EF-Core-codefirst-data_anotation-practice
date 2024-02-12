using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EF_Core_practice2.Entities.Abstracts;

namespace EF_Core_practice2.Entities.Concretes;

public class Student : BaseEntity
{
    [Column(TypeName = "nvarchar(MAX)")]
    [Required]
    public string Name { get; set; }

    [Column(TypeName = "nvarchar(MAX)")]
    [Required]
    public string Surname { get; set; }


    [Required]
    [Range(0, 5)]
    public int Rating { get; set; }
}
