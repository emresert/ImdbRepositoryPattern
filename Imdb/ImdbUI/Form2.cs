using ImdbData.Contexts;
using ImdbData.Models;
using ImdbData.Objects;
using ImdbService.Services;
using ImdbData.Repositories;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Movie _Movie = new Movie();
        List<Star> _Starts = new List<Star>();
        List<Writer> _Writers = new List<Writer>();
        List<Director> _Directors = new List<Director>();
        Description _Description = new Description();
        MovieService _movieService = new MovieService();
        CastService _castService = new CastService();
        CastRoleService _castRoleService = new CastRoleService();
        MovieCastRoleMappingService _movieCastRoleMappingService = new MovieCastRoleMappingService();

        public Form2(Movie Movie, List<Star> Stars, List<Writer> Writers, List<Director> Directors, Description Description)
        {
            _Movie = Movie;
            _Starts = Stars;
            _Writers = Writers;
            _Directors = Directors;
            _Description = Description;
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                /*Helper Variable to Insert inside MovieCastRoleMapping*/
                int movieId, castId, castRoleId;

                /* Find Movie*/
                var _movie = _movieService.FindMovie(_Movie.movieLink);
         
                if (_movie == null)
                {
                    /*To bring new Id from Movie Service*/
                    movieId=_movieService.GenerateMovieId(_Movie);
                }
                else
                {
                    movieId = _movie.movieId;
                }
               
                foreach (var star in _Starts)
                {
                    var _cast = _castService.FindCast(star.starLink);

                    if (_cast == null)
                    {
                        /*To bring new Id from Cast Service*/
                        castId = _castService.CastGenerateCastId(star);
                        
                    }
                    else
                    {
                        castId = _cast.castId;
                    }
                    
                    var castRoleTest = _castRoleService.FindCastRole("Star");

                    if (castRoleTest == null)
                    {
                        /*To bring new Id from CastRole Service*/
                        castRoleId = _castRoleService.CastRoleGenerateCastRoleId("Star");
                    }
                    else
                    {
                        castRoleId = castRoleTest.castRoleId;
                    }

                    /* Insert For mapping*/
                    bool insertState = false;
                    insertState = _movieCastRoleMappingService.MovieCastRoleMappingGenareteId(castId, castRoleId, movieId);
                    if (insertState == true) continue;

                }

                foreach (var writer in _Writers)
                {

                    var _cast = _castService.FindCast(writer.writerLink);
                    if (_cast == null)
                    {
                        /*To bring new Id from Cast Service*/
                        castId = _castService.CastGenerateCastId(writer); 
                    }
                    else
                    {
                        castId = _cast.castId;
                    }

                    var castRoleTest = _castRoleService.FindCastRole("Writer");

                    if (castRoleTest == null)
                    {
                        /*To bring new Id from CastRole Service*/
                        castRoleId = _castRoleService.CastRoleGenerateCastRoleId("Writer");
                    }
                    else
                    {
                        castRoleId = castRoleTest.castRoleId;
                    }

                    /* Insert For mapping*/
                    bool insertState = false;
                    insertState = _movieCastRoleMappingService.MovieCastRoleMappingGenareteId(castId, castRoleId, movieId);
                    if (insertState == true) continue;
                  
                }
               
                foreach (var director in _Directors)
                {

                    var _cast = _castService.FindCast(director.directorLink);
                    if (_cast == null)
                    {
                        /*To bring new Id from Cast Service*/
                        castId = _castService.CastGenerateCastId(director);
                    }
                    else
                    {
                        castId = _cast.castId;
                    }

                    var castRoleTest = _castRoleService.FindCastRole("Director");

                    if (castRoleTest == null)
                    {
                        /*To bring new Id from CastRole Service*/
                        castRoleId = _castRoleService.CastRoleGenerateCastRoleId("Director");
                    }
                    else
                    {
                        castRoleId = castRoleTest.castRoleId;
                    }

                    /* Insert For mapping*/
                    bool insertState = false;
                    insertState = _movieCastRoleMappingService.MovieCastRoleMappingGenareteId(castId, castRoleId, movieId);
                    if (insertState == true) continue;

                }

                MessageBox.Show("Movie saved to Database");

            }
            catch
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var _movie = _movieService.FindMovie(_Movie.movieLink);
            if (_movie != null)
            {
                var mcrmList = _movieCastRoleMappingService.getMcrmList();

                foreach (MovieCastRoleMapping mcrmItem in mcrmList)
                {
                    if (mcrmItem.fkMovieId == _movie.movieId)
                    {
                        /* Delete For mapping*/
                        bool deleteState = false;
                        deleteState = _movieCastRoleMappingService.deleteMovieCastRoleMapping(mcrmItem);
                        if (deleteState == true) continue;
                    }
                }
                bool movieDeleteState = false;
                movieDeleteState = _movieService.deleteMovie(_movie);
                if (movieDeleteState == true)
                {
                    MessageBox.Show("Movie is removed");
                } 
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                rtbxMovieName.Text = _Movie.movieName + " (" + _Movie.movieYear + ")";
                foreach (var itemForStar in _Starts)
                {
                    rtbxStars.Text = rtbxStars.Text + " " + itemForStar.NameSurname;
                }
                foreach (var itemForWriter in _Writers)
                {
                    rtbxWriters.Text = rtbxWriters.Text + " " + itemForWriter.NameSurname;
                }
                foreach (var itemForDirector in _Directors)
                {
                    rtbxDirectors.Text = rtbxDirectors.Text + " " + itemForDirector.NameSurname;
                }
                rtbxDescription.Text = _Description.DescriptionContent;
            }
            catch
            {

                MessageBox.Show("Something went wrong!");
            }
        }
    }
}
