//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct core
    {                
        /// <summary>
        /// Produces an array from a parameter array
        /// </summary>
        /// <param name="src">The source items</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] array<T>(params T[] src)
            => sys.array(src);    

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] array<T>(Span<T> src)
            => sys.array(src);
    }
}