//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class XTend
    {
        /// <summary>
        /// Selects all nested types declared by an array of source types
        /// </summary>
        /// <param name="src">The source types</param>
        public static Type[] Nested(this Type[] src)
            => src.Where(t => t.IsNested);
    }
}