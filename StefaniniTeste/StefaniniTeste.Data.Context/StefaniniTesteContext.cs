using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using StefaniniTeste.Data.Context.Config;
//using StefaniniTeste.Domain.Entities;

namespace StefaniniTeste.Data.Context
{
    public class StefaniniTesteContext : BaseDbContext
    {
        static StefaniniTesteContext()
        {
            Database.SetInitializer(new ContextInitializer());
        }

        public StefaniniTesteContext()
            : base("MusicStoreEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);

            //modelBuilder.Configurations.Add(new GenreMap());
            //modelBuilder.Configurations.Add(new ArtistMap());
            //modelBuilder.Configurations.Add(new AlbumMap());
            //modelBuilder.Configurations.Add(new CartMap());
            //modelBuilder.Configurations.Add(new OrderMap());
            //modelBuilder.Configurations.Add(new OrderDetailMap());
        }

        #region DbSet

        //public DbSet<Genre> Genres { get; set; }
        //public DbSet<Album> Albums { get; set; }
        //public DbSet<Artist> Artists { get; set; }
        //public DbSet<Cart> Carts { get; set; }
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderDetail> OrderDetails { get; set; }

        #endregion
    }
}
