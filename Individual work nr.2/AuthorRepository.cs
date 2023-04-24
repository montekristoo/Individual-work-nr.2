using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_work_nr._2
{
    public class AuthorRepository
    {
        internal PostgresDbContext context = new PostgresDbContext();

        public void AddAuthor(Author author)
        {
            context.Author.Add(author);
            context.SaveChanges();
        }

        public void DeleteAuthor(Author author)
        {
            context.Author.Remove(author);
            context.SaveChanges();
        }

        public Author FindById(int id)
        {
            return context.Author
                .Where(x => x.Id == id)
                .First();
        }

        public Author FindByName(string name)
        {
            return context.Author
                .Where(x => x.Name == name)
                .First();
        }

        public long FindIdByName(string name)
        {
            return context.Author
                .Where(x => x.Name == name)
                .Select(x => x.Id)
                .First();
        }

        public List<Author> FindAll() 
        {
            return context.Author.ToList();
        }

        public void DeleteByName(Author author)
        {
            var entity = context.Author.Attach(author);
            entity.State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
