using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Stat_us
{
    class Ccategories
    {
        public static statsDataSetTableAdapters.categoriesTableAdapter  categoriesTableAdapter = new statsDataSetTableAdapters.categoriesTableAdapter();
        
        public static DataTable getAll()
        {
            
            return categoriesTableAdapter.GetData();
        }

    }
}
