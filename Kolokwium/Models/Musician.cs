using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium.Models
{
    public class Musician
    {
        [Key]
        public int IdMusician { get; set; }
        [MaxLength(30)]
        public String FirstName { get; set; }
        [MaxLength(50)]
        public String LastName { get; set; }
        [MaxLength(20)]
        public String NickName { get; set; }

        public virtual ICollection<Musician_Track> Musician_Tracks { get; set; }
    }
}
