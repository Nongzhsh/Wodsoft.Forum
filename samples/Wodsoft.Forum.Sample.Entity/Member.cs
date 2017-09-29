﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Wodsoft.ComBoost;
using Wodsoft.ComBoost.Data.Entity;
using Wodsoft.Forum;

namespace Wodsoft.Forum.Sample.Entity
{
    [DisplayColumn("Username", "CreateDate", true)]
    [DisplayName("用户")]
    [EntityAuthentication(AllowAnonymous = false,
        AddRolesRequired = new object[] { AdminType.Admin },
        EditRolesRequired = new object[] { AdminType.Admin },
        RemoveRolesRequired = new object[] { AdminType.Admin })]
    public class Member : UserBase, IMember, IPermission
    {
        [Searchable]
        [Display(Name = "用户名", Order = 0)]
        [Required]
        public string Username { get; set; }

        [Hide(IsHiddenOnView = false)]
        [Display(Name = "创建时间", Order = 20)]
        [Searchable]
        public override DateTime CreateDate { get { return base.CreateDate; } set { base.CreateDate = value; } }

        [Display(Name = "密码", Order = 10)]
        [Hide(IsHiddenOnEdit = false, IsHiddenOnCreate = false, IsHiddenOnDetail = true, IsHiddenOnView = true)]
        [CustomDataType(CustomDataType.Password)]
        [Required]
        public override byte[] Password { get { return base.Password; } set { base.Password = value; } }

        [Display(Name = "类型", Order = 30)]
        public AdminType Type { get; set; }

        [Hide]
        public ICollection<Thread> Threads { get; set; }

        string IPermission.Identity { get { return Index.ToString(); } }

        string IPermission.Name { get { return Username; } }

        object[] IPermission.GetStaticRoles()
        {
            return new object[0];
        }

        bool IPermission.IsInRole(object role)
        {
            return true;
        }

        ICollection<IThread> IMember.Threads { get { throw new NotSupportedException(); } }
    }
}
