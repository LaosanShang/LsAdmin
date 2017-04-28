﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ls.Mvc.Validate
{
    /// <summary>
    /// 默认验证处理器，直接抛出异常
    /// </summary>
    public class ValidateHandler : IValidationHandler
    {
        /// <summary>
        /// 处理验证错误
        /// </summary>
        /// <param name="results">验证结果集合</param>
        public void Handle(ValidationResultCollection results)
        {
            if (results.IsValid)
                return;
            throw new ApplicationException(results.First().ErrorMessage);
        }
    }
}