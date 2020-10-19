//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static Konst;

    partial class VXTend
    {
        /// <summary>
        /// Stores vector content to a caller-supplied span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static void StoreTo<T>(this Vector128<T> src, Span<T> dst, int offset = 0)
            where T : unmanaged
                => z.vsave(src,dst,offset);

        /// <summary>
        /// Stores vector content to a caller-supplied span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static void StoreTo<T>(this Vector256<T> src, Span<T> dst, int offset = 0)
            where T : unmanaged
                => z.vsave(src,dst,offset);

        /// <summary>
        /// Stores vector content to a caller-supplied span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static void StoreTo<T>(this Vector512<T> src, Span<T> dst, int offset = 0)
            where T : unmanaged
                => z.vsave(src,dst,offset);

        /// <summary>
        /// Stores vector content to a memory reference
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void StoreTo<T>(this Vector128<T> src, ref T dst, int offset = 0)
            where T : unmanaged
                => z.vsave(src, ref dst, offset);

        /// <summary>
        /// Stores vector content to a memory reference
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void StoreTo<T>(this Vector256<T> src, ref T dst, int offset = 0)
            where T : unmanaged
                => z.vsave(src, ref dst, offset);
    }
}