//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    partial class XTend
    {
        /// <summary>
        /// Forces enumerable evaluation
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(MethodOptions), Op, Closures(Closure)]
        public static T[] Force<T>(this IEnumerable<T> src)
            => src.Array();
    }
}