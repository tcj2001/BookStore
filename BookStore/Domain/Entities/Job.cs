﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities
{
    [Table("Job")]
    public partial class Job
    {
        [Key]
        [Column("job_id")]
        public short JobId { get; set; }
        [Column("job_desc")]
        [StringLength(50)]
        [Unicode(false)]
        public string JobDesc { get; set; } = null!;
    }
}
