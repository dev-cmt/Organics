﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Organic_Food_01_EXM.Models
{
    public class Tag
    {
        public int Id { get; set; }
        [Required, Display(Name = "Tag Name")]
        public string TagName { get; set; }
    }
}
