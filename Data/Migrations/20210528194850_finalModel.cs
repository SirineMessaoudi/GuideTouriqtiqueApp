using Microsoft.EntityFrameworkCore.Migrations;

namespace GuideTouristiqueApp.Data.Migrations
{
    public partial class finalModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Localisation",
                table: "services");

            migrationBuilder.AddColumn<int>(
                name: "busId",
                table: "sites",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "restaurantId",
                table: "sites",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "localisationId",
                table: "services",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Note",
                table: "personnes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "serviceId",
                table: "personnes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServiceTouristiqueId",
                table: "offres",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "busId",
                table: "hotels",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "restaurantId",
                table: "hotels",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "hotelId",
                table: "chambres",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransportId",
                table: "buses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "siteId",
                table: "activites",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_sites_busId",
                table: "sites",
                column: "busId");

            migrationBuilder.CreateIndex(
                name: "IX_sites_restaurantId",
                table: "sites",
                column: "restaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_services_localisationId",
                table: "services",
                column: "localisationId");

            migrationBuilder.CreateIndex(
                name: "IX_personnes_serviceId",
                table: "personnes",
                column: "serviceId");

            migrationBuilder.CreateIndex(
                name: "IX_offres_ServiceTouristiqueId",
                table: "offres",
                column: "ServiceTouristiqueId");

            migrationBuilder.CreateIndex(
                name: "IX_hotels_busId",
                table: "hotels",
                column: "busId");

            migrationBuilder.CreateIndex(
                name: "IX_hotels_restaurantId",
                table: "hotels",
                column: "restaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_chambres_hotelId",
                table: "chambres",
                column: "hotelId");

            migrationBuilder.CreateIndex(
                name: "IX_buses_TransportId",
                table: "buses",
                column: "TransportId");

            migrationBuilder.CreateIndex(
                name: "IX_activites_siteId",
                table: "activites",
                column: "siteId");

            migrationBuilder.AddForeignKey(
                name: "FK_activites_sites_siteId",
                table: "activites",
                column: "siteId",
                principalTable: "sites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_buses_transports_TransportId",
                table: "buses",
                column: "TransportId",
                principalTable: "transports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_chambres_hotels_hotelId",
                table: "chambres",
                column: "hotelId",
                principalTable: "hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_hotels_buses_busId",
                table: "hotels",
                column: "busId",
                principalTable: "buses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_hotels_restaurants_restaurantId",
                table: "hotels",
                column: "restaurantId",
                principalTable: "restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_offres_services_ServiceTouristiqueId",
                table: "offres",
                column: "ServiceTouristiqueId",
                principalTable: "services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_personnes_services_serviceId",
                table: "personnes",
                column: "serviceId",
                principalTable: "services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_services_localisations_localisationId",
                table: "services",
                column: "localisationId",
                principalTable: "localisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_sites_buses_busId",
                table: "sites",
                column: "busId",
                principalTable: "buses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_sites_restaurants_restaurantId",
                table: "sites",
                column: "restaurantId",
                principalTable: "restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_activites_sites_siteId",
                table: "activites");

            migrationBuilder.DropForeignKey(
                name: "FK_buses_transports_TransportId",
                table: "buses");

            migrationBuilder.DropForeignKey(
                name: "FK_chambres_hotels_hotelId",
                table: "chambres");

            migrationBuilder.DropForeignKey(
                name: "FK_hotels_buses_busId",
                table: "hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_hotels_restaurants_restaurantId",
                table: "hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_offres_services_ServiceTouristiqueId",
                table: "offres");

            migrationBuilder.DropForeignKey(
                name: "FK_personnes_services_serviceId",
                table: "personnes");

            migrationBuilder.DropForeignKey(
                name: "FK_services_localisations_localisationId",
                table: "services");

            migrationBuilder.DropForeignKey(
                name: "FK_sites_buses_busId",
                table: "sites");

            migrationBuilder.DropForeignKey(
                name: "FK_sites_restaurants_restaurantId",
                table: "sites");

            migrationBuilder.DropIndex(
                name: "IX_sites_busId",
                table: "sites");

            migrationBuilder.DropIndex(
                name: "IX_sites_restaurantId",
                table: "sites");

            migrationBuilder.DropIndex(
                name: "IX_services_localisationId",
                table: "services");

            migrationBuilder.DropIndex(
                name: "IX_personnes_serviceId",
                table: "personnes");

            migrationBuilder.DropIndex(
                name: "IX_offres_ServiceTouristiqueId",
                table: "offres");

            migrationBuilder.DropIndex(
                name: "IX_hotels_busId",
                table: "hotels");

            migrationBuilder.DropIndex(
                name: "IX_hotels_restaurantId",
                table: "hotels");

            migrationBuilder.DropIndex(
                name: "IX_chambres_hotelId",
                table: "chambres");

            migrationBuilder.DropIndex(
                name: "IX_buses_TransportId",
                table: "buses");

            migrationBuilder.DropIndex(
                name: "IX_activites_siteId",
                table: "activites");

            migrationBuilder.DropColumn(
                name: "busId",
                table: "sites");

            migrationBuilder.DropColumn(
                name: "restaurantId",
                table: "sites");

            migrationBuilder.DropColumn(
                name: "localisationId",
                table: "services");

            migrationBuilder.DropColumn(
                name: "serviceId",
                table: "personnes");

            migrationBuilder.DropColumn(
                name: "ServiceTouristiqueId",
                table: "offres");

            migrationBuilder.DropColumn(
                name: "busId",
                table: "hotels");

            migrationBuilder.DropColumn(
                name: "restaurantId",
                table: "hotels");

            migrationBuilder.DropColumn(
                name: "hotelId",
                table: "chambres");

            migrationBuilder.DropColumn(
                name: "TransportId",
                table: "buses");

            migrationBuilder.DropColumn(
                name: "siteId",
                table: "activites");

            migrationBuilder.AddColumn<string>(
                name: "Localisation",
                table: "services",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Note",
                table: "personnes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
