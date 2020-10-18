using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeelight_Control.Helpers
{
    public static class YeeControlDeviceHelper
    {
        public static List<YeeControlDevice> GetYeeControlDevices()
        {
            return YeeControlDevice.FromJson(File.ReadAllText(GlobalVariables.PATH_DEVICES));
        }

        public static void SaveYeeControlDevices(List<YeeControlDevice> yeelightControlDevices)
        {
            File.WriteAllText(GlobalVariables.PATH_DEVICES, yeelightControlDevices.ToJson());
        }

        public static List<YeeControlDevice> DeleteYeeControlAtIndex(int index)
        {
            List<YeeControlDevice> yeelightControlDevices = GetYeeControlDevices();
            yeelightControlDevices.RemoveAt(index);
            SaveYeeControlDevices(yeelightControlDevices);

            return GetYeeControlDevices();
        }
    }
}
