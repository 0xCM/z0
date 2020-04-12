//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    
    partial class Vectors
    {
        /// <summary>
        /// Stores the source vector to the head of a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector128<T> src, in Block128<T> dst)
            where T : unmanaged
                => vstore(src, ref dst.Head);

        /// <summary>
        /// Stores the source vector to a specified block in a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The 0-based block index at which storage should begin</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector128<T> src, in Block128<T> dst, int block)
            where T : unmanaged
                => vstore(src, ref dst.BlockRef(block));

        /// <summary>
        /// Stores the source vector to a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector256<T> src, in Block256<T> dst)
            where T : unmanaged
                => vstore(src, ref dst.Head);

        /// <summary>
        /// Stores the source vector to a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector512<T> src, in Block512<T> dst)
            where T : unmanaged
                => vstore(src, ref dst.Head);

        /// <summary>
        /// Stores the source vector to a specified block in a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The 0-based block index at which storage should begin</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector256<T> src, in Block256<T> dst, int block)
            where T : unmanaged
                => vstore(src, ref dst.BlockRef(block));

        /// <summary>
        /// Stores the source vector to a specified block in a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The 0-based block index at which storage should begin</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector512<T> src, in Block512<T> dst, int block)
            where T : unmanaged
                => vstore(src, ref dst.BlockRef(block));
    }
}