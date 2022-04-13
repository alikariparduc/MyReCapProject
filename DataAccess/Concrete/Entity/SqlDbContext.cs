using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Entity
{
    public class SqlDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//Proje hangi veritabanı ile ilişkili olduğunu belirteceğimiz yer.
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=RentACar;Integrated Security=True");

        }

        public DbSet<Car> Car { get; set; }
    }
}
