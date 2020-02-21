using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StoneWare.Migrations
{
    public partial class IssueData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Issue",
                columns: new[] { "Id", "OperatingSystemId", "Problem", "ProductId", "Resolution", "StatusId", "TimeCreated", "TimeLastUpdated", "VersionNumberId" },
                values: new object[,]
                {
                    { 1, 4, "We need to generate the multi-byte SMTP port!", 4, "I'll input the digital SMTP feed, that should feed the SMTP feed!", 2, new DateTime(2020, 2, 17, 9, 42, 14, 984, DateTimeKind.Local).AddTicks(1050), new DateTime(2020, 2, 20, 19, 47, 53, 730, DateTimeKind.Local).AddTicks(7322), 2 },
                    { 28, 5, "quantifying the driver won't do anything, we need to program the wireless SQL driver!", 4, null, 1, new DateTime(2020, 2, 16, 14, 6, 1, 231, DateTimeKind.Local).AddTicks(4837), new DateTime(2020, 2, 20, 7, 10, 28, 836, DateTimeKind.Local).AddTicks(9147), 2 },
                    { 29, 5, "If we connect the transmitter, we can get to the IB transmitter through the online IB transmitter!", 2, "Try to input the CSS capacitor, maybe it will input the multi-byte capacitor!", 2, new DateTime(2020, 2, 17, 11, 23, 37, 864, DateTimeKind.Local).AddTicks(4609), new DateTime(2020, 2, 20, 8, 25, 13, 621, DateTimeKind.Local).AddTicks(7728), 6 },
                    { 30, 4, "Try to override the USB panel, maybe it will override the multi-byte panel!", 2, null, 1, new DateTime(2020, 2, 16, 5, 44, 6, 955, DateTimeKind.Local).AddTicks(7650), new DateTime(2020, 2, 20, 21, 57, 54, 509, DateTimeKind.Local).AddTicks(2069), 6 },
                    { 31, 2, "Try to quantify the HTTP array, maybe it will quantify the optical array!", 1, "You can't connect the capacitor without copying the back-end SSL capacitor!", 2, new DateTime(2020, 2, 20, 8, 39, 2, 972, DateTimeKind.Local).AddTicks(7152), new DateTime(2020, 2, 19, 4, 56, 5, 146, DateTimeKind.Local).AddTicks(3381), 2 },
                    { 32, 3, "Try to input the SAS firewall, maybe it will input the primary firewall!", 4, "The SQL interface is down, index the bluetooth interface so we can index the SQL interface!", 2, new DateTime(2020, 2, 19, 6, 51, 48, 187, DateTimeKind.Local).AddTicks(7558), new DateTime(2020, 2, 20, 22, 4, 44, 584, DateTimeKind.Local).AddTicks(940), 1 },
                    { 33, 1, "I'll connect the bluetooth SMS driver, that should driver the SMS driver!", 1, "I'll program the neural TCP matrix, that should matrix the TCP matrix!", 2, new DateTime(2020, 2, 19, 4, 48, 8, 243, DateTimeKind.Local).AddTicks(2188), new DateTime(2020, 2, 19, 3, 21, 16, 174, DateTimeKind.Local).AddTicks(3644), 2 },
                    { 34, 2, "hacking the matrix won't do anything, we need to bypass the haptic COM matrix!", 4, null, 1, new DateTime(2020, 2, 16, 22, 11, 3, 571, DateTimeKind.Local).AddTicks(3241), new DateTime(2020, 2, 20, 10, 17, 12, 314, DateTimeKind.Local).AddTicks(6680), 1 },
                    { 35, 6, "Try to generate the HTTP protocol, maybe it will generate the auxiliary protocol!", 4, "You can't generate the transmitter without quantifying the neural ADP transmitter!", 2, new DateTime(2020, 2, 18, 11, 44, 17, 323, DateTimeKind.Local).AddTicks(3114), new DateTime(2020, 2, 19, 18, 25, 20, 818, DateTimeKind.Local).AddTicks(3500), 1 },
                    { 36, 3, "We need to synthesize the 1080p COM capacitor!", 4, "You can't program the driver without generating the 1080p USB driver!", 2, new DateTime(2020, 2, 17, 19, 44, 53, 761, DateTimeKind.Local).AddTicks(1725), new DateTime(2020, 2, 20, 18, 40, 11, 289, DateTimeKind.Local).AddTicks(4521), 2 },
                    { 37, 2, "generating the protocol won't do anything, we need to hack the digital AI protocol!", 3, null, 1, new DateTime(2020, 2, 15, 16, 40, 6, 20, DateTimeKind.Local).AddTicks(8033), new DateTime(2020, 2, 19, 2, 4, 26, 358, DateTimeKind.Local).AddTicks(6646), 1 },
                    { 38, 5, "calculating the system won't do anything, we need to transmit the wireless RAM system!", 2, "copying the protocol won't do anything, we need to copy the back-end EXE protocol!", 2, new DateTime(2020, 2, 19, 14, 54, 26, 669, DateTimeKind.Local).AddTicks(4360), new DateTime(2020, 2, 20, 6, 21, 25, 394, DateTimeKind.Local).AddTicks(2172), 1 },
                    { 39, 3, "copying the capacitor won't do anything, we need to back up the optical SMS capacitor!", 4, "generating the array won't do anything, we need to transmit the online THX array!", 2, new DateTime(2020, 2, 20, 22, 18, 26, 641, DateTimeKind.Local).AddTicks(9216), new DateTime(2020, 2, 19, 17, 4, 40, 712, DateTimeKind.Local).AddTicks(2823), 2 },
                    { 40, 4, "We need to override the 1080p JSON interface!", 4, null, 1, new DateTime(2020, 2, 15, 4, 16, 21, 630, DateTimeKind.Local).AddTicks(9579), new DateTime(2020, 2, 19, 4, 56, 14, 528, DateTimeKind.Local).AddTicks(9040), 1 },
                    { 41, 3, "The XML panel is down, connect the back-end panel so we can connect the XML panel!", 4, "You can't transmit the bus without quantifying the digital AI bus!", 2, new DateTime(2020, 2, 15, 6, 42, 19, 718, DateTimeKind.Local).AddTicks(1663), new DateTime(2020, 2, 20, 10, 8, 36, 210, DateTimeKind.Local).AddTicks(3663), 2 },
                    { 42, 2, "connecting the application won't do anything, we need to bypass the mobile ADP application!", 2, null, 1, new DateTime(2020, 2, 18, 10, 6, 0, 958, DateTimeKind.Local).AddTicks(9608), new DateTime(2020, 2, 19, 15, 47, 59, 217, DateTimeKind.Local).AddTicks(9064), 1 },
                    { 43, 3, "The JBOD circuit is down, program the neural circuit so we can program the JBOD circuit!", 4, "The SCSI circuit is down, index the open-source circuit so we can index the SCSI circuit!", 2, new DateTime(2020, 2, 16, 22, 46, 2, 182, DateTimeKind.Local).AddTicks(146), new DateTime(2020, 2, 20, 2, 32, 23, 525, DateTimeKind.Local).AddTicks(526), 2 },
                    { 44, 1, "If we navigate the bandwidth, we can get to the RSS bandwidth through the back-end RSS bandwidth!", 3, "Try to hack the GB program, maybe it will hack the 1080p program!", 2, new DateTime(2020, 2, 17, 0, 33, 0, 273, DateTimeKind.Local).AddTicks(278), new DateTime(2020, 2, 20, 14, 55, 36, 595, DateTimeKind.Local).AddTicks(4619), 2 },
                    { 45, 5, "If we connect the feed, we can get to the SDD feed through the virtual SDD feed!", 1, "You can't compress the bus without connecting the haptic SMS bus!", 2, new DateTime(2020, 2, 14, 1, 7, 7, 660, DateTimeKind.Local).AddTicks(5327), new DateTime(2020, 2, 19, 4, 58, 19, 705, DateTimeKind.Local).AddTicks(3537), 4 },
                    { 46, 3, "Try to input the XSS capacitor, maybe it will input the optical capacitor!", 1, null, 1, new DateTime(2020, 2, 16, 17, 7, 49, 641, DateTimeKind.Local).AddTicks(3400), new DateTime(2020, 2, 20, 17, 7, 56, 275, DateTimeKind.Local).AddTicks(3020), 4 },
                    { 47, 4, "The JSON capacitor is down, connect the haptic capacitor so we can connect the JSON capacitor!", 1, null, 1, new DateTime(2020, 2, 14, 9, 10, 16, 876, DateTimeKind.Local).AddTicks(9337), new DateTime(2020, 2, 20, 18, 5, 35, 306, DateTimeKind.Local).AddTicks(2378), 3 },
                    { 48, 5, "indexing the capacitor won't do anything, we need to copy the virtual USB capacitor!", 4, "The JBOD sensor is down, back up the digital sensor so we can back up the JBOD sensor!", 2, new DateTime(2020, 2, 18, 15, 44, 49, 662, DateTimeKind.Local).AddTicks(4153), new DateTime(2020, 2, 20, 2, 42, 55, 714, DateTimeKind.Local).AddTicks(4037), 2 },
                    { 27, 3, "I'll reboot the auxiliary PCI interface, that should interface the PCI interface!", 1, null, 1, new DateTime(2020, 2, 16, 9, 8, 25, 743, DateTimeKind.Local).AddTicks(2389), new DateTime(2020, 2, 20, 20, 35, 36, 598, DateTimeKind.Local).AddTicks(4779), 2 },
                    { 26, 2, "You can't override the capacitor without connecting the cross-platform JSON capacitor!", 3, "I'll parse the primary CSS sensor, that should sensor the CSS sensor!", 2, new DateTime(2020, 2, 20, 0, 54, 12, 226, DateTimeKind.Local).AddTicks(7672), new DateTime(2020, 2, 20, 1, 57, 45, 972, DateTimeKind.Local).AddTicks(4890), 1 },
                    { 25, 2, "transmitting the matrix won't do anything, we need to bypass the multi-byte JBOD matrix!", 2, null, 1, new DateTime(2020, 2, 17, 12, 45, 10, 675, DateTimeKind.Local).AddTicks(9447), new DateTime(2020, 2, 20, 16, 9, 51, 377, DateTimeKind.Local).AddTicks(5155), 6 },
                    { 24, 3, "We need to calculate the primary IB application!", 4, null, 1, new DateTime(2020, 2, 17, 1, 46, 36, 712, DateTimeKind.Local).AddTicks(8908), new DateTime(2020, 2, 20, 2, 52, 7, 988, DateTimeKind.Local).AddTicks(94), 2 },
                    { 2, 2, "Use the bluetooth SCSI alarm, then you can navigate the bluetooth alarm!", 3, "We need to connect the mobile TCP bandwidth!", 2, new DateTime(2020, 2, 16, 4, 51, 34, 257, DateTimeKind.Local).AddTicks(2724), new DateTime(2020, 2, 19, 23, 45, 50, 659, DateTimeKind.Local).AddTicks(9666), 1 },
                    { 3, 3, "Use the solid state XSS firewall, then you can reboot the solid state firewall!", 1, null, 1, new DateTime(2020, 2, 20, 14, 23, 54, 764, DateTimeKind.Local).AddTicks(4097), new DateTime(2020, 2, 20, 5, 57, 6, 276, DateTimeKind.Local).AddTicks(7088), 1 },
                    { 4, 2, "You can't calculate the interface without bypassing the virtual AGP interface!", 2, null, 1, new DateTime(2020, 2, 15, 17, 13, 53, 250, DateTimeKind.Local).AddTicks(8102), new DateTime(2020, 2, 20, 3, 43, 3, 786, DateTimeKind.Local).AddTicks(8443), 5 },
                    { 5, 2, "Use the multi-byte HDD hard drive, then you can connect the multi-byte hard drive!", 2, null, 1, new DateTime(2020, 2, 15, 5, 32, 19, 900, DateTimeKind.Local).AddTicks(4807), new DateTime(2020, 2, 20, 11, 17, 3, 972, DateTimeKind.Local).AddTicks(8904), 1 },
                    { 6, 2, "Use the cross-platform CSS capacitor, then you can copy the cross-platform capacitor!", 1, null, 1, new DateTime(2020, 2, 14, 1, 25, 47, 78, DateTimeKind.Local).AddTicks(3312), new DateTime(2020, 2, 19, 11, 51, 9, 381, DateTimeKind.Local).AddTicks(8473), 3 },
                    { 7, 2, "We need to back up the neural RAM monitor!", 1, "Try to parse the FTP transmitter, maybe it will parse the back-end transmitter!", 2, new DateTime(2020, 2, 20, 22, 42, 24, 98, DateTimeKind.Local).AddTicks(331), new DateTime(2020, 2, 19, 6, 9, 27, 337, DateTimeKind.Local).AddTicks(3477), 3 },
                    { 8, 5, "We need to override the open-source XSS firewall!", 2, "Try to bypass the SMTP bandwidth, maybe it will bypass the primary bandwidth!", 2, new DateTime(2020, 2, 19, 3, 39, 52, 993, DateTimeKind.Local).AddTicks(3557), new DateTime(2020, 2, 20, 12, 23, 57, 234, DateTimeKind.Local).AddTicks(7652), 5 },
                    { 9, 4, "The SSL bandwidth is down, calculate the neural bandwidth so we can calculate the SSL bandwidth!", 4, "Use the cross-platform SCSI interface, then you can index the cross-platform interface!", 2, new DateTime(2020, 2, 16, 14, 16, 1, 596, DateTimeKind.Local).AddTicks(7774), new DateTime(2020, 2, 20, 2, 23, 8, 666, DateTimeKind.Local).AddTicks(3388), 2 },
                    { 10, 2, "Use the multi-byte COM feed, then you can back up the multi-byte feed!", 2, null, 1, new DateTime(2020, 2, 17, 23, 40, 18, 519, DateTimeKind.Local).AddTicks(7075), new DateTime(2020, 2, 20, 20, 42, 50, 774, DateTimeKind.Local).AddTicks(8825), 1 },
                    { 11, 2, "Try to back up the HDD microchip, maybe it will back up the optical microchip!", 4, null, 1, new DateTime(2020, 2, 15, 21, 53, 35, 709, DateTimeKind.Local).AddTicks(2999), new DateTime(2020, 2, 19, 8, 19, 36, 430, DateTimeKind.Local).AddTicks(7530), 2 },
                    { 49, 2, "navigating the circuit won't do anything, we need to parse the 1080p AGP circuit!", 4, "The JSON card is down, program the auxiliary card so we can program the JSON card!", 2, new DateTime(2020, 2, 19, 19, 14, 53, 289, DateTimeKind.Local).AddTicks(609), new DateTime(2020, 2, 20, 20, 59, 5, 374, DateTimeKind.Local).AddTicks(7668), 2 },
                    { 12, 5, "quantifying the port won't do anything, we need to reboot the virtual SCSI port!", 2, "Use the multi-byte JSON panel, then you can bypass the multi-byte panel!", 2, new DateTime(2020, 2, 14, 2, 43, 13, 328, DateTimeKind.Local).AddTicks(4772), new DateTime(2020, 2, 19, 15, 6, 11, 55, DateTimeKind.Local).AddTicks(4054), 6 },
                    { 14, 4, "The FTP sensor is down, transmit the cross-platform sensor so we can transmit the FTP sensor!", 1, "We need to hack the online SAS firewall!", 2, new DateTime(2020, 2, 15, 6, 18, 17, 267, DateTimeKind.Local).AddTicks(4577), new DateTime(2020, 2, 19, 9, 0, 3, 9, DateTimeKind.Local).AddTicks(4676), 4 },
                    { 15, 4, "Use the neural SSL bandwidth, then you can hack the neural bandwidth!", 2, null, 1, new DateTime(2020, 2, 19, 21, 47, 26, 199, DateTimeKind.Local).AddTicks(6356), new DateTime(2020, 2, 20, 2, 10, 48, 939, DateTimeKind.Local).AddTicks(9198), 5 },
                    { 16, 3, "You can't reboot the protocol without synthesizing the digital JSON protocol!", 4, null, 1, new DateTime(2020, 2, 18, 11, 59, 53, 88, DateTimeKind.Local).AddTicks(459), new DateTime(2020, 2, 20, 14, 52, 7, 368, DateTimeKind.Local).AddTicks(7510), 1 },
                    { 17, 1, "Try to back up the USB matrix, maybe it will back up the multi-byte matrix!", 1, null, 1, new DateTime(2020, 2, 18, 12, 27, 29, 377, DateTimeKind.Local).AddTicks(793), new DateTime(2020, 2, 20, 11, 12, 32, 967, DateTimeKind.Local).AddTicks(6305), 1 },
                    { 18, 5, "I'll navigate the open-source SSL sensor, that should sensor the SSL sensor!", 4, null, 1, new DateTime(2020, 2, 18, 0, 32, 41, 309, DateTimeKind.Local).AddTicks(8357), new DateTime(2020, 2, 19, 18, 58, 0, 415, DateTimeKind.Local).AddTicks(3273), 2 },
                    { 19, 1, "I'll back up the multi-byte USB microchip, that should microchip the USB microchip!", 3, null, 1, new DateTime(2020, 2, 18, 16, 35, 34, 922, DateTimeKind.Local).AddTicks(6803), new DateTime(2020, 2, 19, 16, 21, 54, 249, DateTimeKind.Local).AddTicks(2001), 1 },
                    { 20, 5, "Use the digital XSS microchip, then you can connect the digital microchip!", 2, "Try to transmit the FTP transmitter, maybe it will transmit the online transmitter!", 2, new DateTime(2020, 2, 19, 14, 23, 11, 391, DateTimeKind.Local).AddTicks(9227), new DateTime(2020, 2, 20, 6, 26, 25, 888, DateTimeKind.Local).AddTicks(8502), 1 },
                    { 21, 4, "parsing the capacitor won't do anything, we need to compress the redundant HTTP capacitor!", 3, "You can't compress the application without transmitting the wireless RAM application!", 2, new DateTime(2020, 2, 15, 13, 52, 52, 411, DateTimeKind.Local).AddTicks(6168), new DateTime(2020, 2, 20, 14, 32, 56, 419, DateTimeKind.Local).AddTicks(5811), 5 },
                    { 22, 1, "We need to parse the mobile PCI capacitor!", 3, "We need to compress the solid state SQL driver!", 2, new DateTime(2020, 2, 16, 6, 19, 14, 991, DateTimeKind.Local).AddTicks(752), new DateTime(2020, 2, 19, 21, 56, 38, 29, DateTimeKind.Local).AddTicks(5896), 2 },
                    { 23, 4, "I'll bypass the mobile HDD application, that should application the HDD application!", 2, "overriding the capacitor won't do anything, we need to index the multi-byte XML capacitor!", 2, new DateTime(2020, 2, 15, 9, 52, 7, 329, DateTimeKind.Local).AddTicks(1371), new DateTime(2020, 2, 20, 15, 40, 22, 699, DateTimeKind.Local).AddTicks(1736), 5 },
                    { 13, 4, "You can't input the protocol without generating the back-end EXE protocol!", 4, "Use the auxiliary RAM alarm, then you can generate the auxiliary alarm!", 2, new DateTime(2020, 2, 19, 3, 35, 4, 659, DateTimeKind.Local).AddTicks(7639), new DateTime(2020, 2, 19, 22, 36, 4, 525, DateTimeKind.Local).AddTicks(5218), 1 },
                    { 50, 4, "You can't parse the system without copying the wireless THX system!", 2, null, 1, new DateTime(2020, 2, 16, 20, 22, 16, 866, DateTimeKind.Local).AddTicks(6191), new DateTime(2020, 2, 20, 14, 36, 30, 24, DateTimeKind.Local).AddTicks(3244), 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Issue",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
