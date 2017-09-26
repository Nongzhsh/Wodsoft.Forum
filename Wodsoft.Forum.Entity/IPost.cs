using Wodsoft.ComBoost.Data.Entity;

namespace Wodsoft.Forum.Entity
{
    /// <summary>
    /// 话题回复
    /// </summary>
    [EntityInterface]
    public interface IPost : IEntity
    {
        /// <summary>
        /// 回复用户
        /// </summary>
        IMember Member { get; set; }

        /// <summary>
        /// 回复内容
        /// </summary>
        string Content { get; set; }

        /// <summary>
        /// 回复的话题
        /// </summary>
        IThread Thread { get; set; }
    }
}
