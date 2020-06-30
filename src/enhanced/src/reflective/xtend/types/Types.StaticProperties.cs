//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    partial class XTend
    {
        /// <summary>
        /// Selects all static properties declared by the source types
        /// </summary>
        /// <param name="src">The types to search</param>
        public static PropertyInfo[] StaticProperties(this Type[] src)
            => src.SelectMany(x => x.StaticProperties()).ToArray();
    }
}