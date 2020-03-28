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

    partial class Root
    {
        /// <summary>
        /// Consructs an enumerable from a parameter array
        /// </summary>
        /// <param name="src">The source items</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<T> items<T>(params T[] src)
            => src;

    }
}