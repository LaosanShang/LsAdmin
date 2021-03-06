﻿using Ls.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ls.Authorization
{
    /// <summary>
    /// 权限。
    /// </summary>
    public interface IPermission: IEntity<string>
    {
        /// <summary>
        /// 父级权限Id
        /// </summary>
        string ParentId { get; set; }
        /// <summary>
        /// 权限名。
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 菜单Id
        /// </summary>
        string MenuId { get; set; }
        /// <summary>
        /// 操作Id
        /// </summary>
        string ActionId { get; set; }
    }

    /// <summary>
    /// 权限。
    /// </summary>
    public interface IPermission<TPermission, TAction, TMenu> : IPermission
        where TPermission : IPermission<TPermission, TAction, TMenu>
        where TAction : IAction
        where TMenu : IMenu
    {
        /// <summary>
        /// 父级权限。
        /// </summary>
        TPermission Parent { get; set; }
        /// <summary>
        /// 子级权限。
        /// </summary>
        ICollection<TPermission> Children { get; set; }
        /// <summary>
        /// 菜单
        /// </summary>
        TMenu Menu { get; set; }
        /// <summary>
        /// 操作
        /// </summary>
        TAction Action { get; set; }
    }
}
