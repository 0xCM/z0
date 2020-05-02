//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
 
    partial interface IIdentityReflector
    {
       /// <summary>
        /// Dtermines whether a method has a void return
        /// </summary>
        /// <param name="m">The method to examine</param>
        bool IsAction(MethodInfo m)
            => m.IsAction();

        /// <summary>
        /// Queries the stream for methods that are actions
        /// </summary>
        /// <param name="src">The source stream</param>
        IEnumerable<MethodInfo> Actions(IEnumerable<MethodInfo> src)
            => src.Where(IdentityReflector.Service.IsAction);
    }
}