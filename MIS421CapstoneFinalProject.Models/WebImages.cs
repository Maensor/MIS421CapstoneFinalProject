﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MIS421CapstoneFinalProject.Models
{
    public class WebImages
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }


        public byte[] Picture { get; set; }
    }
}
