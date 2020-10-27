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

    partial class XReflex
    {
        /// <summary>
        /// Selects the static methods from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static MethodInfo[] Static(this MethodInfo[] src)
            => src.Where(x => x.IsStatic);
    }
}