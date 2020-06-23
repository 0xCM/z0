//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Memories;
    
    partial class Vectors
    {
        /// <summary>
        /// Stores vector content to the front of a span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> vstore<T>(Vector128<T> src, Span<T> dst)
            where T : unmanaged            
        {
            VStore.vsave(src, ref head(dst));
            return dst;
        }

        /// <summary>
        /// Stores vector content to the front of a span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> vstore<T>(Vector256<T> src, Span<T> dst)
            where T : unmanaged            
        {
            vstore(src, ref head(dst));
            return dst;        
        }

        /// <summary>
        /// Stores vector content to a span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <param name="offset">The target offset at which storage should begin</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector128<T> src, Span<T> dst, int offset)
            where T : unmanaged
                => VStore.vsave(src, ref head(dst), offset);

        /// <summary>
        /// Stores vector content to a span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <param name="offset">The target offset at which storage should begin</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector256<T> src, Span<T> dst, int offset)
            where T : unmanaged
                => VStore.vsave(src, ref head(dst), offset);

        /// <summary>
        /// Stores vector content to a span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <param name="offset">The target offset at which storage should begin</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector512<T> src, Span<T> dst, int offset)
            where T : unmanaged
                => VStore.vsave(src, ref head(dst), offset);
    }
}