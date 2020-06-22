//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct As
    {
        /// <summary>
        /// Adds an offset to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="offset">The source-relative offset amount</param>
        /// <typeparam name="T">The reference type</typeparam>
        /// <remarks>
        /// u8:  movsxd rax,edx -> add rax,rcx
        /// u16: movsxd rax,edx -> lea rax,[rcx+rax*2]
        /// u32: movsxd rax,edx -> lea rax,[rcx+rax*4]
        /// u64: movsxd rax,edx -> lea rax,[rcx+rax*8]
        /// </remarks>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T add<T>(in T src, int offset)
            => ref Add(ref edit(src), offset);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref byte add<T>(W8 w, in T src, int count)
            => ref Add(ref edit<T,byte>(src), count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ushort add<T>(W16 w, in T src, int count)
            => ref Add(ref edit<T,ushort>(src), count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint add<T>(W32 w, in T src, int count)
            => ref Add(ref edit<T,uint>(src), count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ulong add<T>(W64 w, in T src, int count)
            => ref Add(ref edit<T,ulong>(src), count);

        /// <summary>
        /// Adds a T-counted offset to a readonly S-reference and returns the result for
        /// the greater, or perhaps lesser, good
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="tCount">The T-cell count</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T add<S,T>(in S src, int tCount)
            => ref Add(ref edit<S,T>(src), tCount);
    }
}