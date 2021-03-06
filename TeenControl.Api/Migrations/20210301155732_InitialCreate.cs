using Microsoft.EntityFrameworkCore.Migrations;

namespace TeenControl.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teens",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teens", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Teens",
                columns: new[] { "Id", "Img", "ImgName", "Name", "Number", "TeenId" },
                values: new object[,]
                {
                    { "https://vk.com/id412379471", "images/Amaliya.jpg", "images/Amaliya", "Aurora Redfield", 0, 1 },
                    { "https://vk.com/lellap", "images/Sofia_kolotilina.jpg", "images/Sofia_kolotilina", "Elena Popovskikh", 0, 2 },
                    { "https://vk.com/die_young_my_baby", "images/TopTelka.jpg", "images/TopTelka", "Anya Shelk", 0, 3 },
                    { "", "images/DaryaAfanasieva.jpg", "images/DaryaAfanasieva", "noname", 0, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teens");
        }
    }
}
