using Serenity.ComponentModel;
using System;

namespace MovieTutorial.MovieDB.Forms;

[FormScript("MovieDB.Person")]
[BasedOnRow(typeof(PersonRow), CheckNames = true)]
public class PersonForm
{
    public string FirstName { get; set; }
    public string Lastname { get; set; }
    public DateTime BirthDate { get; set; }
    public string BirthPlace { get; set; }
    public int Gender { get; set; }
    public int Height { get; set; }
}