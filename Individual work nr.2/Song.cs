using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Individual_work_nr._2
{
    [Table("song")]
    public class Song
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("age")]
        public int Age { get; set; }
        [Column("album_id")]
        public long albumId { get; set; }
        [Column("tag_id")]
        public long tagId;
        [Column("rank")]
        public double rank;

        public Song() { }

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
            return $"{{Id = {Id}, Name = {Name}, albumId = {albumId}}}";
        }
    }
}
