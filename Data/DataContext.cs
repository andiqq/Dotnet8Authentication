using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using DotNet8Authentication.Models;

namespace DotNet8Authentication.Data 
{
 public class DataContext : IdentityDbContext
 {
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    
    public DbSet<MyUser> Users { get; set; }
 } 
}