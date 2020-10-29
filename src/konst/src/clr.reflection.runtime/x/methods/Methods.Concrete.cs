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

    partial class XClrQuery
    {
        /// <summary>
        /// Selects the concrete (not abstract) methods from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        [Op]
        public static MethodInfo[] Concrete(this MethodInfo[] src)
            => src.Where(m => m.IsConcrete());
    }
}