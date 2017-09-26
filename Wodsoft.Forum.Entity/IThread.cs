using System.Collections.Generic;
using Wodsoft.ComBoost.Data.Entity;

namespace Wodsoft.Forum.Entity
{
    /// <summary>
    /// 话题
    /// </summary>
    [EntityInterface]
    public interface IThread : IEntity
    {
        /// <summary>
        /// 话题发起人
        /// </summary>
        IMember Member { get; set; }

        /// <summary>
        /// 归属论坛
        /// </summary>
        IForum Forum { get; set; }

        /// <summary>
        /// 话题标题
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// 话题回复
        /// </summary>
        ICollection<IPost> Replies { get; }
    }
}
