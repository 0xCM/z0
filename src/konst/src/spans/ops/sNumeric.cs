//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Spans
    {
        /// <summary>
        /// Presents a span of generic values as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<byte> s8u<T>(Span<T> src)
            where T : unmanaged
                => z.recover<T,byte>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a span of signed bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<sbyte> s8i<T>(Span<T> src)
            where T : unmanaged
                => z.recover<T,sbyte>(src);

        /// <summary>
        /// Presents a span of generic values as a span of signed 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<short> s16i<T>(Span<T> src)
            where T : unmanaged
                => z.recover<T,short>(src);

        /// <summary>
        /// Presents a span of generic values as a span of unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<ushort> s16u<T>(Span<T> src)
            where T : unmanaged
                => z.recover<T,ushort>(src);

        /// <summary>
        /// Presents a span of generic values as a span of signed 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<int> s32i<T>(Span<T> src)
            where T : unmanaged
                => z.recover<T,int>(src);

        /// <summary>
        /// Presents a span of generic values as a span of unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<uint> s32u<T>(Span<T> src)
            where T : unmanaged
                => z.recover<T,uint>(src);

        /// <summary>
        /// Presents a span of generic values as a span of 64-bit signed integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<long> s64i<T>(Span<T> src)
            where T : unmanaged
                => z.recover<T,long>(src);

        /// <summary>
        /// Presents a span of generic values as a span of 64-bit unsigned integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<ulong> s64u<T>(Span<T> src)
            where T : unmanaged
                => z.recover<T,ulong>(src);

        /// <summary>
        /// Presents a span of generic values as a span of 32-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<float> s32f<T>(Span<T> src)
            where T : unmanaged
                => z.recover<T,float>(src);

        /// <summary>
        /// Presents a span of generic values as a span of 64-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<double> s64f<T>(Span<T> src)
            where T : unmanaged
                => z.recover<T,double>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of signed bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<sbyte> s8i<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => z.recover<T,sbyte>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<byte> s8u<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => z.recover<T,byte>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of signed 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<short> s16i<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => z.recover<T,short>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<ushort> s16u<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => z.recover<T,ushort>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of signed 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<int> s32i<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => z.recover<T,int>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<uint> s32u<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => z.recover<T,uint>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of 64-bit signed integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<long> s64i<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => z.recover<T,long>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of 64-bit unsigned integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<ulong> s64u<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => z.recover<T,ulong>(src);

        /// <summary>
        /// Presents a readonly span of generic values as a readonly span of 32-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<float> s32f<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => z.recover<T,float>(src);

        /// <summary>
        /// Presents a readonly readonly span of generic values as a readonly readonly span of 64-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<double> s64f<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => z.recover<T,double>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<sbyte> s8i<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => z.recover<T,sbyte>(src.Span);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<byte> s8u<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => z.recover<T,byte>(src.Span);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<short> s16i<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => z.recover<T,short>(src.Span);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<ushort> s16u<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => z.recover<T,ushort>(src.Span);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<int> s32i<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => z.recover<T,int>(src.Span);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<uint> s32u<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => z.recover<T,uint>(src.Span);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<long> s64i<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => z.recover<T,long>(src.Span);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<ulong> s64u<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => z.recover<T,ulong>(src.Span);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<float> s32f<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => z.recover<T,float>(src.Span);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<double> s64f<T>(in ReadOnlyMemory<T> src)
            where T : unmanaged
                => z.recover<T,double>(src.Span);
    }
}