using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecop.PL.Data.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "da16d607-625c-4e07-887a-ebb9f183b9c4", "05c32fff-33a5-4819-b67b-437dd87527bc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "183832f0-8e1a-4649-b2fa-d5b9221e0982", "42e5d5a4-43e5-4860-ac15-a23148a611a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "da16d607-625c-4e07-887a-ebb9f183b9c4", "6126e46c-505b-4b73-bac9-1bd69b2d0be8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "93b0f040-828a-4907-aabf-c85fc6e97559", "65ceb20f-1872-490f-b3c4-93e0cefbf014" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "93b0f040-828a-4907-aabf-c85fc6e97559", "816a4125-0f7c-44c3-a364-281c60402d17" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "87ac289e-8c8d-4b69-820f-3f6e1b3b24c0", "8756e421-ba55-4779-b2ef-451f9436dd7e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "183832f0-8e1a-4649-b2fa-d5b9221e0982", "8f39dcd1-8747-485f-b512-8030d104eda4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "183832f0-8e1a-4649-b2fa-d5b9221e0982");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87ac289e-8c8d-4b69-820f-3f6e1b3b24c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93b0f040-828a-4907-aabf-c85fc6e97559");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da16d607-625c-4e07-887a-ebb9f183b9c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05c32fff-33a5-4819-b67b-437dd87527bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42e5d5a4-43e5-4860-ac15-a23148a611a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6126e46c-505b-4b73-bac9-1bd69b2d0be8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65ceb20f-1872-490f-b3c4-93e0cefbf014");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "816a4125-0f7c-44c3-a364-281c60402d17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8756e421-ba55-4779-b2ef-451f9436dd7e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f39dcd1-8747-485f-b512-8030d104eda4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a7ff634-beed-4b8e-92e3-e7dc830fce9a", null, "Policeman", "POLICEMAN" },
                    { "64f9d946-fd15-419d-8701-3056ef18bc4c", null, "Judge", "JUDGE" },
                    { "a2c887f8-550a-4ed0-8428-7e85b5573459", null, "Admin", "ADMIN" },
                    { "bb1aaa8c-2791-49fa-a39e-4c9bbf14a10f", null, "Citizen", "CITIZEN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1b9689c3-d2df-4db1-8555-ecd9c29978b7", 0, "123cdd0d-055d-4ae2-bf8f-f36f35c10015", "Osama@gmail.com", true, false, null, "OSAMA@GMAIL.COM", "OSAMA", "AQAAAAIAAYagAAAAEOcnfROVdusICrnKxCLPyxWgkG1d8XBJSA16JI30j3gir25pqqf/VOU1K1IPsdptlg==", null, false, "85abdd67-6725-4ac3-9b5d-a5174d48b4ad", false, "Osama" },
                    { "4a3a4914-3e58-4dad-8be4-bfc1595588b4", 0, "2a2dd001-5bca-476f-b970-9b0819c5cd90", "Mohammed@gmail.com", true, false, null, "MOHAMMED@GMAIL.COM", "MOHAMMED", "AQAAAAIAAYagAAAAEHjwie2DkrxB7lTHTNTlMfcS8BX7sHDkpGe7lHtrVlmbAhiN22Vid4kwADF3ZgtriQ==", null, false, "ace6cebf-bc05-4f9c-bf76-16caa0ba71b5", false, "Mohammed" },
                    { "4a432af5-fea6-40c6-aab0-0927e77ce829", 0, "9d1a898f-5769-4bff-a1b1-f1f2e31bf687", "braa@gmail.com", true, false, null, "BRAA@GMAIL.COM", "Braa", "AQAAAAIAAYagAAAAEIkh4Opd4dHurLNqwpapWk1hWbo6xKU5CbkKkU21LxL4P+EO/i1hiBRd+clgveNkQg==", null, false, "5d9526e2-fc21-4a83-8cc1-36f021d9562c", false, "Braa" },
                    { "5be71fe5-57a6-424a-bb42-a5b3088dd6d3", 0, "2f7c33cf-7241-4bf2-8543-e47a0aaece69", "Ali@gmail.com", true, false, null, "ALI@GMAIL.COM", "ALI", "AQAAAAIAAYagAAAAEAypUZl4QuvSU7Umwj2m4WFr96jAJvcsbxJAmHCdMnbwUaw3ZHbVzu4nC9h07XX44w==", null, false, "bdffa4a4-30b6-4e29-83ae-491d2f4bfc9c", false, "Ali" },
                    { "783b9069-7ab2-4f4a-ae09-c4c9f25227a9", 0, "788ab7a0-7345-4b2c-8452-23766808bf66", "Hadi@gmail.com", true, false, null, "HADI@GMAIL.COM", "HADI", "AQAAAAIAAYagAAAAEEa0uBpeaCWZS8jFOHsJp5O4IFzDjzK+ZeSvFW2CjVvW0I2lcWtVzy+t2hH57gj93Q==", null, false, "a0504107-b7c9-4dd4-9d29-78a68b5771e8", false, "Hadi" },
                    { "bc22b377-69d7-407a-8fd5-a561f98bb1bc", 0, "a06e2107-b098-43db-b5df-54bbd2f20c29", "Noor@gmail.com", true, false, null, "Noor@GMAIL.COM", "NOOR", "AQAAAAIAAYagAAAAEI6YPka9Mhx9XhRcMI2kBwZN7z5vXkCH8dgWFKb4qoZfZT9X4GmfdNSOR+ogyrjf6g==", null, false, "3a7d1eff-c020-43cb-8024-40bb55af880b", false, "Noor" },
                    { "ecc15f5c-a5eb-4961-915b-bf4da5ac044b", 0, "ae077cb6-f755-4608-bbf1-a3c2c8a6be9e", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEBh2DnlAxWqUzWDFkQSm2BVP6Q6Lz07LFG4BcA+xWrNRG/akTYs6dqRP7Rfd+NJK7A==", null, false, "1fa3ae2a-7853-4bb6-9d21-852081c08c49", false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "CitizenId",
                keyValue: 1,
                column: "UserId",
                value: "4a432af5-fea6-40c6-aab0-0927e77ce829");

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "CitizenId",
                keyValue: 2,
                column: "UserId",
                value: "1b9689c3-d2df-4db1-8555-ecd9c29978b7");

            migrationBuilder.UpdateData(
                table: "Judges",
                keyColumn: "JudgeId",
                keyValue: 1,
                column: "UserId",
                value: "5be71fe5-57a6-424a-bb42-a5b3088dd6d3");

            migrationBuilder.UpdateData(
                table: "Judges",
                keyColumn: "JudgeId",
                keyValue: 2,
                column: "UserId",
                value: "783b9069-7ab2-4f4a-ae09-c4c9f25227a9");

            migrationBuilder.UpdateData(
                table: "Policemans",
                keyColumn: "PolicemanId",
                keyValue: 1,
                column: "UserId",
                value: "4a3a4914-3e58-4dad-8be4-bfc1595588b4");

            migrationBuilder.UpdateData(
                table: "Policemans",
                keyColumn: "PolicemanId",
                keyValue: 2,
                column: "UserId",
                value: "bc22b377-69d7-407a-8fd5-a561f98bb1bc");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bb1aaa8c-2791-49fa-a39e-4c9bbf14a10f", "1b9689c3-d2df-4db1-8555-ecd9c29978b7" },
                    { "4a7ff634-beed-4b8e-92e3-e7dc830fce9a", "4a3a4914-3e58-4dad-8be4-bfc1595588b4" },
                    { "bb1aaa8c-2791-49fa-a39e-4c9bbf14a10f", "4a432af5-fea6-40c6-aab0-0927e77ce829" },
                    { "64f9d946-fd15-419d-8701-3056ef18bc4c", "5be71fe5-57a6-424a-bb42-a5b3088dd6d3" },
                    { "64f9d946-fd15-419d-8701-3056ef18bc4c", "783b9069-7ab2-4f4a-ae09-c4c9f25227a9" },
                    { "4a7ff634-beed-4b8e-92e3-e7dc830fce9a", "bc22b377-69d7-407a-8fd5-a561f98bb1bc" },
                    { "a2c887f8-550a-4ed0-8428-7e85b5573459", "ecc15f5c-a5eb-4961-915b-bf4da5ac044b" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb1aaa8c-2791-49fa-a39e-4c9bbf14a10f", "1b9689c3-d2df-4db1-8555-ecd9c29978b7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4a7ff634-beed-4b8e-92e3-e7dc830fce9a", "4a3a4914-3e58-4dad-8be4-bfc1595588b4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb1aaa8c-2791-49fa-a39e-4c9bbf14a10f", "4a432af5-fea6-40c6-aab0-0927e77ce829" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "64f9d946-fd15-419d-8701-3056ef18bc4c", "5be71fe5-57a6-424a-bb42-a5b3088dd6d3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "64f9d946-fd15-419d-8701-3056ef18bc4c", "783b9069-7ab2-4f4a-ae09-c4c9f25227a9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4a7ff634-beed-4b8e-92e3-e7dc830fce9a", "bc22b377-69d7-407a-8fd5-a561f98bb1bc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a2c887f8-550a-4ed0-8428-7e85b5573459", "ecc15f5c-a5eb-4961-915b-bf4da5ac044b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a7ff634-beed-4b8e-92e3-e7dc830fce9a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64f9d946-fd15-419d-8701-3056ef18bc4c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2c887f8-550a-4ed0-8428-7e85b5573459");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb1aaa8c-2791-49fa-a39e-4c9bbf14a10f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b9689c3-d2df-4db1-8555-ecd9c29978b7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a3a4914-3e58-4dad-8be4-bfc1595588b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a432af5-fea6-40c6-aab0-0927e77ce829");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5be71fe5-57a6-424a-bb42-a5b3088dd6d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "783b9069-7ab2-4f4a-ae09-c4c9f25227a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc22b377-69d7-407a-8fd5-a561f98bb1bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ecc15f5c-a5eb-4961-915b-bf4da5ac044b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "183832f0-8e1a-4649-b2fa-d5b9221e0982", null, "Policeman", "POLICEMAN" },
                    { "87ac289e-8c8d-4b69-820f-3f6e1b3b24c0", null, "Admin", "ADMIN" },
                    { "93b0f040-828a-4907-aabf-c85fc6e97559", null, "Citizen", "CITIZEN" },
                    { "da16d607-625c-4e07-887a-ebb9f183b9c4", null, "Judge", "JUDGE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "05c32fff-33a5-4819-b67b-437dd87527bc", 0, "cb0d247d-3e95-4075-acf6-51e1034f3ddd", "Hadi@gmail.com", true, false, null, "HADI@GMAIL.COM", "HADI", "AQAAAAIAAYagAAAAEMfSca2PbICYzSxwT+782r8696kf7jLgVKcKuFYrvItio+dpqR8ZbjkLOkJPYfM9VQ==", null, false, "7b944d4e-bc05-43b9-ae2e-3aee81b42c03", false, "Hadi" },
                    { "42e5d5a4-43e5-4860-ac15-a23148a611a6", 0, "5f3070c2-a5be-4abe-a27a-eb4f18a16775", "Mohammed@gmail.com", true, false, null, "MOHAMMED@GMAIL.COM", "MOHAMMED", "AQAAAAIAAYagAAAAEPvbJc+SqyG8jHbjyxRRznTwDBt59MCu8BEJEGJqX318lKUw6HsTJUtPjlX3dWRk6g==", null, false, "a4bcbd4f-8fc8-4979-9693-3948cb7a7d49", false, "Mohammed" },
                    { "6126e46c-505b-4b73-bac9-1bd69b2d0be8", 0, "67c5e189-682c-49a4-b05d-79e2122ef461", "Ali@gmail.com", true, false, null, "ALI@GMAIL.COM", "ALI", "AQAAAAIAAYagAAAAEJl1OQmotREKdn4W2Bfq9+UVtJdm/6dH8QgcEfYHJsYunZfcN/NwaJ97X3VyvsE4gg==", null, false, "ebac1b1d-38d3-4454-b8ab-12427fb3e386", false, "Ali" },
                    { "65ceb20f-1872-490f-b3c4-93e0cefbf014", 0, "5e92ceaa-50c0-4ad7-9210-5e087f470fd5", "Osama@gmail.com", true, false, null, "OSAMA@GMAIL.COM", "OSAMA", "AQAAAAIAAYagAAAAEKvQs3M6W8WkWzE/KxZaDOyIvo/HnlMbf29AIahxfuhweJQWPVMDF8RJqS8M0iK+hQ==", null, false, "61998dbf-48b2-4114-99ba-79655d9474ca", false, "Osama" },
                    { "816a4125-0f7c-44c3-a364-281c60402d17", 0, "cea34c53-95ec-426b-8424-be359bc44bf9", "braa@gmail.com", true, false, null, "BRAA@GMAIL.COM", "Braa", "AQAAAAIAAYagAAAAED6J1fBmOVFicvL8NwptdT7B+u48O4QN/bWe6xq4tkOnfxjLvPqlu/5DOci0SHBBlw==", null, false, "135a8b5d-e0a5-4f81-b627-9473af7b18ed", false, "Braa" },
                    { "8756e421-ba55-4779-b2ef-451f9436dd7e", 0, "105ddcf4-c24d-42ca-a046-6945f5c6eb0f", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAED9ayRupNWXNXy3QNLp7rzodvn0iTGc9fBbkaVtyJvTymmjybLrPIh2r1BWNfsSXTQ==", null, false, "93b16178-fe4a-4c21-ba4a-f5c203da1cb6", false, "admin" },
                    { "8f39dcd1-8747-485f-b512-8030d104eda4", 0, "23f740eb-87f4-4c30-b626-16d2861a948d", "Noor@gmail.com", true, false, null, "Noor@GMAIL.COM", "NOOR", "AQAAAAIAAYagAAAAEHt/3W8mxeG8tlfu2vdcuLW22DAgynijmSCAhBlgG9VxePSMsZ4/DV9Wtj+ogAlxvg==", null, false, "067ebc6f-b306-4516-8e27-25f7c33036d6", false, "Noor" }
                });

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "CitizenId",
                keyValue: 1,
                column: "UserId",
                value: "816a4125-0f7c-44c3-a364-281c60402d17");

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "CitizenId",
                keyValue: 2,
                column: "UserId",
                value: "65ceb20f-1872-490f-b3c4-93e0cefbf014");

            migrationBuilder.UpdateData(
                table: "Judges",
                keyColumn: "JudgeId",
                keyValue: 1,
                column: "UserId",
                value: "6126e46c-505b-4b73-bac9-1bd69b2d0be8");

            migrationBuilder.UpdateData(
                table: "Judges",
                keyColumn: "JudgeId",
                keyValue: 2,
                column: "UserId",
                value: "05c32fff-33a5-4819-b67b-437dd87527bc");

            migrationBuilder.UpdateData(
                table: "Policemans",
                keyColumn: "PolicemanId",
                keyValue: 1,
                column: "UserId",
                value: "42e5d5a4-43e5-4860-ac15-a23148a611a6");

            migrationBuilder.UpdateData(
                table: "Policemans",
                keyColumn: "PolicemanId",
                keyValue: 2,
                column: "UserId",
                value: "8f39dcd1-8747-485f-b512-8030d104eda4");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "da16d607-625c-4e07-887a-ebb9f183b9c4", "05c32fff-33a5-4819-b67b-437dd87527bc" },
                    { "183832f0-8e1a-4649-b2fa-d5b9221e0982", "42e5d5a4-43e5-4860-ac15-a23148a611a6" },
                    { "da16d607-625c-4e07-887a-ebb9f183b9c4", "6126e46c-505b-4b73-bac9-1bd69b2d0be8" },
                    { "93b0f040-828a-4907-aabf-c85fc6e97559", "65ceb20f-1872-490f-b3c4-93e0cefbf014" },
                    { "93b0f040-828a-4907-aabf-c85fc6e97559", "816a4125-0f7c-44c3-a364-281c60402d17" },
                    { "87ac289e-8c8d-4b69-820f-3f6e1b3b24c0", "8756e421-ba55-4779-b2ef-451f9436dd7e" },
                    { "183832f0-8e1a-4649-b2fa-d5b9221e0982", "8f39dcd1-8747-485f-b512-8030d104eda4" }
                });
        }
    }
}
