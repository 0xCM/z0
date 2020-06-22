//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct As
    {

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(char src)
            => As<char,T>(ref src);                 

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(bool src)
            => As<bool,T>(ref src);                 

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(sbyte src)
            => As<sbyte,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(byte src)
            => As<byte,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(short src)
            => As<short,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(ushort src)
            => As<ushort,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(int src)
            => As<int,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(uint src)
            => As<uint,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(long src)
            => As<long,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(ulong src)
            => As<ulong,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(float src)
            => As<float,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(double src)
            => As<double,T>(ref src);            

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(decimal src)
            => As<decimal,T>(ref src);            

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref sbyte src)
            => ref As<sbyte,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref byte src)
            => ref As<byte,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref short src)
            => ref As<short,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref ushort src)
            => ref As<ushort,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref int src)
            => ref As<int,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref uint src)
            => ref As<uint,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref ulong src)
            => ref As<ulong,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref decimal src)
            => ref As<decimal,T>(ref src);
 
        /// <summary>
        /// Reimagines a span of bytes as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> generic<T>(Span<byte> src)
            where T : unmanaged
                => MemoryMarshal.Cast<byte,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> generic<T>(Span<uint> src)
            where T : unmanaged
                => MemoryMarshal.Cast<uint,T>(src);

        /// <summary>
        /// Reimagines a span of signed bytes as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> generic<T>(Span<sbyte> src)
            where T : unmanaged
                => MemoryMarshal.Cast<sbyte,T>(src);

        /// <summary>
        /// Reimagines a span of signed 16-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> generic<T>(Span<short> src)
            where T : unmanaged
                => MemoryMarshal.Cast<short,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 16-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> generic<T>(Span<ushort> src)
            where T : unmanaged
                => MemoryMarshal.Cast<ushort,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit signed integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> generic<T>(Span<int> src)
            where T : unmanaged
                => MemoryMarshal.Cast<int,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 64-bit signed integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> generic<T>(Span<long> src)
            where T : unmanaged
                => MemoryMarshal.Cast<long,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 64-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> generic<T>(Span<ulong> src)
            where T : unmanaged
                => MemoryMarshal.Cast<ulong,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit floats as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> generic<T>(Span<float> src)
            where T : unmanaged
                => MemoryMarshal.Cast<float,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 64-bit floats as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> generic<T>(Span<double> src)
            where T : unmanaged
                => MemoryMarshal.Cast<double,T>(src);

        /// <summary>
        /// Presents a span of 128-bit decimal values as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> generic<T>(Span<decimal> src)
            where T : unmanaged
                => MemoryMarshal.Cast<decimal,T>(src);

        /// <summary>
        /// Reimagines a span of signed bytes as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<sbyte> src)
            where T : unmanaged
                => MemoryMarshal.Cast<sbyte,T>(src);

        /// <summary>
        /// Reimagines a span of bytes as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<byte> src)
            where T : unmanaged
                => MemoryMarshal.Cast<byte,T>(src);

        /// <summary>
        /// Reimagines a span of signed 16-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<short> src)
            where T : unmanaged
                => MemoryMarshal.Cast<short,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 16-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<ushort> src)
            where T : unmanaged
                => MemoryMarshal.Cast<ushort,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<uint> src)
            where T : unmanaged
                => MemoryMarshal.Cast<uint,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit signed integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<int> src)
            where T : unmanaged
                => MemoryMarshal.Cast<int,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 64-bit signed integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<long> src)
            where T : unmanaged
                => MemoryMarshal.Cast<long,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 64-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<ulong> src)
            where T : unmanaged
                => MemoryMarshal.Cast<ulong,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit floats as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<float> src)
            where T : unmanaged
                => MemoryMarshal.Cast<float,T>(src);

        /// <summary>
        /// Presents a span of 64-bit floats as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<double> src)
            where T : unmanaged
                => MemoryMarshal.Cast<double,T>(src); 

        /// <summary>
        /// Presents a span of 128-bit decimals as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<decimal> src)
            where T : unmanaged
                => MemoryMarshal.Cast<decimal,T>(src); 
    }
}