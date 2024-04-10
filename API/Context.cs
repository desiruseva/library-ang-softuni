using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API
{
    public class Context: DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders{ get; set; }
        public Context(DbContextOptions<Context> options) : base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User()
            { 
                Id = 1,
                FName = "Admin",
                LName = "",
                Email = "admin@gmail.com",
                MobNumber = "123567890",
                AccountStatus = AccountStatus.ACTIVE,
                UserType = UserType.ADMIN,
                Password = "admin1",
                CreateOn = new DateTime(2024, 01, 01, 11, 12, 13),
            });

            modelBuilder.Entity<BookCategory>().HasData(
                new BookCategory { Id = 1, Category = "mathematics", SubCategory = "algebra" },
                new BookCategory { Id = 2, Category = "mathematics", SubCategory = "geometry" },
                new BookCategory { Id = 3, Category = "physics", SubCategory = "quantum physics" },
                new BookCategory { Id = 4, Category = "physics", SubCategory = "biophysics" },
                new BookCategory { Id = 5, Category = "medicine", SubCategory = "pharmacy" },
                new BookCategory { Id = 6, Category = "medicine", SubCategory = "dental" },
                new BookCategory { Id = 7, Category = "computer", SubCategory = "hardware" },
                new BookCategory { Id = 8, Category = "computer", SubCategory = "software" }
            );


            modelBuilder.Entity<Book>().HasData(
           new Book { Id = 1, BookCategoryId = 1, Ordered = false, Price = 3500, Author = "Euclid", Title = "Euclid's Elements" },
           new Book { Id = 2, BookCategoryId = 1, Ordered = false, Price = 3600, Author = "Robert Kanigel", Title = "The Man Who Knew Infinity: A Life of the Genius Ramanujan" },
           new Book { Id = 3, BookCategoryId = 1, Ordered = false, Price = 3600, Author = "Robert Kanigel", Title = "The Man Who Knew Infinity: A Life of the Genius Ramanujan" },
           new Book { Id = 4, BookCategoryId = 1, Ordered = false, Price = 3700, Author = "Stephen Hawking", Title = "A Brief History of Time" },
           new Book { Id = 5, BookCategoryId = 1, Ordered = false, Price = 3800, Author = "Albert Einstein", Title = "Relativity: The Special and the General Theory" },
           new Book { Id = 6, BookCategoryId = 1, Ordered = false, Price = 3800, Author = "Albert Einstein", Title = "Relativity: The Special and the General Theory" },
           new Book { Id = 7, BookCategoryId = 1, Ordered = false, Price = 3800, Author = "Albert Einstein", Title = "Relativity: The Special and the General Theory" },
           new Book { Id = 8, BookCategoryId = 1, Ordered = false, Price = 3800, Author = "Albert Einstein", Title = "Relativity: The Special and the General Theory" },
           new Book { Id = 9, BookCategoryId = 1, Ordered = false, Price = 3800, Author = "Albert Einstein", Title = "Relativity: The Special and the General Theory" },

           new Book { Id = 10, BookCategoryId = 2, Ordered = false, Price = 700, Author = "Michael Serra", Title = "Discovering Geometry: An Investigative Approach" },
           new Book { Id = 11, BookCategoryId = 2, Ordered = false, Price = 700, Author = "Michael Serra", Title = "Discovering Geometry: An Investigative Approach" },
           new Book { Id = 12, BookCategoryId = 2, Ordered = false, Price = 700, Author = "Michael Serra", Title = "Discovering Geometry: An Investigative Approach" },
           new Book { Id = 13, BookCategoryId = 2, Ordered = false, Price = 800, Author = "Laurie E. Bass", Title = "Holt Geometry: Student Edition" },
           new Book { Id = 14, BookCategoryId = 2, Ordered = false, Price = 900, Author = "Frederick E. Hohn", Title = "Geometry: Student Edition" },
           new Book { Id = 15, BookCategoryId = 2, Ordered = false, Price = 900, Author = "Frederick E. Hohn", Title = "Geometry: Student Edition" },
           new Book { Id = 16, BookCategoryId = 2, Ordered = false, Price = 1000, Author = "Laurie E. Bass", Title = "Holt McDougal Geometry: Student Edition" },
           new Book { Id = 17, BookCategoryId = 2, Ordered = false, Price = 1100, Author = "Jurgensen", Title = "Contemporary Geometry: A Comprehensive Course" },
           new Book { Id = 18, BookCategoryId = 2, Ordered = false, Price = 1100, Author = "Jurgensen", Title = "Contemporary Geometry: A Comprehensive Course" },
           new Book { Id = 19, BookCategoryId = 2, Ordered = false, Price = 1100, Author = "Jurgensen", Title = "Contemporary Geometry: A Comprehensive Course" },
           new Book { Id = 20, BookCategoryId = 2, Ordered = false, Price = 1200, Author = "Dan Kennedy", Title = "High School Geometry Unlocked: Your Key to Mastering Geometry" },
           new Book { Id = 21, BookCategoryId = 2, Ordered = false, Price = 1300, Author = "Frederick E. Hohn", Title = "Geometry: Student Edition" },
           new Book { Id = 22, BookCategoryId = 2, Ordered = false, Price = 1300, Author = "Frederick E. Hohn", Title = "Geometry: Student Edition" },

           new Book { Id = 23, BookCategoryId = 3, Ordered = false, Price = 1400, Author = "Franz Schwabl", Title = "Quantum Mechanics: An Introduction" },
           new Book { Id = 24, BookCategoryId = 3, Ordered = false, Price = 1500, Author = "Paul A.M. Dirac", Title = "Principles of Quantum Mechanics" },
           new Book { Id = 25, BookCategoryId = 3, Ordered = false, Price = 1500, Author = "Paul A.M. Dirac", Title = "Principles of Quantum Mechanics" },
           new Book { Id = 26, BookCategoryId = 3, Ordered = false, Price = 1600, Author = "Sakurai", Title = "Modern Quantum Mechanics" },
           new Book { Id = 27, BookCategoryId = 3, Ordered = false, Price = 1700, Author = "John S. Townsend",Title = "A Modern Approach to Quantum Mechanics"},
           new Book { Id = 28, BookCategoryId = 3, Ordered = false, Price = 1800, Author = "Steven Weinberg", Title = "Lectures on Quantum Mechanics" },
           new Book { Id = 29, BookCategoryId = 3, Ordered = false, Price = 1800, Author = "Steven Weinberg", Title = "Lectures on Quantum Mechanics" },
           new Book { Id = 30, BookCategoryId = 3, Ordered = false, Price = 1800, Author = "Steven Weinberg", Title = "Lectures on Quantum Mechanics" },

           new Book { Id = 31, BookCategoryId = 4, Ordered = false, Price = 1900, Author = "Peter Atkins",Title = "Biophysics: A Student's Guide"},
           new Book { Id = 32, BookCategoryId = 4, Ordered = false, Price = 2000, Author = "William Bialek", Title = "Biophysics: Searching for Principles" },
           new Book { Id = 33, BookCategoryId = 4, Ordered = false, Price = 2000, Author = "William Bialek", Title = "Biophysics: Searching for Principles" },
           new Book { Id = 34, BookCategoryId = 4, Ordered = false, Price = 2100, Author = "Philip Nelson", Title = "Biological Physics: Energy, Information, Life" },
           new Book { Id = 35, BookCategoryId = 4, Ordered = false, Price = 2200, Author = "Herman C. Berg", Title = "Principles of Biophysics" },
           new Book { Id = 36, BookCategoryId = 4, Ordered = false, Price = 2300, Author = "Klaus Schulten", Title = "Introduction to Computational Biophysics" },
           new Book { Id = 37, BookCategoryId = 4, Ordered = false, Price = 2400, Author = "Bernard Pullman", Title = "Theoretical Aspects of Biophysics" },

           new Book { Id = 38, BookCategoryId = 5, Ordered = false, Price = 2500, Author = "Joseph T. DiPiro",Title = "Pharmacotherapy: A Pathophysiologic Approach"},
           new Book { Id = 39, BookCategoryId = 5, Ordered = false, Price = 2500, Author = "Joseph T. DiPiro", Title = "Pharmacotherapy: A Pathophysiologic Approach" },
           new Book { Id = 40, BookCategoryId = 5, Ordered = false, Price = 2500, Author = "Joseph T. DiPiro", Title = "Pharmacotherapy: A Pathophysiologic Approach" },
           new Book { Id = 41, BookCategoryId = 5, Ordered = false, Price = 2600, Author = "Karen Whalen", Title = "Community Pharmacy Practice Case Studies" },
           new Book { Id = 42, BookCategoryId = 5, Ordered = false, Price = 2700, Author = "Loyd V. Allen Jr.", Title = "Remington: The Science and Practice of Pharmacy" },
           new Book { Id = 43, BookCategoryId = 5, Ordered = false, Price = 2800, Author = "Barbara G. Wells", Title = "Pharmacotherapy Handbook" },
           new Book { Id = 44, BookCategoryId = 5, Ordered = false, Price = 2800, Author = "Barbara G. Wells", Title = "Pharmacotherapy Handbook" },

           new Book { Id = 45, BookCategoryId = 6, Ordered = false, Price = 3000, Author = "Debbie S. Robinson", Title = "Essentials of Dental Assisting" },
           new Book { Id = 46, BookCategoryId = 6, Ordered = false, Price = 3100, Author = "Doni L. Bird", Title = "Modern Dental Assisting" },
           new Book { Id = 47, BookCategoryId = 6, Ordered = false, Price = 3100, Author = "Alice E. Curran", Title = "General and Oral Pathology" },

           new Book { Id = 48, BookCategoryId = 7, Ordered = false, Price = 3200, Author = "Morris Mano", Title = "Computer System Architecture" },
           new Book { Id = 49, BookCategoryId = 7, Ordered = false, Price = 3300, Author = "Thomas C. Bartee", Title = "Computer Architecture and Logic Design" },
           new Book { Id = 50, BookCategoryId = 7, Ordered = false, Price = 3300, Author = "Thomas C. Bartee", Title = "Computer Architecture and Logic Design" },
           new Book { Id = 51, BookCategoryId = 7, Ordered = false, Price = 3400, Author = "William Stallings", Title = "Computer Organization and Architecture" },

           new Book { Id = 52, BookCategoryId = 8, Ordered = false, Price = 3500, Author = "Eric Freeman", Title = "Head First Design Patterns" },
           new Book { Id = 53, BookCategoryId = 8, Ordered = false, Price = 3600, Author = "Martin Fowler",Title = "Refactoring: Improving the Design of Existing Code"},
           new Book { Id = 54, BookCategoryId = 8, Ordered = false, Price = 3600, Author = "Martin Fowler", Title = "Refactoring: Improving the Design of Existing Code" },
           new Book { Id = 55, BookCategoryId = 8, Ordered = false, Price = 3700, Author = "Andrew Hunt",Title = "The Pragmatic Programmer: Your Journey to Mastery"},
           new Book { Id = 56, BookCategoryId = 8, Ordered = false, Price = 3800, Author = "Bjarne Stroustrup", Title = "The C++ Programming Language" },
           new Book { Id = 57, BookCategoryId = 8, Ordered = false, Price = 3800, Author = "Bjarne Stroustrup", Title = "The C++ Programming Language" },
           new Book { Id = 58, BookCategoryId = 8, Ordered = false, Price = 3800, Author = "Bjarne Stroustrup", Title = "The C++ Programming Language" },
           new Book { Id = 59, BookCategoryId = 8, Ordered = false, Price = 3800, Author = "Bjarne Stroustrup", Title = "The C++ Programming Language" },
           new Book { Id = 60, BookCategoryId = 8, Ordered = false, Price = 3800, Author = "Bjarne Stroustrup", Title = "The C++ Programming Language" });
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<UserType>().HaveConversion<string>();
            configurationBuilder.Properties<AccountStatus>().HaveConversion<string>();
        }
    }
}
