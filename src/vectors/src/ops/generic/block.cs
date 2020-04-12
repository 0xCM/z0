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
    using static Memories;
    
    partial class Vectors
    {
        /// <summary>
        /// Allocates and deposits vector content to a data block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [Op, Closures(AllNumeric)]
        public static Block128<T> block<T>(Vector128<T> src)
            where T : unmanaged            
        {
            var dst = Blocks.single<T>(w128);
            vstore(src, ref dst.Head);
            return dst;
        }                       

        /// <summary>
        /// Allocates and deposits vector content to a data block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [Op, Closures(AllNumeric)]
        public static Block256<T> block<T>(Vector256<T> src)
            where T : unmanaged            
        {
            var dst = Blocks.single<T>(w256);
            vstore(src, ref dst.Head);
            return dst;
        }            

        /// <summary>
        /// Allocates and deposits vector content to a data block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [Op, Closures(AllNumeric)]
        public static Block512<T> block<T>(Vector512<T> src)
            where T : unmanaged            
        {
            var dst = Blocks.single<T>(w512);
            Vectors.vstore(src, ref dst.Head);
            return dst;
        }            
    }
}