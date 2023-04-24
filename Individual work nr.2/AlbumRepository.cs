using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_work_nr._2
{
    public class AlbumRepository
    {
        internal PostgresDbContext context = new PostgresDbContext();

        public void AddAlbum(Album album)
        {
            context.Album.Add(album);
            context.SaveChanges();
        }

        public void UpdateAlbum(Album album)
        {
            context.Album.Update(album);
            context.SaveChanges();
        }

        public void DeleteAlbum(Album album)
        {
            context.Album.Remove(album);
            context.SaveChanges();
        }

        public List<Album> FindAllAlbums()
        {
            return context.Album.ToList();
        }

        public List<Album> FindAlbumByTitle(string title)
        {
            return context.Album
                .Where(a => a.Title.Contains(title))
                .ToList();
        }

        public int FindAlbumIdByName(string name)
        {
            return context.Album
                .Where(a => a.Title.Equals(name))
                .First().Id;
        }
    }
}
