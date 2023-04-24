using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_work_nr._2
{
    public class TagRepository
    {
        internal PostgresDbContext context = new PostgresDbContext();

        public void AddTag(Tag tag)
        {
            context.Tag.Add(tag);
            context.SaveChanges();
        }

        public List<Tag> FindAll()
        {
            return context.Tag.ToList();
        }
    }
}
