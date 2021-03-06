using Microsoft.EntityFrameworkCore.Migrations;

namespace HostelGirls.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teens",
                columns: table => new
                {
                    TeenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teens", x => x.TeenId);
                });

            migrationBuilder.InsertData(
                table: "Teens",
                columns: new[] { "TeenId", "Id", "Img", "ImgName", "Name", "Number" },
                values: new object[,]
                {
                    { 1, "https://vk.com/id412379471", "images/Amaliya.jpg", "images/Amaliya", "Aurora Redfield", 0 },
                    { 2, "https://vk.com/lellap", "images/Sofia_kolotilina.jpg", "images/Sofia_kolotilina", "Elena Popovskikh", 0 },
                    { 3, "https://vk.com/die_young_my_baby", "images/TopTelka.jpg", "images/TopTelka", "Anya Shelk", 0 },
                    { 4, "", "images/DaryaAfanasieva.jpg", "images/DaryaAfanasieva", "noname", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teens");
        }
    }
}
