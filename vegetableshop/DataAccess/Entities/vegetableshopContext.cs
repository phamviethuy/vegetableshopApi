using Microsoft.EntityFrameworkCore;

namespace vegetableshop.DataAccess.Entities
{
    public partial class vegetableshopContext : DbContext
    {
        public vegetableshopContext()
        {
        }

        public vegetableshopContext(DbContextOptions<vegetableshopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Links> Links { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Realvegetables> Realvegetables { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Vegetableimages> Vegetableimages { get; set; }
        public virtual DbSet<Vegetables> Vegetables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=vegetableshop;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Links>(entity =>
            {
                entity.ToTable("links");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Link)
                    .HasColumnName("link")
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.VegetableId).HasColumnName("vegetableId");

                entity.HasOne(d => d.Vegetable)
                    .WithMany(p => p.Links)
                    .HasForeignKey(d => d.VegetableId)
                    .HasConstraintName("FK_links_vegetables");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.ToTable("orders");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.VegetableId).HasColumnName("vegetableId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_orders_users");

                entity.HasOne(d => d.Vegetable)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.VegetableId)
                    .HasConstraintName("FK_orders_vegetables");
            });

            modelBuilder.Entity<Realvegetables>(entity =>
            {
                entity.ToTable("realvegetables");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descriptions)
                    .HasColumnName("descriptions")
                    .HasMaxLength(1000);

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Promotionprice)
                    .HasColumnName("promotionprice")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Skills>(entity =>
            {
                entity.ToTable("skills");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descriptions).HasColumnName("descriptions");

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Skill)
                    .HasColumnName("skill")
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.VegetableId).HasColumnName("vegetableId");

                entity.HasOne(d => d.Vegetable)
                    .WithMany(p => p.Skills)
                    .HasForeignKey(d => d.VegetableId)
                    .HasConstraintName("FK_skills_vegetables");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.Avatar)
                    .HasColumnName("avatar")
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Role).HasColumnName("role");

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Vegetableimages>(entity =>
            {
                entity.ToTable("vegetableimages");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.RealvegetableId).HasColumnName("realvegetableId");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.VegetableId).HasColumnName("vegetableId");

                entity.HasOne(d => d.Realvegetable)
                    .WithMany(p => p.Vegetableimages)
                    .HasForeignKey(d => d.RealvegetableId)
                    .HasConstraintName("FK_vegetableimages_realvegetables");

                entity.HasOne(d => d.Vegetable)
                    .WithMany(p => p.Vegetableimages)
                    .HasForeignKey(d => d.VegetableId)
                    .HasConstraintName("FK_vegetableimages_vegetables");
            });

            modelBuilder.Entity<Vegetables>(entity =>
            {
                entity.ToTable("vegetables");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Endworkingtime)
                    .HasColumnName("endworkingtime")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200);

                entity.Property(e => e.Nickname)
                    .HasColumnName("nickname")
                    .HasMaxLength(200);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Phonenumber)
                    .HasColumnName("phonenumber")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Promotionprice)
                    .HasColumnName("promotionprice")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Ratting).HasColumnName("ratting");

                entity.Property(e => e.Skin).HasColumnName("skin");

                entity.Property(e => e.Slogan)
                    .HasColumnName("slogan")
                    .HasMaxLength(400);

                entity.Property(e => e.Startworkingtime)
                    .HasColumnName("startworkingtime")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.V1)
                    .HasColumnName("v1")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.V2)
                    .HasColumnName("v2")
                    .HasColumnType("ntext");

                entity.Property(e => e.V3)
                    .HasColumnName("v3")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Wokingareas)
                    .HasColumnName("wokingareas")
                    .HasMaxLength(1000);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}