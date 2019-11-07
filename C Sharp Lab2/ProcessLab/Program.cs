using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "C:\\Windows\\system32\\notepad.exe";
            myProcess.Start();
        }
    }
}
