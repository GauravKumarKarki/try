﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ropey.Models
{
    [Table("Producer")]
    public partial class Producer
    {
        public Producer()
        {
            Dvdtitles = new HashSet<Dvdtitle>();
        }

        [Key]
        public int ProducerNumber { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? ProducerName { get; set; }

        [InverseProperty("ProducerNumberNavigation")]
        public virtual ICollection<Dvdtitle> Dvdtitles { get; set; }
    }
}
