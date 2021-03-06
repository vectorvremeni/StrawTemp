using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StrawTemp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Presents> Presents { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }

    [Table("Presents",Schema ="PR")]
    public class Presents
    {
        [Key]
        public int Id { get; set; }
        public String UserId { get; set; }
        public String EduClass { get; set; }
        public DateTime RegisrationDateTime { get; set; }
    }
}
