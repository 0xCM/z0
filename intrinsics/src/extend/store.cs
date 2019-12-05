//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    

    partial class CpuVecX
    {
        /// <summary>
        /// Stores vector content to a memory reference
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void StoreTo<T>(this Vector128<T> src, ref T dst, int offset = 0)
            where T : unmanaged            
                => ginx.vstore(src, ref dst, offset);

        /// <summary>
        /// Stores vector content to a memory reference
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        /// <param name="offset">The target offset</param>
        [MethodImpl(Inline)]
        public static void StoreTo<T>(this Vector256<T> src, ref T dst, int offset = 0)
            where T : unmanaged            
                => ginx.vstore(src, ref dst, offset);

        /// <summary>
        /// Stores vector content to a caller-supplied span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static void StoreTo<T>(this Vector128<T> src, Span<T> dst, int offset = 0)
            where T : unmanaged            
                => ginx.vstore(src,dst,offset);

        /// <summary>
        /// Stores vector content to a caller-supplied span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static void StoreTo<T>(this Vector256<T> src, Span<T> dst, int offset = 0)
            where T : unmanaged            
                => ginx.vstore(src,dst,offset);

        /// <summary>
        /// Stores vector content to a caller-supplied block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo<T>(this Vector128<T> src, in Block128<T> dst)
            where T : unmanaged
                => ginx.vstore(src, dst);

        /// <summary>
        /// Stores vector content to a specified block in a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        /// <param name="block">The 0-based block index at which storage should begin</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo<T>(this Vector128<T> src, in Block128<T> dst, int block)
            where T : unmanaged
                => ginx.vstore(src, dst, block);

        /// <summary>
        /// Stores vector content to a caller-supplied block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo<T>(this Vector256<T> src, in Block256<T> dst)
            where T : unmanaged
                => ginx.vstore(src, dst);

        /// <summary>
        /// Stores vector content to a specified block in a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target memory</param>
        /// <param name="block">The 0-based block index at which storage should begin</param>
        [MethodImpl(Inline)]
        public static unsafe void StoreTo<T>(this Vector256<T> src, in Block256<T> dst, int block)
            where T : unmanaged
                => ginx.vstore(src, dst, block);
    }
}