using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace entityFramework.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "House",
                columns: new[] { "HouseId", "Description", "HouseInfluence", "Motto", "ShieldUrl", "StartDate", "Title" },
                values: new object[] { new Guid("dc374853-680b-4fb0-acaf-e0e521359ab6"), null, 0, "Fire and Blood", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Targaryen" });

            migrationBuilder.InsertData(
                table: "House",
                columns: new[] { "HouseId", "Description", "HouseInfluence", "Motto", "ShieldUrl", "StartDate", "Title" },
                values: new object[] { new Guid("dc374853-680b-4fb0-acaf-e0e521359ab7"), null, 0, "Winter is Comming", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stark" });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PersonId", "BirthDate", "HouseId", "LastName", "Name", "NickName" },
                values: new object[,]
                {
                    { new Guid("dc374853-680b-4fb0-acaf-e0e521359ab1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dc374853-680b-4fb0-acaf-e0e521359ab6"), "Targaryen", "Aegon", "The Conqueror" },
                    { new Guid("dc374853-680b-4fb0-acaf-e0e521359ab2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dc374853-680b-4fb0-acaf-e0e521359ab7"), "Stark", "Rickon", null },
                    { new Guid("dc374853-680b-4fb0-acaf-e0e521359ab3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dc374853-680b-4fb0-acaf-e0e521359ab7"), "Stark", "Robb", "The young wolf" },
                    { new Guid("dc374853-680b-4fb0-acaf-e0e521359ab4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dc374853-680b-4fb0-acaf-e0e521359ab7"), "Stark", "Eddard", null },
                    { new Guid("dc374853-680b-4fb0-acaf-e0e521359ab5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dc374853-680b-4fb0-acaf-e0e521359ab7"), "Snow", "Jon", "The Winterfell bastard" },
                    { new Guid("dc374853-680b-4fb0-acaf-e0e521359ac4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dc374853-680b-4fb0-acaf-e0e521359ab6"), "Targaryen", "Maegor", null },
                    { new Guid("dc374853-680b-4fb0-acaf-e0e521359ac5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dc374853-680b-4fb0-acaf-e0e521359ab6"), "Targaryen", "Aenys", null },
                    { new Guid("dc374853-680b-4fb0-acaf-e0e521359ac6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dc374853-680b-4fb0-acaf-e0e521359ab6"), "Targaryen", "Baelor", null },
                    { new Guid("dc374853-680b-4fb0-acaf-e0e521359ac7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dc374853-680b-4fb0-acaf-e0e521359ab6"), "Targaryen", "Daemon", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("dc374853-680b-4fb0-acaf-e0e521359ab1"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("dc374853-680b-4fb0-acaf-e0e521359ab2"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("dc374853-680b-4fb0-acaf-e0e521359ab3"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("dc374853-680b-4fb0-acaf-e0e521359ab4"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("dc374853-680b-4fb0-acaf-e0e521359ab5"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("dc374853-680b-4fb0-acaf-e0e521359ac4"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("dc374853-680b-4fb0-acaf-e0e521359ac5"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("dc374853-680b-4fb0-acaf-e0e521359ac6"));

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "PersonId",
                keyValue: new Guid("dc374853-680b-4fb0-acaf-e0e521359ac7"));

            migrationBuilder.DeleteData(
                table: "House",
                keyColumn: "HouseId",
                keyValue: new Guid("dc374853-680b-4fb0-acaf-e0e521359ab6"));

            migrationBuilder.DeleteData(
                table: "House",
                keyColumn: "HouseId",
                keyValue: new Guid("dc374853-680b-4fb0-acaf-e0e521359ab7"));
        }
    }
}
