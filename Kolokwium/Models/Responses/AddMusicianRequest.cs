using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Models.Responses
{
    public class AddMusicianRequest
    {
        public Musician Musician { get; set; }
        public Track Track { get; set; }
    }
}
