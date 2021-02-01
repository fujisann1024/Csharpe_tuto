using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ToDoApplication.ToDoApp.Common
{
    public class Database
    {
        private SqlConnection sqlConnection;
        private SqlTransaction sqlTransaction;

        public Database()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"LAPTOP-05JSUJKP\SQLEXPRESS";
            builder.InitialCatalog = "SQLTest";
            builder.IntegratedSecurity = true;
            string connectionString = builder.ToString();

            // SqlConnection の新しいインスタンスを生成 (接続文字列を指定)
            this.sqlConnection = new SqlConnection(connectString);

            // データベース接続を開く
            this.sqlConnection.Open();
        }

        ///<summary>
        /// DB切断
        /// </summary>
        public void Close()
        {
            try
            {
                this.sqlConnection.Close();
            }
            catch (SqlException error)
            {
                Console.WriteLine(error);
            }
            
        }

        ///<summary>
        /// トランザクション開始
        /// </summary>
        public void BeginTransaction()
        {
            try
            {
            this.sqlTransaction = this.sqlConnection.BeginTransaction();
            }
            catch (SqlException error)
            {
                Console.WriteLine(error);
            }  
        }

        ///<summary>
        /// トランザクション コミット
        /// </summary>
        public void Commit()
        {
            if (this.sqlTransaction.Connection != null)
            {
                try
                {
                    this.sqlTransaction.Commit();
                    this.sqlTransaction.Dispose();
                }
                catch (Exception error)
                {
                    Console.WriteLine(error);
                }
                
            }
        }

        ///<summary>
        /// トランザクション ロールバック
        /// </summary>
        public void RollBack()
        {
            if (this.sqlTransaction.Connection != null)
            {
                try
                {
                    this.sqlTransaction.Rollback();
                    this.sqlTransaction.Dispose();
                }
                catch (Exception error)
                {
                    Console.WriteLine(error);
                }
            }
        }

        /// <summary>
        /// クエリー実行
        /// <para name="query">SQL文</para>
        /// <para name="paramDict">SQLパラメータ</para>
        /// </summary>
        public SqlDataReader ExecuteQuery(string query, Dictionary<string, Object> paramDict)
        {
            SqlCommand sqlCommand = new SqlCommand();

            //クエリー送信先、トランザクションの指定
            sqlCommand.Connection = this.sqlConnection;
            sqlCommand.Connection = this.sqlTransaction;

            //SQL文を受け取る
            sqlCommand.CommandText = query;
            foreach (KeyValuePair<string, Object>item in paramDict)
            {
                try
                {
                    sqlCommand.Parameters.Add(new SqlParameter(item.Key, item.Value));
                }
                catch (ArgumentException error)
                {
                    Console.WriteLine(error);
                }

            }

            SqlDataReader reader = sqlCommand.ExecuteReader();

            return reader;
        }

        ///<summary>
        ///クエリー実行(OUTPUT項目あり)
        ///<para name="query">SQL文</para>
        /// </summary>
        public SqlDataReader ExecuteQuery(string query)
        {
            return this.ExecuteQuery(query, new Dictionary<string, object>());
        }

        ///<summary>
        ///クエリー実行(OUTPUT項目なし)
        ///<para name="query">SQL文</para>
        ///<para name="paramDict">SQLパラメータ</para>
        /// </summary>
        
        public void ExecuteNonQuery(string query, Dictionary<string, Object> paramDict)
        {
            SqlCommand sqlCommand = new SqlCommand();

            //クエリー送信先、トランザクションの指定
            sqlCommand.Connection = this.sqlConnection;
            sqlCommand.Connection = this.sqlTransaction;

            //SQL文を受け取る
            sqlCommand.CommandText = query;
            foreach (KeyValuePair<string, Object> item in paramDict)
            {
                try
                {
                    sqlCommand.Parameters.Add(new SqlParameter(item.Key, item.Value));
                }
                catch (ArgumentException error)
                {
                    Console.WriteLine(error);
                }

            }


            sqlCommand.ExecuteNonQuery();
        }
    }
}