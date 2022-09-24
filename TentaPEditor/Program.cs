using Microsoft.Win32;
using System.Reflection;

namespace TentaPEditor
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            bool didSetRegistry = false;
            if (args.Length == 0)
            {
                try
                {
                    DelReg();
                }
                catch { }
                try
                {
                    AddReg();
                    didSetRegistry = true;
                }
                catch { }
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(args, didSetRegistry));
        }

        private static void AddReg()
        {
            // Create URI Scheme
            RegistryKey scheme = Registry.ClassesRoot.CreateSubKey("tentap");
            scheme.SetValue("URL Protocol", "");

            // Create URI Scheme's action
            var command = scheme.CreateSubKey("shell").CreateSubKey("open").CreateSubKey("command");
            command.SetValue("", $"\"{GetAssemblyName()}\" \"%1\"");
        }

        private static string GetAssemblyName()
        {
            string location = Assembly.GetExecutingAssembly().Location;
            return Path.Combine(Path.GetDirectoryName(location), Path.GetFileNameWithoutExtension(location) + ".exe");
        }

        private static bool RegistryExists()
        {
            string[] keys = Registry.ClassesRoot.GetSubKeyNames();
            string key = keys.Where(x => x.Contains("tentap")).FirstOrDefault();

            return key != null;
        }

        private static void DelReg()
        {
            // Remove keys about URI Scheme for this program
            Registry.ClassesRoot.DeleteSubKeyTree("tentap");
        }
    }
}