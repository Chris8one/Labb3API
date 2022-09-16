using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb3API.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    InterestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterestTitle = table.Column<string>(maxLength: 50, nullable: false),
                    InterestDescription = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.InterestId);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 25, nullable: false),
                    LastName = table.Column<string>(maxLength: 25, nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    LinkId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkDescription = table.Column<string>(nullable: true),
                    LinkUrl = table.Column<string>(nullable: true),
                    PersonId = table.Column<int>(nullable: false),
                    InterestId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.LinkId);
                    table.ForeignKey(
                        name: "FK_Links_Interests_InterestId",
                        column: x => x.InterestId,
                        principalTable: "Interests",
                        principalColumn: "InterestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Links_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonInterests",
                columns: table => new
                {
                    PersonInterestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterestId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonInterests", x => x.PersonInterestId);
                    table.ForeignKey(
                        name: "FK_PersonInterests_Interests_InterestId",
                        column: x => x.InterestId,
                        principalTable: "Interests",
                        principalColumn: "InterestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonInterests_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "InterestId", "InterestDescription", "InterestTitle" },
                values: new object[,]
                {
                    { 1, "Loves to run around the lake house after submerged from the lake and scare and slaughter teenagers", "Lake houses" },
                    { 2, "Hunt people at halloween", "Halloween" },
                    { 3, "To roam in peoples dreams and take them out", "Dreams" },
                    { 4, "Likes to cook meat, but not animal meat as the rest of us eats", "To eat" },
                    { 5, "Big machetetes is a favorite", "Machetes" },
                    { 6, "Old school hockey masks, used to cover a rotten face from a drowning", "Hockey masks" },
                    { 7, "Loves to make custom gloves.. especially with razor sharp knives on the fingers", "Custom gloves" },
                    { 8, "Just like Jason Voorhees, Michael likes to wear a mask over his face, but not an old hockey mask.. but both wear white masks", "Halloween mask" },
                    { 9, "Loves to run around the lake house after submerged from the lake and scare and slaughter teenagers", "Lake houses" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "jason.voorhees@friday13th.com", "Jason", "Voorhees", "555-123-4567" },
                    { 2, "michael.myers@halloween.com", "Michael", "Myers", "555-123-4657" },
                    { 3, "freddie.krueger@terroronelmstreet.com", "Freddie", "Krueger", "555-123-7564" },
                    { 4, "hannibal.lecter@thesilenceofthelambs.com", "Hannibal", "Lecter", "555-123-5476" }
                });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "LinkId", "InterestId", "LinkDescription", "LinkUrl", "PersonId" },
                values: new object[,]
                {
                    { 1, 1, "A clip of Jason in action", "https://www.youtube.com/watch?v=yfxQmKO041o", 1 },
                    { 6, 5, "Jason shows off his Machete", "https://www.youtube.com/watch?v=p2ff-fiJAcs", 1 },
                    { 8, 6, "Jason Voorhees with his mask", "https://www.youtube.com/watch?v=CflcJ-HSA_Y", 1 },
                    { 2, 2, "A clip of Michael doing what he does at halloween night", "https://www.youtube.com/watch?v=R-HV-gTRqag", 2 },
                    { 7, 8, "Michael Myers got his mask taken off", "https://www.youtube.com/watch?v=9dQ5Q7ILApE", 2 },
                    { 3, 3, "Freddie does his thing", "https://www.youtube.com/watch?v=HcrTqof683A", 3 },
                    { 5, 7, "A clip of Freddie making gloves", "https://www.youtube.com/watch?v=FnEmVboDO0Q", 3 },
                    { 4, 4, "Hannibal in prison", "https://www.youtube.com/watch?v=s3nIw30hn4U", 4 }
                });

            migrationBuilder.InsertData(
                table: "PersonInterests",
                columns: new[] { "PersonInterestId", "InterestId", "PersonId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 5, 5, 1 },
                    { 6, 6, 1 },
                    { 2, 2, 2 },
                    { 8, 8, 2 },
                    { 3, 3, 3 },
                    { 7, 7, 3 },
                    { 4, 4, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Links_InterestId",
                table: "Links",
                column: "InterestId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_PersonId",
                table: "Links",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonInterests_InterestId",
                table: "PersonInterests",
                column: "InterestId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonInterests_PersonId",
                table: "PersonInterests",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "PersonInterests");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
