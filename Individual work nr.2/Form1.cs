using Microsoft.EntityFrameworkCore;

namespace Individual_work_nr._2
{
    public partial class Form1 : Form
    {
        internal AuthorRepository authorRepository = new AuthorRepository();
        internal TagRepository tagRepository = new TagRepository();
        internal AlbumRepository albumRepository = new AlbumRepository();
        internal SongRepository songRepository = new SongRepository();
        public Form1()
        {
            InitializeComponent();
            FormClosing += Form1_FormClosing;
        }
   
        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseLifeCycle.Up();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DatabaseLifeCycle.CleanUp();
        }

        private void addAMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button_add_author_Click(object sender, EventArgs e)
        {
            Author author = new Author
            {
                Name = author_add_text_box.Text
            };

            authorRepository.AddAuthor(author);
        }

        private void remove_author_button_Click(object sender, EventArgs e)
        {
            Author author = new Author
            {
                Name = remove_author_text_box.Text
            };

            authorRepository.DeleteByName(author);
        }

        private void show_authors_button_Click(object sender, EventArgs e)
        {
            List<Author> authorList = authorRepository.FindAll();
            ShowResultForm showResultForm = new ShowResultForm(createResult(authorList));
            showResultForm.Show();
        }

        private void tag_add_button_Click(object sender, EventArgs e)
        {
            Tag tag = new Tag
            {
                Name = add_tag_text_box.Text
            };

            tagRepository.AddTag(tag);
        }

        private void show_all_tag_button_Click(object sender, EventArgs e)
        {
            List<Tag> tags = tagRepository.FindAll();
        }

        private void add_album_button_Click(object sender, EventArgs e)
        {
            Album album = new Album
            {
                Title = add_album_text_box.Text,
                AuthorId = authorRepository.FindIdByName(add_album_author_text_box.Text)
            };

            albumRepository.AddAlbum(album);
        }

        private void rm_album_button_Click(object sender, EventArgs e)
        {
            Album album = new Album
            {
                Title = remove_album_text_box.Text
            };

            albumRepository.DeleteAlbum(album);
        }

        private void search_album_button_Click(object sender, EventArgs e)
        {
            List<Album> albums = albumRepository.FindAlbumByTitle(search_album_text_box.Text);
        }

        private void show_all_album_button_Click(object sender, EventArgs e)
        {
            List<Album> albums = albumRepository.FindAllAlbums();
            ShowResultForm showResultForm = new ShowResultForm(createResult(albums));
            showResultForm.Show();
        }

        private void add_song__button_Click(object sender, EventArgs e)
        {
            Song song = new Song
            {
                Name = name_of_song_text_box.Text,
                albumId = albumRepository.FindAlbumIdByName(album_text_box_song.Text)
            };
            songRepository.AddSong(song);
        }

        private void songs_Click(object sender, EventArgs e)
        {

        }

        private string createResult <T> (List<T> data)
        {
            string result = "";
            data.ForEach(item =>
            {
                result += item.ToString() + "\n";
            });

            return result;
        }

        private void show_all_songs_button_Click(object sender, EventArgs e)
        {
            List<Song> songs = songRepository.FindAll();
            ShowResultForm showResultForm = new ShowResultForm(createResult(songs));
            showResultForm.Show();
        }
    }
}