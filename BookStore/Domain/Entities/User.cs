﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities
{
    [Table("User")]
    public partial class User
    {
        public User()
        {
            RefreshTokens = new HashSet<RefreshToken>();
        }

        [Key]
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("email_address")]
        [StringLength(100)]
        [Unicode(false)]
        public string EmailAddress { get; set; } = null!;
        [Column("password")]
        [StringLength(100)]
        [Unicode(false)]
        public string Password { get; set; } = null!;
        [Column("source")]
        [StringLength(100)]
        [Unicode(false)]
        public string Source { get; set; } = null!;
        [Column("first_name")]
        [StringLength(20)]
        [Unicode(false)]
        public string? FirstName { get; set; }
        [Column("middle_name")]
        [StringLength(1)]
        [Unicode(false)]
        public string? MiddleName { get; set; }
        [Column("last_name")]
        [StringLength(30)]
        [Unicode(false)]
        public string? LastName { get; set; }
        [Column("role_id")]
        public short RoleId { get; set; }
        [Column("pub_id")]
        public int PubId { get; set; }
        [Column("hire_date", TypeName = "datetime")]
        public DateTime? HireDate { get; set; }

        [ForeignKey(nameof(PubId))]
        [InverseProperty(nameof(Publisher.Users))]
        public virtual Publisher Pub { get; set; } = null!;
        [ForeignKey(nameof(RoleId))]
        [InverseProperty("Users")]
        public virtual Role Role { get; set; } = null!;
        [InverseProperty(nameof(RefreshToken.User))]
        public virtual ICollection<RefreshToken> RefreshTokens { get; set; }
    }
}
