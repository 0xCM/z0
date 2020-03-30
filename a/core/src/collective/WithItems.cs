// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Components;
    
    partial class XTend
    {
        /// <summary>
        /// Adds a stream of items to a target set
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="dst">The target set</param>
        /// <param name="src">The source stream</param>
        [MethodImpl(Inline)]
        public static ISet<T> WithItems<T>(this ISet<T> dst, IEnumerable<T> src)
        {
            src.Iter(item => dst.Add(item));
            return dst;
        }
    }
}