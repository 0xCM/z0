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
        /// Returns the first element of the sequence that satisifies the predicate, if any.
        /// </summary>
        /// <param name="src">The sequence to search</param>
        /// <param name="predicate">The predicate to satiisfy</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Option<T> TryFind<T>(this IEnumerable<T> src, Func<T,bool> predicate)
            => src.FirstOrDefault(predicate);
    }
}