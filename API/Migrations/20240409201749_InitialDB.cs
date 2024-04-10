using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCategory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookCategoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Ordered = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_BookCategories_BookCategoryId",
                        column: x => x.BookCategoryId,
                        principalTable: "BookCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Returned = table.Column<bool>(type: "bit", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinePaid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "Id", "Category", "SubCategory" },
                values: new object[,]
                {
                    { 1, "mathematics", "algebra" },
                    { 2, "mathematics", "geometry" },
                    { 3, "physics", "quantum physics" },
                    { 4, "physics", "biophysics" },
                    { 5, "medicine", "pharmacy" },
                    { 6, "medicine", "dental" },
                    { 7, "computer", "hardware" },
                    { 8, "computer", "software" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccountStatus", "CreateOn", "Email", "FName", "LName", "MobNumber", "Password", "UserType" },
                values: new object[] { 1, "ACTIVE", new DateTime(2024, 1, 1, 11, 12, 13, 0, DateTimeKind.Unspecified), "admin@gmail.com", "Admin", "", "123567890", "admin1", "ADMIN" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "BookCategoryId", "Ordered", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Euclid", 1, false, 3500f, "Euclid's Elements" },
                    { 2, "Robert Kanigel", 1, false, 3600f, "The Man Who Knew Infinity: A Life of the Genius Ramanujan" },
                    { 3, "Robert Kanigel", 1, false, 3600f, "The Man Who Knew Infinity: A Life of the Genius Ramanujan" },
                    { 4, "Stephen Hawking", 1, false, 3700f, "A Brief History of Time" },
                    { 5, "Albert Einstein", 1, false, 3800f, "Relativity: The Special and the General Theory" },
                    { 6, "Albert Einstein", 1, false, 3800f, "Relativity: The Special and the General Theory" },
                    { 7, "Albert Einstein", 1, false, 3800f, "Relativity: The Special and the General Theory" },
                    { 8, "Albert Einstein", 1, false, 3800f, "Relativity: The Special and the General Theory" },
                    { 9, "Albert Einstein", 1, false, 3800f, "Relativity: The Special and the General Theory" },
                    { 10, "Michael Serra", 2, false, 700f, "Discovering Geometry: An Investigative Approach" },
                    { 11, "Michael Serra", 2, false, 700f, "Discovering Geometry: An Investigative Approach" },
                    { 12, "Michael Serra", 2, false, 700f, "Discovering Geometry: An Investigative Approach" },
                    { 13, "Laurie E. Bass", 2, false, 800f, "Holt Geometry: Student Edition" },
                    { 14, "Frederick E. Hohn", 2, false, 900f, "Geometry: Student Edition" },
                    { 15, "Frederick E. Hohn", 2, false, 900f, "Geometry: Student Edition" },
                    { 16, "Laurie E. Bass", 2, false, 1000f, "Holt McDougal Geometry: Student Edition" },
                    { 17, "Jurgensen", 2, false, 1100f, "Contemporary Geometry: A Comprehensive Course" },
                    { 18, "Jurgensen", 2, false, 1100f, "Contemporary Geometry: A Comprehensive Course" },
                    { 19, "Jurgensen", 2, false, 1100f, "Contemporary Geometry: A Comprehensive Course" },
                    { 20, "Dan Kennedy", 2, false, 1200f, "High School Geometry Unlocked: Your Key to Mastering Geometry" },
                    { 21, "Frederick E. Hohn", 2, false, 1300f, "Geometry: Student Edition" },
                    { 22, "Frederick E. Hohn", 2, false, 1300f, "Geometry: Student Edition" },
                    { 23, "Franz Schwabl", 3, false, 1400f, "Quantum Mechanics: An Introduction" },
                    { 24, "Paul A.M. Dirac", 3, false, 1500f, "Principles of Quantum Mechanics" },
                    { 25, "Paul A.M. Dirac", 3, false, 1500f, "Principles of Quantum Mechanics" },
                    { 26, "Sakurai", 3, false, 1600f, "Modern Quantum Mechanics" },
                    { 27, "John S. Townsend", 3, false, 1700f, "A Modern Approach to Quantum Mechanics" },
                    { 28, "Steven Weinberg", 3, false, 1800f, "Lectures on Quantum Mechanics" },
                    { 29, "Steven Weinberg", 3, false, 1800f, "Lectures on Quantum Mechanics" },
                    { 30, "Steven Weinberg", 3, false, 1800f, "Lectures on Quantum Mechanics" },
                    { 31, "Peter Atkins", 4, false, 1900f, "Biophysics: A Student's Guide" },
                    { 32, "William Bialek", 4, false, 2000f, "Biophysics: Searching for Principles" },
                    { 33, "William Bialek", 4, false, 2000f, "Biophysics: Searching for Principles" },
                    { 34, "Philip Nelson", 4, false, 2100f, "Biological Physics: Energy, Information, Life" },
                    { 35, "Herman C. Berg", 4, false, 2200f, "Principles of Biophysics" },
                    { 36, "Klaus Schulten", 4, false, 2300f, "Introduction to Computational Biophysics" },
                    { 37, "Bernard Pullman", 4, false, 2400f, "Theoretical Aspects of Biophysics" },
                    { 38, "Joseph T. DiPiro", 5, false, 2500f, "Pharmacotherapy: A Pathophysiologic Approach" },
                    { 39, "Joseph T. DiPiro", 5, false, 2500f, "Pharmacotherapy: A Pathophysiologic Approach" },
                    { 40, "Joseph T. DiPiro", 5, false, 2500f, "Pharmacotherapy: A Pathophysiologic Approach" },
                    { 41, "Karen Whalen", 5, false, 2600f, "Community Pharmacy Practice Case Studies" },
                    { 42, "Loyd V. Allen Jr.", 5, false, 2700f, "Remington: The Science and Practice of Pharmacy" },
                    { 43, "Barbara G. Wells", 5, false, 2800f, "Pharmacotherapy Handbook" },
                    { 44, "Barbara G. Wells", 5, false, 2800f, "Pharmacotherapy Handbook" },
                    { 45, "Debbie S. Robinson", 6, false, 3000f, "Essentials of Dental Assisting" },
                    { 46, "Doni L. Bird", 6, false, 3100f, "Modern Dental Assisting" },
                    { 47, "Alice E. Curran", 6, false, 3100f, "General and Oral Pathology" },
                    { 48, "Morris Mano", 7, false, 3200f, "Computer System Architecture" },
                    { 49, "Thomas C. Bartee", 7, false, 3300f, "Computer Architecture and Logic Design" },
                    { 50, "Thomas C. Bartee", 7, false, 3300f, "Computer Architecture and Logic Design" },
                    { 51, "William Stallings", 7, false, 3400f, "Computer Organization and Architecture" },
                    { 52, "Eric Freeman", 8, false, 3500f, "Head First Design Patterns" },
                    { 53, "Martin Fowler", 8, false, 3600f, "Refactoring: Improving the Design of Existing Code" },
                    { 54, "Martin Fowler", 8, false, 3600f, "Refactoring: Improving the Design of Existing Code" },
                    { 55, "Andrew Hunt", 8, false, 3700f, "The Pragmatic Programmer: Your Journey to Mastery" },
                    { 56, "Bjarne Stroustrup", 8, false, 3800f, "The C++ Programming Language" },
                    { 57, "Bjarne Stroustrup", 8, false, 3800f, "The C++ Programming Language" },
                    { 58, "Bjarne Stroustrup", 8, false, 3800f, "The C++ Programming Language" },
                    { 59, "Bjarne Stroustrup", 8, false, 3800f, "The C++ Programming Language" },
                    { 60, "Bjarne Stroustrup", 8, false, 3800f, "The C++ Programming Language" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookCategoryId",
                table: "Books",
                column: "BookCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BookId",
                table: "Orders",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "BookCategories");
        }
    }
}
