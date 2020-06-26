//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;
    using static AsInternal;

    partial struct As
    {
        /// <summary>
        /// Presents a readonly reference to an unmanaged value as a pointer
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <param name="offset">The number of elements to skip</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe T* pointer<T>(in T src)
            where T : unmanaged
                => pref(ref edit(src));

        /// <summary>
        /// Presents a readonly reference to an unmanaged value as a pointer displaced 
        /// by a specified element offset
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <param name="offset">The number of elements to skip</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe T* pointer<T>(in T src, int offset)
            where T : unmanaged
                => pref(ref edit(in skip(in src, offset)));            
    }
}