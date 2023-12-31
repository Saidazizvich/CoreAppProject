﻿using EntityLayer;
using EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace DataAccessLayer.Concreate
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-8S475CNH\\MSSQLSERVER01; Database=CoralDb;  Trusted_Connection=True");
        }

        public DbSet<Regard> Regards { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Writer> Writers{ get; set; }

        //public DbSet<NewsLetter> NewsLetters { get; set; }
    }
}
