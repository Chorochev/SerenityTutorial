using Serenity.Navigation;
using MovieDB = MovieTutorial.MovieDB.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]

[assembly: NavigationMenu(2000, "Movie Database", icon: "fa-film")]
[assembly: NavigationLink(2100, "Movie Database/Movies", typeof(MovieDB.MoviePage), icon: "fa-video-camera")]
[assembly: NavigationLink(2200, "Movie Database/Genres", typeof(MovieDB.GenrePage), icon: "fa-thumb-tack")]