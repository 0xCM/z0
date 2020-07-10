//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class RootLegacy
    {
        /// <summary>
        /// Computs min(x.Length,y.Length)
        /// </summary>
        /// <param name="x">The first span</param>
        /// <param name="y">The second span</param>
        /// <typeparam name="S">The first span cell type</typeparam>
        /// <typeparam name="T">The second span cell type</typeparam>
        [MethodImpl(Inline)]
        public static int length<S,T>(ReadOnlySpan<S> x, ReadOnlySpan<T> y)
            => z.min(x.Length, y.Length);


    }
}