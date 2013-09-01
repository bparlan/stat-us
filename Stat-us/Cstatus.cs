using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using System.ComponentModel;
using System.Diagnostics;

namespace Stat_us
{
    class Cstatus
    {

        public  List<String> GetProcesses()
        {
            List<String> programNames = new List<string>();
            ManagementClass MgmtClass = new ManagementClass("Win32_Process");
            foreach (ManagementObject mo in MgmtClass.GetInstances())
            {
                programNames.Add("Name:" + mo["Name"] + "ID:" + mo["ProcessId"]);
            }

                return programNames;
        }

        public  void GetApplications()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Process p in Process.GetProcesses("."))
            {
                try
                {
                    if (p.MainWindowTitle.Length > 0)
                    {
                        Console.WriteLine("Window Title:" + p.MainWindowTitle.ToString());
                    }
                }
                catch { }
            }
        }
    }
}