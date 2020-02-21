using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StoneWare.Migrations
{
    public partial class UpdateDateLogic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Problem", "Resolution", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { "If we compress the matrix, we can get to the SSL matrix through the bluetooth SSL matrix!", "Use the wireless JBOD application, then you can synthesize the wireless application!", new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 22, 45, 36, 995, DateTimeKind.Local).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Problem", "Resolution", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { "The XML alarm is down, override the haptic alarm so we can override the XML alarm!", "The AI matrix is down, index the digital matrix so we can index the AI matrix!", new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 22, 43, 26, 499, DateTimeKind.Local).AddTicks(2526), 2 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "OperatingSystemId", "Problem", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 1, "If we reboot the capacitor, we can get to the HTTP capacitor through the cross-platform HTTP capacitor!", new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 19, 45, 23, 37, DateTimeKind.Local).AddTicks(7001), 2 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OperatingSystemId", "Problem", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { 5, "Try to compress the ADP interface, maybe it will compress the 1080p interface!", new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 6, 3, 11, 895, DateTimeKind.Local).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Problem", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { "If we quantify the program, we can get to the TCP program through the digital TCP program!", "Use the 1080p HDD sensor, then you can override the 1080p sensor!", 2, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 3, 43, 54, 576, DateTimeKind.Local).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "OperatingSystemId", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 1, 3, "If we program the driver, we can get to the USB driver through the virtual USB driver!", 2, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 11, 59, 51, 640, DateTimeKind.Local).AddTicks(9911), 1 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "OperatingSystemId", "Problem", "Resolution", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 3, "If we transmit the feed, we can get to the FTP feed through the virtual FTP feed!", "I'll compress the haptic PCI bus, that should bus the PCI bus!", new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 12, 58, 38, 296, DateTimeKind.Local).AddTicks(1880), 1 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 3, "Use the virtual CSS protocol, then you can input the virtual protocol!", 1, null, 1, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 19, 16, 35, 46, DateTimeKind.Local).AddTicks(7681), 1 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 3, "The THX program is down, transmit the redundant program so we can transmit the THX program!", 1, "We need to navigate the bluetooth RAM bus!", new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 18, 34, 48, 412, DateTimeKind.Local).AddTicks(1310), 1 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "OperatingSystemId", "Problem", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 4, "You can't quantify the pixel without backing up the redundant HTTP pixel!", new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 11, 55, 54, 229, DateTimeKind.Local).AddTicks(7825), 5 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { 5, "Use the primary CSS transmitter, then you can navigate the primary transmitter!", 3, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 0, 46, 38, 799, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 3, "You can't calculate the matrix without generating the optical JSON matrix!", 3, null, 1, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 21, 15, 34, 480, DateTimeKind.Local).AddTicks(5090), 5 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "OperatingSystemId", "Problem", "Resolution", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 3, "I'll hack the solid state COM hard drive, that should hard drive the COM hard drive!", "If we compress the application, we can get to the IB application through the auxiliary IB application!", new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 11, 2, 0, 284, DateTimeKind.Local).AddTicks(8490), 2 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { "If we connect the protocol, we can get to the PNG protocol through the haptic PNG protocol!", 3, null, 1, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 19, 12, 50, 8, DateTimeKind.Local).AddTicks(241), 2 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 2, "I'll navigate the neural SAS card, that should card the SAS card!", 3, "Try to connect the RSS transmitter, maybe it will connect the neural transmitter!", 2, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 19, 20, 39, 460, DateTimeKind.Local).AddTicks(8073), 2 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "OperatingSystemId", "Problem", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 2, "The FTP firewall is down, compress the back-end firewall so we can compress the FTP firewall!", new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 17, 19, 7, 568, DateTimeKind.Local).AddTicks(400), 2 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 2, "We need to connect the primary AGP microchip!", 4, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 6, 42, 15, 251, DateTimeKind.Local).AddTicks(2162), 2 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Problem", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { "We need to compress the primary GB array!", new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 2, 15, 18, 833, DateTimeKind.Local).AddTicks(6493), 1 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 4, "If we index the panel, we can get to the IB panel through the optical IB panel!", 2, "Use the digital XSS program, then you can connect the digital program!", 2, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 1, 2, 58, 971, DateTimeKind.Local).AddTicks(6989), 6 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "OperatingSystemId", "Problem", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 2, "Try to synthesize the THX hard drive, maybe it will synthesize the solid state hard drive!", null, 1, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 9, 32, 3, 98, DateTimeKind.Local).AddTicks(2667), 5 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 1, "Use the cross-platform CSS capacitor, then you can override the cross-platform capacitor!", 1, null, 1, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 4, 48, 28, 810, DateTimeKind.Local).AddTicks(6344), 1 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { "You can't parse the feed without transmitting the neural THX feed!", 1, null, 1, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 6, 40, 47, 596, DateTimeKind.Local).AddTicks(4234), 1 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { 5, "If we connect the program, we can get to the ADP program through the mobile ADP program!", 3, null, 1, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 9, 2, 59, 455, DateTimeKind.Local).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 5, "The PCI feed is down, generate the auxiliary feed so we can generate the PCI feed!", 1, "We need to parse the mobile PCI capacitor!", 2, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 11, 41, 36, 995, DateTimeKind.Local).AddTicks(3884), 3 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 3, "We need to transmit the bluetooth FTP feed!", 1, "We need to input the multi-byte JSON capacitor!", 2, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 22, 7, 2, 909, DateTimeKind.Local).AddTicks(388), 2 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 4, "I'll hack the neural ADP port, that should port the ADP port!", 1, "Use the digital ADP bandwidth, then you can index the digital bandwidth!", new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 11, 38, 23, 51, DateTimeKind.Local).AddTicks(3453), 4 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { "You can't quantify the matrix without transmitting the back-end XML matrix!", 4, "connecting the program won't do anything, we need to quantify the primary JBOD program!", 2, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 17, 31, 37, 330, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "OperatingSystemId", "Problem", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 4, "You can't override the capacitor without overriding the mobile XML capacitor!", new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 2, 54, 40, 113, DateTimeKind.Local).AddTicks(7317), 1 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 3, "You can't parse the protocol without quantifying the cross-platform SAS protocol!", 1, "You can't program the capacitor without navigating the redundant TCP capacitor!", new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 20, 20, 8, 285, DateTimeKind.Local).AddTicks(8191), 4 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 2, "quantifying the driver won't do anything, we need to program the wireless SQL driver!", 4, "Try to copy the PNG sensor, maybe it will copy the 1080p sensor!", 2, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 7, 19, 11, 96, DateTimeKind.Local).AddTicks(697), 2 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "OperatingSystemId", "Problem", "Resolution", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 3, "You can't parse the hard drive without generating the digital AGP hard drive!", "connecting the system won't do anything, we need to synthesize the mobile ADP system!", new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 8, 1, 16, 418, DateTimeKind.Local).AddTicks(164), 4 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Problem", "ProductId", "Resolution", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { "We need to reboot the open-source CSS sensor!", 1, "If we synthesize the circuit, we can get to the SCSI circuit through the virtual SCSI circuit!", new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 10, 53, 22, 979, DateTimeKind.Local).AddTicks(6028), 2 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 4, "Try to navigate the JSON port, maybe it will navigate the online port!", 2, null, 1, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 17, 40, 37, 778, DateTimeKind.Local).AddTicks(5398), 5 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Problem", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { "If we copy the monitor, we can get to the USB monitor through the haptic USB monitor!", new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 7, 43, 25, 37, DateTimeKind.Local).AddTicks(4240) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { 1, "Try to program the SDD circuit, maybe it will program the wireless circuit!", 3, null, 1, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 22, 39, 23, 381, DateTimeKind.Local).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { 6, "I'll program the neural TCP matrix, that should matrix the TCP matrix!", 3, null, 1, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 0, 52, 15, 204, DateTimeKind.Local).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Problem", "ProductId", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { "Try to parse the PNG panel, maybe it will parse the haptic panel!", 4, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 19, 28, 8, 23, DateTimeKind.Local).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 2, "Try to index the HDD driver, maybe it will index the cross-platform driver!", 1, "If we calculate the transmitter, we can get to the EXE transmitter through the cross-platform EXE transmitter!", new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 13, 29, 32, 304, DateTimeKind.Local).AddTicks(3474), 4 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "OperatingSystemId", "Problem", "Resolution", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { 5, "overriding the hard drive won't do anything, we need to input the primary ADP hard drive!", "navigating the monitor won't do anything, we need to input the wireless JSON monitor!", new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 8, 27, 21, 890, DateTimeKind.Local).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { 2, "The SSL bus is down, index the 1080p bus so we can index the SSL bus!", 3, "We need to hack the primary THX system!", 2, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 13, 11, 24, 488, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 2, "We need to program the 1080p SMS transmitter!", 3, null, 1, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 10, 57, 51, 710, DateTimeKind.Local).AddTicks(6553), 5 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { 1, "parsing the driver won't do anything, we need to calculate the redundant SAS driver!", 3, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 7, 17, 35, 329, DateTimeKind.Local).AddTicks(1138) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "OperatingSystemId", "Problem", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { 5, "If we navigate the pixel, we can get to the SCSI pixel through the bluetooth SCSI pixel!", null, 1, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 2, 9, 55, 776, DateTimeKind.Local).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { 3, "programming the application won't do anything, we need to program the digital SCSI application!", 4, "You can't program the array without connecting the neural SSL array!", new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 4, 57, 18, 838, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Problem", "ProductId", "Resolution", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { "If we override the interface, we can get to the RAM interface through the online RAM interface!", 4, "The SCSI program is down, hack the neural program so we can hack the SCSI program!", new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 16, 58, 57, 124, DateTimeKind.Local).AddTicks(2694), 1 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 4, "I'll parse the 1080p EXE bus, that should bus the EXE bus!", 2, "Try to parse the SMTP feed, maybe it will parse the multi-byte feed!", 2, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 2, 14, 40, 694, DateTimeKind.Local).AddTicks(6009), 5 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 6, "programming the system won't do anything, we need to synthesize the primary AGP system!", 4, "Use the solid state HTTP microchip, then you can back up the solid state microchip!", 2, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 20, 15, 16, 0, 392, DateTimeKind.Local).AddTicks(7603), 1 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { "Try to hack the GB program, maybe it will hack the 1080p program!", 2, null, 1, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 5, 4, 9, 415, DateTimeKind.Local).AddTicks(5796), 1 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 5, "I'll synthesize the primary TCP card, that should card the TCP card!", 1, "You can't program the firewall without connecting the wireless AI firewall!", new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 19, 23, 44, 9, 192, DateTimeKind.Local).AddTicks(3426), 4 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 3, "Use the open-source RAM circuit, then you can index the open-source circuit!", 1, new DateTime(2020, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 21, 15, 15, 39, 422, DateTimeKind.Local).AddTicks(1709), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Problem", "Resolution", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { "We need to generate the multi-byte SMTP port!", "I'll input the digital SMTP feed, that should feed the SMTP feed!", new DateTime(2020, 2, 8, 13, 16, 31, 650, DateTimeKind.Unspecified).AddTicks(2326), new DateTime(2020, 2, 21, 7, 58, 15, 945, DateTimeKind.Local).AddTicks(1261) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Problem", "Resolution", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { "Use the bluetooth SCSI alarm, then you can navigate the bluetooth alarm!", "We need to connect the mobile TCP bandwidth!", new DateTime(2020, 2, 9, 18, 7, 12, 384, DateTimeKind.Unspecified).AddTicks(4081), new DateTime(2020, 2, 20, 11, 56, 12, 877, DateTimeKind.Local).AddTicks(5344), 1 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "OperatingSystemId", "Problem", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 3, "Use the solid state XSS firewall, then you can reboot the solid state firewall!", new DateTime(2020, 2, 5, 8, 34, 51, 877, DateTimeKind.Unspecified).AddTicks(3154), new DateTime(2020, 2, 20, 18, 7, 28, 494, DateTimeKind.Local).AddTicks(2720), 1 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OperatingSystemId", "Problem", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { 2, "You can't calculate the interface without bypassing the virtual AGP interface!", new DateTime(2020, 2, 10, 5, 44, 53, 390, DateTimeKind.Unspecified).AddTicks(9259), new DateTime(2020, 2, 20, 15, 53, 26, 4, DateTimeKind.Local).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Problem", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { "Use the multi-byte HDD hard drive, then you can connect the multi-byte hard drive!", null, 1, new DateTime(2020, 2, 10, 17, 26, 26, 741, DateTimeKind.Unspecified).AddTicks(2651), new DateTime(2020, 2, 20, 23, 27, 26, 190, DateTimeKind.Local).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "OperatingSystemId", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 2, 1, null, 1, new DateTime(2020, 2, 11, 21, 32, 59, 563, DateTimeKind.Unspecified).AddTicks(4288), new DateTime(2020, 2, 20, 0, 1, 31, 599, DateTimeKind.Local).AddTicks(4033), 3 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "OperatingSystemId", "Problem", "Resolution", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 2, "We need to back up the neural RAM monitor!", "Try to parse the FTP transmitter, maybe it will parse the back-end transmitter!", new DateTime(2020, 2, 5, 0, 16, 22, 543, DateTimeKind.Unspecified).AddTicks(7357), new DateTime(2020, 2, 19, 18, 19, 49, 554, DateTimeKind.Local).AddTicks(9039), 3 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 5, "We need to override the open-source XSS firewall!", 2, "Try to bypass the SMTP bandwidth, maybe it will bypass the primary bandwidth!", 2, new DateTime(2020, 2, 6, 19, 18, 53, 648, DateTimeKind.Unspecified).AddTicks(4264), new DateTime(2020, 2, 21, 0, 34, 19, 452, DateTimeKind.Local).AddTicks(3207), 5 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 4, "The SSL bandwidth is down, calculate the neural bandwidth so we can calculate the SSL bandwidth!", 4, "Use the cross-platform SCSI interface, then you can index the cross-platform interface!", new DateTime(2020, 2, 9, 8, 42, 45, 45, DateTimeKind.Unspecified).AddTicks(167), new DateTime(2020, 2, 20, 14, 33, 30, 883, DateTimeKind.Local).AddTicks(8938), 2 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "OperatingSystemId", "Problem", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 2, "Use the multi-byte COM feed, then you can back up the multi-byte feed!", new DateTime(2020, 2, 7, 23, 18, 28, 122, DateTimeKind.Unspecified).AddTicks(1047), new DateTime(2020, 2, 21, 8, 53, 12, 992, DateTimeKind.Local).AddTicks(4325), 1 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { 2, "Try to back up the HDD microchip, maybe it will back up the optical microchip!", 4, new DateTime(2020, 2, 10, 1, 5, 10, 932, DateTimeKind.Unspecified).AddTicks(5204), new DateTime(2020, 2, 19, 20, 29, 58, 648, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 5, "quantifying the port won't do anything, we need to reboot the virtual SCSI port!", 2, "Use the multi-byte JSON panel, then you can bypass the multi-byte panel!", 2, new DateTime(2020, 2, 11, 20, 15, 33, 313, DateTimeKind.Unspecified).AddTicks(3516), new DateTime(2020, 2, 20, 3, 16, 33, 272, DateTimeKind.Local).AddTicks(9540), 6 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "OperatingSystemId", "Problem", "Resolution", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 4, "You can't input the protocol without generating the back-end EXE protocol!", "Use the auxiliary RAM alarm, then you can generate the auxiliary alarm!", new DateTime(2020, 2, 6, 19, 23, 41, 982, DateTimeKind.Unspecified).AddTicks(869), new DateTime(2020, 2, 20, 10, 46, 26, 743, DateTimeKind.Local).AddTicks(609), 1 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { "The FTP sensor is down, transmit the cross-platform sensor so we can transmit the FTP sensor!", 1, "We need to hack the online SAS firewall!", 2, new DateTime(2020, 2, 10, 16, 40, 29, 374, DateTimeKind.Unspecified).AddTicks(4054), new DateTime(2020, 2, 19, 21, 10, 25, 227, DateTimeKind.Local).AddTicks(62), 4 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 4, "Use the neural SSL bandwidth, then you can hack the neural bandwidth!", 2, null, 1, new DateTime(2020, 2, 6, 1, 11, 20, 442, DateTimeKind.Unspecified).AddTicks(2443), new DateTime(2020, 2, 20, 14, 21, 11, 157, DateTimeKind.Local).AddTicks(4533), 5 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "OperatingSystemId", "Problem", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 3, "You can't reboot the protocol without synthesizing the digital JSON protocol!", new DateTime(2020, 2, 7, 10, 58, 53, 553, DateTimeKind.Unspecified).AddTicks(8422), new DateTime(2020, 2, 21, 3, 2, 29, 586, DateTimeKind.Local).AddTicks(2848), 1 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 1, "Try to back up the USB matrix, maybe it will back up the multi-byte matrix!", 1, new DateTime(2020, 2, 7, 10, 31, 17, 264, DateTimeKind.Unspecified).AddTicks(8168), new DateTime(2020, 2, 20, 23, 22, 55, 185, DateTimeKind.Local).AddTicks(1639), 1 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Problem", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { "I'll navigate the open-source SSL sensor, that should sensor the SSL sensor!", new DateTime(2020, 2, 7, 22, 26, 5, 332, DateTimeKind.Unspecified).AddTicks(689), new DateTime(2020, 2, 20, 7, 8, 22, 632, DateTimeKind.Local).AddTicks(8601), 2 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 1, "I'll back up the multi-byte USB microchip, that should microchip the USB microchip!", 3, null, 1, new DateTime(2020, 2, 7, 6, 23, 11, 719, DateTimeKind.Unspecified).AddTicks(2372), new DateTime(2020, 2, 20, 4, 32, 16, 466, DateTimeKind.Local).AddTicks(7278), 1 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "OperatingSystemId", "Problem", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 5, "Use the digital XSS microchip, then you can connect the digital microchip!", "Try to transmit the FTP transmitter, maybe it will transmit the online transmitter!", 2, new DateTime(2020, 2, 6, 8, 35, 35, 250, DateTimeKind.Unspecified).AddTicks(31), new DateTime(2020, 2, 20, 18, 36, 48, 106, DateTimeKind.Local).AddTicks(3778), 1 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 4, "parsing the capacitor won't do anything, we need to compress the redundant HTTP capacitor!", 3, "You can't compress the application without transmitting the wireless RAM application!", 2, new DateTime(2020, 2, 10, 9, 5, 54, 230, DateTimeKind.Unspecified).AddTicks(3208), new DateTime(2020, 2, 21, 2, 43, 18, 637, DateTimeKind.Local).AddTicks(1082), 5 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { "We need to parse the mobile PCI capacitor!", 3, "We need to compress the solid state SQL driver!", 2, new DateTime(2020, 2, 9, 16, 39, 31, 650, DateTimeKind.Unspecified).AddTicks(8802), new DateTime(2020, 2, 20, 10, 7, 0, 247, DateTimeKind.Local).AddTicks(1115), 2 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { 4, "I'll bypass the mobile HDD application, that should application the HDD application!", 2, "overriding the capacitor won't do anything, we need to index the multi-byte XML capacitor!", 2, new DateTime(2020, 2, 10, 13, 6, 39, 312, DateTimeKind.Unspecified).AddTicks(8296), new DateTime(2020, 2, 21, 3, 50, 44, 916, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 3, "We need to calculate the primary IB application!", 4, null, 1, new DateTime(2020, 2, 8, 21, 12, 9, 929, DateTimeKind.Unspecified).AddTicks(878), new DateTime(2020, 2, 20, 15, 2, 30, 205, DateTimeKind.Local).AddTicks(5302), 2 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 2, "transmitting the matrix won't do anything, we need to bypass the multi-byte JBOD matrix!", 2, null, 1, new DateTime(2020, 2, 8, 10, 13, 35, 966, DateTimeKind.Unspecified).AddTicks(466), new DateTime(2020, 2, 21, 4, 20, 13, 595, DateTimeKind.Local).AddTicks(314), 6 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 2, "You can't override the capacitor without connecting the cross-platform JSON capacitor!", 3, "I'll parse the primary CSS sensor, that should sensor the CSS sensor!", new DateTime(2020, 2, 5, 22, 4, 34, 415, DateTimeKind.Unspecified).AddTicks(2320), new DateTime(2020, 2, 20, 14, 8, 8, 190, DateTimeKind.Local).AddTicks(56), 1 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { "I'll reboot the auxiliary PCI interface, that should interface the PCI interface!", 1, null, 1, new DateTime(2020, 2, 9, 13, 50, 20, 898, DateTimeKind.Unspecified).AddTicks(7721), new DateTime(2020, 2, 21, 8, 45, 58, 815, DateTimeKind.Local).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "OperatingSystemId", "Problem", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 5, "quantifying the driver won't do anything, we need to program the wireless SQL driver!", new DateTime(2020, 2, 9, 8, 52, 45, 410, DateTimeKind.Unspecified).AddTicks(5395), new DateTime(2020, 2, 20, 19, 20, 51, 54, DateTimeKind.Local).AddTicks(4259), 2 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 5, "If we connect the transmitter, we can get to the IB transmitter through the online IB transmitter!", 2, "Try to input the CSS capacitor, maybe it will input the multi-byte capacitor!", new DateTime(2020, 2, 8, 11, 35, 8, 777, DateTimeKind.Unspecified).AddTicks(5708), new DateTime(2020, 2, 20, 20, 35, 35, 839, DateTimeKind.Local).AddTicks(2843), 6 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 4, "Try to override the USB panel, maybe it will override the multi-byte panel!", 2, null, 1, new DateTime(2020, 2, 9, 17, 14, 39, 686, DateTimeKind.Unspecified).AddTicks(2787), new DateTime(2020, 2, 21, 10, 8, 16, 726, DateTimeKind.Local).AddTicks(7179), 6 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "OperatingSystemId", "Problem", "Resolution", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 2, "Try to quantify the HTTP array, maybe it will quantify the optical array!", "You can't connect the capacitor without copying the back-end SSL capacitor!", new DateTime(2020, 2, 5, 14, 19, 43, 669, DateTimeKind.Unspecified).AddTicks(3363), new DateTime(2020, 2, 19, 17, 6, 27, 363, DateTimeKind.Local).AddTicks(8489), 2 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Problem", "ProductId", "Resolution", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { "Try to input the SAS firewall, maybe it will input the primary firewall!", 4, "The SQL interface is down, index the bluetooth interface so we can index the SQL interface!", new DateTime(2020, 2, 6, 16, 6, 58, 454, DateTimeKind.Unspecified).AddTicks(3120), new DateTime(2020, 2, 21, 10, 15, 6, 801, DateTimeKind.Local).AddTicks(6008), 1 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 1, "I'll connect the bluetooth SMS driver, that should driver the SMS driver!", 1, "I'll program the neural TCP matrix, that should matrix the TCP matrix!", 2, new DateTime(2020, 2, 6, 18, 10, 38, 398, DateTimeKind.Unspecified).AddTicks(8611), new DateTime(2020, 2, 19, 15, 31, 38, 391, DateTimeKind.Local).AddTicks(8710), 2 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Problem", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { "hacking the matrix won't do anything, we need to bypass the haptic COM matrix!", new DateTime(2020, 2, 9, 0, 47, 43, 70, DateTimeKind.Unspecified).AddTicks(7724), new DateTime(2020, 2, 20, 22, 27, 34, 532, DateTimeKind.Local).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { 6, "Try to generate the HTTP protocol, maybe it will generate the auxiliary protocol!", 4, "You can't generate the transmitter without quantifying the neural ADP transmitter!", 2, new DateTime(2020, 2, 7, 11, 14, 29, 318, DateTimeKind.Unspecified).AddTicks(7932), new DateTime(2020, 2, 20, 6, 35, 43, 35, DateTimeKind.Local).AddTicks(8546) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { 3, "We need to synthesize the 1080p COM capacitor!", 4, "You can't program the driver without generating the 1080p USB driver!", 2, new DateTime(2020, 2, 8, 3, 13, 52, 880, DateTimeKind.Unspecified).AddTicks(9435), new DateTime(2020, 2, 21, 6, 50, 33, 506, DateTimeKind.Local).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Problem", "ProductId", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { "generating the protocol won't do anything, we need to hack the digital AI protocol!", 3, new DateTime(2020, 2, 10, 6, 18, 40, 621, DateTimeKind.Unspecified).AddTicks(3312), new DateTime(2020, 2, 19, 14, 14, 48, 576, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 5, "calculating the system won't do anything, we need to transmit the wireless RAM system!", 2, "copying the protocol won't do anything, we need to copy the back-end EXE protocol!", new DateTime(2020, 2, 6, 8, 4, 19, 972, DateTimeKind.Unspecified).AddTicks(7066), new DateTime(2020, 2, 20, 18, 31, 47, 611, DateTimeKind.Local).AddTicks(7142), 1 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "OperatingSystemId", "Problem", "Resolution", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { 3, "copying the capacitor won't do anything, we need to back up the optical SMS capacitor!", "generating the array won't do anything, we need to transmit the online THX array!", new DateTime(2020, 2, 5, 0, 40, 20, 0, DateTimeKind.Unspecified).AddTicks(2324), new DateTime(2020, 2, 20, 5, 15, 2, 929, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { 4, "We need to override the 1080p JSON interface!", 4, null, 1, new DateTime(2020, 2, 10, 18, 42, 25, 11, DateTimeKind.Unspecified).AddTicks(2120), new DateTime(2020, 2, 19, 17, 6, 36, 746, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 3, "The XML panel is down, connect the back-end panel so we can connect the XML panel!", 4, "You can't transmit the bus without quantifying the digital AI bus!", 2, new DateTime(2020, 2, 10, 16, 16, 26, 924, DateTimeKind.Unspecified).AddTicks(110), new DateTime(2020, 2, 20, 22, 18, 58, 427, DateTimeKind.Local).AddTicks(8583), 2 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { 2, "connecting the application won't do anything, we need to bypass the mobile ADP application!", 2, new DateTime(2020, 2, 7, 12, 52, 45, 683, DateTimeKind.Unspecified).AddTicks(2330), new DateTime(2020, 2, 20, 3, 58, 21, 435, DateTimeKind.Local).AddTicks(3934) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "OperatingSystemId", "Problem", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { 3, "The JBOD circuit is down, program the neural circuit so we can program the JBOD circuit!", "The SCSI circuit is down, index the open-source circuit so we can index the SCSI circuit!", 2, new DateTime(2020, 2, 9, 0, 12, 44, 460, DateTimeKind.Unspecified).AddTicks(1870), new DateTime(2020, 2, 20, 14, 42, 45, 742, DateTimeKind.Local).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "TimeCreated", "TimeLastUpdated" },
                values: new object[] { 1, "If we navigate the bandwidth, we can get to the RSS bandwidth through the back-end RSS bandwidth!", 3, "Try to hack the GB program, maybe it will hack the 1080p program!", new DateTime(2020, 2, 8, 22, 25, 46, 369, DateTimeKind.Unspecified).AddTicks(1864), new DateTime(2020, 2, 21, 3, 5, 58, 812, DateTimeKind.Local).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Problem", "ProductId", "Resolution", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { "If we connect the feed, we can get to the SDD feed through the virtual SDD feed!", 1, "You can't compress the bus without connecting the haptic SMS bus!", new DateTime(2020, 2, 11, 21, 51, 38, 981, DateTimeKind.Unspecified).AddTicks(6987), new DateTime(2020, 2, 19, 17, 8, 41, 922, DateTimeKind.Local).AddTicks(8361), 4 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 3, "Try to input the XSS capacitor, maybe it will input the optical capacitor!", 1, null, 1, new DateTime(2020, 2, 9, 5, 50, 57, 0, DateTimeKind.Unspecified).AddTicks(9032), new DateTime(2020, 2, 21, 5, 18, 18, 492, DateTimeKind.Local).AddTicks(7842), 4 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 4, "The JSON capacitor is down, connect the haptic capacitor so we can connect the JSON capacitor!", 1, null, 1, new DateTime(2020, 2, 11, 13, 48, 29, 765, DateTimeKind.Unspecified).AddTicks(3173), new DateTime(2020, 2, 21, 6, 15, 57, 523, DateTimeKind.Local).AddTicks(7196), 3 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { "indexing the capacitor won't do anything, we need to copy the virtual USB capacitor!", 4, "The JBOD sensor is down, back up the digital sensor so we can back up the JBOD sensor!", 2, new DateTime(2020, 2, 7, 7, 13, 56, 979, DateTimeKind.Unspecified).AddTicks(8483), new DateTime(2020, 2, 20, 14, 53, 17, 931, DateTimeKind.Local).AddTicks(8805), 2 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "Resolution", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 2, "navigating the circuit won't do anything, we need to parse the 1080p AGP circuit!", 4, "The JSON card is down, program the auxiliary card so we can program the JSON card!", new DateTime(2020, 2, 6, 3, 43, 53, 353, DateTimeKind.Unspecified).AddTicks(2143), new DateTime(2020, 2, 21, 9, 9, 27, 592, DateTimeKind.Local).AddTicks(2441), 2 });

            migrationBuilder.UpdateData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "OperatingSystemId", "Problem", "ProductId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[] { 4, "You can't parse the system without copying the wireless THX system!", 2, new DateTime(2020, 2, 9, 2, 36, 29, 775, DateTimeKind.Unspecified).AddTicks(6680), new DateTime(2020, 2, 21, 2, 46, 52, 241, DateTimeKind.Local).AddTicks(8013), 5 });
        }
    }
}
