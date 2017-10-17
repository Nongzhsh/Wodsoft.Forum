﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Wodsoft.ComBoost.Data.Entity;
using Wodsoft.Forum;

namespace Wodsoft.Forum.Sample.Entity
{
    [DisplayName("论坛")]
    [DisplayColumn("Name", "Order", false)]
    [EntityAuthentication(AllowAnonymous = false,
        AddRolesRequired = new object[] { AdminType.Admin },
        EditRolesRequired = new object[] { AdminType.Admin },
        RemoveRolesRequired = new object[] { AdminType.Admin })]
    public class Forum : EntityBase, IForum
    {
        [Display(Name = "论坛说明", Order = 20)]
        public virtual string Description { get; set; }

        [Display(Name = "论坛名称", Order = 10)]
        [Required]
        [Searchable]
        public virtual string Name { get; set; }

        [Hide]
        public virtual Guid BoardId { get; set; }
        private Board _Board;
        [Display(Name = "所属板块", Order = 0)]
        [Required]
        [ForeignKey("BoardId")]
        public virtual Board Board { get { return _Board; } set { _Board = value; BoardId = value?.Index ?? Guid.Empty; } }

        [Display(Name = "图标", Order = 30)]
        [CustomDataType(CustomDataType.Image)]
        public virtual string Image { get; set; }

        [Display(Name = "排序", Order = 40)]
        [Required]
        public virtual int Order { get; set; }

        [Display(Name = "是否显示", Order = 50)]
        [Required]
        public virtual bool IsDisplay { get; set; }

        IBoard IForum.Board { get { return Board; } set { Board = (Board)value; } }

        [Hide]
        public virtual ICollection<Thread> Threads { get; set; }
    }
}
