﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BDSA2017.Lecture04
{
    public class Episode
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public DateTime? FirstAired { get; set; }

        public ICollection<EpisodeCharacter> Characters { get; set; }
    }
}
