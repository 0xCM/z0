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

    partial class XTend
    {
        /// <summary>
        /// Reimagines a readonly span of generic values as a span of signed bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<sbyte> AsSBytes<T>(this Span<T> src)
            where T : unmanaged
                => MemoryMarshal.Cast<T,sbyte>(src);

        /// <summary>
        /// Reimagines a readonly span of generic values as a span of signed bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source span element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<sbyte> AsSBytes<T>(this ReadOnlySpan<T> src)
            where T : unmanaged
                => MemoryMarshal.Cast<T,sbyte>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of chars
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<char> AsChar<T>(this Span<T> src)
            where T : unmanaged        
                => MemoryMarshal.Cast<T,char>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of signed 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<short> AsInt16<T>(this Span<T> src)
            where T : unmanaged        
                => MemoryMarshal.Cast<T,short>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of signed 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<short> AsInt16<T>(this ReadOnlySpan<T> src)
            where T : unmanaged        
                => MemoryMarshal.Cast<T,short>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<ushort> AsUInt16<T>(this Span<T> src)
            where T : unmanaged        
                => MemoryMarshal.Cast<T,ushort>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<ushort> AsUInt16<T>(this ReadOnlySpan<T> src)
            where T : unmanaged        
                => MemoryMarshal.Cast<T,ushort>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of signed 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<int> AsInt32<T>(this ReadOnlySpan<T> src)
            where T : unmanaged        
                => MemoryMarshal.Cast<T,int>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of signed 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<int> AsInt32<T>(this Span<T> src)
            where T : unmanaged        
                => MemoryMarshal.Cast<T,int>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<uint> AsUInt32<T>(this Span<T> src)
            where T : unmanaged        
                => MemoryMarshal.Cast<T,uint>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<uint> AsUInt32<T>(this ReadOnlySpan<T> src)
            where T : unmanaged        
                => MemoryMarshal.Cast<T,uint>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of 64-bit signed integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<long> AsInt64<T>(this ReadOnlySpan<T> src)
            where T : unmanaged        
                => MemoryMarshal.Cast<T,long>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of 64-bit unsigned integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<ulong> AsUInt64<T>(this ReadOnlySpan<T> src)
            where T : unmanaged        
                => MemoryMarshal.Cast<T,ulong>(src);
        
        /// <summary>
        /// Reimagines a span of generic values as a span of 64-bit signed integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<long> AsInt64<T>(this Span<T> src)
            where T : unmanaged        
                => MemoryMarshal.Cast<T,long>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of 64-bit unsigned integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<ulong> AsUInt64<T>(this Span<T> src)
            where T : unmanaged        
                => MemoryMarshal.Cast<T,ulong>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of 32-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<float> AsFloat32<T>(this Span<T> src)
            where T : unmanaged        
                => MemoryMarshal.Cast<T,float>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of 32-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<float> AsFloat32<T>(this ReadOnlySpan<T> src)
            where T : unmanaged        
                => MemoryMarshal.Cast<T,float>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of 64-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<double> AsFloat64<T>(this Span<T> src)
            where T : unmanaged        
                => MemoryMarshal.Cast<T,double>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of 64-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<double> AsFloat64<T>(this ReadOnlySpan<T> src)
            where T : unmanaged        
                => MemoryMarshal.Cast<T,double>(src);
    }
}