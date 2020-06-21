using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium.Models.Responses;

namespace Kolokwium.Services
{
    public interface IMusicalDbService
    {
        public GetMusicianResponse getMusician(int id);
        public Boolean addMusician(AddMusicianRequest request);
    }
}
