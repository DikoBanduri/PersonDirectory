namespace PersonDirectory.DTO;

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public Gender Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public string PIN { get; set; } = null!;
    public string Address { get; set; } = null!;
    public DateTime CreateDate { get; set; }
    public bool IsDelete { get; set; }
    public City City { get; set; } = null!;
    public ICollection<Phone>? PhoneNumbers { get; set; }
    public ICollection<Relation>? FromRelations { get; set; }
    public ICollection<Relation>? ToRelations { get; set; }
}
public enum Gender : byte
{
    Male = 0,
    Female = 1
}
