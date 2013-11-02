using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Stat_us
{
    class Csessions
    {
        private static statsDataSetTableAdapters.sessionsTableAdapter sessionTableAdapter;

        static Csessions()
        {
            sessionTableAdapter = new statsDataSetTableAdapters.sessionsTableAdapter();
            
        }

        public static DataTable getAll()
        {

            return sessionTableAdapter.GetData();
        }

        public static void closeAll()
        {
            sessionTableAdapter.closeAll();
        }

        public static void close(int programId)
        {
            sessionTableAdapter.close(programId);
        }

        public static DataTable get(int programId)
        {
            return sessionTableAdapter.get(programId);
            
        }

        public static DataTable getOpen(int programId)
        {
            return sessionTableAdapter.getOpen(programId);

        }

        public static void create(int programId)
        {
            sessionTableAdapter.create(programId);
        }

        public static void update(int programId, int passedTime) 
        {
            sessionTableAdapter.update(passedTime, programId);
        }

        public static Double getTotalTime(int programId)
        {
            statsDataSetTableAdapters.sessionsTableAdapter ta = new statsDataSetTableAdapters.sessionsTableAdapter();
            Double time = Convert.ToDouble(ta.getTotalTime(programId));
            return time;
        }

        public static Double getTodayTotalTime(int programId)
        {
            statsDataSetTableAdapters.sessionsTableAdapter ta = new statsDataSetTableAdapters.sessionsTableAdapter();
            Double time = Convert.ToDouble(ta.getTodayTotalTime(programId));
            return time;
        }

        public static void delete(int programId)
        {
            sessionTableAdapter.delete(programId);
        }



        internal static int getTotalStart(int programId)
        {
            statsDataSetTableAdapters.sessionsTableAdapter ta = new statsDataSetTableAdapters.sessionsTableAdapter();
            return Convert.ToInt32(ta.getTotalStart(programId));
        }
    }
}
