using ConsoleApp16.Pustok.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


#nullable disable 

namespace ConsoleApp16.Pustok.Migrations
{
    [DbContext(typeof(PustokContext))]
    [Migration("20230504150257_CategoriesTableCreated")]
    partial class CategoriesTableCreated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("P328Pustok.Models.Tag", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);
                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnType("nvarchar(20)");
                b.HasKey("Id");
                b.ToTable("Tags");
            });
#pragma warning restore 612, 618
        }
    }
}
