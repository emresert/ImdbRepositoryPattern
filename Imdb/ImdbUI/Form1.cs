using HtmlAgilityPack;
using ImdbData.Models;
using ImdbData.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImdbUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Movie> _Movies = new List<Movie>();
        List<Star> _Stars = new List<Star>();
        List<Director> _Directors = new List<Director>();
        List<Writer> _Writers = new List<Writer>();
        Description _description = new Description();
        HtmlWeb web = new HtmlWeb();
        string imdbLink = "http://www.imdb.com";
        private void btnForSearch_Click(object sender, EventArgs e)
        {
            try
            {
                _Movies.Clear();

                string movieName = txbMovieName.Text;
                movieName = movieName.Trim();
                movieName = movieName.Replace(" ", "+");
                movieName = movieName.ToLower();

                HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.imdb.com/find?q=" + movieName + "&ref_=nv_sr_sm");
                string xPathForTable = "/html[1]/body[1]/div[3]/div[1]/div[2]/div[3]/div[1]/div[1]/div[2]/table";

                string movieNameFromInner, movieUrlFromInner, movieImageUrlFromInner;
                int indexFirst;


                HtmlNode nodeMovieImageURL = doc.DocumentNode.SelectSingleNode(xPathForTable);

                foreach (HtmlNode childOne in nodeMovieImageURL.ChildNodes)
                {
                    if (childOne.Name == "tr")
                    {
                        Movie _movie = new Movie();
                        movieNameFromInner = childOne.InnerText;
                        indexFirst = movieNameFromInner.IndexOf("(", 0);
                        _movie.movieName = movieNameFromInner.Substring(0, indexFirst - 1).Trim();
                        _movie.movieYear = movieNameFromInner.Substring(indexFirst + 1, 4);
                        foreach (HtmlNode childTwo in childOne.ChildNodes)
                        {
                            if (childTwo.Name == "td")
                            {
                                movieUrlFromInner = childTwo.InnerHtml;
                                movieUrlFromInner = movieUrlFromInner.Replace("<a href=\"", "");
                                movieUrlFromInner = movieUrlFromInner.Replace("\">", "*");
                                movieUrlFromInner = movieUrlFromInner.Trim();
                                indexFirst = movieUrlFromInner.IndexOf("*", 0);
                                _movie.movieLink = movieUrlFromInner.Substring(0, indexFirst).Trim();
                                foreach (HtmlNode childTree in childTwo.ChildNodes)
                                {
                                    if (childTree.Name == "a")
                                    {
                                        foreach (HtmlNode childFour in childTree.ChildNodes)
                                        {
                                            if (childFour.Name == "img")
                                            {
                                                movieImageUrlFromInner = childTree.InnerHtml;
                                                movieImageUrlFromInner = movieImageUrlFromInner.Replace("<img src=\"", "");
                                                movieImageUrlFromInner = movieImageUrlFromInner.Replace("\">", "*");
                                                movieImageUrlFromInner = movieImageUrlFromInner.Trim();
                                                indexFirst = movieImageUrlFromInner.IndexOf("*", 0);
                                                _movie.movieImageUrl = movieImageUrlFromInner.Substring(0, indexFirst);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        _Movies.Add(_movie);
                    }
                }

                clearItems();
                foreach (var item in _Movies)
                {
                    var _movie = _Movies.FirstOrDefault(m => m.movieLink == item.movieLink);
                    lbMovieInfo.Items.Add(_movie.movieName + " (" + _movie.movieYear + ")");
                    lbMovieLink.Items.Add(_movie.movieLink);
                }
            }
            catch
            {

                MessageBox.Show("Something went wrong in a node!");
            }
        }
        private void lbMovieInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbMovieLink.SelectedIndex = lbMovieInfo.SelectedIndex;
            var selectedMovie = _Movies.FirstOrDefault(m => m.movieLink == lbMovieLink.GetItemText(lbMovieLink.SelectedItem));

            fetchMovieDetail(selectedMovie.movieLink);
        }

        private void lbMovieLink_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbMovieInfo.SelectedIndex = lbMovieLink.SelectedIndex;
        }
        public void clearItems()
        {
            lbMovieInfo.Items.Clear();
            lbMovieLink.Items.Clear();
            lblDescription.Text = "";
            lblRateValue.Text = "";
        }
        public void clearLabels()
        {
            _Directors.Clear();
            _Writers.Clear();
            _Stars.Clear();
            lblDirectorsName.Text = "";
            lblWritersName.Text = "";
            lblStarsName.Text = "";
            pbMovieImage.ImageLocation = "";
        }
        public void fetchMovieDetail(string _url)
        {
            try
            {
                clearLabels();
                var _selectedMovie = _Movies.FirstOrDefault(m => m.movieLink == _url);

                HtmlAgilityPack.HtmlDocument doc = web.Load(imdbLink + _selectedMovie.movieLink);

                _description.DescriptionContent = doc.DocumentNode.Descendants("div").FirstOrDefault(o => o.GetAttributeValue("class", "") == "summary_text").InnerText.Trim();
                _description.DescriptionContent = _description.DescriptionContent.Replace("See full summary&nbsp;&raquo;", "").Trim();
                lblDescription.Text = _description.DescriptionContent;



                string movieRating = doc.DocumentNode.Descendants("div").FirstOrDefault(o => o.GetAttributeValue("class", "") == "ratingValue").InnerText.Trim();
                lblRateValue.Text = movieRating;

                //var movieRating2 = doc.DocumentNode.Descendants("div").FirstOrDefault(o => o.GetAttributeValue("class", "") == "plot_summary_wrapper");

                string xPathForDirectors = "/html[1]/body[1]/div[3]/div[1]/div[2]/div[5]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]";
                string xPathForWriters = "/html[1]/body[1]/div[3]/div[1]/div[2]/div[5]/div[1]/div[1]/div[1]/div[2]/div[1]/div[3]";
                string xPathForStars = "/html[1]/body[1]/div[3]/div[1]/div[2]/div[5]/div[1]/div[1]/div[1]/div[2]/div[1]/div[4]";

                HtmlNode nodeDirectors = doc.DocumentNode.SelectSingleNode(xPathForDirectors);
                HtmlNode nodeWriters = doc.DocumentNode.SelectSingleNode(xPathForWriters);
                HtmlNode nodeStars = doc.DocumentNode.SelectSingleNode(xPathForStars);

                /* Helper Variables */
                string directoryLink, writerLink, starLink;
                int indexDirector, indexWriter, indexStar;

                if (nodeDirectors != null && nodeWriters != null && nodeDirectors != null)
                {

                    foreach (var childOne in nodeDirectors.ChildNodes)
                    {
                        Director _director = new Director();
                        if (childOne.Name == "a") /* Go inside a tag of Director */
                        {
                            _director.NameSurname = childOne.InnerHtml.Trim();
                            directoryLink = childOne.OuterHtml.Replace("\">", "#");
                            directoryLink = directoryLink.Replace("<a href=\"", "");
                            indexDirector = directoryLink.IndexOf("#", 0);
                            _director.directorLink = directoryLink.Substring(0, indexDirector).Trim();
                            _Directors.Add(_director);
                        }
                    }
                    lblDirectorsName.Text = "";
                    foreach (var item in _Directors)
                    {
                        lblDirectorsName.Text = lblDirectorsName.Text + " " + item.NameSurname;
                    }

                    foreach (var childOne in nodeWriters.ChildNodes)
                    {
                        Writer _writer = new Writer();
                        if (childOne.Name == "a") /* Go inside a tag of Writers */
                        {
                            _writer.NameSurname = childOne.InnerHtml.Trim();
                            writerLink = childOne.OuterHtml.Replace("\">", "#");
                            writerLink = writerLink.Replace("<a href=\"", "");
                            indexWriter = writerLink.IndexOf("#", 0);
                            _writer.writerLink = writerLink.Substring(0, indexWriter).Trim();
                            _Writers.Add(_writer);
                        }
                    }
                    lblWritersName.Text = "";
                    foreach (var item in _Writers)
                    {
                        lblWritersName.Text = lblWritersName.Text + " " + item.NameSurname;
                    }

                    foreach (var childOne in nodeStars.ChildNodes)
                    {
                        Star _star = new Star();
                        if (childOne.Name == "a" && childOne.InnerHtml.Trim() != "See full cast & crew") /* Go inside a tag of Stars */
                        {
                            _star.NameSurname = childOne.InnerHtml.Trim();
                            starLink = childOne.OuterHtml.Replace("\">", "#");
                            starLink = starLink.Replace("<a href=\"", "");
                            indexStar = starLink.IndexOf("#", 0);
                            _star.starLink = starLink.Substring(0, indexStar).Trim();
                            _Stars.Add(_star);
                        }
                    }
                    lblStarsName.Text = "";
                    foreach (var item in _Stars)
                    {
                        lblStarsName.Text = lblStarsName.Text + " " + item.NameSurname;
                    }

                }



                pbMovieImage.ImageLocation = _selectedMovie.movieImageUrl;
            }
            catch
            {

                MessageBox.Show("Something went wrong in a node!");

            }

        }
        private void btnForm2_Click(object sender, EventArgs e)
        {

            Movie _selectedMovie = new Movie();
            _selectedMovie = _Movies.FirstOrDefault(m => m.movieLink == lbMovieLink.GetItemText(lbMovieLink.SelectedItem));
            Form2 _form2 = new Form2(_selectedMovie, _Stars, _Writers, _Directors, _description);
            _form2.Show();
        }
        private void btnDirectorBio_Click(object sender, EventArgs e)
        {
            if (_Directors.Count > 0)
            {
                Form3 _form3 = new Form3(_Directors);
                _form3.Show();
            }
            else
            {
                MessageBox.Show("Directors Part is empty.");
            }
        }

        private void btnWriterInfo_Click(object sender, EventArgs e)
        {
            if (_Writers.Count > 0)
            {
                Form3 _form3 = new Form3(_Writers);
                _form3.Show();
            }
            else
            {
                MessageBox.Show("Writers Part is empty.");
            }
        }

        private void btnStarBio_Click(object sender, EventArgs e)
        {
            if (_Stars.Count > 0)
            {
                Form3 _form3 = new Form3(_Stars);
                _form3.Show();
            }
            else
            {
                MessageBox.Show("Stars Part is empty.");
            }
        }


    }
}
