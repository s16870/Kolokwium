using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium.Models;
using Kolokwium.Models.Responses;

namespace Kolokwium.Services
{
    public class MusicalDbService : IMusicalDbService
    {
        private readonly MusicalDbContext _context;
        public MusicalDbService(MusicalDbContext context)
        {
            _context = context;
        }

        public GetMusicianResponse getMusician(int id)
        {
            Musician musician;
            IEnumerable<Track> tracks;
            try
            {
                musician = _context.Musicians.Where(m => m.IdMusician.Equals(id)).First();
            }catch(Exception e)
            {
                throw new Exception("Brak muzyka w bazie");
            }
            try
            {
                tracks = _context.Musician_Tracks.Join(_context.Tracks, mt => mt.IdTrack, t => t.IdTrack, (mt, t) => t);
            }
            catch (Exception e)
            {
                throw new Exception("Utworów w bazie");
            }
            var resp = new GetMusicianResponse();
            resp.FirstName = musician.FirstName;
            resp.LastName = musician.LastName;
            resp.NickName = musician.NickName;
            resp.Track = tracks;
            return resp;
        }
    }
}
