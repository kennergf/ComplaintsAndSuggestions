using ComplaintsAndSuggestions.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ComplaintsAndSuggestions.Data
{
    public class ComplaintSuggestionDbContext : IdentityDbContext<User>
    {
        public DbSet<ComplaintSuggestion> ComplaintsSuggestions {get;set;}

        public ComplaintSuggestionDbContext(DbContextOptions<ComplaintSuggestionDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}