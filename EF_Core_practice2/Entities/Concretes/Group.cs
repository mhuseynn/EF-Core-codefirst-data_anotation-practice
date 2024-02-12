using EF_Core_practice2.Entities.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF_Core_practice2.Entities.Concretes;

public class Group : BaseEntity
{
    
    [Column(TypeName = "nvarchar(10)")]
    [Required]
    public string Name { get; set; }


    [Required]
    [Range(1, 5)]
    public int Year { get; set; }


    [ForeignKey("Department")]
    [Required]
    public int DepartmentId { get; set; }


    public Department Department{ get; set; }
}
