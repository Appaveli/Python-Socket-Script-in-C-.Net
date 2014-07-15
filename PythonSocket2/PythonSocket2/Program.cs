using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System.IO;
namespace PythonSocket2
{
    class PythonSocketConnection
    {
        static void Main(string[] args)
        {
            doPython();
        }
        private static void doPython()
        {
            ScriptEngine engine = Python.CreateEngine();
            // This python script is located in the Bin/Debug folder
            engine.ExecuteFile("MyConnection.py");
            Console.ReadLine();
        }

    }
}
