using System.Windows.Forms;
using Microsoft.Win32;
using Night0wl.Common;

namespace Night0wl.Startup
{
    internal sealed class RegistryManager
    {
        public static void MakeAppRunOnStartup()
        {
            RegistryKey registryKey;
            var isNotStartupApp = IsStartupApp(out registryKey);
            if (isNotStartupApp)
            {
                registryKey.SetValue(Const.APP_KEY, Application.ExecutablePath);
            }
        }

        private static bool IsStartupApp(out RegistryKey registryKey)
        {
            registryKey = Registry.CurrentUser.OpenSubKey(Const.REGISTRY_SUB_KEY, true);
            return registryKey != null && registryKey.GetValue(Const.APP_KEY) == null;
        }
    }
}