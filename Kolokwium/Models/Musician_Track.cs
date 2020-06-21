using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium.Models
{
    public class Musician_Track
    {
        [Key]
        public int IdMusicianTrack { get; set; }
        [ForeignKey("Track")]
        public int IdTrack { get; set; }
        [ForeignKey("Musician")]
        public int IdMusician { get; set; }

        public virtual Musician Musician { get; set; }
        public virtual Track Track { get; set; }
    }
}
