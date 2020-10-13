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

    partial struct z
    {

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static List<T> list<T>(params T[] src)
            => sys.list(src);


        /// <summary>
        /// Creates a list with specified capacity
        /// </summary>
        /// <param name="capacity">The list capacity</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static List<T> list<T>(int capacity)
            => new List<T>(capacity);

        /// <summary>
        /// Creates a list with specified capacity
        /// </summary>
        /// <param name="capacity">The list capacity</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static List<T> list<T>(uint capacity)
            => new List<T>((int)capacity);
    }
}