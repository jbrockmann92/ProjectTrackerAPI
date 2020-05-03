﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class HoursSpent
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Hours { get; set; }
    }
}
