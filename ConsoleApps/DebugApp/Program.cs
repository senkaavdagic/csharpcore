using System;
using static System.Console;
using System.Threading.Tasks;
using SharpPad;
using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;
namespace DebugApp
{
    class Program
    {
        static double Add(double a, double b)
        {
            return a+b; 
        }
        static void Main(string[] args)
        {
           /* double a=4.5;
            double b=3.5;
            double answer = Add(a,b);
            WriteLine($"{a} + {b} = {answer}");
            var complexObject = new 
            {
                FirstName = "Petr",
                BirthDate = new DateTime(year:1972, month:12, day:25),
                Friends = new [] {"Amir", "Jeff", "Lilly"}
            };
            //WriteLine($"Dumping {nameof(complexObject)} to SharpPad.");
            //await complexObject.Dump();
            */
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("Brcko_log.txt")));
            Trace.AutoFlush = true;
            string conf=string.Empty;
            if (args.Length>0)
            {
            conf = args[0];
            } 
            else 
            {
                conf = "Off";
            }
            Debug.WriteLine("Debug...", conf);
            Trace.WriteLine("Trace... Should write to file... ", conf);
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional:true, reloadOnChange:true);
            IConfigurationRoot configuration = builder.Build();
            var ts= new TraceSwitch(
                displayName: "PacktSwitch",
                description: "This switch is set via JSON config."
            );
            configuration.GetSection("PacktSwitch").Bind(ts);
            Trace.WriteLineIf(ts.TraceError, "Trace error");
            Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
            Trace.WriteLineIf(ts.TraceInfo, "Trace information");
            Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");
        }
    }
}
