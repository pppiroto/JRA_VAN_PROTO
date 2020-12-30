using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

namespace JRA_VAN_PROTO.Service
{
    public class DbService
    {
        private string GetConnStr(string host, string database, string user, string password)
        { 
            return $"Database={database};Data Source={host};User Id={user};Password={password}; pooling = false; convert zero datetime=True";
        }

        public void CreateTable(string host, string database, string user, string password)
        {
            // create database jra default character set utf8;
            // create user 'jra'@'localhost' identified by 'new password';
            // create user 'jra'@'%' identified by 'new password';
            // grant all privileges on *.* to 'jra'@'%' with grant option;

            using (var conn = new MySqlConnection(GetConnStr(host, database, user, password)))
            {
                conn.Open();

               var createTable = @"
create table jra_data (
    rec_spec  varchar(2) not null,
    rec_key   varchar(100) not null,
    make_date varchar(10) not null,
    data_type varchar(1) not null,
    data      mediumtext,
    primary key(rec_spec, rec_key)
)";
                var cmd = new MySqlCommand(createTable);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
        }

        public void Load(string host, string database, string user,string password, string fileName)
        {

            using (var conn = new MySqlConnection(GetConnStr(host,database,user,password)))
            {
                conn.Open();

                var da = new MySqlDataAdapter("select * from song_element", conn);
                var ds = new DataSet();
                da.Fill(ds);

                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        foreach (DataColumn col in table.Columns)
                        {
                            Debug.Write($"{row[col]}\t");
                        }
                        Debug.WriteLine("");
                    }
                }
            }
        }
    }
}
