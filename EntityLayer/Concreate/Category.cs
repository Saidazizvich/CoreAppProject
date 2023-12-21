﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescripation { get; set; }

        public bool CategryStatus { get; set; }

        [NotMapped]
        public List<Blog> Blogs { get; set; }

        public Blog Blog { get; set; }



    }
}
