using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkTest.Models
{
    public class Book
    {
        //IDは自動生成されるはず
        public int Id { get; set; }
        [MaxLength(30)]
        [Required]
        public string Title { get; set; }
        public int PublishedYear { get; set; }
        public virtual Author Author { get; set; }
    }
}
