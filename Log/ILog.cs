using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YLM.Common.Log
{
    /// <summary>
    /// 新增日志接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface ILog<T> where T : class
    {
        /// <summary>
        /// 新增日志
        /// </summary>
        /// <param name="t"></param>
        void AddLog(T t);

        /// <summary>
        /// 查询日志
        /// </summary>
        /// <param name="logId"></param>
        /// <returns></returns>
        T Get(int logId);
    }
}
