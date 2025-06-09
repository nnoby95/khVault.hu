using System.Collections.Generic;

namespace TW.Vault.Lib.Scaffold.Seed
{
    public static class TranslationEntryData
    {
        /*
         * Hungarian translations for Tribal Wars Vault
         * OPTIMIZED: Essential English translations + Complete Hungarian translations
         * NO DUPLICATES - Each KeyId appears exactly once per TranslationId
         */

        public static List<TranslationEntry> Contents { get; } = new List<TranslationEntry>
        {
            // ESSENTIAL ENGLISH TRANSLATIONS (TranslationId = 1) - Core functionality only
            new TranslationEntry { TranslationId = 1, KeyId = 2, Value = "Open Vault" },
            new TranslationEntry { TranslationId = 1, KeyId = 3, Value = "Arrival time" },
            new TranslationEntry { TranslationId = 1, KeyId = 4, Value = "Arrives in" },
            new TranslationEntry { TranslationId = 1, KeyId = 5, Value = "This script cannot be used without a premium account!" },
            new TranslationEntry { TranslationId = 1, KeyId = 6, Value = "This is your first time running the script - please see the terms and conditions on DATA COLLECTION below.\n\n\nThis script serves as an interface to the Vault, a private tool for collecting Tribal Wars data.\n\nAll data and requests to the Vault will have various information logged for security. This is limited to:\n- Authentication token\n- IP address\n- Player ID\n- Tribe ID\n- Requested endpoint\n- Time of transaction\n\nRequests to this script will only be IP-logged to protect against abuse. Information collected by this script will never be shared\nwith any third parties or any unauthorized tribes/players.\n\nThese terms can be viewed again after running the script. To cancel your agreement, do not run this script again.\n\n\nAgree to these terms?" },
            new TranslationEntry { TranslationId = 1, KeyId = 7, Value = "Thank you, please run the script again to start using it." },
            new TranslationEntry { TranslationId = 1, KeyId = 8, Value = "The script will not be ran." },
            new TranslationEntry { TranslationId = 1, KeyId = 9, Value = "The vault was recently updated, you will need to re-upload some data." },
            new TranslationEntry { TranslationId = 1, KeyId = 10, Value = "Make BB-code for back-timing" },
            new TranslationEntry { TranslationId = 1, KeyId = 11, Value = "You haven't uploaded data in a while, you can't use the backtiming script until you do. Upload your data then refresh the page and run this script again." },
            new TranslationEntry { TranslationId = 1, KeyId = 12, Value = "commands" },
            new TranslationEntry { TranslationId = 1, KeyId = 13, Value = "incomings" },
            new TranslationEntry { TranslationId = 1, KeyId = 14, Value = "reports" },
            new TranslationEntry { TranslationId = 1, KeyId = 15, Value = "troops" },
            new TranslationEntry { TranslationId = 1, KeyId = 16, Value = "You need to upload:" },
            new TranslationEntry { TranslationId = 1, KeyId = 17, Value = "An error occurred..." },
            new TranslationEntry { TranslationId = 1, KeyId = 18, Value = "No commands available" },
            new TranslationEntry { TranslationId = 1, KeyId = 19, Value = "No data is available" },
            new TranslationEntry { TranslationId = 1, KeyId = 20, Value = "Troops" },
            new TranslationEntry { TranslationId = 1, KeyId = 21, Value = "Source Village" },
            new TranslationEntry { TranslationId = 1, KeyId = 22, Value = "Launch Time" },
            new TranslationEntry { TranslationId = 1, KeyId = 23, Value = "Landing Time" },
            new TranslationEntry { TranslationId = 1, KeyId = 24, Value = "Troop Req." },
            new TranslationEntry { TranslationId = 1, KeyId = 25, Value = "Vault" },
            new TranslationEntry { TranslationId = 1, KeyId = 26, Value = "This is the Main Vault Interface. Make sure to upload your reports, etc. in the Upload tab. Run this script on your Map or on your Incomings to see everything the Vault has to offer." },
            new TranslationEntry { TranslationId = 1, KeyId = 27, Value = "Done" },
            new TranslationEntry { TranslationId = 1, KeyId = 28, Value = "Current uploads will continue running while this popup is closed." },
            new TranslationEntry { TranslationId = 1, KeyId = 29, Value = "{numIncs} incomings weren't uploaded to Vault yet and won't be tagged!" },
            new TranslationEntry { TranslationId = 1, KeyId = 30, Value = "You haven't uploaded data in a while, you can't use tagging until you do." },
            new TranslationEntry { TranslationId = 1, KeyId = 31, Value = "Note - this feature is EXPERIMENTAL and may not be accurate!" },
            new TranslationEntry { TranslationId = 1, KeyId = 32, Value = "Upload Visible Incomings" },
            new TranslationEntry { TranslationId = 1, KeyId = 33, Value = "Code" },
            new TranslationEntry { TranslationId = 1, KeyId = 34, Value = "Details" },
            new TranslationEntry { TranslationId = 1, KeyId = 51, Value = "Tag format:" },
            new TranslationEntry { TranslationId = 1, KeyId = 52, Value = "Reset" },
            new TranslationEntry { TranslationId = 1, KeyId = 53, Value = "Only tag unlabeled incomings" },
            new TranslationEntry { TranslationId = 1, KeyId = 54, Value = "Label as \"Fakes\" if less than" },
            new TranslationEntry { TranslationId = 1, KeyId = 55, Value = "thousand offense population" },
            new TranslationEntry { TranslationId = 1, KeyId = 56, Value = "Ignore incomings without data" },
            new TranslationEntry { TranslationId = 1, KeyId = 57, Value = "Tag All" },
            new TranslationEntry { TranslationId = 1, KeyId = 58, Value = "Tag Selected" },
            new TranslationEntry { TranslationId = 1, KeyId = 59, Value = "Revert to Old Tags" },
            new TranslationEntry { TranslationId = 1, KeyId = 60, Value = "Cancel" },
            new TranslationEntry { TranslationId = 1, KeyId = 61, Value = "Tagging will take a while!" },
            new TranslationEntry { TranslationId = 1, KeyId = 62, Value = "That's not a number!" },
            new TranslationEntry { TranslationId = 1, KeyId = 63, Value = "WARNING - Fake detection isn't 100% accurate, but you have enabled the 'label as fakes' option.\"" },
            new TranslationEntry { TranslationId = 1, KeyId = 64, Value = "You didn't select any incomings!" },
            new TranslationEntry { TranslationId = 1, KeyId = 65, Value = "Either no incomings or all tags are current" },
            new TranslationEntry { TranslationId = 1, KeyId = 66, Value = "Tagging canceled" },
            new TranslationEntry { TranslationId = 1, KeyId = 67, Value = "{numDone}/{numTotal} tagged ({numFailed} failed)" },
            new TranslationEntry { TranslationId = 1, KeyId = 68, Value = "Tagging:" },
            new TranslationEntry { TranslationId = 1, KeyId = 69, Value = "Finished:" },
            new TranslationEntry { TranslationId = 1, KeyId = 70, Value = "Canceled:" },
            new TranslationEntry { TranslationId = 1, KeyId = 71, Value = "Unknown" },
            new TranslationEntry { TranslationId = 1, KeyId = 72, Value = "Fakes" },
            new TranslationEntry { TranslationId = 1, KeyId = 73, Value = "Fake" },
            new TranslationEntry { TranslationId = 1, KeyId = 74, Value = "Nuke?" },
            new TranslationEntry { TranslationId = 1, KeyId = 75, Value = "Using Vault" },
            new TranslationEntry { TranslationId = 1, KeyId = 76, Value = "Any" },
            new TranslationEntry { TranslationId = 1, KeyId = 77, Value = "No" },
            new TranslationEntry { TranslationId = 1, KeyId = 78, Value = "You haven't uploaded data in a while, you can't use the map script until you do. Click the 'Show' link at the top of the page to start uploading. (Then refresh the page)" },
            new TranslationEntry { TranslationId = 1, KeyId = 79, Value = "# Fakes" },
            new TranslationEntry { TranslationId = 1, KeyId = 80, Value = "# Nukes" },
            new TranslationEntry { TranslationId = 1, KeyId = 81, Value = "# Nobles" },
            new TranslationEntry { TranslationId = 1, KeyId = 82, Value = "# DVs" },
            new TranslationEntry { TranslationId = 1, KeyId = 83, Value = "# Players" },
            new TranslationEntry { TranslationId = 1, KeyId = 84, Value = "At home" },
            new TranslationEntry { TranslationId = 1, KeyId = 85, Value = "Stationed" },
            new TranslationEntry { TranslationId = 1, KeyId = 86, Value = "Traveling" },
            new TranslationEntry { TranslationId = 1, KeyId = 87, Value = "Owned" },
            new TranslationEntry { TranslationId = 1, KeyId = 88, Value = "Possibly recruited" },
            new TranslationEntry { TranslationId = 1, KeyId = 89, Value = "Will take ~{nukesRequired} nukes to clear at {morale}% morale (last nuke has ~{lossPercent}% losses)" },
            new TranslationEntry { TranslationId = 1, KeyId = 90, Value = "Seen at" },
            new TranslationEntry { TranslationId = 1, KeyId = 91, Value = "Latest levels" },
            new TranslationEntry { TranslationId = 1, KeyId = 92, Value = "Possible levels" },
            new TranslationEntry { TranslationId = 1, KeyId = 93, Value = "Loyalty" },
            new TranslationEntry { TranslationId = 1, KeyId = 94, Value = "Latest loyalty" },
            new TranslationEntry { TranslationId = 1, KeyId = 95, Value = "Possible loyalty" },
            new TranslationEntry { TranslationId = 1, KeyId = 96, Value = "Hover Settings" },
            new TranslationEntry { TranslationId = 1, KeyId = 97, Value = "Commands" },
            new TranslationEntry { TranslationId = 1, KeyId = 98, Value = "Possible recruits" },
            new TranslationEntry { TranslationId = 1, KeyId = 99, Value = "Buildings" },
            new TranslationEntry { TranslationId = 1, KeyId = 100, Value = "Loyalty" },
            new TranslationEntry { TranslationId = 1, KeyId = 101, Value = "Overlay Settings" },
            new TranslationEntry { TranslationId = 1, KeyId = 102, Value = "Show overlay" },
            new TranslationEntry { TranslationId = 1, KeyId = 103, Value = "Ignore intel over" },
            new TranslationEntry { TranslationId = 1, KeyId = 104, Value = "days old" },
            new TranslationEntry { TranslationId = 1, KeyId = 105, Value = "Highlights" },
            new TranslationEntry { TranslationId = 1, KeyId = 106, Value = "None" },
            new TranslationEntry { TranslationId = 1, KeyId = 128, Value = "Village" },
            new TranslationEntry { TranslationId = 1, KeyId = 129, Value = "Loyalty" },
            new TranslationEntry { TranslationId = 1, KeyId = 151, Value = "Owner" },
            new TranslationEntry { TranslationId = 1, KeyId = 155, Value = "Tribe" },
            new TranslationEntry { TranslationId = 1, KeyId = 170, Value = "Admin" },
            new TranslationEntry { TranslationId = 1, KeyId = 171, Value = "Delete" },
            new TranslationEntry { TranslationId = 1, KeyId = 181, Value = "Manage Users" },
            new TranslationEntry { TranslationId = 1, KeyId = 182, Value = "Keys" },
            new TranslationEntry { TranslationId = 1, KeyId = 183, Value = "Make new key" },
            new TranslationEntry { TranslationId = 1, KeyId = 184, Value = "New Vault Script" },
            new TranslationEntry { TranslationId = 1, KeyId = 185, Value = "User name" },
            new TranslationEntry { TranslationId = 1, KeyId = 186, Value = "Current tribe" },
            new TranslationEntry { TranslationId = 1, KeyId = 187, Value = "Tribe Stats" },
            new TranslationEntry { TranslationId = 1, KeyId = 188, Value = "Working" },
            new TranslationEntry { TranslationId = 1, KeyId = 191, Value = "Download" },
            new TranslationEntry { TranslationId = 1, KeyId = 194, Value = "Admin" },
            new TranslationEntry { TranslationId = 1, KeyId = 195, Value = "Event" },
            new TranslationEntry { TranslationId = 1, KeyId = 196, Value = "Time" },
            new TranslationEntry { TranslationId = 1, KeyId = 216, Value = "Yes" },
            new TranslationEntry { TranslationId = 1, KeyId = 217, Value = "Player" },
            new TranslationEntry { TranslationId = 1, KeyId = 234, Value = "Notifications" },
            new TranslationEntry { TranslationId = 1, KeyId = 241, Value = "Server Time" },
            new TranslationEntry { TranslationId = 1, KeyId = 243, Value = "Message" },
            new TranslationEntry { TranslationId = 1, KeyId = 244, Value = "Add" },
            new TranslationEntry { TranslationId = 1, KeyId = 264, Value = "Optional" },
            new TranslationEntry { TranslationId = 1, KeyId = 268, Value = "Save" },
            new TranslationEntry { TranslationId = 1, KeyId = 275, Value = "Stats" },
            new TranslationEntry { TranslationId = 1, KeyId = 282, Value = "Me" },
            new TranslationEntry { TranslationId = 1, KeyId = 283, Value = "An error occurred while loading stats" },
            new TranslationEntry { TranslationId = 1, KeyId = 284, Value = "Last 7 Days" },
            new TranslationEntry { TranslationId = 1, KeyId = 285, Value = "Nukes" },
            new TranslationEntry { TranslationId = 1, KeyId = 286, Value = "Fangs" },
            new TranslationEntry { TranslationId = 1, KeyId = 287, Value = "Support" },
            new TranslationEntry { TranslationId = 1, KeyId = 288, Value = "Defense" },
            new TranslationEntry { TranslationId = 1, KeyId = 289, Value = "# DVs" },
            new TranslationEntry { TranslationId = 1, KeyId = 290, Value = "At Home" },
            new TranslationEntry { TranslationId = 1, KeyId = 291, Value = "(Backline) At Home" },
            new TranslationEntry { TranslationId = 1, KeyId = 292, Value = "Traveling" },
            new TranslationEntry { TranslationId = 1, KeyId = 293, Value = "Support" },
            new TranslationEntry { TranslationId = 1, KeyId = 294, Value = "High Scores" },
            new TranslationEntry { TranslationId = 1, KeyId = 295, Value = "An error occurred while getting rankings" },
            new TranslationEntry { TranslationId = 1, KeyId = 296, Value = "Rankings" },
            new TranslationEntry { TranslationId = 1, KeyId = 297, Value = "Support" },
            new TranslationEntry { TranslationId = 1, KeyId = 298, Value = "Disclaimers and Terms" },
            new TranslationEntry { TranslationId = 1, KeyId = 299, Value = "This tool is not endorsed or developed by InnoGames." },
            new TranslationEntry { TranslationId = 1, KeyId = 300, Value = "All data and requests to the Vault will have various information logged for security. This is limited to:\n\nAuthentication token, IP address, player ID, tribe ID, requested endpoint, and time of transaction.\n\nRequests to this script will only be IP-logged to protect against abuse. Information collected by this script will never be shared with any third parties or any unauthorized tribes/players." },
            new TranslationEntry { TranslationId = 1, KeyId = 301, Value = "Tools" },
            new TranslationEntry { TranslationId = 1, KeyId = 302, Value = "Fake Script" },
            new TranslationEntry { TranslationId = 1, KeyId = 304, Value = "Players" },
            new TranslationEntry { TranslationId = 1, KeyId = 305, Value = "Tribes" },
            new TranslationEntry { TranslationId = 1, KeyId = 306, Value = "Continents" },
            new TranslationEntry { TranslationId = 1, KeyId = 307, Value = "Min Coord" },
            new TranslationEntry { TranslationId = 1, KeyId = 308, Value = "Max Coord" },
            new TranslationEntry { TranslationId = 1, KeyId = 310, Value = "Dist From Center" },
            new TranslationEntry { TranslationId = 1, KeyId = 311, Value = "fields from" },
            new TranslationEntry { TranslationId = 1, KeyId = 312, Value = "Get Coords" },
            new TranslationEntry { TranslationId = 1, KeyId = 315, Value = "Find Backtimes" },
            new TranslationEntry { TranslationId = 1, KeyId = 316, Value = "Working... (This may take a while)" },
            new TranslationEntry { TranslationId = 1, KeyId = 320, Value = "Minimum returning population:" },
            new TranslationEntry { TranslationId = 1, KeyId = 321, Value = "Minimum attack size:" },
            new TranslationEntry { TranslationId = 1, KeyId = 322, Value = "% of a full nuke" },
            new TranslationEntry { TranslationId = 1, KeyId = 323, Value = "Max travel time:" },
            new TranslationEntry { TranslationId = 1, KeyId = 324, Value = "Max number of timings:" },
            new TranslationEntry { TranslationId = 1, KeyId = 327, Value = "Upload" },
            new TranslationEntry { TranslationId = 1, KeyId = 328, Value = "Uploads all data from all new battle reports." },
            new TranslationEntry { TranslationId = 1, KeyId = 329, Value = "Uploads all available data from your Incomings page. This includes attacks and support." },
            new TranslationEntry { TranslationId = 1, KeyId = 330, Value = "Uploads all data for all of your current commands." },
            new TranslationEntry { TranslationId = 1, KeyId = 331, Value = "Uploads all data for all troops." },
            new TranslationEntry { TranslationId = 1, KeyId = 332, Value = "Local vault cache cleared." },
            new TranslationEntry { TranslationId = 1, KeyId = 333, Value = "Waiting" },
            new TranslationEntry { TranslationId = 1, KeyId = 334, Value = "An unexpected error occurred:" },
            new TranslationEntry { TranslationId = 1, KeyId = 335, Value = "Upload" },
            new TranslationEntry { TranslationId = 1, KeyId = 336, Value = "Progress" },
            new TranslationEntry { TranslationId = 1, KeyId = 340, Value = "Details" },
            new TranslationEntry { TranslationId = 1, KeyId = 341, Value = "Click \"Upload All\" below. If needed, upload different things individually using the other Upload buttons." },
            new TranslationEntry { TranslationId = 1, KeyId = 342, Value = "Reports" },
            new TranslationEntry { TranslationId = 1, KeyId = 345, Value = "Incomings" },
            new TranslationEntry { TranslationId = 1, KeyId = 347, Value = "Commands" },
            new TranslationEntry { TranslationId = 1, KeyId = 348, Value = "Upload All" },
            new TranslationEntry { TranslationId = 1, KeyId = 349, Value = "Clear Cache" },
            new TranslationEntry { TranslationId = 1, KeyId = 356, Value = "Collecting command pages..." },
            new TranslationEntry { TranslationId = 1, KeyId = 357, Value = "Finished: No new commands to upload." },
            new TranslationEntry { TranslationId = 1, KeyId = 358, Value = "Checking for previously-uploaded commands..." },
            new TranslationEntry { TranslationId = 1, KeyId = 359, Value = "Uploading commands..." },
            new TranslationEntry { TranslationId = 1, KeyId = 360, Value = "Finished: {numDone}/{numTotal} uploaded, {numFailed} failed." },
            new TranslationEntry { TranslationId = 1, KeyId = 363, Value = "{numDone}/{numTotal} done, {numFailed} failed" },
            new TranslationEntry { TranslationId = 1, KeyId = 364, Value = "Collecting incoming pages..." },
            new TranslationEntry { TranslationId = 1, KeyId = 365, Value = "({numDone}/{numTotal} done, {numFailed} failed)" },
            new TranslationEntry { TranslationId = 1, KeyId = 366, Value = "Uploading incomings..." },
            new TranslationEntry { TranslationId = 1, KeyId = 367, Value = "Finished: Uploaded {numIncomings} incomings." },
            new TranslationEntry { TranslationId = 1, KeyId = 368, Value = "Collecting report pages..." },
            new TranslationEntry { TranslationId = 1, KeyId = 378, Value = "Finished: {numDone}/{numTotal} uploaded, {numFailed} failed." },
            new TranslationEntry { TranslationId = 1, KeyId = 379, Value = "Finished: No new reports to upload." },
            new TranslationEntry { TranslationId = 1, KeyId = 391, Value = "Uploading troops to vault..." },
            new TranslationEntry { TranslationId = 1, KeyId = 392, Value = "An error occurred while uploading to the vault." },
            new TranslationEntry { TranslationId = 1, KeyId = 393, Value = "Finished: Uploaded troops for {numVillages} villages." },
            new TranslationEntry { TranslationId = 1, KeyId = 394, Value = "Uploading support to vault..." },
            new TranslationEntry { TranslationId = 1, KeyId = 395, Value = "Ram" },
            new TranslationEntry { TranslationId = 1, KeyId = 396, Value = "ram, rams" },
            new TranslationEntry { TranslationId = 1, KeyId = 397, Value = "Catapult" },
            new TranslationEntry { TranslationId = 1, KeyId = 398, Value = "catapult, cat, cats" },
            new TranslationEntry { TranslationId = 1, KeyId = 399, Value = "Spear" },
            new TranslationEntry { TranslationId = 1, KeyId = 400, Value = "spear, spears, sp" },
            new TranslationEntry { TranslationId = 1, KeyId = 401, Value = "Sword" },
            new TranslationEntry { TranslationId = 1, KeyId = 402, Value = "sword, swords, sw" },
            new TranslationEntry { TranslationId = 1, KeyId = 403, Value = "Axe" },
            new TranslationEntry { TranslationId = 1, KeyId = 404, Value = "axe" },
            new TranslationEntry { TranslationId = 1, KeyId = 405, Value = "Archer" },
            new TranslationEntry { TranslationId = 1, KeyId = 406, Value = "archer, ar" },
            new TranslationEntry { TranslationId = 1, KeyId = 407, Value = "Scout" },
            new TranslationEntry { TranslationId = 1, KeyId = 408, Value = "scout, scouts, sc" },
            new TranslationEntry { TranslationId = 1, KeyId = 409, Value = "Light Cav." },
            new TranslationEntry { TranslationId = 1, KeyId = 410, Value = "light cav, light cavalry, light, lc" },
            new TranslationEntry { TranslationId = 1, KeyId = 411, Value = "Mounted Ar." },
            new TranslationEntry { TranslationId = 1, KeyId = 412, Value = "mounted ar, mounted archer, marcher, ma" },
            new TranslationEntry { TranslationId = 1, KeyId = 413, Value = "Heavy Cav." },
            new TranslationEntry { TranslationId = 1, KeyId = 414, Value = "heavy cav, heavy cavalry, hc, heavy" },
            new TranslationEntry { TranslationId = 1, KeyId = 415, Value = "Paladin" },
            new TranslationEntry { TranslationId = 1, KeyId = 416, Value = "paladin, pally" },
            new TranslationEntry { TranslationId = 1, KeyId = 417, Value = "Headquarters" },
            new TranslationEntry { TranslationId = 1, KeyId = 418, Value = "Barracks" },
            new TranslationEntry { TranslationId = 1, KeyId = 419, Value = "Stable" },
            new TranslationEntry { TranslationId = 1, KeyId = 420, Value = "Workshop" },
            new TranslationEntry { TranslationId = 1, KeyId = 421, Value = "Academy" },
            new TranslationEntry { TranslationId = 1, KeyId = 422, Value = "Smithy" },
            new TranslationEntry { TranslationId = 1, KeyId = 423, Value = "Rally point" },
            new TranslationEntry { TranslationId = 1, KeyId = 424, Value = "Statue" },
            new TranslationEntry { TranslationId = 1, KeyId = 425, Value = "Market" },
            new TranslationEntry { TranslationId = 1, KeyId = 426, Value = "Timber camp" },
            new TranslationEntry { TranslationId = 1, KeyId = 427, Value = "Clay pit" },
            new TranslationEntry { TranslationId = 1, KeyId = 428, Value = "Iron mine" },
            new TranslationEntry { TranslationId = 1, KeyId = 429, Value = "Farm" },
            new TranslationEntry { TranslationId = 1, KeyId = 430, Value = "Warehouse" },
            new TranslationEntry { TranslationId = 1, KeyId = 431, Value = "Hiding place" },
            new TranslationEntry { TranslationId = 1, KeyId = 432, Value = "Wall" },
            new TranslationEntry { TranslationId = 1, KeyId = 433, Value = "Watchtower" },
            new TranslationEntry { TranslationId = 1, KeyId = 434, Value = "Church" },
            new TranslationEntry { TranslationId = 1, KeyId = 435, Value = "from {oldLoyalty} to {newLoyalty}" },
            new TranslationEntry { TranslationId = 1, KeyId = 438, Value = "table" },
            new TranslationEntry { TranslationId = 1, KeyId = 439, Value = "Tribal wars Captcha was triggered, please refresh the page and try again. Any uploads will continue where they left off." },
            new TranslationEntry { TranslationId = 1, KeyId = 440, Value = "Your current village group isn't \"All\", please change to group \"All\"." },
            new TranslationEntry { TranslationId = 1, KeyId = 441, Value = "You have filters set for your {dataType}, please remove them before uploading." },
            new TranslationEntry { TranslationId = 1, KeyId = 448, Value = "jan, feb, mar, apr, may, jun, jul, aug, sep, oct, nov, dec" },
            new TranslationEntry { TranslationId = 1, KeyId = 449, Value = "today at {time}" },
            new TranslationEntry { TranslationId = 1, KeyId = 450, Value = "tomorrow at {time}" },
            new TranslationEntry { TranslationId = 1, KeyId = 451, Value = "{time} on {date}" },
            new TranslationEntry { TranslationId = 1, KeyId = 452, Value = "on {date} at {time}" },
            new TranslationEntry { TranslationId = 1, KeyId = 453, Value = "{hour}:{minute}:{second}:{millisecond} on {day}:{month}:{year}" },
            new TranslationEntry { TranslationId = 1, KeyId = 454, Value = "day" },
            new TranslationEntry { TranslationId = 1, KeyId = 455, Value = "hr" },
            new TranslationEntry { TranslationId = 1, KeyId = 456, Value = "min" },
            new TranslationEntry { TranslationId = 1, KeyId = 457, Value = "sec" },
            new TranslationEntry { TranslationId = 1, KeyId = 458, Value = "days" },
            new TranslationEntry { TranslationId = 1, KeyId = 459, Value = "hrs" },
            new TranslationEntry { TranslationId = 1, KeyId = 460, Value = "mins" },
            new TranslationEntry { TranslationId = 1, KeyId = 461, Value = "secs" },
            new TranslationEntry { TranslationId = 1, KeyId = 462, Value = "{numDone}/{numTotal} done, {numFailed} failed" },
            new TranslationEntry { TranslationId = 1, KeyId = 488, Value = "None" },
            new TranslationEntry { TranslationId = 1, KeyId = 489, Value = "Offense" },
            new TranslationEntry { TranslationId = 1, KeyId = 491, Value = "hours" },
            new TranslationEntry { TranslationId = 1, KeyId = 493, Value = "Nobles" },
            new TranslationEntry { TranslationId = 1, KeyId = 494, Value = "Name" },
            new TranslationEntry { TranslationId = 1, KeyId = 495, Value = "Options" },
            new TranslationEntry { TranslationId = 1, KeyId = 496, Value = "No incomings to upload." },
            new TranslationEntry { TranslationId = 1, KeyId = 497, Value = "An error occurred while uploading data." },
            new TranslationEntry { TranslationId = 1, KeyId = 498, Value = "noble, nobleman, nobles" },
            new TranslationEntry { TranslationId = 1, KeyId = 499, Value = "Noble" },
            new TranslationEntry { TranslationId = 1, KeyId = 501, Value = "Your support from" },
            new TranslationEntry { TranslationId = 1, KeyId = 503, Value = "Nukes" },
            new TranslationEntry { TranslationId = 1, KeyId = 504, Value = "Vault Tagging" },
            new TranslationEntry { TranslationId = 1, KeyId = 505, Value = "Distance between the source and target village" },
            new TranslationEntry { TranslationId = 1, KeyId = 506, Value = "Preview" },
            new TranslationEntry { TranslationId = 1, KeyId = 507, Value = "Vault - commands from here" },
            new TranslationEntry { TranslationId = 1, KeyId = 510, Value = "Alerts" },
            new TranslationEntry { TranslationId = 1, KeyId = 511, Value = "unit" },
            new TranslationEntry { TranslationId = 1, KeyId = 512, Value = "url" },
            new TranslationEntry { TranslationId = 1, KeyId = 513, Value = "Help" },
            new TranslationEntry { TranslationId = 1, KeyId = 514, Value = "Translations" },
            new TranslationEntry { TranslationId = 1, KeyId = 515, Value = "Language:" },
            new TranslationEntry { TranslationId = 1, KeyId = 516, Value = "Translation:" },
            new TranslationEntry { TranslationId = 1, KeyId = 517, Value = "Save Settings" },
            new TranslationEntry { TranslationId = 1, KeyId = 518, Value = "Edit Translation" },
            new TranslationEntry { TranslationId = 1, KeyId = 519, Value = "New Translation" },
            new TranslationEntry { TranslationId = 1, KeyId = 520, Value = "Save Changes" },
            new TranslationEntry { TranslationId = 1, KeyId = 521, Value = "{name} by {author}" },
            new TranslationEntry { TranslationId = 1, KeyId = 522, Value = "Key" },
            new TranslationEntry { TranslationId = 1, KeyId = 523, Value = "Value" },
            new TranslationEntry { TranslationId = 1, KeyId = 524, Value = "English Sample" },
            new TranslationEntry { TranslationId = 1, KeyId = 525, Value = "The translation for {keyName} is missing: {parameters}" },
            new TranslationEntry { TranslationId = 1, KeyId = 526, Value = "Note: This is in-game text, it must match EXACTLY!" },
            new TranslationEntry { TranslationId = 1, KeyId = 527, Value = "Saved changes!" },
            new TranslationEntry { TranslationId = 1, KeyId = 528, Value = "Delete Translation" },
            new TranslationEntry { TranslationId = 1, KeyId = 529, Value = "Are you sure you want to delete your translation, \"{name}\"?" },
            new TranslationEntry { TranslationId = 1, KeyId = 530, Value = "You cannot delete a translation that is being used as a default!" },
            new TranslationEntry { TranslationId = 1, KeyId = 531, Value = "You haven't saved your translation yet!" },
            new TranslationEntry { TranslationId = 1, KeyId = 532, Value = "Successfully deleted the translation." },
            new TranslationEntry { TranslationId = 1, KeyId = 534, Value = "You already have a translation with the name \"{name}\"!" },
            new TranslationEntry { TranslationId = 1, KeyId = 535, Value = "Since you don't own this translation, you'll be editing a copy instead." },
            new TranslationEntry { TranslationId = 1, KeyId = 536, Value = "No recent army data available." },
            new TranslationEntry { TranslationId = 1, KeyId = 537, Value = "No recent building data available." },
            new TranslationEntry { TranslationId = 1, KeyId = 538, Value = "{day}/{month}/{year}" },
            new TranslationEntry { TranslationId = 1, KeyId = 539, Value = "Enemy" },
            new TranslationEntry { TranslationId = 1, KeyId = 540, Value = "The Wall has been damaged and downgraded from level {oldLevel} to level {newLevel}" },
            new TranslationEntry { TranslationId = 1, KeyId = 541, Value = "The {buildingName} has been damaged and downgraded from level {oldLevel} to level {newLevel}" },
            new TranslationEntry { TranslationId = 1, KeyId = 543, Value = "Target Village" },
            new TranslationEntry { TranslationId = 1, KeyId = 544, Value = "Fangs have at least {numCats} catapults and at most {maxPop} population" },
            new TranslationEntry { TranslationId = 1, KeyId = 545, Value = "Fangs Traveling" },
            new TranslationEntry { TranslationId = 1, KeyId = 546, Value = "Total Fangs" },
            new TranslationEntry { TranslationId = 1, KeyId = 547, Value = "Settings" },
            new TranslationEntry { TranslationId = 1, KeyId = 548, Value = "No report folders are being ignored." },
            new TranslationEntry { TranslationId = 1, KeyId = 549, Value = "Deleted Folder" },
            new TranslationEntry { TranslationId = 1, KeyId = 550, Value = "Ignore Folder" },
            new TranslationEntry { TranslationId = 1, KeyId = 551, Value = "Report Upload Options" },
            new TranslationEntry { TranslationId = 1, KeyId = 552, Value = "Ignored Report Folders" },
            new TranslationEntry { TranslationId = 1, KeyId = 553, Value = "All report folders are being ignored by your settings!" },
            new TranslationEntry { TranslationId = 1, KeyId = 554, Value = "{month} {day}, {year} {hour}:{minute}:{second}:{millis}" },
            new TranslationEntry { TranslationId = 1, KeyId = 555, Value = "Points" },
            new TranslationEntry { TranslationId = 1, KeyId = 556, Value = "Minimum village points:" },
            new TranslationEntry { TranslationId = 1, KeyId = 557, Value = "{hour}:{minute}:{second}:{millis}\n\n{hour}:{minute}:{second}\n\n{hour}:{minute}" },
            new TranslationEntry { TranslationId = 1, KeyId = 558, Value = "{monthName} {day}, {year}\n\n{day}/{month}/{year}\n\n{day}.{month}." },
            new TranslationEntry { TranslationId = 1, KeyId = 559, Value = "{monthName} {day}, {hour}:{minute}\n\n{monthName} {day},{year} {hour}:{minute}\n\n{hour}:{minute}:{second}:{millisecond} on {day}:{month}:{year}" },
            new TranslationEntry { TranslationId = 1, KeyId = 560, Value = "Receiving nukes" },

            // HUNGARIAN TRANSLATIONS (TranslationId = 2) - CORRECTED & NO DUPLICATES
            // Building Names - EXACT matches for Hungarian game
            new TranslationEntry { TranslationId = 2, KeyId = 1, Value = "Főhadiszállás" },      // Headquarters/Main
            new TranslationEntry { TranslationId = 2, KeyId = 2, Value = "Vault megnyitása" },  // Open Vault
            new TranslationEntry { TranslationId = 2, KeyId = 3, Value = "Érkezési idő" },      // Arrival time
            new TranslationEntry { TranslationId = 2, KeyId = 4, Value = "Érkezik" },           // Arrives in
            new TranslationEntry { TranslationId = 2, KeyId = 5, Value = "Ez a szkript nem használható prémium fiók nélkül!" }, // Premium account required
            new TranslationEntry { TranslationId = 2, KeyId = 12, Value = "Parancsok" },        // Commands
            new TranslationEntry { TranslationId = 2, KeyId = 13, Value = "Beérkezők" },        // Incomings
            new TranslationEntry { TranslationId = 2, KeyId = 14, Value = "Jelentések" },       // Reports
            new TranslationEntry { TranslationId = 2, KeyId = 15, Value = "Csapatok" },         // Troops
            new TranslationEntry { TranslationId = 2, KeyId = 16, Value = "Fel kell töltened:" }, // You need to upload
            new TranslationEntry { TranslationId = 2, KeyId = 17, Value = "Hiba történt..." },  // An error occurred
            new TranslationEntry { TranslationId = 2, KeyId = 18, Value = "Nincsenek elérhető parancsok" }, // No commands available
            new TranslationEntry { TranslationId = 2, KeyId = 19, Value = "Nincsenek elérhető adatok" },    // No data available
            new TranslationEntry { TranslationId = 2, KeyId = 20, Value = "Csapatok" },         // Troops
            new TranslationEntry { TranslationId = 2, KeyId = 21, Value = "Indító" },           // Source/Origin
            new TranslationEntry { TranslationId = 2, KeyId = 22, Value = "Indítási idő" },     // Launch Time
            new TranslationEntry { TranslationId = 2, KeyId = 23, Value = "Érkezési idő" },     // Landing Time
            new TranslationEntry { TranslationId = 2, KeyId = 24, Value = "Csapat igény" },     // Troop Req
            new TranslationEntry { TranslationId = 2, KeyId = 25, Value = "Vault" },            // Vault
            new TranslationEntry { TranslationId = 2, KeyId = 27, Value = "Kész" },             // Done
            new TranslationEntry { TranslationId = 2, KeyId = 31, Value = "Fa" },               // Wood
            new TranslationEntry { TranslationId = 2, KeyId = 32, Value = "Agyag" },            // Clay
            new TranslationEntry { TranslationId = 2, KeyId = 33, Value = "Vas" },              // Iron
            new TranslationEntry { TranslationId = 2, KeyId = 34, Value = "Népesség" },         // Population
            new TranslationEntry { TranslationId = 2, KeyId = 35, Value = "Falu" },             // Village
            new TranslationEntry { TranslationId = 2, KeyId = 36, Value = "Játékos" },          // Player
            new TranslationEntry { TranslationId = 2, KeyId = 37, Value = "Klán" },             // Tribe
            new TranslationEntry { TranslationId = 2, KeyId = 38, Value = "Támadás" },          // Attack
            new TranslationEntry { TranslationId = 2, KeyId = 39, Value = "Támogatás" },        // Support
            new TranslationEntry { TranslationId = 2, KeyId = 40, Value = "Védelem" },          // Defense
            new TranslationEntry { TranslationId = 2, KeyId = 41, Value = "Hiba" },             // Error
            new TranslationEntry { TranslationId = 2, KeyId = 42, Value = "Sikeres" },          // Success
            new TranslationEntry { TranslationId = 2, KeyId = 43, Value = "Figyelmeztetés" },   // Warning
            new TranslationEntry { TranslationId = 2, KeyId = 44, Value = "Mégse" },            // Cancel
            new TranslationEntry { TranslationId = 2, KeyId = 45, Value = "Mentés" },           // Save
            new TranslationEntry { TranslationId = 2, KeyId = 46, Value = "Törlés" },           // Delete
            new TranslationEntry { TranslationId = 2, KeyId = 47, Value = "Beállítások" },      // Settings
            new TranslationEntry { TranslationId = 2, KeyId = 48, Value = "Segítség" },         // Help
            new TranslationEntry { TranslationId = 2, KeyId = 49, Value = "Betöltés" },         // Loading
            new TranslationEntry { TranslationId = 2, KeyId = 50, Value = "Keresés" },          // Search
            new TranslationEntry { TranslationId = 2, KeyId = 51, Value = "Szűrő" },            // Filter
            new TranslationEntry { TranslationId = 2, KeyId = 52, Value = "Exportálás" },       // Export
            new TranslationEntry { TranslationId = 2, KeyId = 53, Value = "Importálás" },       // Import
            new TranslationEntry { TranslationId = 2, KeyId = 54, Value = "Feltöltés" },        // Upload
            new TranslationEntry { TranslationId = 2, KeyId = 55, Value = "Letöltés" },         // Download
            new TranslationEntry { TranslationId = 2, KeyId = 60, Value = "Felhasználónév" },   // Username
            new TranslationEntry { TranslationId = 2, KeyId = 61, Value = "Jelszó" },           // Password
            new TranslationEntry { TranslationId = 2, KeyId = 62, Value = "E-mail" },           // Email
            new TranslationEntry { TranslationId = 2, KeyId = 63, Value = "Név" },              // Name
            new TranslationEntry { TranslationId = 2, KeyId = 64, Value = "Dátum" },            // Date
            new TranslationEntry { TranslationId = 2, KeyId = 65, Value = "Idő" },              // Time
            new TranslationEntry { TranslationId = 2, KeyId = 66, Value = "Állapot" },          // Status
            new TranslationEntry { TranslationId = 2, KeyId = 67, Value = "Aktív" },            // Active
            new TranslationEntry { TranslationId = 2, KeyId = 68, Value = "Inaktív" },          // Inactive
            new TranslationEntry { TranslationId = 2, KeyId = 69, Value = "Online" },           // Online
            new TranslationEntry { TranslationId = 2, KeyId = 70, Value = "Offline" },          // Offline
            new TranslationEntry { TranslationId = 2, KeyId = 71, Value = "Elérhető" },         // Available
            new TranslationEntry { TranslationId = 2, KeyId = 72, Value = "Nem elérhető" },     // Unavailable
            new TranslationEntry { TranslationId = 2, KeyId = 75, Value = "Vault használata" }, // Using Vault
            new TranslationEntry { TranslationId = 2, KeyId = 79, Value = "# Ál-támadások" },   // # Fakes
            new TranslationEntry { TranslationId = 2, KeyId = 80, Value = "# Nukák" },          // # Nukes
            new TranslationEntry { TranslationId = 2, KeyId = 81, Value = "# Nemesek" },        // # Nobles
            new TranslationEntry { TranslationId = 2, KeyId = 82, Value = "# Védelmi egységek" }, // # DVs
            new TranslationEntry { TranslationId = 2, KeyId = 83, Value = "# Játékosok" },      // # Players
            new TranslationEntry { TranslationId = 2, KeyId = 84, Value = "Otthon" },           // At home
            new TranslationEntry { TranslationId = 2, KeyId = 85, Value = "Állomásoztatva" },   // Stationed
            new TranslationEntry { TranslationId = 2, KeyId = 86, Value = "Utazik" },           // Traveling
            new TranslationEntry { TranslationId = 2, KeyId = 87, Value = "Tulajdonban" },      // Owned
            new TranslationEntry { TranslationId = 2, KeyId = 97, Value = "Parancsok" },        // Commands
            new TranslationEntry { TranslationId = 2, KeyId = 98, Value = "Lehetséges toborzás" }, // Possible recruits
            new TranslationEntry { TranslationId = 2, KeyId = 99, Value = "Épületek" },         // Buildings
            new TranslationEntry { TranslationId = 2, KeyId = 100, Value = "Hűség" },           // Loyalty
            new TranslationEntry { TranslationId = 2, KeyId = 128, Value = "Falu" },            // Village
            new TranslationEntry { TranslationId = 2, KeyId = 129, Value = "Hűség" },           // Loyalty
            new TranslationEntry { TranslationId = 2, KeyId = 151, Value = "Tulajdonos" },      // Owner
            new TranslationEntry { TranslationId = 2, KeyId = 155, Value = "Klán" },            // Tribe
            new TranslationEntry { TranslationId = 2, KeyId = 268, Value = "Mentés" },          // Save
            new TranslationEntry { TranslationId = 2, KeyId = 275, Value = "Statisztikák" },    // Stats
            new TranslationEntry { TranslationId = 2, KeyId = 301, Value = "Eszközök" },        // Tools
            new TranslationEntry { TranslationId = 2, KeyId = 327, Value = "Feltöltés" },       // Upload
            new TranslationEntry { TranslationId = 2, KeyId = 333, Value = "Várakozás" },       // Waiting
            new TranslationEntry { TranslationId = 2, KeyId = 334, Value = "Váratlan hiba történt:" }, // Unexpected error
            new TranslationEntry { TranslationId = 2, KeyId = 335, Value = "Feltöltés" },       // Upload
            new TranslationEntry { TranslationId = 2, KeyId = 336, Value = "Folyamat" },        // Progress
            new TranslationEntry { TranslationId = 2, KeyId = 342, Value = "Jelentések" },      // Reports
            new TranslationEntry { TranslationId = 2, KeyId = 345, Value = "Beérkezők" },       // Incomings
            new TranslationEntry { TranslationId = 2, KeyId = 347, Value = "Parancsok" },       // Commands
            new TranslationEntry { TranslationId = 2, KeyId = 448, Value = "jan, feb, már, ápr, máj, jún, júl, aug, szep, okt, nov, dec" }, // Hungarian months
            new TranslationEntry { TranslationId = 2, KeyId = 449, Value = "ma {time}-kor" },   // today at {time}
            new TranslationEntry { TranslationId = 2, KeyId = 450, Value = "holnap {time}-kor" }, // tomorrow at {time}
            new TranslationEntry { TranslationId = 2, KeyId = 451, Value = "{time} {date}-án" }, // {time} on {date}
            new TranslationEntry { TranslationId = 2, KeyId = 452, Value = "{date}-án {time}-kor" }, // on {date} at {time}
            new TranslationEntry { TranslationId = 2, KeyId = 454, Value = "nap" },             // day
            new TranslationEntry { TranslationId = 2, KeyId = 455, Value = "ó" },               // hr
            new TranslationEntry { TranslationId = 2, KeyId = 456, Value = "p" },               // min
            new TranslationEntry { TranslationId = 2, KeyId = 457, Value = "mp" },              // sec
            new TranslationEntry { TranslationId = 2, KeyId = 458, Value = "nap" },             // days
            new TranslationEntry { TranslationId = 2, KeyId = 459, Value = "óra" },             // hrs
            new TranslationEntry { TranslationId = 2, KeyId = 460, Value = "perc" },            // mins
            new TranslationEntry { TranslationId = 2, KeyId = 461, Value = "másodperc" },       // secs
            new TranslationEntry { TranslationId = 2, KeyId = 491, Value = "órák" },            // hours
            new TranslationEntry { TranslationId = 2, KeyId = 506, Value = "Előnézet" },        // Preview
            new TranslationEntry { TranslationId = 2, KeyId = 507, Value = "Vault - parancsok innen" }, // Vault - commands from here
            new TranslationEntry { TranslationId = 2, KeyId = 510, Value = "Riasztások" },      // Alerts
            new TranslationEntry { TranslationId = 2, KeyId = 538, Value = "{year}.{month}.{day}" }, // Hungarian date format
            new TranslationEntry { TranslationId = 2, KeyId = 543, Value = "Célpont" },         // Target Village
            new TranslationEntry { TranslationId = 2, KeyId = 547, Value = "Beállítások" }      // Settings
        };
    }
}