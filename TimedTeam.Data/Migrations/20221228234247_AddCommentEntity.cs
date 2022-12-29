using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimedTeam.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCommentEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentEntityReplyEntity_Comments_CommentsId",
                table: "CommentEntityReplyEntity");

            migrationBuilder.DropTable(
                name: "CommentEntityPostEntity");

            migrationBuilder.RenameColumn(
                name: "CommentsId",
                table: "CommentEntityReplyEntity",
                newName: "Text");

            migrationBuilder.RenameIndex(
                name: "IX_CommentEntityReplyEntity_CommentsId",
                table: "CommentEntityReplyEntity",
                newName: "IX_CommentEntityReplyEntity_Text");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostEntityId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostEntityId",
                table: "Comments",
                column: "PostEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentEntityReplyEntity_Comments_Text",
                table: "CommentEntityReplyEntity",
                column: "Text",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostEntityId",
                table: "Comments",
                column: "PostEntityId",
                principalTable: "Posts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentEntityReplyEntity_Comments_Text",
                table: "CommentEntityReplyEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostEntityId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_PostEntityId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "PostEntityId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "CommentEntityReplyEntity",
                newName: "CommentsId");

            migrationBuilder.RenameIndex(
                name: "IX_CommentEntityReplyEntity_Text",
                table: "CommentEntityReplyEntity",
                newName: "IX_CommentEntityReplyEntity_CommentsId");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "CommentEntityPostEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    PostsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentEntityPostEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentEntityPostEntity_Comments_Id",
                        column: x => x.Id,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentEntityPostEntity_Posts_PostsId",
                        column: x => x.PostsId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentEntityPostEntity_PostsId",
                table: "CommentEntityPostEntity",
                column: "PostsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentEntityReplyEntity_Comments_CommentsId",
                table: "CommentEntityReplyEntity",
                column: "CommentsId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
