//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static DataBlocks;

    partial class BlockExtend    
    {

        /// <summary>
        /// Extracts an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this Block32<T> src, int block)
            where T : unmanaged
                => src.Data.ToArray();

        /// <summary>
        /// Extracts an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this Block64<T> src, int block)
            where T : unmanaged
                => src.Data.ToArray();

        /// <summary>
        /// Extracts an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this Block128<T> src, int block)
            where T : unmanaged
                => src.Data.ToArray();

        /// <summary>
        /// Extracts an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this Block256<T> src, int block)
            where T : unmanaged
                => src.Data.ToArray();

        /// <summary>
        /// Extracts an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this ConstBlock32<T> src, int block)
            where T : unmanaged
                => src.Data.ToArray();

        /// <summary>
        /// Extracts an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this ConstBlock64<T> src, int block)
            where T : unmanaged
                => src.Data.ToArray();

        /// <summary>
        /// Extracts an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this ConstBlock128<T> src, int block)
            where T : unmanaged
                => src.Data.ToArray();

        /// <summary>
        /// Extracts an index-identified block
        /// </summary>
        /// <param name="src">The source block container</param>
        /// <param name="block">The block-relative index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static T[] ToArray<T>(this ConstBlock256<T> src, int block)
            where T : unmanaged
                => src.Data.ToArray();
 
    }

}