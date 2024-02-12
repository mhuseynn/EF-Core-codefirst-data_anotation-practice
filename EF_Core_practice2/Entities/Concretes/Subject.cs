using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EF_Core_practice2.Entities.Abstracts;

namespace EF_Core_practice2.Entities.Concretes;

public class Subject : BaseEntity
{
    
    [Column(TypeName = "nvarchar(100)")]
    [Required]
    public string Name { get; set; }



}
