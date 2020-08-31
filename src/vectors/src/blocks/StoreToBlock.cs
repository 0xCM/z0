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

    partial class XTend
    {
        /// <summary>
        /// Stores vector content to a caller-supplied block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo<T>(this Vector128<T> src, in SpanBlock128<T> dst)
            where T : unmanaged
                => Vectors.vstore(src, dst);

        /// <summary>
        /// Stores vector content to a specified block in a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        /// <param name="block">The 0-based block index at which storage should begin</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo<T>(this Vector128<T> src, in SpanBlock128<T> dst, int block)
            where T : unmanaged
                => Vectors.vstore(src, dst, block);

        /// <summary>
        /// Stores vector content to a caller-supplied block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo<T>(this Vector256<T> src, in SpanBlock256<T> dst)
            where T : unmanaged
                => Vectors.vstore(src, dst);

        /// <summary>
        /// Stores vector content to a caller-supplied block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo<T>(this Vector512<T> src, in SpanBlock512<T> dst)
            where T : unmanaged
                => Vectors.vstore(src, dst);

        /// <summary>
        /// Stores vector content to a specified block in a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        /// <param name="block">The 0-based block index at which storage should begin</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo<T>(this Vector256<T> src, in SpanBlock256<T> dst, int block)
            where T : unmanaged
                => Vectors.vstore(src, dst, block);

        /// <summary>
        /// Stores vector content to a specified block in a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        /// <param name="block">The 0-based block index at which storage should begin</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo<T>(this Vector512<T> src, in SpanBlock512<T> dst, int block)
            where T : unmanaged
                => Vectors.vstore(src, dst, block);
    }
}