using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yeelight_Control.Helpers;
using Yeelight_Control.Helpers.YeelightDevices;
using YeelightAPI;

namespace Yeelight_Control
{
    public partial class MainForm : Form
    {
        DeviceGroup allDevices = new DeviceGroup();
        CancellationTokenSource cts = new CancellationTokenSource();
        Size defaultSize = new Size(580, 345);
        Size expandedSize = new Size(580, 525);

        List<YeelightPreset> savedYeelightStates = new List<YeelightPreset>();
        int selectedPreset = -1;

        Dictionary<int, string> hostnamesByListIndex = new Dictionary<int, string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "YeeControl " + GlobalVariables.VERSION + " | www.yeecontrol.com";
            foreach (YeelightControlDevice ycd in YeelightDevices.GetYeelightControlDevices())
            {
                allDevices.Add(new Device(ycd.Hostname));
            }
            allDevices.Connect();

            this.Size = defaultSize;

            if(!File.Exists(GlobalVariables.PATH_PRESETS))
            {
                File.WriteAllText(GlobalVariables.PATH_PRESETS, "[]");
            }

            RefreshPresets();
            RefreshCheckedListBox();
            RefreshLightState();

            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;

            RT(() => RefreshLightState(), 7, cts.Token);
        }

        private void RefreshPresets()
        {
            savedYeelightStates = YeelightPreset.FromJson(File.ReadAllText(GlobalVariables.PATH_PRESETS));
            listBox1.Items.Clear();
            foreach(YeelightPreset savedYeelightState in savedYeelightStates)
            {
                listBox1.Items.Add(savedYeelightState.Name);
            }
            selectedPreset = -1;
            groupBox_Edit.Enabled = false;
        }

        private void RefreshCheckedListBox()
        {
            checkedListBox_Devices.Items.Clear();
            hostnamesByListIndex.Clear();

            int index = 0;
            foreach (Device d in allDevices)
            {
                checkedListBox_Devices.Items.Add(d.Hostname);
                hostnamesByListIndex.Add(index, d.Hostname);
                index++;
            }

            for (int i = 0; i < checkedListBox_Devices.Items.Count; i++)
            {
                checkedListBox_Devices.SetItemChecked(i, true);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string curItem = listBox1.SelectedItem?.ToString();
            if (curItem is string)
            {
                YeelightPreset state = savedYeelightStates[listBox1.SelectedIndex];
                selectedPreset = listBox1.SelectedIndex;
                textBox_Rename.Text = state.Name;

                ReconnectIfNeeded();
                for (int i = 0; i < state.Bulbs.Count; i++)
                {
                    Device d = GetDeviceByHostname(state.Bulbs[i].Hostname);
                    if (d is Device)
                    {
                        d.SetPower(state.Bulbs[i].Power);
                        d.SetRGBColor(state.Bulbs[i].Color.R, state.Bulbs[i].Color.G, state.Bulbs[i].Color.B);
                        d.SetBrightness(state.Bulbs[i].Brightness);
                        if (state.Bulbs[i].Temperature.HasValue)
                        {
                            d.SetColorTemperature(state.Bulbs[i].Temperature.Value);
                        }
                    }
                }

                groupBox_Edit.Enabled = true;
            }
        }

        private Device GetDeviceByHostname(string hostname)
        {
            foreach(Device d in allDevices)
            {
                if (d.Hostname == hostname)
                    return d;
            }

            return null;
        }

        private void ReconnectIfNeeded()
        {
            foreach (Device d in allDevices)
                if (!d.IsConnected)
                    d.Connect(); 
        }

        private async void RefreshLightState()
        {
            try
            {
                ReconnectIfNeeded();
                for (int i = 0; i < checkedListBox_Devices.Items.Count; i++)
                {
                    string hostname = hostnamesByListIndex[i];
                    Device device = GetDeviceByHostname(hostname);
                    Dictionary<YeelightAPI.Models.PROPERTIES, object> props = await device.GetAllProps();

                    string text = props[YeelightAPI.Models.PROPERTIES.name].ToString();
                    text += " [" + hostname + "]";
                    text += " - ";
                    if (props[YeelightAPI.Models.PROPERTIES.power].ToString() == "on")
                    {
                        string color = "";
                        if (props[YeelightAPI.Models.PROPERTIES.color_mode].ToString() == "1") //RGB Mode
                        {
                            Color c = GetColorFromInt(int.Parse(props[YeelightAPI.Models.PROPERTIES.rgb].ToString()));
                            color = "(" + c.R + ", " + c.G + ", " + c.B + ")";
                        }
                        else
                        {
                            color = props[YeelightAPI.Models.PROPERTIES.ct].ToString() + "K";
                        }
                        string bright = props[YeelightAPI.Models.PROPERTIES.bright].ToString() + "%";

                        text += "ON, " + color + ", " + bright;
                    }
                    else
                    {
                        text += "OFF";
                    }

                    checkedListBox_Devices.BeginInvoke((MethodInvoker)delegate ()
                    {
                        checkedListBox_Devices.Items[i - 1] = text;
                    });
                }
            }
            catch (Exception) { }
        }

        static void RT(Action action, int seconds, CancellationToken token)
        {
            if (action == null)
                return;
            Task.Run(async () => {
                while (!token.IsCancellationRequested)
                {
                    action();
                    await Task.Delay(TimeSpan.FromSeconds(seconds), token);
                }
            }, token);
        }

        private void button_ToggleOn_Click(object sender, EventArgs e)
        {
            ReconnectIfNeeded();
            GetSelectedLights().TurnOn();
        }

        private void button_ToggleOff_Click(object sender, EventArgs e)
        {
            ReconnectIfNeeded();
            GetSelectedLights().TurnOff();
        }

        public DeviceGroup GetSelectedLights()
        {
            DeviceGroup devices = new DeviceGroup();




            for(int i = 0; i < checkedListBox_Devices.Items.Count; i++)
            {
                string hostname = hostnamesByListIndex[i];
                if (checkedListBox_Devices.GetItemChecked(i))
                {
                    foreach (Device d in allDevices)
                    {
                        if (d.Hostname == hostname)
                        {
                            devices.Add(d);
                        }
                    }
                }
            }


            return devices;
        }

        private void button_Color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ReconnectIfNeeded();
                GetSelectedLights().SetRGBColor(colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
            }
        }

        private void trackBarBrightness_Scroll(object sender, EventArgs e)
        {
            label_Brightness.Text = trackBarBrightness.Value + "%";
        }

        private void button_Brightness_Click(object sender, EventArgs e)
        {
            ReconnectIfNeeded();
            GetSelectedLights().SetBrightness(trackBarBrightness.Value);
        }

        private void button_White_Click(object sender, EventArgs e)
        {
            ReconnectIfNeeded();
            GetSelectedLights().SetColorTemperature(4000);
        }

        private void button_Dropdown_Click(object sender, EventArgs e)
        {
            this.Size = (this.Size == expandedSize ? defaultSize : expandedSize);
        }

        private async void button_SavePreset_Click(object sender, EventArgs e)
        {
            if(textBox_Preset.Text.Length >= 1)
            {
                YeelightPreset saved = new YeelightPreset();
                saved.Name = textBox_Preset.Text;
                saved.Bulbs = new List<Bulb>(); 
                foreach(Device device in allDevices)
                {
                    saved.Bulbs.Add(await GetBulb(device));
                }
                savedYeelightStates.Add(saved);

                SaveYeelightState();
            }
        }

        private async Task<Bulb> GetBulb(Device device)
        {
            Dictionary<YeelightAPI.Models.PROPERTIES, object> props = await device.GetAllProps();

            bool rgbMode = (props[YeelightAPI.Models.PROPERTIES.color_mode].ToString() == "1");

            Bulb b = new Bulb();
            b.Hostname = device.Hostname;
            b.Power = (props[YeelightAPI.Models.PROPERTIES.power].ToString() == "on");
            Color c = GetColorFromInt(int.Parse(props[YeelightAPI.Models.PROPERTIES.rgb].ToString()));
            b.Color = new YeelightColor();
            b.Color.R = c.R;
            b.Color.G = c.G;
            b.Color.B = c.B;
            b.Brightness = int.Parse(props[YeelightAPI.Models.PROPERTIES.bright].ToString());
            if (!rgbMode)
            {
                b.Temperature = int.Parse(props[YeelightAPI.Models.PROPERTIES.ct].ToString());
            }

            return b;
        }

        private Color GetColorFromInt(int color)
        {
            return Color.FromArgb(color);
        }

        private void SaveYeelightState()
        {
            File.WriteAllText(GlobalVariables.PATH_PRESETS, Serialize.ToJson(savedYeelightStates));
            RefreshPresets();
        }

        private void button_Rename_Click(object sender, EventArgs e)
        {

            if (textBox_Rename.Text.Length >= 1)
            {
                savedYeelightStates[selectedPreset].Name = textBox_Rename.Text;


                SaveYeelightState();
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            savedYeelightStates.RemoveAt(selectedPreset);
            SaveYeelightState();
        }

        private async void button_Overwrite_Click(object sender, EventArgs e)
        {
            List<Bulb> bulbs = new List<Bulb>();
            foreach (Device device in allDevices)
            {
                bulbs.Add(await GetBulb(device));
            }
            savedYeelightStates[selectedPreset].Bulbs = bulbs;

            SaveYeelightState();
        }

        private void trackBarTemperature_Scroll(object sender, EventArgs e)
        {
            label_Temperature.Text = trackBarTemperature.Value + "K";
        }

        private void button_Temperature_Click(object sender, EventArgs e)
        {
            ReconnectIfNeeded();
            GetSelectedLights().SetColorTemperature(trackBarTemperature.Value);
        }






        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            allDevices.Disconnect();
            cts.Cancel();
            Application.Exit();
        }

        private void button_Devices_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
