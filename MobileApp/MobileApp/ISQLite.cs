using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}
