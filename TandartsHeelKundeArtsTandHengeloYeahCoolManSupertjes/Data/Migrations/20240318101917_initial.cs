using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TandartsHeelKundeArtsTandHengeloYeahCoolManSupertjes.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Behandeling",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tijd_in_min = table.Column<int>(type: "int", nullable: false),
                    Prijs = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Behandeling", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Gebruiker",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Voornaam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Achternaam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tussenvoegsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Woonplaats = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Geboortedatum = table.Column<DateOnly>(type: "date", nullable: false),
                    Zorgverzekeraar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Klantnummer = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefoon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gebruiker", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kamer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    In_gebruik = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kamer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zorgverzekeraar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Klantnummer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GebruikerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Patient_Gebruiker_GebruikerID",
                        column: x => x.GebruikerID,
                        principalTable: "Gebruiker",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Tandarts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GebruikerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tandarts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tandarts_Gebruiker_GebruikerID",
                        column: x => x.GebruikerID,
                        principalTable: "Gebruiker",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Tandartsassistent",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GebruikerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tandartsassistent", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tandartsassistent_Gebruiker_GebruikerID",
                        column: x => x.GebruikerID,
                        principalTable: "Gebruiker",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Afspraak",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientID = table.Column<int>(type: "int", nullable: true),
                    TandartsID = table.Column<int>(type: "int", nullable: true),
                    TandartsassistentID = table.Column<int>(type: "int", nullable: true),
                    KamerID = table.Column<int>(type: "int", nullable: true),
                    BehandelingID = table.Column<int>(type: "int", nullable: true),
                    Notitie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datum = table.Column<DateOnly>(type: "date", nullable: false),
                    Start_tijd = table.Column<TimeOnly>(type: "time", nullable: false),
                    Stop_tijd = table.Column<TimeOnly>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afspraak", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Afspraak_Behandeling_BehandelingID",
                        column: x => x.BehandelingID,
                        principalTable: "Behandeling",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Afspraak_Kamer_KamerID",
                        column: x => x.KamerID,
                        principalTable: "Kamer",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Afspraak_Patient_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Afspraak_Tandarts_TandartsID",
                        column: x => x.TandartsID,
                        principalTable: "Tandarts",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Afspraak_Tandartsassistent_TandartsassistentID",
                        column: x => x.TandartsassistentID,
                        principalTable: "Tandartsassistent",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Afspraak_BehandelingID",
                table: "Afspraak",
                column: "BehandelingID");

            migrationBuilder.CreateIndex(
                name: "IX_Afspraak_KamerID",
                table: "Afspraak",
                column: "KamerID");

            migrationBuilder.CreateIndex(
                name: "IX_Afspraak_PatientID",
                table: "Afspraak",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Afspraak_TandartsassistentID",
                table: "Afspraak",
                column: "TandartsassistentID");

            migrationBuilder.CreateIndex(
                name: "IX_Afspraak_TandartsID",
                table: "Afspraak",
                column: "TandartsID");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_GebruikerID",
                table: "Patient",
                column: "GebruikerID");

            migrationBuilder.CreateIndex(
                name: "IX_Tandarts_GebruikerID",
                table: "Tandarts",
                column: "GebruikerID");

            migrationBuilder.CreateIndex(
                name: "IX_Tandartsassistent_GebruikerID",
                table: "Tandartsassistent",
                column: "GebruikerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Afspraak");

            migrationBuilder.DropTable(
                name: "Behandeling");

            migrationBuilder.DropTable(
                name: "Kamer");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Tandarts");

            migrationBuilder.DropTable(
                name: "Tandartsassistent");

            migrationBuilder.DropTable(
                name: "Gebruiker");
        }
    }
}
