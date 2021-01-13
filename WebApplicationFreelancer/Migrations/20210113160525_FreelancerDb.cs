using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationFreelancer.Migrations
{
    public partial class FreelancerDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quote",
                columns: table => new
                {
                    quote_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuoteState = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    QuoteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuoteAmount = table.Column<int>(type: "int", nullable: false),
                    QuoteFinalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuoteFinalAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quote", x => x.quote_id);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    job_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobState = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    JobStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JobEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JobDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    QuoteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.job_id);
                    table.ForeignKey(
                        name: "FK_Job_Quote_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quote",
                        principalColumn: "quote_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    JobId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.customer_id);
                    table.ForeignKey(
                        name: "FK_Customer_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "job_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customercat",
                columns: table => new
                {
                    customercat_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomercatName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomercatDescription = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customercat", x => x.customercat_id);
                    table.ForeignKey(
                        name: "FK_Customercat_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_JobId",
                table: "Customer",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Customercat_CustomerId",
                table: "Customercat",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Job_QuoteId",
                table: "Job",
                column: "QuoteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customercat");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "Quote");
        }
    }
}
