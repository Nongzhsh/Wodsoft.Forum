using System.Collections.Generic;
using Wodsoft.ComBoost.Data.Entity;

namespace Wodsoft.Forum.Entity
{
    /// <summary>
    /// 论坛用户
    /// </summary>
    [EntityInterface]
    public interface IMember : IEntity
    {
        /// <summary>
        /// 用户名
        /// </summary>
        string Username { get; set; }

        /// <summary>
        /// 用户发起的话题
        /// </summary>
        ICollection<IThread> Threads { get; }
    }
}
