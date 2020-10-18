using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeelight_Control.Helpers
{
    public static class YeeControlPresetHelper
    {
        public static List<YeeControlPreset> GetYeeControlPresets()
        {
            return YeeControlPreset.FromJson(File.ReadAllText(GlobalVariables.PATH_PRESETS));
        }

        public static void SaveYeeControlPresets(List<YeeControlPreset> yeelightPresets)
        {
            File.WriteAllText(GlobalVariables.PATH_PRESETS, yeelightPresets.ToJson());
        }

        public static List<YeeControlPreset> DeleteYeeControlPresetAtIndex(int index)
        {
            List<YeeControlPreset> yeelightPresets = GetYeeControlPresets();
            yeelightPresets.RemoveAt(index);
            SaveYeeControlPresets(yeelightPresets);

            return GetYeeControlPresets();
        }
    }
}
