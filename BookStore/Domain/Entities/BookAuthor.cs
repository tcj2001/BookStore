using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities
{
    [Table("BookAuthor")]
    public partial class BookAuthor
    {
        [Key]
        [Column("author_id")]
        public int AuthorId { get; set; }
        [Key]
        [Column("book_id")]
        public int BookId { get; set; }
        [Column("author_order")]
        public byte? AuthorOrder { get; set; }
        [Column("royality_percentage")]
        public int? RoyalityPercentage { get; set; }

        [ForeignKey(nameof(AuthorId))]
        [InverseProperty("BookAuthors")]
        public virtual Author Author { get; set; } = null!;
        [ForeignKey(nameof(BookId))]
        [InverseProperty("BookAuthors")]
        public virtual Book Book { get; set; } = null!;
    }
}
