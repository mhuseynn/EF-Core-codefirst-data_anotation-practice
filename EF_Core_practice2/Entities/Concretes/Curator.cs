using EF_Core_practice2.Entities.Abstracts;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_practice2.Entities.Concretes;

public class Curator : BaseEntity
{
    [Column(TypeName ="nvarchar(MAX)")]
    [Required]
    public string? Name { get; set; }

    [Column(TypeName = "nvarchar(MAX)")]
    [Required]
    public string? Surname { get; set; }




}
