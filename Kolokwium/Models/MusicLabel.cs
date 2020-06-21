using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium.Models
{
    public class MusicLabel
    {
        [Key]
        public int IdMusicLabel { get; set; }
        [MaxLength(50)]
        public String Name { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}
