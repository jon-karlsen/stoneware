using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StoneWare.Migrations
{
    public partial class ReviseIssueCreatedAtSeedLogic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 8, 13, 16, 31, 650, DateTimeKind.Unspecified).AddTicks(2326), new DateTime(2020, 2, 21, 7, 58, 15, 945, DateTimeKind.Local).AddTicks(1261) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 9, 18, 7, 12, 384, DateTimeKind.Unspecified).AddTicks(4081), new DateTime(2020, 2, 20, 11, 56, 12, 877, DateTimeKind.Local).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 5, 8, 34, 51, 877, DateTimeKind.Unspecified).AddTicks(3154), new DateTime(2020, 2, 20, 18, 7, 28, 494, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 10, 5, 44, 53, 390, DateTimeKind.Unspecified).AddTicks(9259), new DateTime(2020, 2, 20, 15, 53, 26, 4, DateTimeKind.Local).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 10, 17, 26, 26, 741, DateTimeKind.Unspecified).AddTicks(2651), new DateTime(2020, 2, 20, 23, 27, 26, 190, DateTimeKind.Local).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 11, 21, 32, 59, 563, DateTimeKind.Unspecified).AddTicks(4288), new DateTime(2020, 2, 20, 0, 1, 31, 599, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 5, 0, 16, 22, 543, DateTimeKind.Unspecified).AddTicks(7357), new DateTime(2020, 2, 19, 18, 19, 49, 554, DateTimeKind.Local).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 6, 19, 18, 53, 648, DateTimeKind.Unspecified).AddTicks(4264), new DateTime(2020, 2, 21, 0, 34, 19, 452, DateTimeKind.Local).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 9, 8, 42, 45, 45, DateTimeKind.Unspecified).AddTicks(167), new DateTime(2020, 2, 20, 14, 33, 30, 883, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 7, 23, 18, 28, 122, DateTimeKind.Unspecified).AddTicks(1047), new DateTime(2020, 2, 21, 8, 53, 12, 992, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 10, 1, 5, 10, 932, DateTimeKind.Unspecified).AddTicks(5204), new DateTime(2020, 2, 19, 20, 29, 58, 648, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 11, 20, 15, 33, 313, DateTimeKind.Unspecified).AddTicks(3516), new DateTime(2020, 2, 20, 3, 16, 33, 272, DateTimeKind.Local).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 6, 19, 23, 41, 982, DateTimeKind.Unspecified).AddTicks(869), new DateTime(2020, 2, 20, 10, 46, 26, 743, DateTimeKind.Local).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 10, 16, 40, 29, 374, DateTimeKind.Unspecified).AddTicks(4054), new DateTime(2020, 2, 19, 21, 10, 25, 227, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 6, 1, 11, 20, 442, DateTimeKind.Unspecified).AddTicks(2443), new DateTime(2020, 2, 20, 14, 21, 11, 157, DateTimeKind.Local).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 7, 10, 58, 53, 553, DateTimeKind.Unspecified).AddTicks(8422), new DateTime(2020, 2, 21, 3, 2, 29, 586, DateTimeKind.Local).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 7, 10, 31, 17, 264, DateTimeKind.Unspecified).AddTicks(8168), new DateTime(2020, 2, 20, 23, 22, 55, 185, DateTimeKind.Local).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 7, 22, 26, 5, 332, DateTimeKind.Unspecified).AddTicks(689), new DateTime(2020, 2, 20, 7, 8, 22, 632, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 7, 6, 23, 11, 719, DateTimeKind.Unspecified).AddTicks(2372), new DateTime(2020, 2, 20, 4, 32, 16, 466, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 6, 8, 35, 35, 250, DateTimeKind.Unspecified).AddTicks(31), new DateTime(2020, 2, 20, 18, 36, 48, 106, DateTimeKind.Local).AddTicks(3778) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 10, 9, 5, 54, 230, DateTimeKind.Unspecified).AddTicks(3208), new DateTime(2020, 2, 21, 2, 43, 18, 637, DateTimeKind.Local).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 9, 16, 39, 31, 650, DateTimeKind.Unspecified).AddTicks(8802), new DateTime(2020, 2, 20, 10, 7, 0, 247, DateTimeKind.Local).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 10, 13, 6, 39, 312, DateTimeKind.Unspecified).AddTicks(8296), new DateTime(2020, 2, 21, 3, 50, 44, 916, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 8, 21, 12, 9, 929, DateTimeKind.Unspecified).AddTicks(878), new DateTime(2020, 2, 20, 15, 2, 30, 205, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 8, 10, 13, 35, 966, DateTimeKind.Unspecified).AddTicks(466), new DateTime(2020, 2, 21, 4, 20, 13, 595, DateTimeKind.Local).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 5, 22, 4, 34, 415, DateTimeKind.Unspecified).AddTicks(2320), new DateTime(2020, 2, 20, 14, 8, 8, 190, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 9, 13, 50, 20, 898, DateTimeKind.Unspecified).AddTicks(7721), new DateTime(2020, 2, 21, 8, 45, 58, 815, DateTimeKind.Local).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 9, 8, 52, 45, 410, DateTimeKind.Unspecified).AddTicks(5395), new DateTime(2020, 2, 20, 19, 20, 51, 54, DateTimeKind.Local).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 8, 11, 35, 8, 777, DateTimeKind.Unspecified).AddTicks(5708), new DateTime(2020, 2, 20, 20, 35, 35, 839, DateTimeKind.Local).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 9, 17, 14, 39, 686, DateTimeKind.Unspecified).AddTicks(2787), new DateTime(2020, 2, 21, 10, 8, 16, 726, DateTimeKind.Local).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 5, 14, 19, 43, 669, DateTimeKind.Unspecified).AddTicks(3363), new DateTime(2020, 2, 19, 17, 6, 27, 363, DateTimeKind.Local).AddTicks(8489) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 6, 16, 6, 58, 454, DateTimeKind.Unspecified).AddTicks(3120), new DateTime(2020, 2, 21, 10, 15, 6, 801, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 6, 18, 10, 38, 398, DateTimeKind.Unspecified).AddTicks(8611), new DateTime(2020, 2, 19, 15, 31, 38, 391, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 9, 0, 47, 43, 70, DateTimeKind.Unspecified).AddTicks(7724), new DateTime(2020, 2, 20, 22, 27, 34, 532, DateTimeKind.Local).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 7, 11, 14, 29, 318, DateTimeKind.Unspecified).AddTicks(7932), new DateTime(2020, 2, 20, 6, 35, 43, 35, DateTimeKind.Local).AddTicks(8546) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 8, 3, 13, 52, 880, DateTimeKind.Unspecified).AddTicks(9435), new DateTime(2020, 2, 21, 6, 50, 33, 506, DateTimeKind.Local).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 10, 6, 18, 40, 621, DateTimeKind.Unspecified).AddTicks(3312), new DateTime(2020, 2, 19, 14, 14, 48, 576, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 6, 8, 4, 19, 972, DateTimeKind.Unspecified).AddTicks(7066), new DateTime(2020, 2, 20, 18, 31, 47, 611, DateTimeKind.Local).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 5, 0, 40, 20, 0, DateTimeKind.Unspecified).AddTicks(2324), new DateTime(2020, 2, 20, 5, 15, 2, 929, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 10, 18, 42, 25, 11, DateTimeKind.Unspecified).AddTicks(2120), new DateTime(2020, 2, 19, 17, 6, 36, 746, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 10, 16, 16, 26, 924, DateTimeKind.Unspecified).AddTicks(110), new DateTime(2020, 2, 20, 22, 18, 58, 427, DateTimeKind.Local).AddTicks(8583) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 7, 12, 52, 45, 683, DateTimeKind.Unspecified).AddTicks(2330), new DateTime(2020, 2, 20, 3, 58, 21, 435, DateTimeKind.Local).AddTicks(3934) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 9, 0, 12, 44, 460, DateTimeKind.Unspecified).AddTicks(1870), new DateTime(2020, 2, 20, 14, 42, 45, 742, DateTimeKind.Local).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 8, 22, 25, 46, 369, DateTimeKind.Unspecified).AddTicks(1864), new DateTime(2020, 2, 21, 3, 5, 58, 812, DateTimeKind.Local).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 11, 21, 51, 38, 981, DateTimeKind.Unspecified).AddTicks(6987), new DateTime(2020, 2, 19, 17, 8, 41, 922, DateTimeKind.Local).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 9, 5, 50, 57, 0, DateTimeKind.Unspecified).AddTicks(9032), new DateTime(2020, 2, 21, 5, 18, 18, 492, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 11, 13, 48, 29, 765, DateTimeKind.Unspecified).AddTicks(3173), new DateTime(2020, 2, 21, 6, 15, 57, 523, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 7, 7, 13, 56, 979, DateTimeKind.Unspecified).AddTicks(8483), new DateTime(2020, 2, 20, 14, 53, 17, 931, DateTimeKind.Local).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 6, 3, 43, 53, 353, DateTimeKind.Unspecified).AddTicks(2143), new DateTime(2020, 2, 21, 9, 9, 27, 592, DateTimeKind.Local).AddTicks(2441) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 9, 2, 36, 29, 775, DateTimeKind.Unspecified).AddTicks(6680), new DateTime(2020, 2, 21, 2, 46, 52, 241, DateTimeKind.Local).AddTicks(8013) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 17, 9, 53, 22, 331, DateTimeKind.Local).AddTicks(9571), new DateTime(2020, 2, 20, 19, 59, 1, 77, DateTimeKind.Local).AddTicks(1351) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 16, 5, 2, 41, 603, DateTimeKind.Local).AddTicks(8468), new DateTime(2020, 2, 19, 23, 56, 58, 6, DateTimeKind.Local).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 20, 14, 35, 2, 110, DateTimeKind.Local).AddTicks(9760), new DateTime(2020, 2, 20, 6, 8, 13, 623, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 15, 17, 25, 0, 597, DateTimeKind.Local).AddTicks(3850), new DateTime(2020, 2, 20, 3, 54, 11, 133, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 15, 5, 43, 27, 247, DateTimeKind.Local).AddTicks(553), new DateTime(2020, 2, 20, 11, 28, 11, 319, DateTimeKind.Local).AddTicks(4649) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 14, 1, 36, 54, 424, DateTimeKind.Local).AddTicks(9017), new DateTime(2020, 2, 19, 12, 2, 16, 728, DateTimeKind.Local).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 20, 22, 53, 31, 444, DateTimeKind.Local).AddTicks(6038), new DateTime(2020, 2, 19, 6, 20, 34, 683, DateTimeKind.Local).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 19, 3, 51, 0, 339, DateTimeKind.Local).AddTicks(9314), new DateTime(2020, 2, 20, 12, 35, 4, 581, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 16, 14, 27, 8, 943, DateTimeKind.Local).AddTicks(3534), new DateTime(2020, 2, 20, 2, 34, 16, 12, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 17, 23, 51, 25, 866, DateTimeKind.Local).AddTicks(2837), new DateTime(2020, 2, 20, 20, 53, 58, 121, DateTimeKind.Local).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 15, 22, 4, 43, 55, DateTimeKind.Local).AddTicks(8763), new DateTime(2020, 2, 19, 8, 30, 43, 777, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 14, 2, 54, 20, 675, DateTimeKind.Local).AddTicks(535), new DateTime(2020, 2, 19, 15, 17, 18, 401, DateTimeKind.Local).AddTicks(9816) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 19, 3, 46, 12, 6, DateTimeKind.Local).AddTicks(3394), new DateTime(2020, 2, 19, 22, 47, 11, 872, DateTimeKind.Local).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 29, 24, 614, DateTimeKind.Local).AddTicks(336), new DateTime(2020, 2, 19, 9, 11, 10, 356, DateTimeKind.Local).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 19, 21, 58, 33, 546, DateTimeKind.Local).AddTicks(2069), new DateTime(2020, 2, 20, 2, 21, 56, 286, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 18, 12, 11, 0, 434, DateTimeKind.Local).AddTicks(6214), new DateTime(2020, 2, 20, 15, 3, 14, 715, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 18, 12, 38, 36, 723, DateTimeKind.Local).AddTicks(6550), new DateTime(2020, 2, 20, 11, 23, 40, 314, DateTimeKind.Local).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 18, 0, 43, 48, 656, DateTimeKind.Local).AddTicks(4114), new DateTime(2020, 2, 19, 19, 9, 7, 761, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 18, 16, 46, 42, 269, DateTimeKind.Local).AddTicks(2513), new DateTime(2020, 2, 19, 16, 33, 1, 595, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 19, 14, 34, 18, 738, DateTimeKind.Local).AddTicks(4934), new DateTime(2020, 2, 20, 6, 37, 33, 235, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 15, 14, 3, 59, 758, DateTimeKind.Local).AddTicks(1976), new DateTime(2020, 2, 20, 14, 44, 3, 766, DateTimeKind.Local).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 16, 6, 30, 22, 337, DateTimeKind.Local).AddTicks(6724), new DateTime(2020, 2, 19, 22, 7, 45, 376, DateTimeKind.Local).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 15, 10, 3, 14, 675, DateTimeKind.Local).AddTicks(7459), new DateTime(2020, 2, 20, 15, 51, 30, 45, DateTimeKind.Local).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 17, 1, 57, 44, 59, DateTimeKind.Local).AddTicks(5009), new DateTime(2020, 2, 20, 3, 3, 15, 334, DateTimeKind.Local).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 17, 12, 56, 18, 22, DateTimeKind.Local).AddTicks(5499), new DateTime(2020, 2, 20, 16, 20, 58, 724, DateTimeKind.Local).AddTicks(1208) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 20, 1, 5, 19, 573, DateTimeKind.Local).AddTicks(3782), new DateTime(2020, 2, 20, 2, 8, 53, 319, DateTimeKind.Local).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 16, 9, 19, 33, 89, DateTimeKind.Local).AddTicks(8507), new DateTime(2020, 2, 20, 20, 46, 43, 945, DateTimeKind.Local).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 16, 14, 17, 8, 578, DateTimeKind.Local).AddTicks(913), new DateTime(2020, 2, 20, 7, 21, 36, 183, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 17, 11, 34, 45, 211, DateTimeKind.Local).AddTicks(732), new DateTime(2020, 2, 20, 8, 36, 20, 968, DateTimeKind.Local).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 16, 5, 55, 14, 302, DateTimeKind.Local).AddTicks(3777), new DateTime(2020, 2, 20, 22, 9, 1, 855, DateTimeKind.Local).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 20, 8, 50, 10, 319, DateTimeKind.Local).AddTicks(3284), new DateTime(2020, 2, 19, 5, 7, 12, 492, DateTimeKind.Local).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 19, 7, 2, 55, 534, DateTimeKind.Local).AddTicks(3694), new DateTime(2020, 2, 20, 22, 15, 51, 930, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 19, 4, 59, 15, 589, DateTimeKind.Local).AddTicks(8331), new DateTime(2020, 2, 19, 3, 32, 23, 520, DateTimeKind.Local).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 16, 22, 22, 10, 917, DateTimeKind.Local).AddTicks(9342), new DateTime(2020, 2, 20, 10, 28, 19, 661, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 18, 11, 55, 24, 669, DateTimeKind.Local).AddTicks(9267), new DateTime(2020, 2, 19, 18, 36, 28, 164, DateTimeKind.Local).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 17, 19, 56, 1, 107, DateTimeKind.Local).AddTicks(7883), new DateTime(2020, 2, 20, 18, 51, 18, 636, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 15, 16, 51, 13, 367, DateTimeKind.Local).AddTicks(4121), new DateTime(2020, 2, 19, 2, 15, 33, 705, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 19, 15, 5, 34, 16, DateTimeKind.Local).AddTicks(530), new DateTime(2020, 2, 20, 6, 32, 32, 740, DateTimeKind.Local).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 20, 22, 29, 33, 988, DateTimeKind.Local).AddTicks(5391), new DateTime(2020, 2, 19, 17, 15, 48, 58, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 15, 4, 27, 28, 977, DateTimeKind.Local).AddTicks(5760), new DateTime(2020, 2, 19, 5, 7, 21, 875, DateTimeKind.Local).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 15, 6, 53, 27, 64, DateTimeKind.Local).AddTicks(7847), new DateTime(2020, 2, 20, 10, 19, 43, 556, DateTimeKind.Local).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 18, 10, 17, 8, 305, DateTimeKind.Local).AddTicks(5749), new DateTime(2020, 2, 19, 15, 59, 6, 564, DateTimeKind.Local).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 16, 22, 57, 9, 528, DateTimeKind.Local).AddTicks(6334), new DateTime(2020, 2, 20, 2, 43, 30, 871, DateTimeKind.Local).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 17, 0, 44, 7, 619, DateTimeKind.Local).AddTicks(6470), new DateTime(2020, 2, 20, 15, 6, 43, 942, DateTimeKind.Local).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 14, 1, 18, 15, 7, DateTimeKind.Local).AddTicks(1471), new DateTime(2020, 2, 19, 5, 9, 27, 51, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 16, 17, 18, 56, 987, DateTimeKind.Local).AddTicks(9595), new DateTime(2020, 2, 20, 17, 19, 3, 621, DateTimeKind.Local).AddTicks(9216) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 14, 9, 21, 24, 223, DateTimeKind.Local).AddTicks(5535), new DateTime(2020, 2, 20, 18, 16, 42, 652, DateTimeKind.Local).AddTicks(8575) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 18, 15, 55, 57, 9, DateTimeKind.Local).AddTicks(306), new DateTime(2020, 2, 20, 2, 54, 3, 61, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 19, 19, 26, 0, 635, DateTimeKind.Local).AddTicks(6816), new DateTime(2020, 2, 20, 21, 10, 12, 721, DateTimeKind.Local).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "TimeCreated", "TimeLastUpdated" },
                values: new object[] { new DateTime(2020, 2, 16, 20, 33, 24, 213, DateTimeKind.Local).AddTicks(2400), new DateTime(2020, 2, 20, 14, 47, 37, 370, DateTimeKind.Local).AddTicks(9452) });
        }
    }
}
