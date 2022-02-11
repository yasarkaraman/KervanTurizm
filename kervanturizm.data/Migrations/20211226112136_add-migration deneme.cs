using Microsoft.EntityFrameworkCore.Migrations;

namespace kervanturizm.data.Migrations
{
    public partial class addmigrationdeneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Kullanici = table.Column<string>(nullable: true),
                    Sifre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "Guzergahs",
                columns: table => new
                {
                    GuzergahID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Baslangic = table.Column<string>(nullable: true),
                    gz1 = table.Column<string>(nullable: true),
                    gz2 = table.Column<string>(nullable: true),
                    gz3 = table.Column<string>(nullable: true),
                    Bitis = table.Column<string>(nullable: true),
                    Tarih = table.Column<string>(nullable: true),
                    Saat = table.Column<string>(nullable: true),
                    Fiyat = table.Column<double>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guzergahs", x => x.GuzergahID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicis",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Mail = table.Column<string>(nullable: true),
                    Sifre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicis", x => x.KullaniciID);
                });

            migrationBuilder.CreateTable(
                name: "Sehirs",
                columns: table => new
                {
                    SehirID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SehirAd = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirs", x => x.SehirID);
                });

            migrationBuilder.CreateTable(
                name: "Bilets",
                columns: table => new
                {
                    BiletID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ad = table.Column<string>(nullable: true),
                    Soyad = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Nereden = table.Column<string>(nullable: true),
                    Nereye = table.Column<string>(nullable: true),
                    KoltukNo = table.Column<int>(nullable: false),
                    Fiyat = table.Column<double>(nullable: false),
                    GuzergahID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bilets", x => x.BiletID);
                    table.ForeignKey(
                        name: "FK_Bilets_Guzergahs_GuzergahID",
                        column: x => x.GuzergahID,
                        principalTable: "Guzergahs",
                        principalColumn: "GuzergahID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bilets_GuzergahID",
                table: "Bilets",
                column: "GuzergahID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Bilets");

            migrationBuilder.DropTable(
                name: "Kullanicis");

            migrationBuilder.DropTable(
                name: "Sehirs");

            migrationBuilder.DropTable(
                name: "Guzergahs");
        }
    }
}
