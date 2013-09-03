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

        
        
         /*
          * Process EXE'leri Loadlıyor ve listeliyor
          */
         
        public  List<String> GetProcesses()
        {
            List<String> programNames = new List<string>();
            ManagementClass MgmtClass = new ManagementClass("Win32_Process");

            foreach (ManagementObject mo in MgmtClass.GetInstances())
            {
                programNames.Add("Name: " + mo["Name"] + "\t\t ID: " + mo["ProcessId"] + "\t\t Desc: " + mo["OSName"]);
            }

            return programNames;
        }
         

        /*
         * WindowTitle'dan isimleri loadlarsak
         * 1- "windows" çalışmayan process'lerden kurtulmuş oluruz
         * 2- Process Name ile uğraşmadan düzgün uygulama ismi elde etmiş oluruz.
         * */

        public StringBuilder GetApplications()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Process p in Process.GetProcesses("."))
            {
                try
                {
                    if (p.MainWindowTitle.Length > 0)
                    {
                        //Console.WriteLine("Window Title: " + p.MainWindowTitle.ToString());
                        sb.Append("Window Title: " + p.MainWindowTitle.ToString() + Environment.NewLine);
                    }
                }
                catch { }
            }

            return sb.ToString();
        }
    }
}