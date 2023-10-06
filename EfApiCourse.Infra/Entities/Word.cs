namespace EfApiCourse.Infra.Entities;

public class Word
{
    public int Id { get; set; }
    public virtual ICollection<Book> Books { get; set; }
}