using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;

namespace Species
{
    public class SqlCommander
    {

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;

        public SqlCommander()
        {
            OpenFileDialog fbd = new OpenFileDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileLocation = fbd.FileName;
                sql_con = new SQLiteConnection($"Data Source={fileLocation};Version=3;New=False;Compress=True;");
            }
        }

        public void AddStuff(List<string> query)
        {
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            foreach (string s in query)
            {
                sql_cmd.CommandText = s;
                sql_cmd.ExecuteNonQuery();
            }
            sql_con.Close();
        }

    }
}
