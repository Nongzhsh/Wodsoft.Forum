using Wodsoft.ComBoost.Data.Entity;

namespace Wodsoft.Forum.Entity
{
    /// <summary>
    /// 论坛
    /// </summary>
    [EntityInterface]
    public interface IForum : IEntity
    {
        /// <summary>
        /// 论坛名称
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 归属板块
        /// </summary>
        IBoard Board { get; set; }
    }
}
