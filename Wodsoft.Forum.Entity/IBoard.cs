using System.Collections.Generic;
using Wodsoft.ComBoost.Data.Entity;

namespace Wodsoft.Forum.Entity
{
    /// <summary>
    /// 板块
    /// </summary>
    [EntityInterface]
    public interface IBoard : IEntity
    {
        /// <summary>
        /// 板块名称
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 板块拥有的论坛
        /// </summary>
        ICollection<IForum> Forums { get; }
    }
}
