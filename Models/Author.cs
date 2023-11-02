namespace Moldovan_Andrada_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string AuthorName { get; set; }
        public ICollection<Book>? Book { get; set; }
    }
}
