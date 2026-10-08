using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GenerationControleurs.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "Adresse", "Nom", "Telephone" },
                values: new object[,]
                {
                    { 1, "123 rue Principale, Montréal", "Marie-Josée Tremblay", "(514) 555-1234" },
                    { 2, "456 boulevard Saint-Laurent, Québec", "Patrick Gagné", "(418) 555-5678" },
                    { 3, "789 avenue des Érables, Trois-Rivières", "Sophie Dubois", "(819) 555-9012" },
                    { 4, "1010 rue Saint-Denis, Montréal", "Jean-François Lavoie", "(514) 555-3456" },
                    { 5, "111 rue des Pionniers, Québec", "Geneviève Parent", "(418) 555-7890" }
                });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "Adresse", "Nom", "Telephone" },
                values: new object[,]
                {
                    { 1, "456 rue Boyer, Montréal", "La graine du père George", "(514) 555-2345" },
                    { 2, "789 rue Principale, Québec", "Le Bistro", "(418) 555-6789" },
                    { 3, "1010 Pie IX, Trois-Rivières", "La Belle Province", "(819) 555-2345" },
                    { 4, "1111 rue de la Montagne, Montréal", "La Piazzetta", "(514) 555-6789" }
                });

            migrationBuilder.InsertData(
                table: "Commande",
                columns: new[] { "Id", "ClientId", "Date", "RestaurantId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 2, new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, 3, new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, 2, new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 5, 2, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "Plat",
                columns: new[] { "Id", "Description", "NiveauPiquant", "Nom", "Prix", "RestaurantId", "Vegetarien" },
                values: new object[,]
                {
                    { 1, "Un mélange de légumes frais sautés à la poêle", null, "Sauté de légumes", 8.99m, 1, true },
                    { 2, "Du riz blanc servi avec des carottes fraîches", null, "Riz aux carottes", 6.99m, 1, true },
                    { 3, "Un délicieux plat de poulet avec du gingembre frais", 1, "Poulet au gingembre", 12.99m, 2, false },
                    { 4, "Un délicieux plat de tofu avec du gingembre frais", 2, "Tofu au gingembre", 11.99m, 2, true },
                    { 5, "Patate, sauce, fromage skwich skwich", null, "Poutine", 7.99m, 3, false },
                    { 6, "Pepperonni fromage", null, "Pizza", 9.99m, 4, false }
                });

            migrationBuilder.InsertData(
                table: "CommandePlat",
                columns: new[] { "Id", "CommandeId", "PlatId", "Quantite" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 1, 2, 2 },
                    { 3, 2, 3, 1 },
                    { 4, 2, 4, 1 },
                    { 5, 3, 5, 4 },
                    { 6, 4, 6, 2 },
                    { 7, 5, 3, 3 },
                    { 8, 5, 4, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CommandePlat",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CommandePlat",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CommandePlat",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CommandePlat",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CommandePlat",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CommandePlat",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CommandePlat",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CommandePlat",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Commande",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Commande",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Commande",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Commande",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Commande",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Plat",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
