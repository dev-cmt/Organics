﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Organic_Food_01_EXM.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, Display(Name = "Category Name")]
        public string CategoryName { get; set; }
    }
}
