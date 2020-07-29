//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    partial struct Arrays
    {            
        /// <summary>
        /// Returns an empty array
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T[] empty<T>()
             => sys.empty<T>();

        /// <summary>
        /// Tests whether an array is empty
        /// </summary>
        /// <param name="src">The array to test</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bool empty<T>(T[] src)
            =>  src == null || src.Length == 0;
    }
}