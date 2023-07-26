using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.ViewModels
{
    public class BookAuthorViewModel
    {
        public int BookId { get; set; }

        [Required]
        [StringLength(20,MinimumLength = 5 )]
        //[MaxLength(20)]
        //[MinLength(5)]
        public string Title { get; set; }

        [Required]
        [StringLength(120, MinimumLength = 5)]
        // [MaxLength(120)]
        // [MinLength(5)]
        public string Description { get; set; }

        public int AuthorId { get; set; }
        public List<Author> Authors{ get; set; }


    }
}
