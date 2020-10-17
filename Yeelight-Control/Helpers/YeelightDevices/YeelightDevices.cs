using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeelight_Control.Helpers.YeelightDevices
{
    public static class YeelightDevices
    {
        public static List<YeelightControlDevice> GetYeelightControlDevices()
        {
            return YeelightControlDevice.FromJson(File.ReadAllText(GlobalVariables.PATH_DEVICES));
        }

        public static void SaveYeelightControlDevices(List<YeelightControlDevice> yeelightControlDevices)
        {
            File.WriteAllText(GlobalVariables.PATH_DEVICES, yeelightControlDevices.ToJson());
        }

        public static List<YeelightControlDevice> DeleteYeelightControlAtIndex(int index)
        {
            List<YeelightControlDevice> yeelightControlDevices = GetYeelightControlDevices();
            yeelightControlDevices.RemoveAt(index);
            SaveYeelightControlDevices(yeelightControlDevices);

            return GetYeelightControlDevices();
        }
    }
}
