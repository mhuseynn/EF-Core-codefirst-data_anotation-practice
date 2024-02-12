using EF_Core_practice2.Entities.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EF_Core_practice2.Entities.Concretes
{
    public class Teacher : BaseEntity
    {
        [Column(TypeName = "bit")]
        [Required]
        public bool IsProfessor { get; set; }


        [Column(TypeName = "nvarchar(MAX)")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        [Required]
        public string Surname { get; set; }


        [Required]
        [Column(TypeName = "money")]
        [Range(1, double.MaxValue, ErrorMessage = "0 ola bilmez")]
        public double Salary { get; set; }
    }
}
