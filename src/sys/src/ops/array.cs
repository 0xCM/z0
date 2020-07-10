//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    
    partial struct sys
    {
        /// <summary>
        /// Produces an array from a parameter array
        /// </summary>
        /// <param name="src">The source items</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Options), Op, Closures(Closure)]
        public static T[] array<T>(params T[] src)
            => xsys.array(src);

        [MethodImpl(Options), Op, Closures(Closure)]
        public static T[] array<T>(Span<T> src)
            => xsys.array(src);

        [MethodImpl(Options), Op, Closures(Closure)]
        public static T[] array<T>(List<T> src)
            => xsys.array(src);

        [MethodImpl(Options), Op, Closures(Closure)]
        public static T[] array<T>(IEnumerable<T> src)
            => xsys.array(src);
    }
}