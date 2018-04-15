using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AZDotNet.Basic
{
    public static class Logger
    {
        public static void WriteDebug(string content, [CallerMemberName]string name = "Unknown")
        {
            Console.WriteLine("{0}: {1}", name, content);
        }

        public static void WriteWarning(string content, [CallerMemberName]string name = "Unknown")
        {
            Console.WriteLine("{0}: {1}", name, content);
        }

        public static void WriteError(string content, [CallerMemberName]string name = "Unknown")
        {
            Console.WriteLine("{0}: {1}", name, content);
        }
    }
}
