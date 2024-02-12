using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_practice2.Entities.Abstracts
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
