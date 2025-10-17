using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TDT_Day09_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tdtLoai_San_Pham",
                columns: table => new
                {
                    tdtId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tdtMaLoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tdtTenLoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tdtTrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tdtLoai_San_Pham", x => x.tdtId);
                });

            migrationBuilder.CreateTable(
                name: "tdtSan_Pham",
                columns: table => new
                {
                    tdtId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tdtMaSanPham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tdtTenSanPham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tdtHinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tdtSoLuong = table.Column<int>(type: "int", nullable: false),
                    tdtDonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    tdtTrangThai = table.Column<bool>(type: "bit", nullable: false),
                    tdtMaLoai = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tdtSan_Pham", x => x.tdtId);
                    table.ForeignKey(
                        name: "FK_tdtSan_Pham_tdtLoai_San_Pham_tdtMaLoai",
                        column: x => x.tdtMaLoai,
                        principalTable: "tdtLoai_San_Pham",
                        principalColumn: "tdtId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tdtSan_Pham_tdtMaLoai",
                table: "tdtSan_Pham",
                column: "tdtMaLoai");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tdtSan_Pham");

            migrationBuilder.DropTable(
                name: "tdtLoai_San_Pham");
        }
    }
}
