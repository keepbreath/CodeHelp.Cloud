using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CodeHelp.Interface.Interface_Base
{
    public interface IRepository
    {
        #region Tran
        /// <summary>
        /// 开始事务
        /// </summary>
        /// <returns></returns>
        void TranStart();
        /// <summary>
        /// 事务回滚
        /// </summary>
        /// <param name="tran"></param>
        void TranRollBack();
        /// <summary>
        /// 提交事务
        /// </summary>
        /// <param name="tran"></param>
        void TranCommit();
        #endregion

        #region Get
        /// <summary>
        /// 获取实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id">主键</param>
        T Get<T>(string id) where T : class, new();
        /// <summary>
        /// 获取实体 - 筛选
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression">查询条件</param>
        /// <returns></returns>
        T Get<T>(Expression<Func<T, bool>> expression) where T : class, new();
        /// <summary>
        /// 获取数量
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression"></param>
        /// <returns></returns>
        int Count<T>(Expression<Func<T, bool>> expression) where T : class, new();
        /// <summary>
        /// 获取集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression">查询条件</param>
        /// <returns></returns>
        List<T> GetEntities<T>(Expression<Func<T, bool>> expression) where T : class, new();
        /// <summary>
        /// 获取集合 - 排序
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression">查询条件</param>
        /// <param name="order">排序条件</param>
        /// <returns></returns>
        List<T> GetEntities<T>(Expression<Func<T, bool>> expression, Expression<Func<T, object>> order) where T : class, new();
        /// <summary>
        /// 获取集合 - 排序 - 分页
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression">查询条件</param>
        /// <param name="pageIndex">第几页</param>
        /// <param name="pageSize">每页条数</param>
        /// <returns></returns>
        List<T> GetEntities<T>(Expression<Func<T, bool>> expression, Expression<Func<T, object>> order, int pageIndex, int pageSize, ref int totalNum) where T : class, new();
        #endregion

        #region Insert
        /// <summary>
        /// 插入实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        T Insert<T>(T entity) where T : class, new();
        #endregion

        #region Update
        bool Update<T>(T entity) where T : class, new();
        #endregion

        #region Delete
        /// <summary>
        /// 删除实体 - 通过主键
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id">主键</param>
        /// <returns></returns>
        bool Delete<T>(string id) where T : class, new();
        /// <summary>
        /// 删除实体 - 通过条件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression"></param>
        /// <returns></returns>
        bool Delete<T>(Expression<Func<T, bool>> expression) where T : class, new();
        #endregion
    }
}
