using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium.Models
{
    public class Track
    {
        [Key]
        public int IdTrack { get; set; }
        [MaxLength(20)]
        public String TrackName { get; set; }
        public float Duration { get; set; }
        [Required]
        [ForeignKey("Album")]
        public int? IdMusicAlbum { get; set; }

        public virtual Album Album { get; set; }
        public virtual ICollection<Musician_Track> Musician_Tracks { get; set; }
    }
}
