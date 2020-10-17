using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Globalization;
using Yeelight_Control.Helpers.YeelightDevices;

namespace Yeelight_Control.Helpers
{
    public static class Serialize
    {
        public static string ToJson(this List<YeelightPreset> self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this List<YeelightControlDevice> self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
