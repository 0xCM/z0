//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.IO;

    using static Konst;

    partial struct core
    {
        /// <summary>
        /// Implements the canonical join operation that reduces the monadic depth by one level
        /// </summary>
        /// <param name="src">The optional option</param>
        /// <typeparam name="T">The encapsulated value</typeparam>
        [MethodImpl(Inline)]
        public static Option<T> reduce<T>(Option<Option<T>> src)
            => src.ValueOrDefault(none<T>());

        /// <summary>
        /// Implements the canonical join operation that reduces the (LiNQ-monadic) depth by one level
        /// </summary>
        /// <param name="src">The optional option</param>
        /// <typeparam name="T">The encapsulated value</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<T> reduce<T>(params IEnumerable<T>[] src)
            => src.SelectMany(x => x);
    }
}