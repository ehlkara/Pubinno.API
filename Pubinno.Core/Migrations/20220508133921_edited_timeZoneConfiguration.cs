using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pubinno.Core.Migrations
{
    public partial class edited_timeZoneConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TimeZone",
                table: "TimeZone");

            migrationBuilder.RenameTable(
                name: "TimeZone",
                newName: "TimeZoneName");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "TimeZoneName",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimeZoneName",
                table: "TimeZoneName",
                column: "Id");

            migrationBuilder.InsertData(
                table: "TimeZoneName",
                columns: new[] { "Id", "CreatedTime", "DeletedTime", "IsActive", "IsDelete", "UpdatedTime", "ZoneName" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5369), null, true, false, null, "Australia/Sydney" },
                    { 392, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6876), null, true, false, null, "Etc/GMT+11" },
                    { 393, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6878), null, true, false, null, "Pacific/Pago_Pago" },
                    { 394, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6881), null, true, false, null, "Pacific/Niue" },
                    { 395, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6883), null, true, false, null, "Pacific/Midway" },
                    { 396, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6886), null, true, false, null, "Asia/Ulaanbaatar" },
                    { 397, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6889), null, true, false, null, "Asia/Choibalsan" },
                    { 391, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6873), null, true, false, null, "Pacific/Gambier" },
                    { 398, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6891), null, true, false, null, "America/Caracas" },
                    { 400, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6896), null, true, false, null, "Asia/Ust-Nera" },
                    { 401, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6899), null, true, false, null, "Europe/Volgograd" },
                    { 402, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6902), null, true, false, null, "Australia/Perth" },
                    { 403, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6904), null, true, false, null, "Africa/Lagos" },
                    { 404, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6907), null, true, false, null, "Africa/Luanda" },
                    { 405, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6909), null, true, false, null, "Africa/Porto-Novo" },
                    { 399, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6894), null, true, false, null, "Asia/Vladivostok" },
                    { 390, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6870), null, true, false, null, "Etc/GMT+9" },
                    { 389, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6868), null, true, false, null, "Pacific/Pitcairn" },
                    { 388, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6865), null, true, false, null, "Etc/GMT+8" },
                    { 373, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6826), null, true, false, null, "Pacific/Tarawa" },
                    { 374, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6829), null, true, false, null, "Pacific/Majuro" },
                    { 375, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6831), null, true, false, null, "Pacific/Kwajalein" },
                    { 376, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6834), null, true, false, null, "Pacific/Nauru" },
                    { 377, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6836), null, true, false, null, "Pacific/Funafuti" },
                    { 378, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6839), null, true, false, null, "Pacific/Wake" },
                    { 379, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6842), null, true, false, null, "Pacific/Wallis" },
                    { 380, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6844), null, true, false, null, "Etc/GMT-13" },
                    { 381, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6847), null, true, false, null, "Pacific/Enderbury" },
                    { 382, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6849), null, true, false, null, "Pacific/Fakaofo" },
                    { 383, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6852), null, true, false, null, "Etc/UTC" },
                    { 384, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6855), null, true, false, null, "Etc/GMT" },
                    { 385, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6857), null, true, false, null, "Etc/GMT+2" },
                    { 386, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6860), null, true, false, null, "America/Noronha" },
                    { 387, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6862), null, true, false, null, "Atlantic/South_Georgia" },
                    { 406, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6912), null, true, false, null, "Africa/Kinshasa" },
                    { 372, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6823), null, true, false, null, "Etc/GMT-12" },
                    { 407, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6915), null, true, false, null, "Africa/Bangui" },
                    { 409, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6920), null, true, false, null, "Africa/Douala" },
                    { 429, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6972), null, true, false, null, "Europe/Oslo" },
                    { 430, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6975), null, true, false, null, "Europe/Stockholm" },
                    { 431, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6977), null, true, false, null, "Arctic/Longyearbyen" },
                    { 432, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6980), null, true, false, null, "Europe/San_Marino" }
                });

            migrationBuilder.InsertData(
                table: "TimeZoneName",
                columns: new[] { "Id", "CreatedTime", "DeletedTime", "IsActive", "IsDelete", "UpdatedTime", "ZoneName" },
                values: new object[,]
                {
                    { 433, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6983), null, true, false, null, "Europe/Vatican" },
                    { 434, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6985), null, true, false, null, "Asia/Hovd" },
                    { 428, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6969), null, true, false, null, "Europe/Amsterdam" },
                    { 435, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6988), null, true, false, null, "Asia/Tashkent" },
                    { 437, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7030), null, true, false, null, "Asia/Oral" },
                    { 438, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7033), null, true, false, null, "Asia/Aqtau" },
                    { 439, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7035), null, true, false, null, "Asia/Aqtobe" },
                    { 440, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7038), null, true, false, null, "Asia/Atyrau" },
                    { 441, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7040), null, true, false, null, "Indian/Maldives" },
                    { 442, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7043), null, true, false, null, "Indian/Kerguelen" },
                    { 436, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6990), null, true, false, null, "Antarctica/Mawson" },
                    { 427, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6967), null, true, false, null, "Europe/Malta" },
                    { 426, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6964), null, true, false, null, "Europe/Monaco" },
                    { 425, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6962), null, true, false, null, "Europe/Luxembourg" },
                    { 410, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6923), null, true, false, null, "Africa/Algiers" },
                    { 411, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6925), null, true, false, null, "Africa/Libreville" },
                    { 412, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6928), null, true, false, null, "Africa/Malabo" },
                    { 413, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6930), null, true, false, null, "Africa/Niamey" },
                    { 414, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6933), null, true, false, null, "Africa/Ndjamena" },
                    { 415, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6936), null, true, false, null, "Africa/Tunis" },
                    { 416, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6938), null, true, false, null, "Etc/GMT-1" },
                    { 417, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6941), null, true, false, null, "Europe/Berlin" },
                    { 418, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6943), null, true, false, null, "Europe/Andorra" },
                    { 419, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6946), null, true, false, null, "Europe/Vienna" },
                    { 420, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6949), null, true, false, null, "Europe/Zurich" },
                    { 421, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6951), null, true, false, null, "Europe/Busingen" },
                    { 422, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6954), null, true, false, null, "Europe/Gibraltar" },
                    { 423, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6956), null, true, false, null, "Europe/Rome" },
                    { 424, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6959), null, true, false, null, "Europe/Vaduz" },
                    { 408, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6917), null, true, false, null, "Africa/Brazzaville" },
                    { 443, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7046), null, true, false, null, "Asia/Dushanbe" },
                    { 371, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6821), null, true, false, null, "Etc/GMT+7" },
                    { 369, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6816), null, true, false, null, "America/Fort_Nelson" },
                    { 318, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6646), null, true, false, null, "Asia/Saigon" },
                    { 319, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6649), null, true, false, null, "Etc/GMT-7" },
                    { 320, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6652), null, true, false, null, "America/Miquelon" },
                    { 321, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6654), null, true, false, null, "Asia/Sakhalin" },
                    { 322, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6657), null, true, false, null, "Pacific/Apia" },
                    { 323, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6660), null, true, false, null, "Africa/Sao_Tome" },
                    { 317, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6644), null, true, false, null, "Asia/Vientiane" },
                    { 324, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6662), null, true, false, null, "Europe/Saratov" },
                    { 326, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6667), null, true, false, null, "Asia/Brunei" }
                });

            migrationBuilder.InsertData(
                table: "TimeZoneName",
                columns: new[] { "Id", "CreatedTime", "DeletedTime", "IsActive", "IsDelete", "UpdatedTime", "ZoneName" },
                values: new object[,]
                {
                    { 327, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6670), null, true, false, null, "Asia/Makassar" },
                    { 328, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6673), null, true, false, null, "Asia/Kuala_Lumpur" },
                    { 329, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6675), null, true, false, null, "Asia/Kuching" },
                    { 330, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6678), null, true, false, null, "Asia/Manila" },
                    { 331, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6680), null, true, false, null, "Etc/GMT-8" },
                    { 325, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6665), null, true, false, null, "Asia/Singapore" },
                    { 316, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6641), null, true, false, null, "Asia/Phnom_Penh" },
                    { 315, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6639), null, true, false, null, "Asia/Pontianak" },
                    { 314, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6636), null, true, false, null, "Asia/Jakarta" },
                    { 299, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6597), null, true, false, null, "America/St_Kitts" },
                    { 300, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6599), null, true, false, null, "America/St_Lucia" },
                    { 301, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6602), null, true, false, null, "America/Marigot" },
                    { 302, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6605), null, true, false, null, "America/Martinique" },
                    { 303, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6607), null, true, false, null, "America/Montserrat" },
                    { 304, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6610), null, true, false, null, "America/Puerto_Rico" },
                    { 305, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6613), null, true, false, null, "America/Lower_Princes" },
                    { 306, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6615), null, true, false, null, "America/Port_of_Spain" },
                    { 307, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6618), null, true, false, null, "America/St_Vincent" },
                    { 308, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6620), null, true, false, null, "America/Tortola" },
                    { 309, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6623), null, true, false, null, "America/St_Thomas" },
                    { 310, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6626), null, true, false, null, "Etc/GMT+4" },
                    { 311, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6628), null, true, false, null, "Asia/Bangkok" },
                    { 312, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6631), null, true, false, null, "Antarctica/Davis" },
                    { 313, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6633), null, true, false, null, "Indian/Christmas" },
                    { 332, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6683), null, true, false, null, "Africa/Johannesburg" },
                    { 370, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6818), null, true, false, null, "America/Hermosillo" },
                    { 333, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6686), null, true, false, null, "Africa/Bujumbura" },
                    { 335, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6691), null, true, false, null, "Africa/Lubumbashi" },
                    { 355, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6779), null, true, false, null, "Pacific/Palau" },
                    { 356, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6781), null, true, false, null, "Asia/Dili" },
                    { 357, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6784), null, true, false, null, "Etc/GMT-9" },
                    { 358, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6787), null, true, false, null, "Asia/Tomsk" },
                    { 359, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6789), null, true, false, null, "Pacific/Tongatapu" },
                    { 360, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6792), null, true, false, null, "Asia/Chita" },
                    { 354, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6776), null, true, false, null, "Asia/Jayapura" },
                    { 361, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6795), null, true, false, null, "Europe/Istanbul" },
                    { 363, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6800), null, true, false, null, "America/Indianapolis" },
                    { 364, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6802), null, true, false, null, "America/Indiana/Marengo" },
                    { 365, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6805), null, true, false, null, "America/Indiana/Vevay" },
                    { 366, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6808), null, true, false, null, "America/Phoenix" },
                    { 367, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6810), null, true, false, null, "America/Creston" },
                    { 368, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6813), null, true, false, null, "America/Dawson_Creek" }
                });

            migrationBuilder.InsertData(
                table: "TimeZoneName",
                columns: new[] { "Id", "CreatedTime", "DeletedTime", "IsActive", "IsDelete", "UpdatedTime", "ZoneName" },
                values: new object[,]
                {
                    { 362, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6797), null, true, false, null, "America/Grand_Turk" },
                    { 353, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6774), null, true, false, null, "Asia/Tokyo" },
                    { 352, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6771), null, true, false, null, "America/Araguaina" },
                    { 351, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6768), null, true, false, null, "Antarctica/Macquarie" },
                    { 336, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6693), null, true, false, null, "Africa/Maseru" },
                    { 337, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6696), null, true, false, null, "Africa/Blantyre" },
                    { 338, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6699), null, true, false, null, "Africa/Maputo" },
                    { 339, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6701), null, true, false, null, "Africa/Kigali" },
                    { 340, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6704), null, true, false, null, "Africa/Mbabane" },
                    { 341, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6706), null, true, false, null, "Africa/Lusaka" },
                    { 342, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6709), null, true, false, null, "Africa/Harare" },
                    { 343, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6712), null, true, false, null, "Etc/GMT-2" },
                    { 344, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6714), null, true, false, null, "Africa/Juba" },
                    { 345, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6753), null, true, false, null, "Asia/Colombo" },
                    { 346, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6755), null, true, false, null, "Africa/Khartoum" },
                    { 347, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6758), null, true, false, null, "Asia/Damascus" },
                    { 348, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6761), null, true, false, null, "Asia/Taipei" },
                    { 349, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6763), null, true, false, null, "Australia/Hobart" },
                    { 350, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6766), null, true, false, null, "Australia/Currie" },
                    { 334, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6688), null, true, false, null, "Africa/Gaborone" },
                    { 298, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6594), null, true, false, null, "America/Guyana" },
                    { 444, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7048), null, true, false, null, "Asia/Ashgabat" },
                    { 446, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7053), null, true, false, null, "Etc/GMT-5" },
                    { 540, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7375), null, true, false, null, "Australia/Tasmania" },
                    { 541, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7377), null, true, false, null, "Australia/LHI" },
                    { 542, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7380), null, true, false, null, "Australia/Victoria" },
                    { 543, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7382), null, true, false, null, "Australia/West" },
                    { 544, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7385), null, true, false, null, "Australia/ACT" },
                    { 545, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7388), null, true, false, null, "Australia/Canberra" },
                    { 539, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7372), null, true, false, null, "Australia/North" },
                    { 546, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7393), null, true, false, null, "Australia/NSW" },
                    { 548, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7398), null, true, false, null, "EST" },
                    { 549, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7400), null, true, false, null, "MST" },
                    { 550, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7403), null, true, false, null, "Etc/GMT+0" },
                    { 551, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7406), null, true, false, null, "Etc/GMT-0" },
                    { 552, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7408), null, true, false, null, "Etc/GMT0" },
                    { 553, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7411), null, true, false, null, "Etc/Greenwich" },
                    { 547, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7395), null, true, false, null, "HST" },
                    { 538, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7369), null, true, false, null, "Australia/Yancowinna" },
                    { 537, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7367), null, true, false, null, "Australia/Queensland" },
                    { 536, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7364), null, true, false, null, "Australia/South" },
                    { 521, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7298), null, true, false, null, "Asia/Chongqing" }
                });

            migrationBuilder.InsertData(
                table: "TimeZoneName",
                columns: new[] { "Id", "CreatedTime", "DeletedTime", "IsActive", "IsDelete", "UpdatedTime", "ZoneName" },
                values: new object[,]
                {
                    { 522, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7300), null, true, false, null, "Asia/Chungking" },
                    { 523, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7303), null, true, false, null, "Asia/Harbin" },
                    { 524, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7306), null, true, false, null, "PRC" },
                    { 525, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7308), null, true, false, null, "Singapore" },
                    { 526, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7311), null, true, false, null, "ROC" },
                    { 527, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7313), null, true, false, null, "Iran" },
                    { 528, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7316), null, true, false, null, "Asia/Thimbu" },
                    { 529, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7319), null, true, false, null, "Japan" },
                    { 530, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7349), null, true, false, null, "Asia/Ulan_Bator" },
                    { 531, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7351), null, true, false, null, "Asia/Kashgar" },
                    { 532, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7354), null, true, false, null, "Asia/Yangon" },
                    { 533, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7356), null, true, false, null, "WET" },
                    { 534, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7359), null, true, false, null, "Atlantic/Faroe" },
                    { 535, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7362), null, true, false, null, "Iceland" },
                    { 554, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7413), null, true, false, null, "GMT" },
                    { 520, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7295), null, true, false, null, "ROK" },
                    { 555, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7416), null, true, false, null, "GMT+0" },
                    { 557, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7421), null, true, false, null, "GMT0" },
                    { 577, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7474), null, true, false, null, "Atlantic/Jan_Mayen" },
                    { 578, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7476), null, true, false, null, "CET" },
                    { 579, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7479), null, true, false, null, "Poland" },
                    { 580, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7481), null, true, false, null, "Antarctica/South_Pole" },
                    { 581, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7484), null, true, false, null, "NZ" },
                    { 582, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7487), null, true, false, null, "NZ-CHAT" },
                    { 576, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7471), null, true, false, null, "W-SU" },
                    { 583, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7489), null, true, false, null, "Pacific/Chuuk" },
                    { 585, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7494), null, true, false, null, "Chile/EasterIsland" },
                    { 586, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7497), null, true, false, null, "US/Hawaii" },
                    { 587, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7500), null, true, false, null, "Pacific/Kanton" },
                    { 588, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7502), null, true, false, null, "Kwajalein" },
                    { 589, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7505), null, true, false, null, "Pacific/Samoa" },
                    { 590, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7507), null, true, false, null, "US/Samoa" },
                    { 584, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7492), null, true, false, null, "Pacific/Yap" },
                    { 575, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7468), null, true, false, null, "GB-Eire" },
                    { 574, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7466), null, true, false, null, "GB" },
                    { 573, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7463), null, true, false, null, "Europe/Belfast" },
                    { 558, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7424), null, true, false, null, "Greenwich" },
                    { 559, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7426), null, true, false, null, "Etc/UCT" },
                    { 560, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7429), null, true, false, null, "Etc/Universal" },
                    { 561, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7432), null, true, false, null, "Etc/Zulu" },
                    { 562, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7434), null, true, false, null, "UCT" },
                    { 563, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7437), null, true, false, null, "UTC" }
                });

            migrationBuilder.InsertData(
                table: "TimeZoneName",
                columns: new[] { "Id", "CreatedTime", "DeletedTime", "IsActive", "IsDelete", "UpdatedTime", "ZoneName" },
                values: new object[,]
                {
                    { 564, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7439), null, true, false, null, "Universal" },
                    { 565, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7442), null, true, false, null, "Zulu" },
                    { 566, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7445), null, true, false, null, "MET" },
                    { 567, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7447), null, true, false, null, "EET" },
                    { 568, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7450), null, true, false, null, "Europe/Tiraspol" },
                    { 569, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7453), null, true, false, null, "Eire" },
                    { 570, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7455), null, true, false, null, "Asia/Istanbul" },
                    { 571, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7458), null, true, false, null, "Turkey" },
                    { 572, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7460), null, true, false, null, "Portugal" },
                    { 556, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7419), null, true, false, null, "GMT-0" },
                    { 445, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7051), null, true, false, null, "Asia/Samarkand" },
                    { 519, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7293), null, true, false, null, "Europe/Nicosia" },
                    { 517, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7287), null, true, false, null, "Asia/Macao" },
                    { 466, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7106), null, true, false, null, "America/Argentina/Buenos_Aires" },
                    { 467, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7108), null, true, false, null, "America/Argentina/Catamarca" },
                    { 468, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7111), null, true, false, null, "America/Argentina/ComodRivadavia" },
                    { 469, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7113), null, true, false, null, "America/Argentina/Cordoba" },
                    { 470, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7116), null, true, false, null, "America/Rosario" },
                    { 471, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7119), null, true, false, null, "America/Argentina/Jujuy" },
                    { 465, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7103), null, true, false, null, "US/Alaska" },
                    { 472, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7121), null, true, false, null, "America/Argentina/Mendoza" },
                    { 474, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7126), null, true, false, null, "America/Shiprock" },
                    { 475, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7129), null, true, false, null, "Navajo" },
                    { 476, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7132), null, true, false, null, "US/Mountain" },
                    { 477, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7134), null, true, false, null, "US/Michigan" },
                    { 478, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7137), null, true, false, null, "Canada/Mountain" },
                    { 479, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7139), null, true, false, null, "Canada/Atlantic" },
                    { 473, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7124), null, true, false, null, "US/Central" },
                    { 464, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7100), null, true, false, null, "US/Aleutian" },
                    { 463, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7098), null, true, false, null, "America/Atka" },
                    { 462, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7095), null, true, false, null, "Libya" },
                    { 447, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7056), null, true, false, null, "Asia/Hebron" },
                    { 448, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7059), null, true, false, null, "Asia/Gaza" },
                    { 449, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7061), null, true, false, null, "Pacific/Port_Moresby" },
                    { 450, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7064), null, true, false, null, "Antarctica/DumontDUrville" },
                    { 451, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7066), null, true, false, null, "Pacific/Truk" },
                    { 452, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7069), null, true, false, null, "Pacific/Guam" },
                    { 453, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7072), null, true, false, null, "Pacific/Saipan" },
                    { 454, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7074), null, true, false, null, "Etc/GMT-10" },
                    { 455, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7077), null, true, false, null, "Asia/Yakutsk" },
                    { 456, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7080), null, true, false, null, "Asia/Khandyga" },
                    { 457, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7082), null, true, false, null, "America/Whitehorse" }
                });

            migrationBuilder.InsertData(
                table: "TimeZoneName",
                columns: new[] { "Id", "CreatedTime", "DeletedTime", "IsActive", "IsDelete", "UpdatedTime", "ZoneName" },
                values: new object[,]
                {
                    { 458, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7085), null, true, false, null, "America/Dawson" },
                    { 459, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7087), null, true, false, null, "Africa/Timbuktu" },
                    { 460, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7090), null, true, false, null, "Egypt" },
                    { 461, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7093), null, true, false, null, "Africa/Asmara" },
                    { 480, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7142), null, true, false, null, "Cuba" },
                    { 518, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7290), null, true, false, null, "Asia/Ujung_Pandang" },
                    { 481, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7145), null, true, false, null, "America/Indiana/Indianapolis" },
                    { 483, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7150), null, true, false, null, "America/Knox_IN" },
                    { 503, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7202), null, true, false, null, "America/Ensenada" },
                    { 504, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7205), null, true, false, null, "Mexico/BajaNorte" },
                    { 505, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7207), null, true, false, null, "Canada/Eastern" },
                    { 506, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7210), null, true, false, null, "Canada/Pacific" },
                    { 507, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7212), null, true, false, null, "Canada/Yukon" },
                    { 508, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7215), null, true, false, null, "Canada/Central" },
                    { 502, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7199), null, true, false, null, "Canada/Newfoundland" },
                    { 509, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7218), null, true, false, null, "Asia/Ashkhabad" },
                    { 511, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7223), null, true, false, null, "Asia/Ho_Chi_Minh" },
                    { 512, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7226), null, true, false, null, "Hongkong" },
                    { 513, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7228), null, true, false, null, "Asia/Tel_Aviv" },
                    { 514, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7279), null, true, false, null, "Israel" },
                    { 515, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7282), null, true, false, null, "Asia/Kathmandu" },
                    { 516, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7285), null, true, false, null, "Asia/Kolkata" },
                    { 510, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7220), null, true, false, null, "Asia/Dacca" },
                    { 501, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7197), null, true, false, null, "Brazil/East" },
                    { 500, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7194), null, true, false, null, "Chile/Continental" },
                    { 499, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7192), null, true, false, null, "Brazil/Acre" },
                    { 484, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7153), null, true, false, null, "US/Indiana-Starke" },
                    { 485, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7155), null, true, false, null, "Jamaica" },
                    { 486, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7158), null, true, false, null, "America/Kentucky/Louisville" },
                    { 487, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7160), null, true, false, null, "US/Pacific" },
                    { 488, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7163), null, true, false, null, "Brazil/West" },
                    { 489, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7166), null, true, false, null, "Mexico/BajaSur" },
                    { 490, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7168), null, true, false, null, "Mexico/General" },
                    { 491, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7171), null, true, false, null, "US/Eastern" },
                    { 492, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7173), null, true, false, null, "Brazil/DeNoronha" },
                    { 493, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7176), null, true, false, null, "America/Nuuk" },
                    { 494, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7179), null, true, false, null, "America/Atikokan" },
                    { 495, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7181), null, true, false, null, "US/Arizona" },
                    { 496, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7184), null, true, false, null, "America/Virgin" },
                    { 497, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7186), null, true, false, null, "Canada/Saskatchewan" },
                    { 498, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7189), null, true, false, null, "America/Porto_Acre" },
                    { 482, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7147), null, true, false, null, "US/East-Indiana" }
                });

            migrationBuilder.InsertData(
                table: "TimeZoneName",
                columns: new[] { "Id", "CreatedTime", "DeletedTime", "IsActive", "IsDelete", "UpdatedTime", "ZoneName" },
                values: new object[,]
                {
                    { 297, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6592), null, true, false, null, "America/Guadeloupe" },
                    { 296, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6589), null, true, false, null, "America/Grenada" },
                    { 295, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6586), null, true, false, null, "America/Santo_Domingo" },
                    { 95, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5946), null, true, false, null, "America/Monterrey" },
                    { 96, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5948), null, true, false, null, "America/Chicago" },
                    { 97, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5951), null, true, false, null, "America/Winnipeg" },
                    { 98, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5954), null, true, false, null, "America/Rainy_River" },
                    { 99, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5956), null, true, false, null, "America/Rankin_Inlet" },
                    { 100, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5959), null, true, false, null, "America/Resolute" },
                    { 94, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5943), null, true, false, null, "America/Merida" },
                    { 101, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5962), null, true, false, null, "America/Matamoros" },
                    { 103, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5967), null, true, false, null, "America/Indiana/Tell_City" },
                    { 104, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5969), null, true, false, null, "America/Menominee" },
                    { 105, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5972), null, true, false, null, "America/North_Dakota/Beulah" },
                    { 106, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5975), null, true, false, null, "America/North_Dakota/Center" },
                    { 107, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5977), null, true, false, null, "America/North_Dakota/New_Salem" },
                    { 108, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5980), null, true, false, null, "CST6CDT" },
                    { 102, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5964), null, true, false, null, "America/Indiana/Knox" },
                    { 93, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5941), null, true, false, null, "America/Bahia_Banderas" },
                    { 92, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5938), null, true, false, null, "America/Mexico_City" },
                    { 91, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5935), null, true, false, null, "Etc/GMT-11" },
                    { 76, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5896), null, true, false, null, "Europe/Prague" },
                    { 77, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5899), null, true, false, null, "Europe/Podgorica" },
                    { 78, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5901), null, true, false, null, "Europe/Belgrade" },
                    { 79, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5904), null, true, false, null, "Europe/Ljubljana" },
                    { 80, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5907), null, true, false, null, "Europe/Bratislava" },
                    { 81, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5909), null, true, false, null, "Europe/Warsaw" },
                    { 82, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5912), null, true, false, null, "Europe/Sarajevo" },
                    { 83, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5914), null, true, false, null, "Europe/Zagreb" },
                    { 84, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5917), null, true, false, null, "Europe/Skopje" },
                    { 85, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5920), null, true, false, null, "Pacific/Guadalcanal" },
                    { 86, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5922), null, true, false, null, "Antarctica/Casey" },
                    { 87, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5925), null, true, false, null, "Pacific/Ponape" },
                    { 88, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5928), null, true, false, null, "Pacific/Kosrae" },
                    { 89, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5930), null, true, false, null, "Pacific/Noumea" },
                    { 90, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5933), null, true, false, null, "Pacific/Efate" },
                    { 109, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5983), null, true, false, null, "Pacific/Chatham" },
                    { 75, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5893), null, true, false, null, "Europe/Tirane" },
                    { 110, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5985), null, true, false, null, "Asia/Shanghai" },
                    { 112, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5990), null, true, false, null, "Asia/Macau" },
                    { 132, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6083), null, true, false, null, "America/Cancun" },
                    { 133, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6086), null, true, false, null, "America/New_York" }
                });

            migrationBuilder.InsertData(
                table: "TimeZoneName",
                columns: new[] { "Id", "CreatedTime", "DeletedTime", "IsActive", "IsDelete", "UpdatedTime", "ZoneName" },
                values: new object[,]
                {
                    { 134, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6088), null, true, false, null, "America/Nassau" },
                    { 135, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6091), null, true, false, null, "America/Toronto" },
                    { 136, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6094), null, true, false, null, "America/Iqaluit" },
                    { 137, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6096), null, true, false, null, "America/Montreal" },
                    { 131, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6080), null, true, false, null, "Pacific/Easter" },
                    { 138, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6099), null, true, false, null, "America/Nipigon" },
                    { 140, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6104), null, true, false, null, "America/Thunder_Bay" },
                    { 141, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6107), null, true, false, null, "America/Detroit" },
                    { 142, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6109), null, true, false, null, "America/Indiana/Petersburg" },
                    { 143, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6112), null, true, false, null, "America/Indiana/Vincennes" },
                    { 144, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6115), null, true, false, null, "America/Indiana/Winamac" },
                    { 145, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6117), null, true, false, null, "America/Kentucky/Monticello" },
                    { 139, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6102), null, true, false, null, "America/Pangnirtung" },
                    { 130, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6078), null, true, false, null, "America/Sao_Paulo" },
                    { 129, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6035), null, true, false, null, "Europe/Chisinau" },
                    { 128, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6032), null, true, false, null, "Australia/Lindeman" },
                    { 113, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5993), null, true, false, null, "America/Havana" },
                    { 114, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5996), null, true, false, null, "Etc/GMT+12" },
                    { 115, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5998), null, true, false, null, "Africa/Nairobi" },
                    { 116, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6001), null, true, false, null, "Antarctica/Syowa" },
                    { 117, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6003), null, true, false, null, "Africa/Djibouti" },
                    { 118, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6006), null, true, false, null, "Africa/Asmera" },
                    { 119, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6009), null, true, false, null, "Africa/Addis_Ababa" },
                    { 120, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6011), null, true, false, null, "Indian/Comoro" },
                    { 121, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6014), null, true, false, null, "Indian/Antananarivo" },
                    { 122, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6016), null, true, false, null, "Africa/Mogadishu" },
                    { 123, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6019), null, true, false, null, "Africa/Dar_es_Salaam" },
                    { 124, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6022), null, true, false, null, "Africa/Kampala" },
                    { 125, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6024), null, true, false, null, "Indian/Mayotte" },
                    { 126, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6027), null, true, false, null, "Etc/GMT-3" },
                    { 127, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6030), null, true, false, null, "Australia/Brisbane" },
                    { 111, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5988), null, true, false, null, "Asia/Hong_Kong" },
                    { 146, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6120), null, true, false, null, "America/Louisville" },
                    { 74, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5891), null, true, false, null, "Europe/Budapest" },
                    { 72, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5886), null, true, false, null, "America/Cuiaba" },
                    { 21, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5558), null, true, false, null, "America/Buenos_Aires" },
                    { 22, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5560), null, true, false, null, "America/Argentina/La_Rioja" },
                    { 23, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5563), null, true, false, null, "America/Argentina/Rio_Gallegos" },
                    { 24, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5566), null, true, false, null, "America/Argentina/Salta" },
                    { 25, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5568), null, true, false, null, "America/Argentina/San_Juan" },
                    { 26, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5571), null, true, false, null, "America/Argentina/San_Luis" },
                    { 20, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5555), null, true, false, null, "Asia/Baghdad" }
                });

            migrationBuilder.InsertData(
                table: "TimeZoneName",
                columns: new[] { "Id", "CreatedTime", "DeletedTime", "IsActive", "IsDelete", "UpdatedTime", "ZoneName" },
                values: new object[,]
                {
                    { 27, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5573), null, true, false, null, "America/Argentina/Tucuman" },
                    { 29, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5579), null, true, false, null, "America/Catamarca" },
                    { 30, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5581), null, true, false, null, "America/Cordoba" },
                    { 31, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5584), null, true, false, null, "America/Jujuy" },
                    { 32, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5586), null, true, false, null, "America/Mendoza" },
                    { 33, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5589), null, true, false, null, "Europe/Astrakhan" },
                    { 34, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5593), null, true, false, null, "Europe/Ulyanovsk" },
                    { 28, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5576), null, true, false, null, "America/Argentina/Ushuaia" },
                    { 19, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5553), null, true, false, null, "Etc/GMT-4" },
                    { 18, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5550), null, true, false, null, "Asia/Muscat" },
                    { 17, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5546), null, true, false, null, "Asia/Dubai" },
                    { 2, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5492), null, true, false, null, "Australia/Melbourne" },
                    { 3, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5495), null, true, false, null, "Asia/Kabul" },
                    { 4, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5498), null, true, false, null, "America/Anchorage" },
                    { 5, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5501), null, true, false, null, "America/Juneau" },
                    { 6, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5516), null, true, false, null, "America/Metlakatla" },
                    { 7, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5519), null, true, false, null, "America/Nome" },
                    { 8, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5521), null, true, false, null, "America/Sitka" },
                    { 9, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5524), null, true, false, null, "America/Yakutat" },
                    { 10, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5527), null, true, false, null, "America/Adak" },
                    { 11, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5530), null, true, false, null, "Asia/Barnaul" },
                    { 12, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5532), null, true, false, null, "Asia/Riyadh" },
                    { 13, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5535), null, true, false, null, "Asia/Bahrain" },
                    { 14, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5538), null, true, false, null, "Asia/Kuwait" },
                    { 15, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5540), null, true, false, null, "Asia/Qatar" },
                    { 16, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5543), null, true, false, null, "Asia/Aden" },
                    { 35, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5596), null, true, false, null, "America/Halifax" },
                    { 73, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5888), null, true, false, null, "America/Campo_Grande" },
                    { 36, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5598), null, true, false, null, "Atlantic/Bermuda" },
                    { 38, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5603), null, true, false, null, "America/Goose_Bay" },
                    { 58, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5847), null, true, false, null, "America/Belize" },
                    { 59, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5850), null, true, false, null, "America/Costa_Rica" },
                    { 60, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5852), null, true, false, null, "Pacific/Galapagos" },
                    { 61, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5855), null, true, false, null, "America/Tegucigalpa" },
                    { 62, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5858), null, true, false, null, "America/Managua" },
                    { 63, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5860), null, true, false, null, "America/El_Salvador" },
                    { 57, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5844), null, true, false, null, "America/Guatemala" },
                    { 64, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5863), null, true, false, null, "Etc/GMT+6" },
                    { 66, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5870), null, true, false, null, "Antarctica/Vostok" },
                    { 67, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5873), null, true, false, null, "Asia/Urumqi" },
                    { 68, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5875), null, true, false, null, "Indian/Chagos" },
                    { 69, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5878), null, true, false, null, "Asia/Bishkek" }
                });

            migrationBuilder.InsertData(
                table: "TimeZoneName",
                columns: new[] { "Id", "CreatedTime", "DeletedTime", "IsActive", "IsDelete", "UpdatedTime", "ZoneName" },
                values: new object[,]
                {
                    { 70, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5880), null, true, false, null, "Asia/Qostanay" },
                    { 71, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5883), null, true, false, null, "Etc/GMT-6" },
                    { 65, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5865), null, true, false, null, "Asia/Almaty" },
                    { 56, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5841), null, true, false, null, "Australia/Broken_Hill" },
                    { 55, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5648), null, true, false, null, "Australia/Adelaide" },
                    { 54, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5645), null, true, false, null, "Asia/Yerevan" },
                    { 39, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5606), null, true, false, null, "America/Moncton" },
                    { 40, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5609), null, true, false, null, "America/Thule" },
                    { 41, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5611), null, true, false, null, "Australia/Eucla" },
                    { 42, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5614), null, true, false, null, "Asia/Baku" },
                    { 43, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5617), null, true, false, null, "Atlantic/Azores" },
                    { 44, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5619), null, true, false, null, "America/Scoresbysund" },
                    { 45, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5622), null, true, false, null, "America/Bahia" },
                    { 46, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5624), null, true, false, null, "Asia/Dhaka" },
                    { 47, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5627), null, true, false, null, "Asia/Thimphu" },
                    { 48, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5630), null, true, false, null, "Europe/Minsk" },
                    { 49, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5632), null, true, false, null, "Pacific/Bougainville" },
                    { 50, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5635), null, true, false, null, "America/Regina" },
                    { 51, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5638), null, true, false, null, "America/Swift_Current" },
                    { 52, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5640), null, true, false, null, "Atlantic/Cape_Verde" },
                    { 53, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5643), null, true, false, null, "Etc/GMT+1" },
                    { 37, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(5601), null, true, false, null, "America/Glace_Bay" },
                    { 147, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6122), null, true, false, null, "EST5EDT" },
                    { 148, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6125), null, true, false, null, "Africa/Cairo" },
                    { 149, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6128), null, true, false, null, "Asia/Yekaterinburg" },
                    { 244, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6416), null, true, false, null, "America/Vancouver" },
                    { 245, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6418), null, true, false, null, "PST8PDT" },
                    { 246, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6421), null, true, false, null, "Asia/Karachi" },
                    { 247, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6424), null, true, false, null, "America/Asuncion" },
                    { 248, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6426), null, true, false, null, "Asia/Qyzylorda" },
                    { 249, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6429), null, true, false, null, "Europe/Paris" },
                    { 243, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6413), null, true, false, null, "America/Los_Angeles" },
                    { 250, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6431), null, true, false, null, "Europe/Brussels" },
                    { 252, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6437), null, true, false, null, "Africa/Ceuta" },
                    { 253, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6439), null, true, false, null, "Europe/Madrid" },
                    { 254, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6442), null, true, false, null, "Asia/Srednekolymsk" },
                    { 255, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6445), null, true, false, null, "Asia/Kamchatka" },
                    { 256, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6447), null, true, false, null, "Asia/Anadyr" },
                    { 257, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6450), null, true, false, null, "Europe/Samara" },
                    { 251, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6434), null, true, false, null, "Europe/Copenhagen" },
                    { 242, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6411), null, true, false, null, "America/Santa_Isabel" },
                    { 241, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6408), null, true, false, null, "America/Tijuana" }
                });

            migrationBuilder.InsertData(
                table: "TimeZoneName",
                columns: new[] { "Id", "CreatedTime", "DeletedTime", "IsActive", "IsDelete", "UpdatedTime", "ZoneName" },
                values: new object[,]
                {
                    { 240, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6405), null, true, false, null, "America/Santiago" },
                    { 225, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6366), null, true, false, null, "MST7MDT" },
                    { 226, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6369), null, true, false, null, "Asia/Rangoon" },
                    { 227, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6371), null, true, false, null, "Indian/Cocos" },
                    { 228, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6374), null, true, false, null, "Asia/Novosibirsk" },
                    { 229, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6377), null, true, false, null, "Africa/Windhoek" },
                    { 230, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6379), null, true, false, null, "Asia/Katmandu" },
                    { 231, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6382), null, true, false, null, "Pacific/Auckland" },
                    { 232, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6384), null, true, false, null, "Antarctica/McMurdo" },
                    { 233, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6387), null, true, false, null, "America/St_Johns" },
                    { 234, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6390), null, true, false, null, "Pacific/Norfolk" },
                    { 235, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6392), null, true, false, null, "Asia/Irkutsk" },
                    { 236, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6395), null, true, false, null, "Asia/Krasnoyarsk" },
                    { 237, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6398), null, true, false, null, "Asia/Novokuznetsk" },
                    { 238, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6400), null, true, false, null, "Asia/Pyongyang" },
                    { 239, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6403), null, true, false, null, "Asia/Omsk" },
                    { 258, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6490), null, true, false, null, "Europe/Moscow" },
                    { 224, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6363), null, true, false, null, "America/Boise" },
                    { 259, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6492), null, true, false, null, "Europe/Kirov" },
                    { 261, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6498), null, true, false, null, "America/Cayenne" },
                    { 281, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6550), null, true, false, null, "Etc/GMT+5" },
                    { 282, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6553), null, true, false, null, "America/La_Paz" },
                    { 283, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6555), null, true, false, null, "America/Antigua" },
                    { 284, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6558), null, true, false, null, "America/Anguilla" },
                    { 285, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6560), null, true, false, null, "America/Aruba" },
                    { 286, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6563), null, true, false, null, "America/Barbados" },
                    { 280, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6547), null, true, false, null, "America/Lima" },
                    { 287, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6566), null, true, false, null, "America/St_Barthelemy" },
                    { 289, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6571), null, true, false, null, "America/Manaus" },
                    { 290, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6573), null, true, false, null, "America/Boa_Vista" },
                    { 291, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6576), null, true, false, null, "America/Porto_Velho" },
                    { 292, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6579), null, true, false, null, "America/Blanc-Sablon" },
                    { 293, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6581), null, true, false, null, "America/Curacao" },
                    { 294, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6584), null, true, false, null, "America/Dominica" },
                    { 288, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6568), null, true, false, null, "America/Kralendijk" },
                    { 279, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6545), null, true, false, null, "America/Panama" },
                    { 278, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6542), null, true, false, null, "America/Cayman" },
                    { 277, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6539), null, true, false, null, "America/Jamaica" },
                    { 262, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6500), null, true, false, null, "Antarctica/Rothera" },
                    { 263, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6503), null, true, false, null, "Antarctica/Palmer" },
                    { 264, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6506), null, true, false, null, "America/Fortaleza" },
                    { 265, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6508), null, true, false, null, "America/Belem" }
                });

            migrationBuilder.InsertData(
                table: "TimeZoneName",
                columns: new[] { "Id", "CreatedTime", "DeletedTime", "IsActive", "IsDelete", "UpdatedTime", "ZoneName" },
                values: new object[,]
                {
                    { 266, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6511), null, true, false, null, "America/Maceio" },
                    { 267, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6513), null, true, false, null, "America/Recife" },
                    { 268, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6516), null, true, false, null, "America/Santarem" },
                    { 269, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6519), null, true, false, null, "Atlantic/Stanley" },
                    { 270, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6521), null, true, false, null, "America/Paramaribo" },
                    { 271, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6524), null, true, false, null, "Etc/GMT+3" },
                    { 272, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6526), null, true, false, null, "America/Bogota" },
                    { 273, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6529), null, true, false, null, "America/Rio_Branco" },
                    { 274, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6532), null, true, false, null, "America/Eirunepe" },
                    { 275, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6534), null, true, false, null, "America/Coral_Harbour" },
                    { 276, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6537), null, true, false, null, "America/Guayaquil" },
                    { 260, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6495), null, true, false, null, "Europe/Simferopol" },
                    { 223, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6361), null, true, false, null, "America/Ojinaga" },
                    { 222, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6358), null, true, false, null, "America/Yellowknife" },
                    { 221, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6356), null, true, false, null, "America/Inuvik" },
                    { 169, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6180), null, true, false, null, "Europe/Bucharest" },
                    { 170, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6183), null, true, false, null, "Asia/Nicosia" },
                    { 171, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6185), null, true, false, null, "Asia/Famagusta" },
                    { 172, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6188), null, true, false, null, "Europe/Athens" },
                    { 173, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6191), null, true, false, null, "Asia/Tbilisi" },
                    { 174, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6193), null, true, false, null, "America/Godthab" },
                    { 168, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6178), null, true, false, null, "Atlantic/Madeira" },
                    { 175, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6196), null, true, false, null, "Atlantic/Reykjavik" },
                    { 177, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6201), null, true, false, null, "Africa/Ouagadougou" },
                    { 178, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6204), null, true, false, null, "Africa/Abidjan" },
                    { 179, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6206), null, true, false, null, "Africa/Accra" },
                    { 180, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6209), null, true, false, null, "America/Danmarkshavn" },
                    { 181, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6212), null, true, false, null, "Africa/Banjul" },
                    { 182, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6214), null, true, false, null, "Africa/Conakry" },
                    { 176, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6198), null, true, false, null, "Atlantic/St_Helena" },
                    { 167, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6175), null, true, false, null, "Europe/Lisbon" },
                    { 166, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6172), null, true, false, null, "Europe/Jersey" },
                    { 165, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6170), null, true, false, null, "Europe/Isle_of_Man" },
                    { 150, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6130), null, true, false, null, "Europe/Kiev" },
                    { 151, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6133), null, true, false, null, "Europe/Mariehamn" },
                    { 152, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6136), null, true, false, null, "Europe/Sofia" },
                    { 153, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6138), null, true, false, null, "Europe/Tallinn" },
                    { 154, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6141), null, true, false, null, "Europe/Helsinki" },
                    { 155, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6143), null, true, false, null, "Europe/Vilnius" },
                    { 156, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6146), null, true, false, null, "Europe/Riga" },
                    { 157, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6149), null, true, false, null, "Europe/Uzhgorod" },
                    { 158, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6151), null, true, false, null, "Europe/Zaporozhye" }
                });

            migrationBuilder.InsertData(
                table: "TimeZoneName",
                columns: new[] { "Id", "CreatedTime", "DeletedTime", "IsActive", "IsDelete", "UpdatedTime", "ZoneName" },
                values: new object[,]
                {
                    { 159, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6154), null, true, false, null, "Pacific/Fiji" },
                    { 160, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6157), null, true, false, null, "Europe/London" },
                    { 161, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6159), null, true, false, null, "Atlantic/Canary" },
                    { 162, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6162), null, true, false, null, "Atlantic/Faeroe" },
                    { 163, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6164), null, true, false, null, "Europe/Guernsey" },
                    { 164, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6167), null, true, false, null, "Europe/Dublin" },
                    { 183, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6217), null, true, false, null, "Africa/Bissau" },
                    { 184, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6219), null, true, false, null, "Africa/Monrovia" },
                    { 185, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6222), null, true, false, null, "Africa/Bamako" },
                    { 186, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6225), null, true, false, null, "Africa/Nouakchott" },
                    { 206, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6316), null, true, false, null, "Asia/Magadan" },
                    { 207, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6319), null, true, false, null, "America/Punta_Arenas" },
                    { 208, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6321), null, true, false, null, "Pacific/Marquesas" },
                    { 209, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6324), null, true, false, null, "Indian/Mauritius" },
                    { 210, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6327), null, true, false, null, "Indian/Reunion" },
                    { 211, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6329), null, true, false, null, "Indian/Mahe" },
                    { 212, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6332), null, true, false, null, "Asia/Beirut" },
                    { 213, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6335), null, true, false, null, "America/Montevideo" },
                    { 214, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6337), null, true, false, null, "Africa/Casablanca" },
                    { 215, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6340), null, true, false, null, "Africa/El_Aaiun" },
                    { 216, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6342), null, true, false, null, "America/Chihuahua" },
                    { 217, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6345), null, true, false, null, "America/Mazatlan" },
                    { 218, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6348), null, true, false, null, "America/Denver" },
                    { 219, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6350), null, true, false, null, "America/Edmonton" },
                    { 220, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6353), null, true, false, null, "America/Cambridge_Bay" },
                    { 205, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6274), null, true, false, null, "Australia/Lord_Howe" },
                    { 591, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7510), null, true, false, null, "Pacific/Pohnpei" },
                    { 204, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6272), null, true, false, null, "Etc/GMT-14" },
                    { 202, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6266), null, true, false, null, "Africa/Tripoli" },
                    { 187, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6227), null, true, false, null, "Africa/Freetown" },
                    { 188, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6230), null, true, false, null, "Africa/Dakar" },
                    { 189, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6233), null, true, false, null, "Africa/Lome" },
                    { 190, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6235), null, true, false, null, "America/Port-au-Prince" },
                    { 191, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6238), null, true, false, null, "Pacific/Honolulu" },
                    { 192, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6240), null, true, false, null, "Pacific/Rarotonga" },
                    { 193, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6243), null, true, false, null, "Pacific/Tahiti" },
                    { 194, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6246), null, true, false, null, "Pacific/Johnston" },
                    { 195, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6248), null, true, false, null, "Etc/GMT+10" },
                    { 196, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6251), null, true, false, null, "Asia/Calcutta" },
                    { 197, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6253), null, true, false, null, "Asia/Tehran" },
                    { 198, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6256), null, true, false, null, "Asia/Jerusalem" },
                    { 199, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6259), null, true, false, null, "Asia/Amman" }
                });

            migrationBuilder.InsertData(
                table: "TimeZoneName",
                columns: new[] { "Id", "CreatedTime", "DeletedTime", "IsActive", "IsDelete", "UpdatedTime", "ZoneName" },
                values: new object[,]
                {
                    { 200, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6261), null, true, false, null, "Europe/Kaliningrad" },
                    { 201, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6264), null, true, false, null, "Asia/Seoul" },
                    { 203, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(6269), null, true, false, null, "Pacific/Kiritimati" },
                    { 592, new DateTime(2022, 5, 8, 16, 39, 20, 138, DateTimeKind.Local).AddTicks(7513), null, true, false, null, "Antarctica/Troll" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TimeZoneName",
                table: "TimeZoneName");

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "TimeZoneName",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.RenameTable(
                name: "TimeZoneName",
                newName: "TimeZone");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "TimeZone",
                type: "bit",
                nullable: true,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimeZone",
                table: "TimeZone",
                column: "Id");
        }
    }
}
