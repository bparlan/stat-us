using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Stat_us
{
    class  Cprograms
    {
        private static statsDataSetTableAdapters.programsTableAdapter programsTableAdapter = new statsDataSetTableAdapters.programsTableAdapter();
        

        public static DataTable getAll()
        {

            return programsTableAdapter.getAll();
            
        }

        public static void insert(String name, String exe, bool isTracked, String path, int categoryid, bool is_confirmed)
        {
            DataTable table = new DataTable();
            table = programsTableAdapter.get(exe);
            //eğer zaten kayıtlı değil ise kaydet
            if (table.Rows.Count == 0)
            {
                programsTableAdapter.create(name, exe, categoryid, isTracked, path, is_confirmed);
            }
        }

        public static DataTable getAllTracked()
        {

            return programsTableAdapter.getAllTracked();

        }

        public static DataTable getAllIgnored()
        {

            return programsTableAdapter.getAllIgnored();

        }

        public static DataTable getAllUnconfirmed()
        {

            return programsTableAdapter.getAllUnconfirmed();

        }

        public static void hide(String exe)
        {
            //same as untrack
            programsTableAdapter.hide(exe);
            programsTableAdapter.confirm(exe);
        }

        public static void track(String exe)
        {
            
            programsTableAdapter.track(exe);
            programsTableAdapter.confirm(exe);
        }

        public static void update(int programId, String title, int categoryid)
        {

            programsTableAdapter.update(title, categoryid, programId);

        }
        

    }
}
