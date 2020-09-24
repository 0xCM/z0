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

    partial class Cells
    {
        [MethodImpl(Inline), Op]
        public static Cell8 cell(byte src)
            => src;

        [MethodImpl(Inline), Op]
        public static Cell8 cell(sbyte src)
            => src;

        [MethodImpl(Inline), Op]
        public static Cell16 cell(short src)
            => src;

        [MethodImpl(Inline), Op]
        public static Cell16 cell(ushort src)
            => src;

        [MethodImpl(Inline), Op]
        public static Cell32 cell(int src)
            => src;

        [MethodImpl(Inline), Op]
        public static Cell32 cell(uint src)
            => src;

        [MethodImpl(Inline), Op]
        public static Cell64 cell(long src)
            => src;

        [MethodImpl(Inline), Op]
        public static Cell64 cell(ulong src)
            => src;

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Cell8 c8<T>(T src)
            where T : unmanaged
                => Cell8.From(z.force<T,byte>(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Cell16 c16<T>(T src)
            where T : unmanaged
                => Cell16.From(z.force<T,ushort>(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Cell32 c32<T>(T src)
            where T : unmanaged
                => Cell32.init(z.force<T,uint>(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Cell64 c64<T>(T src)
            where T : unmanaged
                => Cell64.From(z.force<T,ulong>(src));

        [MethodImpl(Inline)]
        public static F fix<T,F>(T src)
            where F : unmanaged, IDataCell
            where T : unmanaged
                => Unsafe.As<T,F>(ref src);

        [MethodImpl(Inline)]
        public static T unfix<F,T>(F src)
            where F : unmanaged, IDataCell
            where T : unmanaged
                => Unsafe.As<F,T>(ref src);

        /// <summary>
        /// Initializes a 128-bit value with a 128-bit source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Cell128 cell<T>(Vector128<T> x)
            where T : unmanaged
                => new Cell128(v64u(x));

        /// <summary>
        /// Initializes a 256-bit value with a 256-bit source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Cell256 cell<T>(Vector256<T> x)
            where T : unmanaged
                => new Cell256(v64u(x));

        /// <summary>
        /// Queries/manipulates a cell within a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T cell<F,T>(ref F src, int index)
            where F : unmanaged, IDataCell
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<F,T>(ref src), index);

        /// <summary>
        /// Queries/manipulates a generic cell within an 8-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8k)]
        public static ref T cell<T>(ref Cell8 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<Cell8,T>(ref src), index);

        /// <summary>
        /// Queries/manipulates a generic cell within a 16-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16k)]
        public static ref T cell<T>(ref Cell16 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<Cell16,T>(ref src), index);

        /// <summary>
        /// Queries/manipulates a generic cell within a 32-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16x32k)]
        public static ref T cell<T>(ref Cell32 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<Cell32,T>(ref src), index);

        /// <summary>
        /// Queries/manipulates a generic cell within a 64-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T cell<T>(ref Cell64 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<Cell64,T>(ref src), index);

        /// <summary>
        /// Queries/manipulates a generic cell within a 128-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T cell<T>(ref Cell128 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<Cell128,T>(ref src), index);

        /// <summary>
        /// Queries/manipulates a generic cell within a 256-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T cell<T>(ref Cell256 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<Cell256,T>(ref src), index);
    }
}