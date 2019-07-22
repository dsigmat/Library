using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
    public class LibraryContext : DbContext
    {
        public LibraryContext (DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Library.Models.Book> Books { get; set; }
        public DbSet<Library.Models.Video> Videos { get; set; }
        public DbSet<Library.Models.Checkout> Checkouts { get; set; }
        public DbSet<Library.Models.CheckoutHistory> CheckoutHistorys { get; set; }
        public DbSet<Library.Models.LibraryBranch> LibraryBranchs { get; set; }
        public DbSet<Library.Models.BranchHours> BranchHours { get; set; }
        public DbSet<Library.Models.LibraryCard> LibraryCards { get; set; }
        public DbSet<Library.Models.Patron> Patrons { get; set; }
        public DbSet<Library.Models.Status> Statuses { get; set; }
        public DbSet<Library.Models.LibraryAsset> LibraryAssets { get; set; }
        public DbSet<Library.Models.Hold> Holds { get; set; }
    }
}
