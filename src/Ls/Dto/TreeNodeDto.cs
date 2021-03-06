﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ls.Dto
{
    public class TreeNodeDto<T> : BaseDto, ITreeNodeDto<T>
        where T : TreeNodeDto<T>
    {
        public TreeNodeDto()
        {
            children = new List<T>();
        }
        /// <summary>
        /// 父级菜单Id
        /// </summary>
        public string ParentId { get; set; }
        /// <summary>
        /// 子集元素列表
        /// </summary>
        public List<T> children { get; set; }
    }
}
