using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_work_nr._2
{
    public class SongRepository
    {
        internal PostgresDbContext context = new PostgresDbContext();

        public void AddSong(Song song)
        {
            context.Song.Add(song);
            context.SaveChanges();
        }

        public void UpdateSong(Song song)
        {
            context.Song.Update(song);
            context.SaveChanges();
        }

        public void DeleteSong(Song song)
        {
            context.Song.Remove(song);
            context.SaveChanges();
        }

        public Song FindSongById(int id)
        {
            return context.Song
                .Where(s => s.Id == id)
                .First();
        }

        public List<Song> FindSongsByDescription(string description)
        {
            return context.Song
                .Where(s => s.Description.Contains(description))
                .ToList();
        }

        public List<Song> FindAll()
        {
            return context.Song.ToList();
        }
    }
}
