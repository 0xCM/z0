//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    partial class Memories
    {
        /// <summary>
        /// Iterates over the supplied items, invoking an indexed receiver for each
        /// </summary>
        /// <param name="src">The source items</param>
        /// <param name="f">The receiver</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void iteri<T>(IEnumerable<T> items, Action<int,T> action)
            => Root.iteri(items,action);
    }
}