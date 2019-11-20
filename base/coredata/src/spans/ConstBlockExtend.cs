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
        /// Presents selected span content as a readonly span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The source offset</param>
        /// <param name="length">The source length</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> AsBytes<T>(this ReadOnlySpan<T> src, int offset = 0, int ? length = null)
            where T : unmanaged
            =>   (offset == 0 && length == null) 
                ? MemoryMarshal.AsBytes(src)
                : length == null  
                ? MemoryMarshal.AsBytes(src.Slice(offset)) 
                : MemoryMarshal.AsBytes(src.Slice(offset, length.Value));

        /// <summary>
        /// Reimagines a readonly span of generic values as a span of readonly bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source span element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> AsBytes<T>(this ReadOnlySpan<T> src)
            where T : unmanaged
                => MemoryMarshal.AsBytes(src);

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
        public static ReadOnlySpan<double> AsFloat64<T>(this ReadOnlySpan<T> src)
            where T : unmanaged        
                => MemoryMarshal.Cast<T,double>(src);

        /// <summary>
        /// Reimagines a span of signed bytes as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> As<T>(this ReadOnlySpan<sbyte> src)
            where T : unmanaged
                => MemoryMarshal.Cast<sbyte,T>(src);

        /// <summary>
        /// Reimagines a span of bytes as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> As<T>(this ReadOnlySpan<byte> src)
            where T : unmanaged
                => MemoryMarshal.Cast<byte,T>(src);

        /// <summary>
        /// Reimagines a span of signed 16-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> As<T>(this ReadOnlySpan<short> src)
            where T : unmanaged
                => MemoryMarshal.Cast<short,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 16-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> As<T>(this ReadOnlySpan<ushort> src)
            where T : unmanaged
                => MemoryMarshal.Cast<ushort,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> As<T>(this ReadOnlySpan<uint> src)
            where T : unmanaged
                => MemoryMarshal.Cast<uint,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit signed integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> As<T>(this ReadOnlySpan<int> src)
            where T : unmanaged
                => MemoryMarshal.Cast<int,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 64-bit signed integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> As<T>(this ReadOnlySpan<long> src)
            where T : unmanaged
                => MemoryMarshal.Cast<long,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 64-bit unsigned integers as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> As<T>(this ReadOnlySpan<ulong> src)
            where T : unmanaged
                => MemoryMarshal.Cast<ulong,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 32-bit floats as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> As<T>(this ReadOnlySpan<float> src)
            where T : unmanaged
                => MemoryMarshal.Cast<float,T>(src);

        /// <summary>
        /// Reimagines a span of unsigned 64-bit floats as a span of generic values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> As<T>(this ReadOnlySpan<double> src)
            where T : unmanaged
                => MemoryMarshal.Cast<double,T>(src);
 
        /// <summary>
        /// Presents a readonly span of one value-type as a span of another value-type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source span element type</typeparam>
        /// <typeparam name="T">The target span element type</typeparam>
        [MethodImpl(Inline)]        
        public static ReadOnlySpan<T> As<S,T>(this ReadOnlySpan<S> src)
            where S : unmanaged
            where T : unmanaged
                => MemoryMarshal.Cast<S,T>(src);                                    

        /// <summary>
        /// Presents the source span as a byte span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">The source span type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock<N,byte> AsBytes<N,T>(this ConstBlock<N,T> src)
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
        public static ConstBlock<N,sbyte> AsSBytes<N,T>(this ConstBlock<N,T> src)
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
        public static ConstBlock<N,ushort> AsUInt16<N,T>(this ConstBlock<N,T> src)
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
        public static ConstBlock<N,short> AsInt16<N,T>(this ConstBlock<N,T> src)
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
        public static ConstBlock<N,int> AsInt32<N,T>(this ConstBlock<N,T> src)
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
        public static ConstBlock<N,uint> AsUInt32<N,T>(this ConstBlock<N,T> src)
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
        public static ConstBlock<N,long> AsInt64<N,T>(this ConstBlock<N,T> src)
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
        public static ConstBlock<N,ulong> AsUInt64<N,T>(this ConstBlock<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.As<ulong>();

        /// <summary>
        /// Presents the source span as a float span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">The source span type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock<N,float> AsSingle<N,T>(this ConstBlock<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.As<float>();

        /// <summary>
        /// Presents the source span as a double span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">The source span type</typeparam>
        [MethodImpl(Inline)]
        public static ConstBlock<N,double> AsDouble<N,T>(this ConstBlock<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.As<double>(); 
    }

}