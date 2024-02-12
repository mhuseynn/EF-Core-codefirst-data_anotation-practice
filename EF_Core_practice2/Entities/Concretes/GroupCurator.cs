using EF_Core_practice2.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_practice2.Entities.Concretes
{
    public class GroupCurator : BaseEntity
    {
        
        [Required]
        [ForeignKey(nameof(Curator))]
        public int CuratorId { get; set; }

        [Required]
        [ForeignKey(nameof(Group))]
        public int GroupId { get; set; }

       
        public Curator Curator { get; set; }
        public Group Group { get; set; }
    }
}
