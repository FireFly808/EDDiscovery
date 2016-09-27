﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDDiscovery.EliteDangerous.JournalEvents
{
    public class JournalFileHeader : JournalEntry
    {
        public JournalFileHeader(JObject evt ) : base(evt, JournalTypeEnum.FileHeader)
        {

            GameVersion = Tools.GetStringDef(evt["gameversion"]);
            Build = Tools.GetStringDef(evt["build"]);
            Language = Tools.GetStringDef(evt["language"]);
        }

        public string GameVersion { get; set; }
        public string Build { get; set; }
        public string Language { get; set; }
    }
}