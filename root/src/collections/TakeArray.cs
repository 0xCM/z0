// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Linq;

    using static Root;
    
    partial class RootCollections
    {

        /// <summary>
        /// Constructs an array of specified length from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="length">The length of the index</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static T[] TakeArray<T>(this IEnumerable<T> src, int length)
            => src.Take(length).ToArray();

        /// <summary>
        /// Constructs an array from a specified number of elmements from a source stream after a skip
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] TakeArray<T>(this IEnumerable<T> src, int skip, int count)
            => src.Skip(skip).TakeArray(count);

    }
}