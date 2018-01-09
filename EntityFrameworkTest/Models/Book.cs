using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest.Models
{
    public class Book
    {
        //IDは自動生成されるはず
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublishedYear { get; set; }
        public virtual Author Author { get; set; }
    }
}
