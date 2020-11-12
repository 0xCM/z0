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

    partial class XCell
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

        [MethodImpl(Inline)]
        public static Cell512 ToCell<T>(this Vector512<T> x)
            where T : unmanaged
                => Unsafe.As<Vector512<T>,Cell512>(ref x);

        [MethodImpl(Inline), Op]
        public static Cell8 ToCell(this byte x)
            => x;

        [MethodImpl(Inline), Op]
        public static Cell8 ToCell(this sbyte x)
            => x;

        [MethodImpl(Inline), Op]
        public static Cell16 ToCell(this short x)
            => x;

        [MethodImpl(Inline), Op]
        public static Cell16 ToCell(this ushort x)
            => x;

        [MethodImpl(Inline), Op]
        public static Cell32 ToCell(this int x)
            => x;

        [MethodImpl(Inline), Op]
        public static Cell32 ToCell(this uint x)
            => x;

        [MethodImpl(Inline), Op]
        public static Cell64 ToCell(this long x)
            => x;

        [MethodImpl(Inline), Op]
        public static Cell64 ToCell(this ulong x)
            => x;
    }
}