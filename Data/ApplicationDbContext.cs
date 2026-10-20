using Microsoft.EntityFrameworkCore;
using PaymentDetails.models;

namespace PaymentDetails.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<PaymentDetailsModel> paymentDetails { get; set; }
    }
}
