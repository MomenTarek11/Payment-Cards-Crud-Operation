using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaymentDetails.Migrations
{
    /// <inheritdoc />
    public partial class AddPaymentDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "paymentDetails",
                columns: table => new
                {
                    paymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cardName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    cardNumber = table.Column<string>(type: "nvarchar(16)", nullable: false),
                    expiredDate = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    privacyNumber = table.Column<string>(type: "nvarchar(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentDetails", x => x.paymentId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "paymentDetails");
        }
    }
}
