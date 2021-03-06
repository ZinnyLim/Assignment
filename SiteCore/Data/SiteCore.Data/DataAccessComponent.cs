﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteCore.Data
{
    public abstract class DataAccessComponent
    {
        protected const string CONNECTION_NAME = "default";


        protected T GetDataValue<T>(IDataReader dr, string columnName)
        {
            // NOTE: GetOrdinal() is used to automatically determine where the column
            //       is physically located in the database table. This allows the
            //       schema to be changed without affecting this piece of code.
            //       This of course sacrifices a little performance for maintainability.
            int i = dr.GetOrdinal(columnName);

            if (!dr.IsDBNull(i))
                return (T)dr.GetValue(i);
            else
                return default(T);
        }
    }
}
