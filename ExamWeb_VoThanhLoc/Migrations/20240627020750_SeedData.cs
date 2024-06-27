using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamWeb_VoThanhLoc.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaNhacs",
                columns: new[] { "TuaCD", "TheLoai", "GiaBan", "SoLuong", "Action" },
                values: new object[,]
                {
                    { "CD Nổi buồn gác trọ", "Việt Nam", 150000.0, 20 },
                    { "CD Bài tình ca đêm", "Việt Nam", 250000.0, 15 },
                    { "CD BABYMONTER", "Nước Ngoài", 230000.0, 10 },
                    { "CD Chuyện chúng mình", "Việt Nam", 150000.0, 30 },
                    { "CD Today's US-UK hit", "Nước Ngoài", 27000.0, 10 },
                    { "CD Đoá hồng nhạc việt", "Việt Nam", 220000.0, 40 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
               table: "DiaNhacs",
               keyColumn: "Id",
               keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
