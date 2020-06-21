using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium.Models
{
    public class Album
    {
        [Key]
        public int IdAlbum { get; set; }
        [MaxLength(20)]
        public String AlbumName { get; set; }
        public DateTime PublishDate { get; set; }
        [ForeignKey("MusicLabel")]
        public int IdMusicLabel { get; set; }

        public virtual MusicLabel MusicLabel { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
