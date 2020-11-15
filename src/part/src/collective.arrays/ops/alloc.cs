//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Arrays
    {
        /// <summary>
        /// Allocates a new array
        /// </summary>
        /// <param name="length">The array length</param>
        /// <typeparam name="T">The element type</typeparam>
        [Op, MethodImpl(Inline), Closures(Closure)]
        public static T[] alloc<T>(int length)
            => new T[length];

        /// <summary>
        /// Allocates a new array and populates it with a specified value
        /// </summary>
        /// <param name="length">The array length</param>
        /// <param name="src">The value with which to populate the array</param>
        /// <typeparam name="T">The element type</typeparam>
        [Op, MethodImpl(Inline), Closures(Closure)]
        public static T[] alloc<T>(int length, T src)
            => fill(alloc<T>(length), src);
    }
}
