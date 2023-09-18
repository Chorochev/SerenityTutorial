using Serenity.Navigation;
using MyPages = MovieTutorial.MovieDB.Pages;

//[assembly: NavigationLink(int.MaxValue, "Movie Database/Movies", typeof(MyPages.MoviePage), icon: "fa-video-camera")]
//[assembly: NavigationLink(int.MaxValue, "MovieDB/Genre", typeof(MyPages.GenrePage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "MovieDB/Movie Genres", typeof(MyPages.MovieGenresPage), icon: null)]