//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class Cells
    {
        [MethodImpl(Inline)]
        internal static unsafe Span<T> span<F,T>(ref F src)
            where F : unmanaged, IDataCell
            where T : unmanaged
                => new Span<T>(Unsafe.AsPointer(ref src), Unsafe.SizeOf<F>());

        [MethodImpl(Inline)]
        internal static ref T first<F,T>(in F src, T t)
            where F : unmanaged, IDataCell
            where T : unmanaged
                => ref Unsafe.As<F,T>(ref z.edit(src));

        [MethodImpl(Inline)]
        internal static ref F from<T,F>(in T src)
            where F : unmanaged, IDataCell
            where T : struct
                => ref Unsafe.As<T,F>(ref  Unsafe.AsRef(in src));

        [MethodImpl(Inline)]
        internal static unsafe ReadOnlySpan<T> view<F,T>(in F src)
            where F : unmanaged, IDataCell
            where T : unmanaged
                => new ReadOnlySpan<T>(Unsafe.AsPointer(ref Unsafe.AsRef(in src)), Unsafe.SizeOf<F>());

        /// <summary>
        /// Writes a specified number of source elements to a fixed target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="count">The number of source elements to write</param>
        /// <param name="dst">The target</param>
        /// <param name="offset">The element-relative offset into the target</param>
        /// <typeparam name="S">The source cell type</typeparam>
        [MethodImpl(Inline)]
        internal static unsafe void deposit<S,F>(in S src, int count, ref F dst, int offset)
            where S : struct
            where F : struct
                => store(src, (int)(size<S>() * count), ref Unsafe.Add(ref Unsafe.As<F,byte>(ref dst), (int)(size<S>() * offset)));

        [MethodImpl(Inline)]
        internal static unsafe ref T store<S,T>(in S src, int bytecount, ref T dst)
            where S : struct
            where T : struct
        {
            ref var dstBytes = ref Unsafe.As<T,byte>(ref dst);
            ref var srcBytes = ref Unsafe.As<S,byte>(ref Unsafe.AsRef(in src));
            Unsafe.CopyBlockUnaligned(ref dstBytes, ref srcBytes, (uint)bytecount);
            return ref dst;
        }
    }
}