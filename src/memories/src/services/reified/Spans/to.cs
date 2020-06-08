namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Seed;

    partial class Spans
    {
        /// <summary>
        /// Reimagines a span of bytes as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> to<T>(Span<byte> src)
            where T : struct
                => MemoryMarshal.Cast<byte,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> to<T>(Span<uint> src)
            where T : struct
                => MemoryMarshal.Cast<uint,T>(src);

        /// <summary>
        /// Reimagines a span of signed bytes as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> to<T>(Span<sbyte> src)
            where T : struct
                => MemoryMarshal.Cast<sbyte,T>(src);

        /// <summary>
        /// Reimagines a span of signed 16-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> to<T>(Span<short> src)
            where T : struct
                => MemoryMarshal.Cast<short,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 16-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> to<T>(Span<ushort> src)
            where T : struct
                => MemoryMarshal.Cast<ushort,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit signed integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> to<T>(Span<int> src)
            where T : struct
                => MemoryMarshal.Cast<int,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 64-bit signed integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> to<T>(Span<long> src)
            where T : struct
                => MemoryMarshal.Cast<long,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 64-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> to<T>(Span<ulong> src)
            where T : struct
                => MemoryMarshal.Cast<ulong,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 64-bit floats as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> to<T>(Span<double> src)
            where T : struct
                => MemoryMarshal.Cast<double,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit floats as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> to<T>(Span<float> src)
            where T : struct
                => MemoryMarshal.Cast<float,T>(src);

        /// <summary>
        /// Reimagines a span of signed bytes as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> to<T>(ReadOnlySpan<sbyte> src)
            where T : struct
                => MemoryMarshal.Cast<sbyte,T>(src);

        /// <summary>
        /// Reimagines a span of bytes as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> to<T>(ReadOnlySpan<byte> src)
            where T : struct
                => MemoryMarshal.Cast<byte,T>(src);

        /// <summary>
        /// Reimagines a span of signed 16-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> to<T>(ReadOnlySpan<short> src)
            where T : struct
                => MemoryMarshal.Cast<short,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 16-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> to<T>(ReadOnlySpan<ushort> src)
            where T : struct
                => MemoryMarshal.Cast<ushort,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> to<T>(ReadOnlySpan<uint> src)
            where T : struct
                => MemoryMarshal.Cast<uint,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit signed integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> to<T>(ReadOnlySpan<int> src)
            where T : struct
                => MemoryMarshal.Cast<int,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 64-bit signed integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> to<T>(ReadOnlySpan<long> src)
            where T : struct
                => MemoryMarshal.Cast<long,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 64-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> to<T>(ReadOnlySpan<ulong> src)
            where T : struct
                => MemoryMarshal.Cast<ulong,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit floats as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> to<T>(ReadOnlySpan<float> src)
            where T : struct
                => MemoryMarshal.Cast<float,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 64-bit floats as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<T> to<T>(ReadOnlySpan<double> src)
            where T : struct
                => MemoryMarshal.Cast<double,T>(src);        
    }
}