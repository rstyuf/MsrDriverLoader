using Ring0DriverLoader.Interop;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Ring0DriverLoader
{
 
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //NativeMethods.AllocConsole();
            Console.WriteLine("++++ Ring0 Driver Loader ++++");
            if (args.Length < 1 || args[0] == "keep_open")
            {
                Console.WriteLine("### Loading driver ###");
                Ring0.Open();
                Console.WriteLine("< Loaded: will keep open until closed by pressing ENTER key >");
                Console.ReadLine();

                Console.WriteLine("--- Unloading driver ---");
                Ring0.Close();
                Console.WriteLine(" Goodbye! ");

                // Console.WriteLine("Need an argument: Either 'load' or 'unload' or 'keep_open'");
                // Console.WriteLine("Note: 'unload' currently doesn't work yet so 'keep_open' is recommended");
            }
            else if (args[0] == "load")
            {
                Console.WriteLine("### Loading driver ###");
                Ring0.Open();
            }
            else if (args[0] == "unload")
            {
                Console.WriteLine("--- Unloading driver ---");
                Ring0.Close();
            }
            /*else if (args[0] == "keep_open")
            {
                Console.WriteLine("### Loading driver ###");
                Ring0.Open();
                Console.WriteLine("< Loaded: will keep open until closed by pressing ENTER key >");
                Console.ReadLine();

                Console.WriteLine("--- Unloading driver ---");
                Ring0.Close();
                Console.WriteLine(" Goodbye! ");

            }*/
            else
            {
                Console.WriteLine("Need an argument: Either 'load' or 'unload' or 'keep_open'");
                Console.WriteLine("Note: 'unload' currently doesn't work yet so 'keep_open' is recommended");
            }

        }
    }
}
