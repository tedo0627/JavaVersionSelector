using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JavaVersionSelector
{
    public partial class MainForm : Form
    {
        private readonly Dictionary<string, string> versions = new Dictionary<string, string>();
        private readonly List<RadioButton> buttons = new List<RadioButton>();

        public MainForm()
        {
            InitializeComponent();
            Reload();
        }

        private void Reload()
        {
            foreach (RadioButton button in buttons)
            {
                Controls.Remove(button);
            }
            buttons.Clear();
            versions.Clear();

            string java_home = Environment.GetEnvironmentVariable("JAVA_HOME", EnvironmentVariableTarget.Machine);
            IDictionary dictionary = Environment.GetEnvironmentVariables();

            foreach (object key in dictionary.Keys)
            {
                if (!(key is string keyString)) continue;
                if (!keyString.StartsWith("JAVA_")) continue;
                if (keyString.StartsWith("JAVA_HOME")) continue;

                string version = keyString.Replace("JAVA_", "");
                if (!(dictionary[key] is string value)) continue;

                versions.Add(version, value);
            }

            List<string> sortList = new List<string>(versions.Keys);
            sortList.Sort();

            int i = 0;
            foreach (string version in sortList)
            {
                i++;
                RadioButton button = new RadioButton
                {
                    Checked = java_home == versions[version],
                    Text = $"java {version}",
                    Location = new Point(50, 50 + i * 30)
                };
                buttons.Add(button);
                Controls.Add(button);
            }
        }

        private void ApplyButtonClick(object sender, EventArgs e)
        {
            foreach (RadioButton button in buttons)
            {
                if (!button.Checked) continue;
                string version = button.Text.Replace("java ", "");
                
                if (!versions.ContainsKey(version))
                {
                    Reload();
                    return;
                }
                string path = versions[version];
                Environment.SetEnvironmentVariable("JAVA_HOME", path, EnvironmentVariableTarget.Machine);
                return;
            }
        }

        private void ReloadButtonClick(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
