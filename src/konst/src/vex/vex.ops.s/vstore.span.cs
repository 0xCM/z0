//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;

    partial struct gcpu
    {
        /// <summary>
        /// Stores vector content to the front of a span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> vstore<T>(Vector128<T> src, Span<T> dst)
            where T : unmanaged
        {
            z.vstore(src, ref memory.first(dst));
            return dst;
        }

        /// <summary>
        /// Stores vector content to the front of a span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> vstore<T>(Vector256<T> src, Span<T> dst)
            where T : unmanaged
        {
            z.vstore(src, ref memory.first(dst));
            return dst;
        }

        /// <summary>
        /// Stores vector content to a span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <param name="offset">The target offset at which storage should begin</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void vstore<T>(Vector128<T> src, Span<T> dst, int offset)
            where T : unmanaged
                => z.vstore(src, ref memory.first(dst), offset);

        /// <summary>
        /// Stores vector content to a span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <param name="offset">The target offset at which storage should begin</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void vstore<T>(Vector256<T> src, Span<T> dst, int offset)
            where T : unmanaged
                => z.vstore(src, ref memory.first(dst), offset);

        /// <summary>
        /// Stores vector content to a span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <param name="offset">The target offset at which storage should begin</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void vstore<T>(Vector512<T> src, Span<T> dst, int offset)
            where T : unmanaged
                => z.vstore(src, ref memory.first(dst), offset);
    }
}