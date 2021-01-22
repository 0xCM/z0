//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector128<T> src, ref Cell128 dst)
            where T : unmanaged
                => z.vstore(src, ref Cells.first<T>(dst));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector256<T> src, ref Cell256 dst)
            where T : unmanaged
                => z.vstore(src, ref Cells.first<T>(dst));

        /// <summary>
        /// Stores the source vector to the head of a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void vstore<T>(Vector128<T> src, in SpanBlock128<T> dst)
            where T : unmanaged
                => vstore(src, ref dst.First);

        /// <summary>
        /// Stores the source vector to a specified block in a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The 0-based block index at which storage should begin</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void vstore<T>(Vector128<T> src, in SpanBlock128<T> dst, int block)
            where T : unmanaged
                => vstore(src, ref dst.BlockRef(block));

        /// <summary>
        /// Stores the source vector to a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void vstore<T>(Vector256<T> src, in SpanBlock256<T> dst)
            where T : unmanaged
                => vstore(src, ref dst.First);

        /// <summary>
        /// Stores the source vector to a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void vstore<T>(Vector512<T> src, in SpanBlock512<T> dst)
            where T : unmanaged
                => vstore(src, ref dst.First);

        /// <summary>
        /// Stores the source vector to a specified block in a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The 0-based block index at which storage should begin</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void vstore<T>(Vector256<T> src, in SpanBlock256<T> dst, int block)
            where T : unmanaged
                => vstore(src, ref dst.BlockRef(block));

        /// <summary>
        /// Stores the source vector to a specified block in a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The 0-based block index at which storage should begin</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void vstore<T>(Vector512<T> src, in SpanBlock512<T> dst, int block)
            where T : unmanaged
                => vstore(src, ref dst.BlockRef(block));

        [MethodImpl(Inline), Store]
        public static unsafe void vstore(Vector128<byte> src, ref byte dst)
            => Store(pointer(ref dst), src);

        [MethodImpl(Inline), Store]
        public static unsafe void vstore(Vector256<byte> src, ref byte dst)
            => Store(pointer(ref dst), src);

        [MethodImpl(Inline), Store]
        public static unsafe void vstore(Vector512<byte> src, ref byte dst)
        {
            vstore(src.Lo, ref dst);
            vstore(src.Hi, ref Unsafe.Add(ref dst, 32));
        }

        [MethodImpl(Inline), Store]
        public static unsafe void vstore(Vector128<ushort> src, ref ushort dst)
            => Store(pointer(ref dst), src);

        [MethodImpl(Inline), Store]
        public static unsafe void vstore(Vector256<ushort> src, ref ushort dst)
            => Store(pointer(ref dst), src);

        [MethodImpl(Inline), Store]
        public static unsafe void vstore(Vector512<ushort> src, ref ushort dst)
        {
            vstore(src.Lo, ref dst);
            vstore(src.Hi, ref Unsafe.Add(ref dst, 16));
        }

        [MethodImpl(Inline), Store]
        public static unsafe void vstore(Vector128<byte> src, Span<byte> dst)
            => vstore(src, ref first(dst));

        [MethodImpl(Inline), Store]
        public static unsafe void vstore(Vector256<byte> src, Span<byte> dst)
            => vstore(src, ref first(dst));

        [MethodImpl(Inline), Store]
        public static unsafe void vstore(Vector512<byte> src, Span<byte> dst)
            => vstore(src, ref first(dst));
    }
}