//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Applies a function to a source if a predicate evaluated over the source is true, otherwise returns the source as-is
        /// </summary>
        /// <typeparam name="T">The function input/output type</typeparam>
        /// <param name="criterion">The criterion on which to branch</param>
        /// <param name="src">The value to supply to the chosen function</param>
        /// <param name="true">The function to evaulate when the criterion is true</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static X @if<X>(X src, Func<X,bool> test, Func<X,X> @true)
            where X : struct
                => test(src) ? @true(src) : src;

    }
}