using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MovieTutorial.MovieDB;

[ConnectionKey("Default"), Module("MovieDB"), TableName("[mov].[Person]")]
[DisplayName("Person"), InstanceName("Person")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[LookupScript("MovieDB.Person")]
public sealed class PersonRow : Row<PersonRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Person Id"), Identity, IdProperty]
    public int? PersonId
    {
        get => fields.PersonId[this];
        set => fields.PersonId[this] = value;
    }

    [DisplayName("First Name"), Size(50), NotNull]
    public string FirstName
    {
        get => fields.FirstName[this];
        set => fields.FirstName[this] = value;
    }

    [DisplayName("Lastname"), Size(50), NotNull]
    public string Lastname
    {
        get => fields.Lastname[this];
        set => fields.Lastname[this] = value;
    }

    [DisplayName("Full Name"), Concat("t0.FirstName", "' '", "t0.Lastname"), QuickSearch, NameProperty]
    public string Fullname
    {
        get => fields.Fullname[this];
        set => fields.Fullname[this] = value;
    }

    [DisplayName("Birth Date")]
    public DateTime? BirthDate
    {
        get => fields.BirthDate[this];
        set => fields.BirthDate[this] = value;
    }

    [DisplayName("Birth Place"), Size(100)]
    public string BirthPlace
    {
        get => fields.BirthPlace[this];
        set => fields.BirthPlace[this] = value;
    }

    [DisplayName("Gender")]
    public Gender? Gender
    {
        get => fields.Gender[this];
        set => fields.Gender[this] = value;
    }

    [DisplayName("Height")]
    public int? Height
    {
        get => fields.Height[this];
        set => fields.Height[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field PersonId;
        public StringField FirstName;
        public StringField Lastname;
        public StringField Fullname;
        public DateTimeField BirthDate;
        public StringField BirthPlace;
        public EnumField<Gender> Gender;
        public Int32Field Height;

    }
}