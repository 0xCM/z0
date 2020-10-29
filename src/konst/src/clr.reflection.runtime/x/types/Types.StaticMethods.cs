//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;

    partial class XReflex
    {
        /// <summary>
        /// Selects all static methods declared by the source types
        /// </summary>
        /// <param name="src">The types to search</param>
        public static MethodInfo[] StaticMethods(this Type[] src)
            => src.SelectMany(x => x.StaticMethods()).ToArray();
    }
}