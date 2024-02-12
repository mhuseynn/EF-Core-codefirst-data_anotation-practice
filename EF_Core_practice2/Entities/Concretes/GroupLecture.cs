using EF_Core_practice2.Entities.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF_Core_practice2.Entities.Concretes;

public class GroupLecture : BaseEntity
{
    
    [Required]
    [ForeignKey(nameof(Lecture))]
    public int LectureId { get; set; }

    [Required]
    [ForeignKey(nameof(Group))]
    public int GroupId { get; set; }

    public Lecture Lecture { get; set; }
    public Group Group { get; set; }
}
