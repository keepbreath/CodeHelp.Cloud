using CodeHelp.Interface.Interface_Base;
using CodeHelp.Repository.Repository_Db;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CodeHelp.Repository.Repository_Base
{
    public class BaseRepository : IRepository
    {
        private SqlSugarClient DbClient = null;
        public BaseRepository()
        {
            DbRepository repository = new DbRepository();
            DbClient = repository.CreateClient();
        }
        public int Count<T>(Expression<Func<T, bool>> expression) where T : class, new() => DbClient.Queryable<T>().Count(expression);

        public bool Delete<T>(string id) where T : class, new() => DbClient.Deleteable<T>(id).ExecuteCommand() > 0 ? true : false;

        public bool Delete<T>(Expression<Func<T, bool>> expression) where T : class, new() => DbClient.Deleteable<T>(expression).ExecuteCommand() > 0 ? true : false;

        public T Get<T>(string id) where T : class, new() => DbClient.Queryable<T>().InSingle(id);

        public T Get<T>(Expression<Func<T, bool>> expression) where T : class, new() => DbClient.Queryable<T>().Single(expression);

        public List<T> GetEntities<T>(Expression<Func<T, bool>> expression) where T : class, new() => DbClient.Queryable<T>().Where(expression).ToList();

        public List<T> GetEntities<T>(Expression<Func<T, bool>> expression, Expression<Func<T, object>> order) where T : class, new() => DbClient.Queryable<T>().Where(expression).OrderBy(order, OrderByType.Desc).ToList();

        public List<T> GetEntities<T>(Expression<Func<T, bool>> expression, Expression<Func<T, object>> order, int pageIndex, int pageSize, ref int totalNum) where T : class, new() => DbClient.Queryable<T>().Where(expression).OrderBy(order, OrderByType.Desc).ToPageList(pageIndex, pageSize, ref totalNum);

        public T Insert<T>(T entity) where T : class, new() => DbClient.Insertable<T>(entity).ExecuteReturnEntity();

        public void TranCommit() => DbClient.Ado.CommitTran();

        public void TranRollBack() => DbClient.Ado.RollbackTran();

        public void TranStart() => DbClient.BeginTran();

        public bool Update<T>(T entity) where T : class, new() => DbClient.Updateable<T>(entity).ExecuteCommand() > 0 ? true : false;
    }
}
