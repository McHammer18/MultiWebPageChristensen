using Microsoft.EntityFrameworkCore;

namespace MultiWebPageChristensen.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    Name = "Morgan",
                    Number = "(712)-555-6658",
                    Address = "3520 1st Street",
                    Note = "Iowa"
                },
                new Contact
                {
                    ContactId = 2,
                    Name = "Carlos",
                    Number = "(515)-265-3356",
                    Address = "5560 2nd Street",
                    Note = "Kansas"
                },
                new Contact
                {
                    ContactId = 3,
                    Name = "Victoria",
                    Number = "(659)-889-4213",
                    Address = "720 2nd Ave",
                    Note = "Ohio"
                }

            );
        }
    }
}

