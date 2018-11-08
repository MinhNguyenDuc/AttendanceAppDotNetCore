using Microsoft.EntityFrameworkCore.Migrations;

namespace AttendanceApp.Migrations
{
    public partial class AddField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mark_Subject_SubjectId",
                table: "Mark");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Mark",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_Subject_SubjectId",
                table: "Mark",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mark_Subject_SubjectId",
                table: "Mark");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Mark",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_Subject_SubjectId",
                table: "Mark",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
