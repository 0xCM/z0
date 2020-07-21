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
    using static z;
    
    partial class Vectors
    {
        /// <summary>
        /// Allocates and deposits vector content to a data block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [Op, Closures(UnsignedInts)]
        public static Block128<T> block<T>(Vector128<T> src)
            where T : unmanaged            
        {
            var w = w128;
            var stack = Stacks.alloc(w);
            ref var dst = ref Stacks.head<T>(ref stack);
            V0.vsave(src, ref dst);
            return Blocks.load(w, ref dst);            
        }                       

        /// <summary>
        /// Allocates and deposits vector content to a data block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [Op, Closures(UnsignedInts)]
        public static Block256<T> block<T>(Vector256<T> src)
            where T : unmanaged            
        {
            var w = w256;
            var stack = Stacks.alloc(w);
            ref var dst = ref Stacks.head<T>(ref stack);
            V0.vsave(src, ref dst);
            return Blocks.load(w, ref dst);            
        }            

        /// <summary>
        /// Allocates and deposits vector content to a data block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [Op, Closures(UnsignedInts)]
        public static Block512<T> block<T>(Vector512<T> src)
            where T : unmanaged            
        {
            var w = w512;
            var stack = Stacks.alloc(w);
            ref var dst = ref Stacks.head<T>(ref stack);
            V0.vsave(src, ref dst);
            return Blocks.load(w, ref dst);            
        }                  

        /// <summary>
        /// Stores the source vector to the head of a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void vstore<T>(Vector128<T> src, in Block128<T> dst)
            where T : unmanaged
                => V0.vsave(src, ref dst.Head);

        /// <summary>
        /// Stores the source vector to a specified block in a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The 0-based block index at which storage should begin</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void vstore<T>(Vector128<T> src, in Block128<T> dst, int block)
            where T : unmanaged
                => V0.vsave(src, ref dst.BlockRef(block));

        /// <summary>
        /// Stores the source vector to a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void vstore<T>(Vector256<T> src, in Block256<T> dst)
            where T : unmanaged
                => V0.vsave(src, ref dst.Head);

        /// <summary>
        /// Stores the source vector to a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void vstore<T>(Vector512<T> src, in Block512<T> dst)
            where T : unmanaged
                => V0.vsave(src, ref dst.Head);

        /// <summary>
        /// Stores the source vector to a specified block in a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The 0-based block index at which storage should begin</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void vstore<T>(Vector256<T> src, in Block256<T> dst, int block)
            where T : unmanaged
                => V0.vsave(src, ref dst.BlockRef(block));

        /// <summary>
        /// Stores the source vector to a specified block in a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The 0-based block index at which storage should begin</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void vstore<T>(Vector512<T> src, in Block512<T> dst, int block)
            where T : unmanaged
                => V0.vsave(src, ref dst.BlockRef(block));
    }
}