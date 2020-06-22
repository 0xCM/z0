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

    partial class VBlock
    {
        /// <summary>
        /// Loads a 128-bit vector from the first 128-bit source block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Vector128<T> vload<T>(in Block128<T> src)
            where T : unmanaged
                => Vectors.vload(w128,src.Data);

        /// <summary>
        /// Loads a 256-bit vector from the leading source block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Vector256<T> vload<T>(in Block256<T> src)
            where T : unmanaged
                => Vectors.vload(w256,src.Data);

        /// <summary>
        /// Loads a 512-bit vector from the leading source block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Vector512<T> vload<T>(in Block512<T> src)
            where T : unmanaged
                => Vectors.vload(w512,src.Data);

        /// <summary>
        /// Loads a block-identified 128-bit vector
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Vector128<T> vload<T>(in Block128<T> src, int block)            
            where T : unmanaged      
                => Vectors.vload(src.BlockRef(block), out Vector128<T> x);

        /// <summary>
        /// Loads a block-identified 256-bit vector
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Vector256<T> vload<T>(in Block256<T> src, int block)            
            where T : unmanaged      
                => Vectors.vload(src.BlockRef(block), out Vector256<T> x);

        /// <summary>
        /// Loads a block-identified 512-bit vector
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Vector512<T> vload<T>(in Block512<T> src, int block)            
            where T : unmanaged      
                => Vectors.vload(src.BlockRef(block), out Vector512<T> x);
    }
}