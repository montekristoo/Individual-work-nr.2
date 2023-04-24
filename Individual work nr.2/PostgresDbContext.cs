using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace Individual_work_nr._2
{
    public class PostgresDbContext : DbContext
    {

        public PostgresDbContext(DbContextOptions<PostgresDbContext> options) : base(options)
        {
            
        }

        public PostgresDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            var builder = new NpgsqlConnectionStringBuilder
            {
                Host = "localhost",
                Port = 5432,
                Database = "songs",
                Username = "postgres",
                Password= "postgres",
            };

            optionsBuilder.UseNpgsql(builder.ConnectionString);
        }
        public DbSet<Author> Author { get; set; }
        public DbSet<Song> Song { get; set; }
        public DbSet<Album> Album { get; set; }
        public DbSet<Tag> Tag { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>()
                .ToTable("album")
                .HasKey(a => a.Id);

            modelBuilder.Entity<Tag>()
                .ToTable("tag")
                .HasKey(b => b.Id);

            modelBuilder.Entity<Song>()
                .ToTable("song")
                .HasKey(c => c.Id);

            modelBuilder.Entity<Author>()
                .ToTable("author")
                .HasKey(a => a.Id);
        }
    }
}
