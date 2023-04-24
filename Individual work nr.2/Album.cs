using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_work_nr._2
{
    [Table("album")]
    public class Album
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [Column("image_url")]
        public String ImageUrl { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("author_id")]
        public long AuthorId { get; set; }
        public Album() { }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return $"{{Id = {Id}, Title = {Title}, AuthorId = {AuthorId}}}";
        }
    }
}
