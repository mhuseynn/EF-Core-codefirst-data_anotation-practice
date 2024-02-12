using EF_Core_practice2.Entities.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF_Core_practice2.Entities.Concretes;

public class Faculty : BaseEntity
{
    
    [Column(TypeName = "nvarchar(100)")]
    [Required]
    public string Name { get; set; }

}
