using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace TestRegistry
{
    public partial class FormMain : Form
    {
        private string REGISTRY_KEY_NAME = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\BLayout.exe";
        private string REGISTRY_KEY_VALUE_NAME = "dpiAwareness";
        private CImageFileExecutionOptions m_ImageFileExecutionOptions;
        private object curObject;
        private UInt32 m_RegistryKeyValueData = 0;
        private string m_ErrMessage = string.Empty;

        public FormMain()
        {
            InitializeComponent();

            if (0 != ConfigurationManager.AppSettings["REGISTRY_KEY_NAME"].CompareTo(string.Empty))
            {
                REGISTRY_KEY_NAME = ConfigurationManager.AppSettings["REGISTRY_KEY_NAME"];
            }
            if (0 != ConfigurationManager.AppSettings["REGISTRY_KEY_VALUE_NAME"].CompareTo(string.Empty))
            {
                REGISTRY_KEY_VALUE_NAME = ConfigurationManager.AppSettings["REGISTRY_KEY_VALUE_NAME"];
            }
            m_ImageFileExecutionOptions = new CImageFileExecutionOptions(REGISTRY_KEY_NAME, REGISTRY_KEY_VALUE_NAME);
        }

        private void RefreshLabels()
        {
            labelKeyName.Text = string.Format("Key name: HKEY_LOCAL_MACHINE\\{0}", m_ImageFileExecutionOptions.RegistryKeyName);
            labelKeyExists.Text = string.Format("Key value name: {0}. Key exists: {1}", 
                REGISTRY_KEY_VALUE_NAME, m_ImageFileExecutionOptions.RegistryKeyExists.ToString());
        }

        private void SetStatusMessage(string statusMessage)
        {
            this.toolStripStatusLabelMain.Text = statusMessage;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SetStatusMessage(string.Empty);
            RefreshLabels();
        }

        private void buttonGetValue_Click(object sender, EventArgs e)
        {
            if (true == m_ImageFileExecutionOptions.GetValue(ref curObject, ref m_ErrMessage))
            {
                m_RegistryKeyValueData = Convert.ToUInt32(curObject);
                SetStatusMessage(string.Format("{0} data is {1}", REGISTRY_KEY_VALUE_NAME, m_RegistryKeyValueData));
            }
            else
            {
                SetStatusMessage(string.Format("{0} data is does not exists", REGISTRY_KEY_VALUE_NAME));
            }
            RefreshLabels();
        }

        private void buttonSetValue_Click(object sender, EventArgs e)
        {
            m_RegistryKeyValueData = Convert.ToUInt32(numericUpDownKeyValueData.Value);
            if (true == m_ImageFileExecutionOptions.SetValue(m_RegistryKeyValueData, Microsoft.Win32.RegistryValueKind.DWord, ref m_ErrMessage))
            {
                SetStatusMessage(string.Format("{0} data set to {1}", REGISTRY_KEY_VALUE_NAME, m_RegistryKeyValueData));
            }
            else
            {
                SetStatusMessage(string.Format("Error: {0}", m_ErrMessage));
            }
            RefreshLabels();
        }

        private void buttonResetKey_Click(object sender, EventArgs e)
        {
            if (true == m_ImageFileExecutionOptions.Unregister(ref m_ErrMessage))
            {
                SetStatusMessage(string.Format("{0} data has reset", REGISTRY_KEY_VALUE_NAME));
            }
            else
            {
                SetStatusMessage(string.Format("Error: {0}", m_ErrMessage));
            }
            RefreshLabels();
        }

        private void buttonGetOSInfo_Click(object sender, EventArgs e)
        {
            OperatingSystem operatingSystem = Environment.OSVersion;
            bool is64bit = Environment.Is64BitOperatingSystem;
            string OSInfo = CImageFileExecutionOptions.getOSInfo();
            string aMessage = string.Format("OS version: {0} - OS info: {1} - is 64 bit: {2}", operatingSystem, OSInfo, is64bit);
            SetStatusMessage(aMessage);
        }
    }
}
