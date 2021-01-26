//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static Numeric;
    using static memory;

    partial class Cells
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T cell<T>(ReadOnlySpan<byte> src)
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(cell(src, n1));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(cell(src, n2));
            else if(typeof(T) == typeof(uint))
                return generic<T>(cell(src, n4));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(cell(src, n8));
            else
                return default;
        }

        [MethodImpl(Inline), Op]
        public static ulong cell(ReadOnlySpan<byte> src, N1 n)
            => memory.first(src);


        [MethodImpl(Inline), Op]
        public static ulong cell(ReadOnlySpan<byte> src, N5 n)
        {
            var dst = 0ul;
            seek32(dst, 0) = (uint)cell(src,n4);
            seek32(dst, 1) = skip(src, 4);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ulong cell(ReadOnlySpan<byte> src, N6 n)
        {
            var dst = 0ul;
            seek32(dst, 0) = (uint)cell(src, n4);
            seek32(dst, 1) = (uint)cell(src, n2);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ulong cell(ReadOnlySpan<byte> src, N8 n)
            => memory.first(memory.recover<byte,ulong>(src));

        /// <summary>
        /// Creates a <see cref='Cell8'/> from a specified <see cref='byte'/> value
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static Cell8 cell(byte src)
            => src;

        /// <summary>
        /// Creates a <see cref='Cell8'/> from a specified <see cref='sbyte'/> value
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static Cell8 cell(sbyte src)
            => src;

        /// <summary>
        /// Creates a <see cref='Cell16'/> from a specified <see cref='short'/> value
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static Cell16 cell(short src)
            => src;

        /// <summary>
        /// Creates a <see cref='Cell16'/> from a specified <see cref='ushort'/> value
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static Cell16 cell(ushort src)
            => src;

        /// <summary>
        /// Creates a <see cref='Cell32'/> from a specified <see cref='int'/> value
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static Cell32 cell(int src)
            => src;

        /// <summary>
        /// Creates a <see cref='Cell32'/> from a specified <see cref='uint'/> value
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static Cell32 cell(uint src)
            => src;

        /// <summary>
        /// Creates a <see cref='Cell64'/> from a specified <see cref='long'/> value
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static Cell64 cell(long src)
            => src;

        /// <summary>
        /// Creates a <see cref='Cell64'/> from a specified <see cref='ulong'/> value
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static Cell64 cell(ulong src)
            => src;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Cell128 init<T>(Vector128<T> src)
            where T : unmanaged
                => new Cell128(gcpu.v64u(src));

        [MethodImpl(Inline), Op]
        public static Cell128 cell((ulong x0, ulong x1) x)
            => new Cell128(x.x0, x.x1);

        [MethodImpl(Inline), Op]
        public static Cell128 cell(in ConstPair<ulong> x)
            => new Cell128(x.Left, x.Right);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Cell8 cell8<T>(T src)
            where T : unmanaged
                => new Cell8(force<T,byte>(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Cell16 cell16<T>(T src)
            where T : unmanaged
                => Cell16.init(force<T,ushort>(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Cell32 cell32<T>(T src)
            where T : unmanaged
                => new Cell32(force<T,uint>(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Cell64 cell64<T>(T src)
            where T : unmanaged
                => new Cell64(force<T,ulong>(src));

        /// <summary>
        /// Presents a 128-bit vector as a 128-bit fixed block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Cell128 cell<T>(in Vector128<T> src)
            where T : unmanaged
                => ref from<Vector128<T>,Cell128>(in src);

        /// <summary>
        /// Presents a 256-bit vector as a 256-bit fixed block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Cell256 cell<T>(in Vector256<T> src)
            where T : unmanaged
                => ref from<Vector256<T>,Cell256>(in src);

        /// <summary>
        /// Presents a 512-bit vector as a 512-bit fixed block
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Cell512 cell<T>(in Vector512<T> src)
            where T : unmanaged
                => ref from<Vector512<T>,Cell512>(in src);

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

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Cell128 cell<T>(W128 w, T src)
            where T : unmanaged
                => cell(gcpu.vscalar(w128,src));

        [MethodImpl(Inline), Op]
        static ulong cell(ReadOnlySpan<byte> src, N2 n)
            => memory.first(memory.recover<byte,ushort>(slice(src,2)));

        [MethodImpl(Inline), Op]
        static ulong cell(ReadOnlySpan<byte> src, N4 n)
            => memory.first(memory.recover<byte,uint>(slice(src,4)));
    }
}