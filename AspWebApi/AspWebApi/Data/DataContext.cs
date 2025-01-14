﻿using AspWebApi.Core;

namespace AspWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        { }
        public DbSet<ProductEntity> Products { get; set; }
    }

}
