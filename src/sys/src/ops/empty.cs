//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
                
    partial struct sys
    {
        /// <summary>
        /// Tests whether the source string is null or empty
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Options), Op]
        public static bool blank(string src)
            => proxy.blank(src);
        

        /// <summary>
        /// Returns an empty array
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Options), Op, Closures(Closure)]
        public static T[] empty<T>()
            => proxy.empty<T>();
    }
}