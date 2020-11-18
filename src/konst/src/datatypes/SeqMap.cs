//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct SeqMap
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Projects a sequence of <typeparamref name='T'/> cells onto a sequence of <see cref='sbyte'/> cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<sbyte> i8<T>(Span<T> src)
            where T : struct
                => recover<T,sbyte>(src);

        /// <summary>
        /// Projects a readonly sequence of <typeparamref name='T'/> cells onto a sequence of readonly <see cref='sbyte'/> cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<sbyte> i8<T>(ReadOnlySpan<T> src)
            where T : struct
                => recover<T,sbyte>(src);

        /// <summary>
        /// Projects a sequence of <typeparamref name='T'/> cells onto a sequence of <see cref='byte'/> cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<byte> u8<T>(Span<T> src)
            where T : struct
                => recover<T,byte>(src);

        /// <summary>
        /// Projects a readonly sequence of <typeparamref name='T'/> cells onto a sequence of readonly <see cref='byte'/> cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<byte> u8<T>(ReadOnlySpan<T> src)
            where T : struct
                => recover<T,byte>(src);

        /// <summary>
        /// Projects a sequence of <typeparamref name='T'/> cells onto a sequence of <see cref='short'/> cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<short> i16<T>(Span<T> src)
            where T : struct
                => recover<T,short>(src);

        /// <summary>
        /// Projects a readonly sequence of <typeparamref name='T'/> cells onto a sequence of readonly <see cref='short'/> cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<short> i16<T>(ReadOnlySpan<T> src)
            where T : struct
                => recover<T,short>(src);

        /// <summary>
        /// Projects a sequence of <typeparamref name='T'/> cells onto a sequence of <see cref='ushort'/> cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<ushort> u16<T>(Span<T> src)
            where T : struct
                => recover<T,ushort>(src);

        /// <summary>
        /// Projects a readonly sequence of <typeparamref name='T'/> cells onto a readonly sequence of <see cref='ushort'/> cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<ushort> u16<T>(ReadOnlySpan<T> src)
            where T : struct
                => recover<T,ushort>(src);

        /// <summary>
        /// Projects a sequence of <typeparamref name='T'/> cells onto a sequence of <see cref='int'/> cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<int> i32<T>(Span<T> src)
            where T : struct
                => recover<T,int>(src);

        /// <summary>
        /// Projects a readonly sequence of <typeparamref name='T'/> cells onto a sequence of readonly <see cref='int'/> cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<int> i32<T>(ReadOnlySpan<T> src)
            where T : struct
                => recover<T,int>(src);

        /// <summary>
        /// Projects a sequence of <typeparamref name='T'/> cells onto a sequence of <see cref='uint'/> cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<uint> u32<T>(Span<T> src)
            where T : struct
                => recover<T,uint>(src);

        /// <summary>
        /// Projects a readonly sequence of <typeparamref name='T'/> cells onto a readonly sequence of <see cref='uint'/> cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<uint> u32<T>(ReadOnlySpan<T> src)
            where T : struct
                => recover<T,uint>(src);

        /// <summary>
        /// Projects a sequence of <typeparamref name='T'/> cells onto a sequence of <see cref='long'/> cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<long> i64<T>(Span<T> src)
            where T : struct
                => recover<T,long>(src);

        /// <summary>
        /// Projects a readonly sequence of <typeparamref name='T'/> cells onto a sequence of readonly <see cref='long'/> cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<long> i64<T>(ReadOnlySpan<T> src)
            where T : struct
                => recover<T,long>(src);

        /// <summary>
        /// Projects a sequence of <typeparamref name='T'/> cells onto a sequence of <see cref='ulong'/> cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<ulong> u64<T>(Span<T> src)
            where T : struct
                => recover<T,ulong>(src);

        /// <summary>
        /// Projects a readonly sequence of <typeparamref name='T'/> cells onto a readonly sequence of <see cref='ulong'/> cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<ulong> u64<T>(ReadOnlySpan<T> src)
            where T : struct
                => recover<T,ulong>(src);
    }
}