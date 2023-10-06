namespace EfApiCourse.Infra.Entities;

public class Author
{
    public int AuthorId { get; set; }
    
    public string Firstname { get; set; }

    public string Lastname { get; set; }

    public virtual ICollection<Book> WrittenBooks { get; set; }
}