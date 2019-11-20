//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    partial class MemBlockExtend
    {
        /// <summary>
        /// Presents selected span content as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The source offset</param>
        /// <param name="length">The source length</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> AsBytes<T>(this Span<T> src, int offset = 0, int ? length = null)
            where T : unmanaged
            =>   (offset == 0 && length == null) 
                ? MemoryMarshal.AsBytes(src)
                : length == null  
                ? MemoryMarshal.AsBytes(src.Slice(offset)) 
                : MemoryMarshal.AsBytes(src.Slice(offset, length.Value));

        /// <summary>
        /// Reimagines a span of generic values as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> AsBytes<T>(this Span<T> src)
            where T : unmanaged
                => MemoryMarshal.AsBytes(src);

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
        /// Reimagines a span of generic values as a span of signed 16-bit integers
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<short> AsInt16<T>(this Span<T> src)
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
        /// Reimagines a span of generic values as a span of 64-bit floats
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<double> AsFloat64<T>(this Span<T> src)
            where T : unmanaged        
                => MemoryMarshal.Cast<T,double>(src);

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
        /// Reimagines a span of bytes as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> As<T>(this Span<byte> src)
            where T : unmanaged
                => MemoryMarshal.Cast<byte,T>(src);

        /// <summary>
        /// Reimagines a span of signed bytes as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> As<T>(this Span<sbyte> src)
            where T : unmanaged
                => MemoryMarshal.Cast<sbyte,T>(src);


        /// <summary>
        /// Reimagines a span of signed 16-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> As<T>(this Span<short> src)
            where T : unmanaged
                => MemoryMarshal.Cast<short,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 16-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> As<T>(this Span<ushort> src)
            where T : unmanaged
                => MemoryMarshal.Cast<ushort,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit signed integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> As<T>(this Span<int> src)
            where T : unmanaged
                => MemoryMarshal.Cast<int,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> As<T>(this Span<uint> src)
            where T : unmanaged
                => MemoryMarshal.Cast<uint,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 64-bit signed integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> As<T>(this Span<long> src)
            where T : unmanaged
                => MemoryMarshal.Cast<long,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 64-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> As<T>(this Span<ulong> src)
            where T : unmanaged
                => MemoryMarshal.Cast<ulong,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 64-bit floats as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> As<T>(this Span<double> src)
            where T : unmanaged
                => MemoryMarshal.Cast<double,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit floats as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> As<T>(this Span<float> src)
            where T : unmanaged
                => MemoryMarshal.Cast<float,T>(src);

        /// <summary>
        /// Presents a span of one value-type as a span of another value-type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source span element type</typeparam>
        /// <typeparam name="T">The target span element type</typeparam>
        [MethodImpl(Inline)]        
        public static Span<T> As<S,T>(this Span<S> src)
            where S : unmanaged
            where T : unmanaged
                => MemoryMarshal.Cast<S,T>(src);                                    

        /// <summary>
        /// Presents an unsized span as one of natural length
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="size">The target size</param>
        /// <typeparam name="N">The target type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static Span<N,T> AsNatural<N,T>(this Span<T> src, N size = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => Span<N, T>.CheckedTransfer(src);       

        /// <summary>
        /// Presents the source span as a byte span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">The source span type</typeparam>
        [MethodImpl(Inline)]
        public static Span<N,byte> AsBytes<N,T>(this Span<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.As<byte>();

        /// <summary>
        /// Presents the source span as an sbyte span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">The source span type</typeparam>
        [MethodImpl(Inline)]
        public static Span<N,sbyte> AsSBytes<N,T>(this Span<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.As<sbyte>();

        /// <summary>
        /// Presents the source span as a uint16 span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">The source span type</typeparam>
        [MethodImpl(Inline)]
        public static Span<N,ushort> AsUInt16<N,T>(this Span<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.As<ushort>();

        /// <summary>
        /// Presents the source span as an int16 span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">The source span type</typeparam>
        [MethodImpl(Inline)]
        public static Span<N,short> AsInt16<N,T>(this Span<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.As<short>();

        /// <summary>
        /// Presents the source span as an int32 span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">The source span type</typeparam>
        [MethodImpl(Inline)]
        public static Span<N,int> AsInt32<N,T>(this Span<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.As<int>();

        /// <summary>
        /// Presents the source span as a uint32 span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">The source span type</typeparam>
        [MethodImpl(Inline)]
        public static Span<N,uint> AsUInt32<N,T>(this Span<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.As<uint>();

        /// <summary>
        /// Presents the source span as an int64 span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">The source span type</typeparam>
        [MethodImpl(Inline)]
        public static Span<N,long> AsInt64<N,T>(this Span<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.As<long>();

        /// <summary>
        /// Presents the source span as a uint64 span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">The source span type</typeparam>
        [MethodImpl(Inline)]
        public static Span<N,ulong> AsUInt64<N,T>(this Span<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.As<ulong>();


        [MethodImpl(Inline)]
        public static Span<N,float> AsSingle<N,T>(this Span<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.As<float>();

        [MethodImpl(Inline)]
        public static Span<N,double> AsDouble<N,T>(this Span<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.As<double>();
    }

}