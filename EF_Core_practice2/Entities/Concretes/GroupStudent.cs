using EF_Core_practice2.Entities.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF_Core_practice2.Entities.Concretes;

public class GroupStudent : BaseEntity
{
    [Required]
    [ForeignKey(nameof(Student))]
    public int StudentId { get; set; }

    [Required]
    [ForeignKey(nameof(Group))]
    public int GroupId { get; set; }

 
    public Student Student { get; set; }
    public Group Group { get; set; }
}
