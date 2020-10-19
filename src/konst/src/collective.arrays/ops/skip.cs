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
        /// Adds an offset to the head of an array, measured relative to the reference type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bytes">The number of elements to advance</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly T skip<T>(T[] src, int count)
            => ref z.skip(in head<T>(src), (uint)count);
    }
}