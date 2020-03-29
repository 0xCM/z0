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

    using static Collective;

    partial class XCollective
    {
        public static IEnumerable<S> TakeAtMost<S>(this IEnumerable<S> src, int count)
        {
            var i = 0;
            var it = src.GetEnumerator();
            while(it.MoveNext() && i++ < count)
                yield return it.Current;        
        }

        /// <summary>
        /// Defines missing Take(stream,n:uint) method
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="count">The number of elements to remove from the from of the stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IEnumerable<T> Take<T>(this IEnumerable<T> src, uint count)
            => src.Take((int)count);

    }
}