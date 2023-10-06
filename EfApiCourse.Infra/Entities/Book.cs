using EfApiCourse.Infra.Entities.Enums;

namespace EfApiCourse.Infra.Entities;

public class Book
{
    public int BookId { get; set; }
    
    public string Title { get; set; }

    public LitteraryKind Kind { get; set; }

    public Author Author { get; set; }

    public virtual ICollection<Word> Words { get; set; }

    public DateTime PublicationDate { get; set; }
}