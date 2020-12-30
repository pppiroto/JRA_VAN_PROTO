using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;
using System.IO;

namespace JRA_VAN_PROTO.Service
{
    public class DbService
    {
        /// <summary>
        /// 接続文字列生成
        /// </summary>
        /// <param name="host"></param>
        /// <param name="database"></param>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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
    data_type varchar(1) not null,
    rec_key   varchar(100) not null,
    make_date varchar(10) not null,
    data      mediumtext,
    primary key(rec_spec, data_type, rec_key)
)";
                var cmd = new MySqlCommand(createTable);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
        }

        public void Load(string host, string database, string user,string password, string fileName)
        {

            MySqlCommand insCmd =
                new MySqlCommand(
                    @"insert into jra_data ( rec_spec, rec_key, make_date, data_type, data  ) " +
                     " values ( @rec_spec, @rec_key, @make_date, @data_type, @data )");


            using (var conn = new MySqlConnection(GetConnStr(host, database, user, password)))
            {
                conn.Open();

                insCmd.Connection = conn;

                using (var reader = new StreamReader(fileName))
                {
                    string line = null;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var record = line.Split("\t");
                        Debug.WriteLine(line);
                        if (record.Length >= 5)
                        {
                            var recSpec  = record[0];
                            var makeDate = record[1];
                            var dataType = record[2];
                            var recKey   = record[3];
                            var data     = record[4];

                            insCmd.Parameters.Clear();
                            insCmd.Parameters.Add(new MySqlParameter("rec_spec",   recSpec));
                            insCmd.Parameters.Add(new MySqlParameter("rec_key",    recKey));
                            insCmd.Parameters.Add(new MySqlParameter("make_date",  makeDate));
                            insCmd.Parameters.Add(new MySqlParameter("data_type",  dataType));
                            insCmd.Parameters.Add(new MySqlParameter("data",       data));
                            insCmd.ExecuteNonQuery();
                        }
                    }
                }

                //var da = new MySqlDataAdapter("select * from song_element", conn);
                //var ds = new DataSet();
                //da.Fill(ds);

                //foreach (DataTable table in ds.Tables)
                //{
                //    foreach (DataRow row in table.Rows)
                //    {
                //        foreach (DataColumn col in table.Columns)
                //        {
                //            Debug.Write($"{row[col]}\t");
                //        }
                //        Debug.WriteLine("");
                //    }
                //}
            }
        }
    }
}
