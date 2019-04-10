using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace engine.db
{
    public class MysqlAdapter : IDbAdapter
    {
        string server = null;
        string userName = null;
        string password = null;
        string database = null;
        string port = "3306";
        string charset = "UTF8";

        public MysqlAdapter() { }
        public MysqlAdapter SetServer(string server)
        {
            this.server = server;
            return this;
        }

        public MysqlAdapter SetUsername(string userid)
        {
            this.userName = userid;
            return this;
        }

        public MysqlAdapter SetDataBase(string database)
        {
            this.database = database;
            return this;
        }

        public MysqlAdapter SetPassword(string password)
        {
            this.password = password;
            return this;
        }
        public MysqlAdapter SetPort(string port)
        {
            this.port = port;
            return this;
        }
        public MysqlAdapter SetCharset(string charset)
        {
            this.charset = charset;
            return this;
        }
        #region  建立MySql数据库连接
        /// <summary>
        /// 建立数据库连接.
        /// </summary>
        /// <returns>返回MySqlConnection对象</returns>
        public  MySqlConnection GetConnection()
        {
            string M_str_sqlcon = string.Format("server={0};user id={1};password={2};database={3};port={4};Charset={5};SslMode = none", server, userName, password, database, port, charset);
            MySqlConnection myCon = new MySqlConnection(M_str_sqlcon);
            return myCon;
        }
        #endregion
        #region IDatabaseAdapter接口实现
        List<DbColumn> IDbAdapter.GetColumns(String tableName)
        {
            List<DbColumn> cols = new List<DbColumn>();
            //try
            //{
                String sql = String.Format(
                    @"select 
                    table_name,
                    column_name, 
                    column_comment,
                    is_nullable,
                    data_type,
                    character_maximum_length 
                    from 
                    information_schema.columns 
                    where 
                    table_schema ='{0}' and table_name = '{1}'"
                    , database, tableName);
                MySqlConnection conn = this.GetConnection();
                MySqlCommand mysqlcom = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = mysqlcom.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    DbColumn col = new DbColumn();
                    if(reader.GetString("table_name") != null)
                    {
                        col.TableName = reader.GetString("table_name");
                    }
                    if (reader.GetString("column_name") != null)
                    {
                        col.ColumnName = (String)reader["column_name"];
                    }
                    if (reader.GetString("column_comment") != null)
                    {
                        col.ColumnComment = reader.GetString("column_comment");
                    }
                    if (reader.GetString("is_nullable") != null)
                    {
                        col.IsNullable = reader.GetString("is_nullable");
                    }
                    if (reader.GetString("data_type") != null)
                    {
                        col.ColumnType = reader.GetString("data_type");
                    }
                    if (reader["character_maximum_length"].ToString() != "")
                    {
                        col.ColumnLength = reader.GetUInt32("character_maximum_length");
                    }

                    cols.Add(col);
                }
            //}catch(Exception ex)
            //{
            //    //do nth
            //}
            return cols;
        }
        List<string> IDbAdapter.GetTables()
        {
            List<String> tables = new List<string>();
            try
            {
                String sql = String.Format("select table_name from information_schema.tables where table_schema = '{0}'", database);
                MySqlConnection conn = this.GetConnection();
                MySqlCommand mysqlcom = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = mysqlcom.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        tables.Add((String)reader.GetValue(i));
                    }
                }
                conn.Close();
            }catch(Exception ex)
            {
                   // do nth
            }
            return tables;
        }
        #endregion
    }
}
