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
    using static As;

    partial class XTend
    {
        /// <summary>
        /// Reimagines a span of generic values as a span of signed 8-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<sbyte> AsInt8<T>(this Span<T> src)
            where T : struct        
                => cast<T,sbyte>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of unsigned 8-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> AsUInt8<T>(this Span<T> src)
            where T : struct        
                => cast<T,byte>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of signed 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<short> AsInt16<T>(this Span<T> src)
            where T : struct        
                => cast<T,short>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<ushort> AsUInt16<T>(this Span<T> src)
            where T : struct        
                => cast<T,ushort>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of signed 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<int> AsInt32<T>(this Span<T> src)
            where T : struct        
                => cast<T,int>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<uint> AsUInt32<T>(this Span<T> src)
            where T : struct        
                => cast<T,uint>(src);
        
        /// <summary>
        /// Reimagines a span of generic values as a span of 64-bit signed integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<long> AsInt64<T>(this Span<T> src)
            where T : struct        
                => cast<T,long>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of 64-bit unsigned integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<ulong> AsUInt64<T>(this Span<T> src)
            where T : struct        
                => cast<T,ulong>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of 32-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<float> AsFloat32<T>(this Span<T> src)
            where T : struct        
                => cast<T,float>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of 64-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<double> AsFloat64<T>(this Span<T> src)
            where T : struct        
                => cast<T,double>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of 64-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<decimal> AsFloat128<T>(this Span<T> src)
            where T : struct        
                => cast<T,decimal>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of bools
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<bool> AsBool<T>(this Span<T> src)
            where T : struct        
                => cast<T,bool>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of 64-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<char> AsChar<T>(this Span<T> src)
            where T : struct        
                => cast<T,char>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of chars
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<E> AsEnum<T,E>(this Span<T> src, E e = default)
            where T : struct
            where E : unmanaged, Enum
                => cast<T,E>(src); 

        /// <summary>
        /// Reimagines a readonly span of generic values as a span of signed bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source span element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<sbyte> AsInt8<T>(this ReadOnlySpan<T> src)
            where T : struct
                => cast<T,sbyte>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of signed 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<short> AsInt16<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => cast<T,short>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<ushort> AsUInt16<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => cast<T,ushort>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of signed 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<int> AsInt32<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => cast<T,int>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<uint> AsUInt32<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => cast<T,uint>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of 64-bit signed integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<long> AsInt64<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => cast<T,long>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of 64-bit unsigned integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<ulong> AsUInt64<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => cast<T,ulong>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of 32-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<float> AsFloat32<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => cast<T,float>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of 64-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<double> AsFloat64<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => cast<T,double>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of 64-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<decimal> AsFloat128<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => cast<T,decimal>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of boola
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<bool> AsBool<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => cast<T,bool>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of chars
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> AsChar<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => cast<T,char>(src);      
    }
}