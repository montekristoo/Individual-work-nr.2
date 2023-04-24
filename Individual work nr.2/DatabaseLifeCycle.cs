using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_work_nr._2
{
    public class DatabaseLifeCycle
    {
        internal static string postgresDbConnectionString = "Server=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres";
        internal static string songsDbConnectionString = "Server=localhost;Port=5432;Database=songs;Username=postgres;Password=postgres";
        internal static string createDatabase = "CREATE DATABASE songs;";
        internal static string dropDatabase = "DROP DATABASE songs;";
        internal static string createTableSong = "CREATE TABLE song (id BIGSERIAL PRIMARY KEY, name varchar, description varchar, age int, album_id bigint, tag_id bigint, rank double precision);";
        internal static string createTableAlbum = "CREATE TABLE album (id BIGSERIAL PRIMARY KEY, description varchar, title varchar, image_url varchar, author_id bigint);";
        internal static string createTableAuthor = "CREATE TABLE author(id BIGSERIAL PRIMARY KEY, name varchar, image_url varchar);";
        internal static string createTableTag = "CREATE TABLE tag(id BIGSERIAL PRIMARY KEY, name varchar);";
        internal static string closeAllConnections = "SELECT pg_terminate_backend(pid) FROM pg_stat_activity WHERE datname = 'songs'";
        public static void Up()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(postgresDbConnectionString))
            {
                connection.Open();


                using (NpgsqlCommand command = new NpgsqlCommand(createDatabase, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            using (NpgsqlConnection connection = new NpgsqlConnection(songsDbConnectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(createTableSong, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (NpgsqlCommand command = new NpgsqlCommand(createTableAlbum, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (NpgsqlCommand command = new NpgsqlCommand(createTableAuthor, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (NpgsqlCommand command = new NpgsqlCommand(createTableTag, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
            
        }
        
        public static void CleanUp()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(postgresDbConnectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(closeAllConnections, connection))
                {
                    command.ExecuteNonQuery();
                }

                using (NpgsqlCommand command = new NpgsqlCommand(dropDatabase, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
