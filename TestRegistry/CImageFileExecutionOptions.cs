using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace TestRegistry
{
    public class CImageFileExecutionOptions
    {
        private RegistryKey m_registryKey;
        private string m_registryKeyName;
        private string m_registryKeyValueName;

        private string m_ParentKeyName;
        private string m_AppName;

        public CImageFileExecutionOptions(string registryKeyName, string registryKeyValueName) {
            m_registryKeyName = registryKeyName;
            m_registryKeyValueName = registryKeyValueName;
            m_registryKey = Registry.LocalMachine.OpenSubKey(registryKeyName, true);

            int index = registryKeyName.LastIndexOf("\\");
            m_ParentKeyName = registryKeyName.Substring(0, index);
            m_AppName = registryKeyName.Substring(index + 1);
        }

        public bool SetValue(object valueData, RegistryValueKind aRegistryValueKind, ref string aErrMsg) {
            try
            {
                if (null == m_registryKey) {
                    m_registryKey = Registry.LocalMachine.CreateSubKey(m_registryKeyName, true);
                }
                m_registryKey.SetValue(m_registryKeyValueName, valueData, aRegistryValueKind);
                return true;
            }
            catch (Exception ex)
            {
                aErrMsg = ex.Message;
                return false;
            }
        }

        public bool GetValue(ref object valueData, ref string aErrMsg)
        {
            try
            {
                valueData = m_registryKey.GetValue(m_registryKeyValueName);
                return true;
            }
            catch (Exception ex)
            {
                aErrMsg = ex.Message;
                return false;
            }
        }


        public bool Unregister(ref string aErrMsg)
        {
            try
            {
                if (null != m_registryKey)
                {
                    RegistryKey curregistryKey = Registry.LocalMachine.OpenSubKey(m_ParentKeyName, true);
                    curregistryKey.DeleteSubKey(m_AppName);
                    curregistryKey.Dispose();
                }
                m_registryKey.Dispose();
                m_registryKey = null;
                return true;
            }
            catch (Exception ex)
            {
                aErrMsg = ex.Message;
                return false;
            }
        }

        public static string getOSInfo()
        {
            //Get Operating system information.
            OperatingSystem os = Environment.OSVersion;
            //Get version information about the os.
            Version vs = os.Version;

            //Variable to hold our return value
            string operatingSystem = "";

            if (os.Platform == PlatformID.Win32Windows)
            {
                //This is a pre-NT version of Windows
                switch (vs.Minor)
                {
                    case 0:
                        operatingSystem = "95";
                        break;
                    case 10:
                        if (vs.Revision.ToString() == "2222A")
                            operatingSystem = "98SE";
                        else
                            operatingSystem = "98";
                        break;
                    case 90:
                        operatingSystem = "Me";
                        break;
                    default:
                        break;
                }
            }
            else if (os.Platform == PlatformID.Win32NT)
            {
                switch (vs.Major)
                {
                    case 3:
                        operatingSystem = "NT 3.51";
                        break;
                    case 4:
                        operatingSystem = "NT 4.0";
                        break;
                    case 5:
                        if (vs.Minor == 0)
                            operatingSystem = "2000";
                        else
                            operatingSystem = "XP";
                        break;
                    case 6:
                        if (vs.Minor == 0)
                            operatingSystem = "Vista";
                        else if (vs.Minor == 1)
                            operatingSystem = "7";
                        else if (vs.Minor == 2)
                            operatingSystem = "8";
                        else
                            operatingSystem = "8.1";
                        break;
                    case 10:
                        operatingSystem = "10";
                        break;
                    default:
                        break;
                }
            }
            //Make sure we actually got something in our OS check
            //We don't want to just return " Service Pack 2" or " 32-bit"
            //That information is useless without the OS version.
            if (operatingSystem != "")
            {
                //Got something.  Let's prepend "Windows" and get more info.
                operatingSystem = "Windows " + operatingSystem;
                //See if there's a service pack installed.
                if (os.ServicePack != "")
                {
                    //Append it to the OS name.  i.e. "Windows XP Service Pack 3"
                    operatingSystem += " " + os.ServicePack;
                }
                //Append the OS architecture.  i.e. "Windows XP Service Pack 3 32-bit"
                //operatingSystem += " " + getOSArchitecture().ToString() + "-bit";
            }
            //Return the information we've gathered.
            return operatingSystem;
        }

        public string RegistryKeyName {
            get {
                return m_registryKeyName;
            }
        }

        public string RegistryKeyValueName
        {
            get
            {
                return m_registryKeyValueName;
            }
        }

        public bool RegistryKeyExists
        {
            get {
                return (null != m_registryKey);
            }
        }

    }

}
