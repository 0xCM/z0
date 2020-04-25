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
    
    using static Seed;
    using static Widths;

    partial class XTend
    {
        /// <summary>
        /// Allocates and deposits vector content to a data block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        public static Block128<T> ToBlock<T>(this Vector128<T> src)
            where T : unmanaged            
        {
            var dst = Blocks.alloc<T>(w128);
            Vectors.vstore(src, ref dst.Head);
            return dst;
        }                       

        /// <summary>
        /// Allocates and deposits vector content to a data block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        public static Block256<T> ToBlock<T>(this Vector256<T> src)
            where T : unmanaged            
        {
            var dst = Blocks.single<T>(w256);
            Vectors.vstore(src, ref dst.Head);
            return dst;
        }            

        /// <summary>
        /// Allocates and deposits vector content to a data block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        public static Block512<T> ToBlock<T>(this Vector512<T> src)
            where T : unmanaged            
        {
            var dst = Blocks.single<T>(w512);
            Vectors.vstore(src, ref dst.Head);
            return dst;
        }            
    }
}