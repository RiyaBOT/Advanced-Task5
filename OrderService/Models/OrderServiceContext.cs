using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OrderService.Models;


namespace OrderService.Model
{
    public class OrderServiceDbContext : DbContext
    {
        
        public OrderServiceDbContext(DbContextOptions<OrderServiceDbContext> options, IConfiguration configuration, ILogger<OrderconsumerDbContext> logger) : base(options)
        {
            _logger = logger;
            Configuration = configuration;
            
        }
        
        public ILogger _logger { get; }
        public IConfiguration Configuration { get; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            var server = Configuration["DbServer"] ?? "db-mssql";
            var port = Configuration["DbPort"] ?? "1433"; // Default SQL Server port
            var user = Configuration["DbUser"] ?? "guest"; // Warning do not use the SA account
            var password = Configuration["Password"] ?? "guest";
            var database = Configuration["Database"] ?? "OrdersDb";

            _logger.LogInformation("Connection string:" + $"Server={server},{port};Database={database};User={user};Password={password}"
               );
            optionsBuilder.UseSqlServer(
                
                $"Server={server},{port};Database={database};User={user};Password={password}"
                );
            base.OnConfiguring(optionsBuilder);
        }


        
        public DbSet<OrderConsumer> OrderConsumers { get; set; }

    }
}
