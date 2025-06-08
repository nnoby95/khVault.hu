using System;
using System.Collections.Generic;
using System.Text;

namespace TW.Vault.Lib.Scaffold.Seed
{
    public class WorldSettingsTemplate
    {
        public String TldHostname { get; set; }
        public String TimeZoneId { get; set; }
        public short DefaultTranslationId { get; set; }
        public String Market { get; set; }
        public String Language { get; set; }
        public String Locale { get; set; }
        public String Culture { get; set; }
        public String DateFormat { get; set; }
        public String NumberFormat { get; set; }

        public static List<WorldSettingsTemplate> Contents { get; } = new List<WorldSettingsTemplate>
        {
            new WorldSettingsTemplate
            {
                TldHostname = "klanhaboru.hu",
                TimeZoneId = "Europe/Budapest",
                DefaultTranslationId = 2,
                Market = "hu",
                Language = "hu_HU",
                Locale = "hu_HU",
                Culture = "hu-HU",
                DateFormat = "yyyy.MM.dd",
                NumberFormat = "hu-HU"
            }
        };
    }
}
