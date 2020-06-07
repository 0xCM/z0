//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Seed;

    [ApiHost]
    public readonly struct SpanAs
    {
        /// <summary>
        /// Reimagines a span of bytes as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> As<T>(Span<byte> src)
            where T : unmanaged
                => MemoryMarshal.Cast<byte,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> As<T>(Span<uint> src)
            where T : unmanaged
                => MemoryMarshal.Cast<uint,T>(src);

        /// <summary>
        /// Reimagines a span of signed bytes as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> As<T>(Span<sbyte> src)
            where T : unmanaged
                => MemoryMarshal.Cast<sbyte,T>(src);

        /// <summary>
        /// Reimagines a span of signed 16-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> As<T>(Span<short> src)
            where T : unmanaged
                => MemoryMarshal.Cast<short,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 16-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> As<T>(Span<ushort> src)
            where T : unmanaged
                => MemoryMarshal.Cast<ushort,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit signed integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> As<T>(Span<int> src)
            where T : unmanaged
                => MemoryMarshal.Cast<int,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 64-bit signed integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> As<T>(Span<long> src)
            where T : unmanaged
                => MemoryMarshal.Cast<long,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 64-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> As<T>(Span<ulong> src)
            where T : unmanaged
                => MemoryMarshal.Cast<ulong,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 64-bit floats as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> As<T>(Span<double> src)
            where T : unmanaged
                => MemoryMarshal.Cast<double,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit floats as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> As<T>(Span<float> src)
            where T : unmanaged
                => MemoryMarshal.Cast<float,T>(src);

        /// <summary>
        /// Reimagines a span of signed bytes as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> As<T>(ReadOnlySpan<sbyte> src)
            where T : unmanaged
                => MemoryMarshal.Cast<sbyte,T>(src);

        /// <summary>
        /// Reimagines a span of bytes as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> As<T>(ReadOnlySpan<byte> src)
            where T : unmanaged
                => MemoryMarshal.Cast<byte,T>(src);

        /// <summary>
        /// Reimagines a span of signed 16-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> As<T>(ReadOnlySpan<short> src)
            where T : unmanaged
                => MemoryMarshal.Cast<short,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 16-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> As<T>(ReadOnlySpan<ushort> src)
            where T : unmanaged
                => MemoryMarshal.Cast<ushort,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> As<T>(ReadOnlySpan<uint> src)
            where T : unmanaged
                => MemoryMarshal.Cast<uint,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit signed integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> As<T>(ReadOnlySpan<int> src)
            where T : unmanaged
                => MemoryMarshal.Cast<int,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 64-bit signed integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> As<T>(ReadOnlySpan<long> src)
            where T : unmanaged
                => MemoryMarshal.Cast<long,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 64-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> As<T>(ReadOnlySpan<ulong> src)
            where T : unmanaged
                => MemoryMarshal.Cast<ulong,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit floats as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> As<T>(ReadOnlySpan<float> src)
            where T : unmanaged
                => MemoryMarshal.Cast<float,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 64-bit floats as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> As<T>(ReadOnlySpan<double> src)
            where T : unmanaged
                => MemoryMarshal.Cast<double,T>(src);
    }
}