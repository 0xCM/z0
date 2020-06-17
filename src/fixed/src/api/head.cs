//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Fixed
    {        
        /// <summary>
        /// Returns a generic reference to the leading storage cell of an 8-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <typeparam name="T">The reference cell type, of maximal width=8</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8)]
        public static ref T head<T>(ref Fixed8 src)
            where T : unmanaged
                => ref head(ref src, default(T));

        /// <summary>
        /// Returns a generic reference to the leading storage cell of a 16-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <typeparam name="T">The reference cell type, of maximal width=16</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16)]
        public static ref T head<T>(ref Fixed16 src)
            where T : unmanaged
                => ref head(ref src, default(T));

        /// <summary>
        /// Returns a generic reference to the leading storage cell of a 32-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <typeparam name="T">The reference cell type, of maximal width=32</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16x32)]
        public static ref T head<T>(ref Fixed32 src)
            where T : unmanaged
                => ref head(ref src, default(T));

        /// <summary>
        /// Returns a generic reference to the leading storage cell of a 64-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <typeparam name="T">The reference cell type, of maximal width=64</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T head<T>(ref Fixed64 src)
            where T : unmanaged
                => ref head(ref src, default(T));

        /// <summary>
        /// Returns a generic reference to the leading storage cell of a 128-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <typeparam name="T">The reference cell type, of maximal width=128</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T head<T>(ref Fixed128 src)
            where T : unmanaged
                => ref head(ref src, default(T));

        /// <summary>
        /// Returns a generic reference to the leading storage cell of a 256-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <typeparam name="T">The reference cell type, of maximal width=256</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T head<T>(ref Fixed256 src)
            where T : unmanaged
                => ref head(ref src, default(T));

        /// <summary>
        /// Returns a generic reference to the leading storage cell of a 512-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <typeparam name="T">The reference cell type, of maximal width=512</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T head<T>(ref Fixed512 src)
            where T : unmanaged
                => ref head(ref src, default(T));

        /// <summary>
        /// Returns a generic reference to the leading storage cell of a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<F,T>(ref F src)
            where F : unmanaged, IFixed
            where T : unmanaged
                => ref Unsafe.As<F,T>(ref src);
    }
}