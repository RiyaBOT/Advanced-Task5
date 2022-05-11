using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CartApi.Models
{
    public class CartContext : DbContext
    {
        public CartContext(DbContextOptions<CartContext> options)
            : base(options)
        {
        }

        public DbSet<CartItem> CartItems { get; set; }
    }
}
