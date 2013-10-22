using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using Microsoft.Win32;
using System.Data;
using System.Data.OleDb;



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
                programNames.Add(mo["Name"].ToString());
                //programNames.Add("Name: " + mo["Name"] + "\t\t ID: " + mo["ProcessId"] + "\t\t Path: " + mo["ExecutablePath"]);
            }
            programNames = programNames.Distinct().ToList();

            return programNames;
        }

        public List<String> GetUnregistredProcesses()
        {
            List<String> programNames = new List<string>();
            ManagementClass MgmtClass = new ManagementClass("Win32_Process");

            foreach (ManagementObject mo in MgmtClass.GetInstances())
            {
                programNames.Add(mo["Name"].ToString());
                //programNames.Add("Name: " + mo["Name"] + "\t\t ID: " + mo["ProcessId"] + "\t\t Path: " + mo["ExecutablePath"]);
            }
            programNames = programNames.Distinct().ToList();
            DataTable dbPrograms = new DataTable();

            dbPrograms = Cprograms.getAll();
            
            List<string> dbList = dbPrograms.AsEnumerable()
                           .Select(r => r.Field<string>("exe"))
                           .ToList();

            List<String> difList = programNames.Except(dbList).ToList();

            return difList;
        }
          
       
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


        
        
        public List<String> GetInstalled()
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