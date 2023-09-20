using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MovieTutorial.MovieDB.Columns;

[ColumnsScript("MovieDB.Person")]
[BasedOnRow(typeof(PersonRow), CheckNames = true)]
public class PersonColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int PersonId { get; set; }
    [EditLink]
    public string FirstName { get; set; }
    public string Lastname { get; set; }
    public DateTime BirthDate { get; set; }
    public string BirthPlace { get; set; }
    public int Gender { get; set; }
    public int Height { get; set; }
}