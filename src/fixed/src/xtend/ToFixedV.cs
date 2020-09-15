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

    partial class XTend
    {
        /// <summary>
        /// Presents a 128-bit vector as a 128-bit fixed block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Cell128 ToCell<T>(this in Vector128<T> x)
            where T : unmanaged
                => ref Cells.from(x);

        /// <summary>
        /// Presents a 256-bit vector as a 256-bit fixed block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Cell256 ToCell<T>(this in Vector256<T> x)
            where T : unmanaged
                => ref Cells.from(x);

        /// <summary>
        /// Presents a 512-bit vector as a 512-bit fixed block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Cell512 ToCell<T>(this in Vector512<T> x)
            where T : unmanaged
                => ref Cells.from(x);
    }
}