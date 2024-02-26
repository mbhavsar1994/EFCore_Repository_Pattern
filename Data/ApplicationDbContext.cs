using Microsoft.EntityFrameworkCore;
using PocketBook.Models;

namespace PocketBook.Data;

public class ApplicationDbContext : DbContext
{
    // the dbset property will be used with ef core to ensure the table creation if doesn't exist 
    public virtual DbSet<User> Users { get; set;}

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)   
    {
        
    }
}
