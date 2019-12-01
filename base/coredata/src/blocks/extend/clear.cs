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

    partial class BlockExtend    
    {
        /// <summary>
        /// Zero-fills the block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void Clear<T>(this Block32<T> src)
            where T : unmanaged
                => src.Data.Clear();

        /// <summary>
        /// Zero-fills the block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void Clear<T>(this Block64<T> src)
            where T : unmanaged
                => src.Data.Clear();

        /// <summary>
        /// Zero-fills the block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void Clear<T>(this Block128<T> src)
            where T : unmanaged
                => src.Data.Clear();

        /// <summary>
        /// Zero-fills the block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void Clear<T>(this Block256<T> src)
            where T : unmanaged
                => src.Data.Clear();
    }

}