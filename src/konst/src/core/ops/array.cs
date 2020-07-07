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

        /// <summary>
        /// Produces an array from a span
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] array<T>(Span<T> src)
            => sys.array(src);

        /// <summary>
        /// Produces an array from a list
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] array<T>(List<T> src)
            => sys.array(src);            
    }
}