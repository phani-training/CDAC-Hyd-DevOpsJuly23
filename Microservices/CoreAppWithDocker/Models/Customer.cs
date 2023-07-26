using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreAppWithDocker.Models
{
    [Table("tblCustomer", Schema ="dbo")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }

        [Column("customername")]
        public string CustomerName { get; set; } = string.Empty;

        [Column("customeremail")]
        public string CustomerEmail { get; set; } = string.Empty;

        [Column("customerphone")]
        public long CustomerPhone { get; set; }
    }

    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> dbOptions) : base(dbOptions)
        {
            try
            {
                var dbCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
                if(dbCreator != null)
                {
                    if (!dbCreator.CanConnect()) dbCreator.Create();
                    if (!dbCreator.HasTables()) dbCreator.CreateTables();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
