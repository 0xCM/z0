//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class Cells
    {
        [MethodImpl(Inline)]
        public static ref T segment<C,T,W>(in C src, W w, out T dst)
            where T : unmanaged
            where C : IDataCell
            where W : unmanaged, INumericWidth
                => ref seg1(src,w,out dst);

        /// <summary>
        /// Queries/manipulates a cell within a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T segment<F,T>(ref F src, byte index)
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
        public static ref T segment<T>(ref Cell8 src, byte index)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<Cell8,T>(ref src), index);

        /// <summary>
        /// Queries/manipulates a generic cell within a 16-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16k)]
        public static ref T segment<T>(ref Cell16 src, byte index)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<Cell16,T>(ref src), index);

        /// <summary>
        /// Queries/manipulates a generic cell within a 32-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Numeric8x16x32k)]
        public static ref T segment<T>(ref Cell32 src, byte index)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<Cell32,T>(ref src), index);

        /// <summary>
        /// Queries/manipulates a generic cell within a 64-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T segment<T>(ref Cell64 src, byte index)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<Cell64,T>(ref src), index);

        /// <summary>
        /// Queries/manipulates a generic cell within a 128-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T segment<T>(ref Cell128 src, byte index)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<Cell128,T>(ref src), index);

        /// <summary>
        /// Queries/manipulates a generic cell within a 256-bit storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T segment<T>(ref Cell256 src, byte index)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<Cell256,T>(ref src), index);

        [MethodImpl(Inline)]
        static ref T seg1<C,T,W>(in C src, W w, out T dst)
            where T : unmanaged
            where C : IDataCell
            where W : unmanaged, INumericWidth
        {
            dst = default;
            ref var input = ref @as<C,byte>(src);
            var size = w.BitWidth/8u;
            ref var output = ref @as<T,byte>(dst);
            if(typeof(W) == typeof(W8))
                copy(w8, input, ref output);
            else if(typeof(W) == typeof(W16))
                copy(w16, input, ref output);
            else if(typeof(W) == typeof(W32))
                copy(w32, input, ref output);
            else if(typeof(W) == typeof(W64))
                copy(w64, input, ref output);
            else
                throw no<W>();

            return ref dst;
        }
    }
}