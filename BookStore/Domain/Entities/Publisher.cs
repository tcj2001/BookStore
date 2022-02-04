using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities
{
    [Table("Publisher")]
    public partial class Publisher
    {
        public Publisher()
        {
            Books = new HashSet<Book>();
            Users = new HashSet<User>();
        }

        [Key]
        [Column("pub_id")]
        public int PubId { get; set; }
        [Column("publisher_name")]
        [StringLength(40)]
        [Unicode(false)]
        public string? PublisherName { get; set; }
        [Column("city")]
        [StringLength(20)]
        [Unicode(false)]
        public string? City { get; set; }
        [Column("state")]
        [StringLength(2)]
        [Unicode(false)]
        public string? State { get; set; }
        [Column("country")]
        [StringLength(30)]
        [Unicode(false)]
        public string? Country { get; set; }

        [InverseProperty(nameof(Book.Pub))]
        public virtual ICollection<Book> Books { get; set; }
        [InverseProperty(nameof(User.Pub))]
        public virtual ICollection<User> Users { get; set; }
    }
}
