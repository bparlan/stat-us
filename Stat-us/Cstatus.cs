using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using System.ComponentModel;
using System.Diagnostics;
using Microsoft.Win32;



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
                programNames.Add("Name: " + mo["Name"] + "\t\t ID: " + mo["ProcessId"] + "\t\t Path: " + mo["ExecutablePath"]);
            }

            return programNames;
        }
         

        /*
         * WindowTitle'dan isimleri loadlarsak
         * 1- "windows" çalışmayan process'lerden kurtulmuş oluruz
         * 2- Process Name ile uğraşmadan düzgün uygulama ismi elde etmiş oluruz.
         * */

        public  List<String>  GetApplications()
        {
            List<String> programNames = new List<string>();
            foreach (Process p in Process.GetProcesses("."))
            {
                try
                {
                    if (p.MainWindowTitle.Length > 0)
                    {
                        programNames.Add(p.MainWindowTitle.ToString());
                    }
                }
                catch { }
            }

            return programNames;
        }

        /*
        public List<String> GetInstalled()
        {
            List<String> programNames = new List<string>();
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_Product");
            foreach (ManagementObject mo in mos.Get())
            {
                programNames.Add(mo["Name"].ToString());
            }

            return programNames;
        }*/
        
        public List<String> GetInstalled2()
        {
            string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            List<String> programNames = new List<string>();
            using (Microsoft.Win32.RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key))
            {
                foreach (string subkey_name in key.GetSubKeyNames())
                {
                    using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                    {
                        try
                        {
                            programNames.Add(subkey.GetValue("DisplayName").ToString());
                        }
                        catch(Exception e){

                        }
                    }
                }
            }

            return programNames;
        }


    }
}