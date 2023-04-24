namespace Individual_work_nr._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getSongsByYearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getSongByAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSongsByAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getBestSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.remove_author_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.remove_author_text_box = new System.Windows.Forms.TextBox();
            this.show_authors_button = new System.Windows.Forms.Button();
            this.button_add_author = new System.Windows.Forms.Button();
            this.authors_label1 = new System.Windows.Forms.Label();
            this.author_add_text_box = new System.Windows.Forms.TextBox();
            this.authors = new System.Windows.Forms.Label();
            this.songs = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.album_label_song = new System.Windows.Forms.Label();
            this.album_text_box_song = new System.Windows.Forms.TextBox();
            this.remove_song_button = new System.Windows.Forms.Button();
            this.add_song__button = new System.Windows.Forms.Button();
            this.label_name_of_song = new System.Windows.Forms.Label();
            this.name_of_song_text_box = new System.Windows.Forms.TextBox();
            this.tags = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tag_add_button = new System.Windows.Forms.Button();
            this.tag_label = new System.Windows.Forms.Label();
            this.add_tag_text_box = new System.Windows.Forms.TextBox();
            this.show_all_tag_button = new System.Windows.Forms.Button();
            this.albums = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.add_album_author_label = new System.Windows.Forms.Label();
            this.add_album_author_text_box = new System.Windows.Forms.TextBox();
            this.search_album_button = new System.Windows.Forms.Button();
            this.search_album_label = new System.Windows.Forms.Label();
            this.search_album_text_box = new System.Windows.Forms.TextBox();
            this.rm_album_button = new System.Windows.Forms.Button();
            this.rm_album_label = new System.Windows.Forms.Label();
            this.remove_album_text_box = new System.Windows.Forms.TextBox();
            this.add_album_button = new System.Windows.Forms.Button();
            this.add_album_label = new System.Windows.Forms.Label();
            this.show_all_album_button = new System.Windows.Forms.Button();
            this.add_album_text_box = new System.Windows.Forms.TextBox();
            this.show_all_songs_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.authorToolStripMenuItem,
            this.bestSongsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1044, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAMusicToolStripMenuItem,
            this.deleteAMusicToolStripMenuItem,
            this.getSongToolStripMenuItem,
            this.updateSongToolStripMenuItem,
            this.getSongsByYearToolStripMenuItem1});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.optionToolStripMenuItem.Text = "Song";
            // 
            // addAMusicToolStripMenuItem
            // 
            this.addAMusicToolStripMenuItem.Name = "addAMusicToolStripMenuItem";
            this.addAMusicToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.addAMusicToolStripMenuItem.Text = "Add new song";
            this.addAMusicToolStripMenuItem.Click += new System.EventHandler(this.addAMusicToolStripMenuItem_Click);
            // 
            // deleteAMusicToolStripMenuItem
            // 
            this.deleteAMusicToolStripMenuItem.Name = "deleteAMusicToolStripMenuItem";
            this.deleteAMusicToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.deleteAMusicToolStripMenuItem.Text = "Delete song";
            // 
            // getSongToolStripMenuItem
            // 
            this.getSongToolStripMenuItem.Name = "getSongToolStripMenuItem";
            this.getSongToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.getSongToolStripMenuItem.Text = "Get song";
            // 
            // updateSongToolStripMenuItem
            // 
            this.updateSongToolStripMenuItem.Name = "updateSongToolStripMenuItem";
            this.updateSongToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.updateSongToolStripMenuItem.Text = "Update song";
            // 
            // getSongsByYearToolStripMenuItem1
            // 
            this.getSongsByYearToolStripMenuItem1.Name = "getSongsByYearToolStripMenuItem1";
            this.getSongsByYearToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.getSongsByYearToolStripMenuItem1.Text = "Get songs by year";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewAuthorToolStripMenuItem,
            this.getSongByAuthorToolStripMenuItem,
            this.deleteSongsByAuthorToolStripMenuItem,
            this.deleteAuthorToolStripMenuItem});
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.authorToolStripMenuItem.Text = "Author";
            // 
            // addNewAuthorToolStripMenuItem
            // 
            this.addNewAuthorToolStripMenuItem.Name = "addNewAuthorToolStripMenuItem";
            this.addNewAuthorToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.addNewAuthorToolStripMenuItem.Text = "Add new author";
            this.addNewAuthorToolStripMenuItem.Click += new System.EventHandler(this.addNewAuthorToolStripMenuItem_Click);
            // 
            // getSongByAuthorToolStripMenuItem
            // 
            this.getSongByAuthorToolStripMenuItem.Name = "getSongByAuthorToolStripMenuItem";
            this.getSongByAuthorToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.getSongByAuthorToolStripMenuItem.Text = "Get song by author";
            // 
            // deleteSongsByAuthorToolStripMenuItem
            // 
            this.deleteSongsByAuthorToolStripMenuItem.Name = "deleteSongsByAuthorToolStripMenuItem";
            this.deleteSongsByAuthorToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.deleteSongsByAuthorToolStripMenuItem.Text = "Delete songs by author";
            // 
            // deleteAuthorToolStripMenuItem
            // 
            this.deleteAuthorToolStripMenuItem.Name = "deleteAuthorToolStripMenuItem";
            this.deleteAuthorToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.deleteAuthorToolStripMenuItem.Text = "Delete author";
            // 
            // bestSongsToolStripMenuItem
            // 
            this.bestSongsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getBestSongsToolStripMenuItem});
            this.bestSongsToolStripMenuItem.Name = "bestSongsToolStripMenuItem";
            this.bestSongsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bestSongsToolStripMenuItem.Text = "Best songs";
            // 
            // getBestSongsToolStripMenuItem
            // 
            this.getBestSongsToolStripMenuItem.Name = "getBestSongsToolStripMenuItem";
            this.getBestSongsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.getBestSongsToolStripMenuItem.Text = "Get best songs of this year";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.remove_author_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.remove_author_text_box);
            this.panel1.Controls.Add(this.show_authors_button);
            this.panel1.Controls.Add(this.button_add_author);
            this.panel1.Controls.Add(this.authors_label1);
            this.panel1.Controls.Add(this.author_add_text_box);
            this.panel1.Location = new System.Drawing.Point(58, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 173);
            this.panel1.TabIndex = 2;
            // 
            // remove_author_button
            // 
            this.remove_author_button.Location = new System.Drawing.Point(177, 88);
            this.remove_author_button.Name = "remove_author_button";
            this.remove_author_button.Size = new System.Drawing.Size(75, 23);
            this.remove_author_button.TabIndex = 16;
            this.remove_author_button.Text = "Remove author";
            this.remove_author_button.UseVisualStyleBackColor = true;
            this.remove_author_button.Click += new System.EventHandler(this.remove_author_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enter name of author";
            // 
            // remove_author_text_box
            // 
            this.remove_author_text_box.Location = new System.Drawing.Point(43, 89);
            this.remove_author_text_box.Name = "remove_author_text_box";
            this.remove_author_text_box.Size = new System.Drawing.Size(119, 23);
            this.remove_author_text_box.TabIndex = 14;
            // 
            // show_authors_button
            // 
            this.show_authors_button.Location = new System.Drawing.Point(88, 130);
            this.show_authors_button.Name = "show_authors_button";
            this.show_authors_button.Size = new System.Drawing.Size(119, 23);
            this.show_authors_button.TabIndex = 13;
            this.show_authors_button.Text = "Show all authors";
            this.show_authors_button.UseVisualStyleBackColor = true;
            this.show_authors_button.Click += new System.EventHandler(this.show_authors_button_Click);
            // 
            // button_add_author
            // 
            this.button_add_author.Location = new System.Drawing.Point(177, 35);
            this.button_add_author.Name = "button_add_author";
            this.button_add_author.Size = new System.Drawing.Size(75, 23);
            this.button_add_author.TabIndex = 12;
            this.button_add_author.Text = "Add author";
            this.button_add_author.UseVisualStyleBackColor = true;
            this.button_add_author.Click += new System.EventHandler(this.button_add_author_Click);
            // 
            // authors_label1
            // 
            this.authors_label1.AutoSize = true;
            this.authors_label1.Location = new System.Drawing.Point(43, 18);
            this.authors_label1.Name = "authors_label1";
            this.authors_label1.Size = new System.Drawing.Size(119, 15);
            this.authors_label1.TabIndex = 11;
            this.authors_label1.Text = "Enter name of author";
            // 
            // author_add_text_box
            // 
            this.author_add_text_box.Location = new System.Drawing.Point(43, 36);
            this.author_add_text_box.Name = "author_add_text_box";
            this.author_add_text_box.Size = new System.Drawing.Size(119, 23);
            this.author_add_text_box.TabIndex = 10;
            // 
            // authors
            // 
            this.authors.AutoSize = true;
            this.authors.Location = new System.Drawing.Point(191, 52);
            this.authors.Name = "authors";
            this.authors.Size = new System.Drawing.Size(44, 15);
            this.authors.TabIndex = 3;
            this.authors.Text = "Author";
            // 
            // songs
            // 
            this.songs.AutoSize = true;
            this.songs.Location = new System.Drawing.Point(742, 52);
            this.songs.Name = "songs";
            this.songs.Size = new System.Drawing.Size(34, 15);
            this.songs.TabIndex = 5;
            this.songs.Text = "Song";
            this.songs.Click += new System.EventHandler(this.songs_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.show_all_songs_button);
            this.panel2.Controls.Add(this.album_label_song);
            this.panel2.Controls.Add(this.album_text_box_song);
            this.panel2.Controls.Add(this.remove_song_button);
            this.panel2.Controls.Add(this.add_song__button);
            this.panel2.Controls.Add(this.label_name_of_song);
            this.panel2.Controls.Add(this.name_of_song_text_box);
            this.panel2.Location = new System.Drawing.Point(530, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 173);
            this.panel2.TabIndex = 4;
            // 
            // album_label_song
            // 
            this.album_label_song.AutoSize = true;
            this.album_label_song.Location = new System.Drawing.Point(237, 39);
            this.album_label_song.Name = "album_label_song";
            this.album_label_song.Size = new System.Drawing.Size(114, 15);
            this.album_label_song.TabIndex = 20;
            this.album_label_song.Text = "Enter album of song";
            // 
            // album_text_box_song
            // 
            this.album_text_box_song.Location = new System.Drawing.Point(221, 63);
            this.album_text_box_song.Name = "album_text_box_song";
            this.album_text_box_song.Size = new System.Drawing.Size(140, 23);
            this.album_text_box_song.TabIndex = 19;
            // 
            // remove_song_button
            // 
            this.remove_song_button.Location = new System.Drawing.Point(220, 94);
            this.remove_song_button.Name = "remove_song_button";
            this.remove_song_button.Size = new System.Drawing.Size(141, 23);
            this.remove_song_button.TabIndex = 18;
            this.remove_song_button.Text = "Remove song";
            this.remove_song_button.UseVisualStyleBackColor = true;
            // 
            // add_song__button
            // 
            this.add_song__button.Location = new System.Drawing.Point(72, 94);
            this.add_song__button.Name = "add_song__button";
            this.add_song__button.Size = new System.Drawing.Size(142, 23);
            this.add_song__button.TabIndex = 17;
            this.add_song__button.Text = "Add song";
            this.add_song__button.UseVisualStyleBackColor = true;
            this.add_song__button.Click += new System.EventHandler(this.add_song__button_Click);
            // 
            // label_name_of_song
            // 
            this.label_name_of_song.AutoSize = true;
            this.label_name_of_song.Location = new System.Drawing.Point(88, 39);
            this.label_name_of_song.Name = "label_name_of_song";
            this.label_name_of_song.Size = new System.Drawing.Size(110, 15);
            this.label_name_of_song.TabIndex = 13;
            this.label_name_of_song.Text = "Enter name of song";
            // 
            // name_of_song_text_box
            // 
            this.name_of_song_text_box.Location = new System.Drawing.Point(72, 63);
            this.name_of_song_text_box.Name = "name_of_song_text_box";
            this.name_of_song_text_box.Size = new System.Drawing.Size(140, 23);
            this.name_of_song_text_box.TabIndex = 12;
            // 
            // tags
            // 
            this.tags.AutoSize = true;
            this.tags.Location = new System.Drawing.Point(186, 304);
            this.tags.Name = "tags";
            this.tags.Size = new System.Drawing.Size(30, 15);
            this.tags.TabIndex = 7;
            this.tags.Text = "Tags";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tag_add_button);
            this.panel3.Controls.Add(this.tag_label);
            this.panel3.Controls.Add(this.add_tag_text_box);
            this.panel3.Controls.Add(this.show_all_tag_button);
            this.panel3.Location = new System.Drawing.Point(53, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 183);
            this.panel3.TabIndex = 6;
            // 
            // tag_add_button
            // 
            this.tag_add_button.Location = new System.Drawing.Point(196, 79);
            this.tag_add_button.Name = "tag_add_button";
            this.tag_add_button.Size = new System.Drawing.Size(75, 23);
            this.tag_add_button.TabIndex = 20;
            this.tag_add_button.Text = "Add tag";
            this.tag_add_button.UseVisualStyleBackColor = true;
            this.tag_add_button.Click += new System.EventHandler(this.tag_add_button_Click);
            // 
            // tag_label
            // 
            this.tag_label.AutoSize = true;
            this.tag_label.Location = new System.Drawing.Point(106, 44);
            this.tag_label.Name = "tag_label";
            this.tag_label.Size = new System.Drawing.Size(101, 15);
            this.tag_label.TabIndex = 19;
            this.tag_label.Text = "Enter name of tag";
            // 
            // add_tag_text_box
            // 
            this.add_tag_text_box.Location = new System.Drawing.Point(62, 80);
            this.add_tag_text_box.Name = "add_tag_text_box";
            this.add_tag_text_box.Size = new System.Drawing.Size(119, 23);
            this.add_tag_text_box.TabIndex = 18;
            // 
            // show_all_tag_button
            // 
            this.show_all_tag_button.Location = new System.Drawing.Point(107, 121);
            this.show_all_tag_button.Name = "show_all_tag_button";
            this.show_all_tag_button.Size = new System.Drawing.Size(119, 23);
            this.show_all_tag_button.TabIndex = 17;
            this.show_all_tag_button.Text = "Show all tags";
            this.show_all_tag_button.UseVisualStyleBackColor = true;
            this.show_all_tag_button.Click += new System.EventHandler(this.show_all_tag_button_Click);
            // 
            // albums
            // 
            this.albums.AutoSize = true;
            this.albums.Location = new System.Drawing.Point(713, 304);
            this.albums.Name = "albums";
            this.albums.Size = new System.Drawing.Size(48, 15);
            this.albums.TabIndex = 9;
            this.albums.Text = "Albums";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.add_album_author_label);
            this.panel4.Controls.Add(this.add_album_author_text_box);
            this.panel4.Controls.Add(this.search_album_button);
            this.panel4.Controls.Add(this.search_album_label);
            this.panel4.Controls.Add(this.search_album_text_box);
            this.panel4.Controls.Add(this.rm_album_button);
            this.panel4.Controls.Add(this.rm_album_label);
            this.panel4.Controls.Add(this.remove_album_text_box);
            this.panel4.Controls.Add(this.add_album_button);
            this.panel4.Controls.Add(this.add_album_label);
            this.panel4.Controls.Add(this.show_all_album_button);
            this.panel4.Controls.Add(this.add_album_text_box);
            this.panel4.Location = new System.Drawing.Point(531, 331);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(432, 183);
            this.panel4.TabIndex = 8;
            // 
            // add_album_author_label
            // 
            this.add_album_author_label.AutoSize = true;
            this.add_album_author_label.Location = new System.Drawing.Point(18, 82);
            this.add_album_author_label.Name = "add_album_author_label";
            this.add_album_author_label.Size = new System.Drawing.Size(119, 15);
            this.add_album_author_label.TabIndex = 32;
            this.add_album_author_label.Text = "Enter name of author";
            // 
            // add_album_author_text_box
            // 
            this.add_album_author_text_box.Location = new System.Drawing.Point(18, 100);
            this.add_album_author_text_box.Name = "add_album_author_text_box";
            this.add_album_author_text_box.Size = new System.Drawing.Size(119, 23);
            this.add_album_author_text_box.TabIndex = 31;
            // 
            // search_album_button
            // 
            this.search_album_button.Location = new System.Drawing.Point(344, 102);
            this.search_album_button.Name = "search_album_button";
            this.search_album_button.Size = new System.Drawing.Size(75, 23);
            this.search_album_button.TabIndex = 30;
            this.search_album_button.Text = "Search";
            this.search_album_button.UseVisualStyleBackColor = true;
            this.search_album_button.Click += new System.EventHandler(this.search_album_button_Click);
            // 
            // search_album_label
            // 
            this.search_album_label.AutoSize = true;
            this.search_album_label.Location = new System.Drawing.Point(211, 84);
            this.search_album_label.Name = "search_album_label";
            this.search_album_label.Size = new System.Drawing.Size(118, 15);
            this.search_album_label.TabIndex = 29;
            this.search_album_label.Text = "Enter name of album";
            // 
            // search_album_text_box
            // 
            this.search_album_text_box.Location = new System.Drawing.Point(211, 102);
            this.search_album_text_box.Name = "search_album_text_box";
            this.search_album_text_box.Size = new System.Drawing.Size(119, 23);
            this.search_album_text_box.TabIndex = 28;
            // 
            // rm_album_button
            // 
            this.rm_album_button.Location = new System.Drawing.Point(344, 55);
            this.rm_album_button.Name = "rm_album_button";
            this.rm_album_button.Size = new System.Drawing.Size(75, 23);
            this.rm_album_button.TabIndex = 27;
            this.rm_album_button.Text = "Remove";
            this.rm_album_button.UseVisualStyleBackColor = true;
            this.rm_album_button.Click += new System.EventHandler(this.rm_album_button_Click);
            // 
            // rm_album_label
            // 
            this.rm_album_label.AutoSize = true;
            this.rm_album_label.Location = new System.Drawing.Point(210, 38);
            this.rm_album_label.Name = "rm_album_label";
            this.rm_album_label.Size = new System.Drawing.Size(118, 15);
            this.rm_album_label.TabIndex = 26;
            this.rm_album_label.Text = "Enter name of album";
            // 
            // remove_album_text_box
            // 
            this.remove_album_text_box.Location = new System.Drawing.Point(210, 56);
            this.remove_album_text_box.Name = "remove_album_text_box";
            this.remove_album_text_box.Size = new System.Drawing.Size(119, 23);
            this.remove_album_text_box.TabIndex = 25;
            // 
            // add_album_button
            // 
            this.add_album_button.Location = new System.Drawing.Point(40, 136);
            this.add_album_button.Name = "add_album_button";
            this.add_album_button.Size = new System.Drawing.Size(75, 23);
            this.add_album_button.TabIndex = 24;
            this.add_album_button.Text = "Add";
            this.add_album_button.UseVisualStyleBackColor = true;
            this.add_album_button.Click += new System.EventHandler(this.add_album_button_Click);
            // 
            // add_album_label
            // 
            this.add_album_label.AutoSize = true;
            this.add_album_label.Location = new System.Drawing.Point(17, 38);
            this.add_album_label.Name = "add_album_label";
            this.add_album_label.Size = new System.Drawing.Size(118, 15);
            this.add_album_label.TabIndex = 23;
            this.add_album_label.Text = "Enter name of album";
            // 
            // show_all_album_button
            // 
            this.show_all_album_button.Location = new System.Drawing.Point(210, 136);
            this.show_all_album_button.Name = "show_all_album_button";
            this.show_all_album_button.Size = new System.Drawing.Size(119, 23);
            this.show_all_album_button.TabIndex = 21;
            this.show_all_album_button.Text = "Show all albums";
            this.show_all_album_button.UseVisualStyleBackColor = true;
            this.show_all_album_button.Click += new System.EventHandler(this.show_all_album_button_Click);
            // 
            // add_album_text_box
            // 
            this.add_album_text_box.Location = new System.Drawing.Point(17, 56);
            this.add_album_text_box.Name = "add_album_text_box";
            this.add_album_text_box.Size = new System.Drawing.Size(119, 23);
            this.add_album_text_box.TabIndex = 22;
            // 
            // show_all_songs_button
            // 
            this.show_all_songs_button.Location = new System.Drawing.Point(164, 130);
            this.show_all_songs_button.Name = "show_all_songs_button";
            this.show_all_songs_button.Size = new System.Drawing.Size(119, 23);
            this.show_all_songs_button.TabIndex = 17;
            this.show_all_songs_button.Text = "Show all songs";
            this.show_all_songs_button.UseVisualStyleBackColor = true;
            this.show_all_songs_button.Click += new System.EventHandler(this.show_all_songs_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1044, 605);
            this.Controls.Add(this.albums);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tags);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.songs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.authors);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionToolStripMenuItem;
        private ToolStripMenuItem addAMusicToolStripMenuItem;
        private ToolStripMenuItem deleteAMusicToolStripMenuItem;
        private ToolStripMenuItem getSongToolStripMenuItem;
        private ToolStripMenuItem updateSongToolStripMenuItem;
        private ToolStripMenuItem getSongsByYearToolStripMenuItem1;
        private ToolStripMenuItem authorToolStripMenuItem;
        private ToolStripMenuItem getSongByAuthorToolStripMenuItem;
        private ToolStripMenuItem deleteSongsByAuthorToolStripMenuItem;
        private ToolStripMenuItem bestSongsToolStripMenuItem;
        private ToolStripMenuItem getBestSongsToolStripMenuItem;
        private ToolStripMenuItem addNewAuthorToolStripMenuItem;
        private ToolStripMenuItem deleteAuthorToolStripMenuItem;
        private Panel panel1;
        private Label authors;
        private Label songs;
        private Panel panel2;
        private Button button_add_author;
        private Label authors_label1;
        private TextBox author_add_text_box;
        private Label tags;
        private Panel panel3;
        private Label albums;
        private Panel panel4;
        private Button remove_author_button;
        private Label label1;
        private TextBox remove_author_text_box;
        private Button show_authors_button;
        private Button tag_add_button;
        private Label tag_label;
        private TextBox add_tag_text_box;
        private Button show_all_tag_button;
        private Button search_album_button;
        private Label search_album_label;
        private TextBox search_album_text_box;
        private Button rm_album_button;
        private Label rm_album_label;
        private TextBox remove_album_text_box;
        private Button add_album_button;
        private Label add_album_label;
        private Button show_all_album_button;
        private TextBox add_album_text_box;
        private Label add_album_author_label;
        private TextBox add_album_author_text_box;
        private Label album_label_song;
        private TextBox album_text_box_song;
        private Button remove_song_button;
        private Button add_song__button;
        private Label label_name_of_song;
        private TextBox name_of_song_text_box;
        private Button show_all_songs_button;
    }
}