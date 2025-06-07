﻿using System;
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

        public static List<WorldSettingsTemplate> Templates { get; } = new List<WorldSettingsTemplate>
        {
            new WorldSettingsTemplate { TldHostname = "tribalwars.net", DefaultTranslationId = 1, TimeZoneId = "Europe/London" },
            new WorldSettingsTemplate { TldHostname = "tribalwars.us", DefaultTranslationId = 1, TimeZoneId = "America/New_York" },
            new WorldSettingsTemplate { TldHostname = "tribalwars.com.br", DefaultTranslationId = 96, TimeZoneId = "America/Sao_Paulo" },
            new WorldSettingsTemplate { TldHostname = "fyletikesmaxes.gr", DefaultTranslationId = 61, TimeZoneId = "Europe/Athens" },
            new WorldSettingsTemplate { TldHostname = "tribals.it", DefaultTranslationId = 52, TimeZoneId = "Europe/Berlin" },
            new WorldSettingsTemplate { TldHostname = "tribalwars.nl", DefaultTranslationId = 33, TimeZoneId = "Europe/Amsterdam" },
            new WorldSettingsTemplate { TldHostname = "tribalwars.com.pt", DefaultTranslationId = 32, TimeZoneId = "Europe/London" },
            new WorldSettingsTemplate { 
                TldHostname = "klanhaboru.hu", 
                DefaultTranslationId = 2,
                TimeZoneId = "Europe/Budapest",
                Market = "hu",
                Language = "hu_HU",
                Locale = "hu_HU",
                Culture = "hu-HU",
                DateFormat = "yyyy.MM.dd",
                NumberFormat = "hu-HU"
            },
        };
    }
}
