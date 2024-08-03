using Microsoft.EntityFrameworkCore;
using CRUD_using_GraphQL.Data.Entities;

namespace CRUD_using_GraphQL.Data
{
    public class MyWorldDbContext : DbContext
    {
        public MyWorldDbContext(DbContextOptions<MyWorldDbContext> options) : base(options)
        {
             
        }
        public DbSet<Cake> Cake{get; set;}
    }
}
