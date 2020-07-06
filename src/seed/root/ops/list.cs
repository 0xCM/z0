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

    using static Konst;

    partial class RootLegacy
    {
        /// <summary>
        /// Creates a list from a parameter array
        /// </summary>
        /// <param name="src">The source items</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static List<T> list<T>(params T[] src)
            => sys.list(src);
    }
}