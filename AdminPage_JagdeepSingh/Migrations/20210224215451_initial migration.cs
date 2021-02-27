using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminPage_JagdeepSingh.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    companyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    postalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fax = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    titleOfCourtesy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    postalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coutnry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    homePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    extension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    notes = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    reportTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    photoPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    regionDescription = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Shippers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    companyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    companyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    postalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fax = table.Column<int>(type: "int", nullable: false),
                    homepage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerID = table.Column<int>(type: "int", nullable: true),
                    employeeID = table.Column<int>(type: "int", nullable: true),
                    weight = table.Column<float>(type: "real", nullable: false),
                    shipVia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shipName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shipAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shipCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shipRegion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shipPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shipCOuntry = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_customerID",
                        column: x => x.customerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Employees_employeeID",
                        column: x => x.employeeID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Territories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    regionID = table.Column<int>(type: "int", nullable: true),
                    territoryDescription = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Territories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Territories_Regions_regionID",
                        column: x => x.regionID,
                        principalTable: "Regions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryID = table.Column<int>(type: "int", nullable: true),
                    supplierID = table.Column<int>(type: "int", nullable: true),
                    productName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantityPerLabel = table.Column<int>(type: "int", nullable: false),
                    unitPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    unitsInStocks = table.Column<int>(type: "int", nullable: false),
                    unitsOnOrder = table.Column<int>(type: "int", nullable: false),
                    reorderLevel = table.Column<int>(type: "int", nullable: false),
                    dicounted = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_categoryID",
                        column: x => x.categoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_supplierID",
                        column: x => x.supplierID,
                        principalTable: "Suppliers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTerritory",
                columns: table => new
                {
                    EmployeesID = table.Column<int>(type: "int", nullable: false),
                    TerritoriesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTerritory", x => new { x.EmployeesID, x.TerritoriesID });
                    table.ForeignKey(
                        name: "FK_EmployeeTerritory_Employees_EmployeesID",
                        column: x => x.EmployeesID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeTerritory_Territories_TerritoriesID",
                        column: x => x.TerritoriesID,
                        principalTable: "Territories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productID = table.Column<int>(type: "int", nullable: true),
                    unitPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    discount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_productID",
                        column: x => x.productID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTerritory_TerritoriesID",
                table: "EmployeeTerritory",
                column: "TerritoriesID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_productID",
                table: "OrderDetails",
                column: "productID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_customerID",
                table: "Orders",
                column: "customerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_employeeID",
                table: "Orders",
                column: "employeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_categoryID",
                table: "Products",
                column: "categoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_supplierID",
                table: "Products",
                column: "supplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Territories_regionID",
                table: "Territories",
                column: "regionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeTerritory");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Shippers");

            migrationBuilder.DropTable(
                name: "Territories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
