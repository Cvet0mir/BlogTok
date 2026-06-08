using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogTok.Data.Migrations
{
    /// <inheritdoc />
    public partial class Changedreactiontobeingdeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFollows_Users_FollowerId",
                table: "UserFollows");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFollows_Users_FollowingId",
                table: "UserFollows");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFollows_Users_FollowerId",
                table: "UserFollows",
                column: "FollowerId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFollows_Users_FollowingId",
                table: "UserFollows",
                column: "FollowingId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFollows_Users_FollowerId",
                table: "UserFollows");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFollows_Users_FollowingId",
                table: "UserFollows");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFollows_Users_FollowerId",
                table: "UserFollows",
                column: "FollowerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFollows_Users_FollowingId",
                table: "UserFollows",
                column: "FollowingId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
