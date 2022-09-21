using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQL___CSharp__21._09._22_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string ConnectParametr = @"Data source = inventory.db; Version = 3;Mode=ReadWriteCreate;";
            string SQLCommand = "CREATE TABLE workplace " +
                "(id INTEGER PRIMARY KEY ASC AUTOINCREMENT, " +
                "name VARCHAR (1, 50), display  VARCHAR (1, 50), " +
                "keyboard VARCHAR (1, 50), mouse VARCHAR (1, 50));";
            SQLiteConnection _sqlite = new SQLiteConnection(ConnectParametr);
            _sqlite.Open();
            SQLiteCommand cmd = _sqlite.CreateCommand();
            cmd.CommandText = (SQLCommand);
            //SQLiteDataReader _sql = cmd.ExecuteReader();
            SQLCommand = "INSERT INTO workplace" +
                " (name, display, keyboard, mouse) " +
                "VALUES ( 'WorkPC001', 'Disp001', 'Keyboard001', 'Mouse001');";
            cmd.CommandText = (SQLCommand);
            cmd.ExecuteReader();
            //if (_sql.HasRows)
            //{
            //    string _text = "";
            //    while (_sql.Read())
            //    {
            //        _text += "Номер: " + _sql["tel_number"] + "\t\tИмя: " + _sql["name"] + "\n";
            //    }
            //    Console.WriteLine(_text);
            //}
            //else
            //{
            //    Console.WriteLine("Ничего не найдено...");
            //}
            Console.ReadKey();
            _sqlite.Close();
        }
    }
}
