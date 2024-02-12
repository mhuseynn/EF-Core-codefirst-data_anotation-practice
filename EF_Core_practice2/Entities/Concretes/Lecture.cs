using EF_Core_practice2.Entities.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF_Core_practice2.Entities.Concretes;

public class Lecture : BaseEntity
{
    [Column(TypeName = "date")]
    [Required]
    public DateTime DateOfLecture { get; set; }

   
    [Required]
    [ForeignKey(nameof(Subject))]
    public int SubjectId { get; set; }

    [Required]
    [ForeignKey(nameof(Teacher))]
    public int TeacherId { get; set; }


    public Subject Subject { get; set; }
    public Teacher Teacher { get; set; }

}
