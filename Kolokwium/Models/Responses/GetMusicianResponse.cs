using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Models.Responses
{
    public class GetMusicianResponse
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String NickName { get; set; }
        public IEnumerable<Track> Track { get; set; }
    }
}
