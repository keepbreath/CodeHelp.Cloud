using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeHelp.Repository.Repository_Base
{
    public class DbRepository
    {
        private readonly string _connStr;
        public DbRepository()
        {
            _connStr = "server=localhost;port=3306;userid=root;password=y0918s;database=db_report";
        }
        /// <summary>
        /// 创建数据库连接对象
        /// </summary>
        /// <returns></returns>
        public SqlSugarClient CreateClient()
        {
            SqlSugarClient db = new SqlSugarClient(
                new ConnectionConfig()
                {
                    ConnectionString = _connStr,
                    DbType = DbType.MySql,//设置数据库类型
                    IsAutoCloseConnection = true,//自动释放数据务，如果存在事务，在事务结束后释放
                    InitKeyType = InitKeyType.Attribute //从实体特性中读取主键自增列信息
                });
            return db;
        }
        /// <summary>
        /// 创建数据库表
        /// </summary>
        public void CodeFirst_CreateTable<T>() where T:class
        {
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = _connStr,
                DbType = DbType.MySql,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute
            });
            //db.CodeFirst.BackupTable().InitTables(typeof(T), typeof(T));
            db.CodeFirst.InitTables(typeof(T), typeof(T));
        }
        /// <summary>
        /// 创建数据库表
        /// </summary>
        public void DbFirst_CreateClass(string path,string nameSpace)
        {
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = _connStr,
                DbType = DbType.MySql,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute
            });
            db.DbFirst.IsCreateDefaultValue().IsCreateAttribute().CreateClassFile(path, nameSpace);
        }
    }
}
