﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlackboxFest.Models
{
    public class TimeSlot
    {
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string Hour { get; set; }

        public virtual IEnumerable<Concert> Concert { get; set; }
    }
}
