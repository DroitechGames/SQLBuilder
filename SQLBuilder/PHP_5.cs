using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLBuilder
{
    class PHP_5_MySQLi
    {
        public string UseMySQLi(string _SQLi_HOST, string _SQLi_USER, string _SQLi_PASS, string _SQLi_CONNECTION_VAR, string _SQLi_CUSTOM_ERROR_MSG)
        {
            // create mysqli sql code from here.

            string _H = _SQLi_HOST;
            string _U = _SQLi_USER;
            string _P = _SQLi_PASS;
            
            //////////////////////////////////////////////
            // db dynamic variables.
            string _DB_VAR = "$";

            // set connection variable
            string _DB_VAR_STRING = _SQLi_CONNECTION_VAR;
            string _DB_SQLI = _DB_VAR + _DB_VAR_STRING + " = new mysqli(";
            // create connection string.
            string _CNX_DBCONNECT = "<?php " + Environment.NewLine + Environment.NewLine + _DB_SQLI + " " + _H + "," + _U + "," + _P + ");" + Environment.NewLine + Environment.NewLine; // create connection.

            // php connection params.
            string _CNX_ER = "connect_error";
            string _CNX_DIE = Environment.NewLine + "die";
            string _CNX_IF = "if";

            // Check Connection string...
            string _CNX_IFS = _CNX_IF + " ( " + _DB_VAR + _DB_VAR_STRING + "->" + _CNX_ER + ")" + " { " + _CNX_DIE + "( ";
            // build first part.

            string _CNX_IFS_2   = "'" + _SQLi_CUSTOM_ERROR_MSG + "' . ";
            // build second part

            string _CNX_IFS_3 = _DB_VAR + _DB_VAR_STRING + "->" + _CNX_ER + ");"  + Environment.NewLine  +"}";
            // build third part
            string _CNX_ECHO = Environment.NewLine + Environment.NewLine + "echo 'Connected Successfully';" + Environment.NewLine + "?>";
            // combine the php if statement.

            string _CNX_IF_FINAL = _CNX_DBCONNECT + _CNX_IFS + _CNX_IFS_2 + _CNX_IFS_3 + _CNX_ECHO;
            
            // final combined string.

            return _CNX_IF_FINAL;
        }
    }
    class PHP_5_PDO
    {
        public void UsePDO()
        {
            // create pdo code here...
        }
    }
}
