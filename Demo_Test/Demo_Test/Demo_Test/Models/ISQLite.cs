using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Test.Models
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
