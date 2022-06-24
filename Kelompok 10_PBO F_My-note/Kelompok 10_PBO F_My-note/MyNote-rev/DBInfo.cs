using System;
using System.Collections.Generic;
using System.Text;

namespace MyNote_rev
{
    public class DBInfo
    {
        string server = "localhost";
        string port = "5432";
        string userId = "postgres";
        string pass = "dimas1912";
        string db = "pencatatan";

        public string getArg()
        {
            string arg = "Host=" + server + ";port=" + port + ";User Id=" + userId + ";Password=" + pass + ";Database=" + db + ";";
            return arg;
        }
    }
}
