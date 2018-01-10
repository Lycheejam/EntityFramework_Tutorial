using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest.Models
{
    public class Author
    {
        //Bookと同じくIDは自動生成されるはず
        public int Id { get; set; }
        [MaxLength(30)]
        [Required]
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
