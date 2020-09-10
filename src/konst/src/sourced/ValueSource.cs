//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct ValueSource
    {        
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static CachedSource<T> cache<T>(T[] src)
            where T : struct
                => cache(src,sys.alloc<int>(1));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static CachedSource<T> cache<T>(T[] src, int[] index)
            where T : struct
                => new CachedSource<T>(src, index);

        /// <summary>
        /// Deposits a specified number of cells to reference-identified storage
        /// </summary>
        /// <param name="src">The value source</param>
        /// <param name="count">The number of cells to store</param>
        /// <param name="dst">The leading storage cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void store<T>(ICachedSource<T> src, uint count, ref T dst)
            where T : unmanaged
        {
            for(var i=0; i<count; i++)
                z.seek(dst, i) = src.Next();
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T next<T>(IValueSource src, T t = default)
            where T : struct
                => src.Next<T>();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly T next<T>(ICachedSource<T> src)
            where T : struct
                => ref src.Next();
    }
}