//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    public static class BlockExtend    
    {

        /// <summary>
        /// Reverses a blocked span in-place
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> Reverse<T>(this in Block256<T> src)
            where T : unmanaged
        {
            src.Data.Reverse();
            return src;
        }

        /// <summary>
        /// Reverses a blocked span in-place
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> Reverse<T>(this in Block128<T> src)
            where T : unmanaged
        {
            src.Data.Reverse();
            return src;
        }

        /// <summary>
        /// Constructs a 256-bit blocked span from an array
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> ToSpan256<T>(this T[] src)
            where T : unmanaged
            => Z0.Block256.load<T>(src);

        /// <summary>
        /// Constructs a 128-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> ToSpan128<T>(this Span<T> src)
             where T : unmanaged
                => Z0.Block128.load(src);

        /// <summary>
        /// Constructs a 128-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> ToSpan256<T>(this Span<T> src)
             where T : unmanaged
                => Z0.Block256.load(src);

        [MethodImpl(Inline)]
        public static NatBlock<N,T> ToNatural<N,T>(this Span<T> src, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => NatBlock.load(n,src);

        /// <summary>
        /// Presents an unsized span as one of natural length
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="size">The target size</param>
        /// <typeparam name="N">The target type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static NatBlock<N,T> AsNatural<N,T>(this Span<T> src, N size = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => NatBlock<N, T>.CheckedTransfer(src);       

        /// <summary>
        /// Presents the source span as a byte span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">The source span type</typeparam>
        [MethodImpl(Inline)]
        public static NatBlock<N,byte> AsBytes<N,T>(this in NatBlock<N,T> src)
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
        public static NatBlock<N,sbyte> AsSBytes<N,T>(this in NatBlock<N,T> src)
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
        public static NatBlock<N,ushort> AsUInt16<N,T>(this in NatBlock<N,T> src)
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
        public static NatBlock<N,short> AsInt16<N,T>(this in NatBlock<N,T> src)
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
        public static NatBlock<N,int> AsInt32<N,T>(this in NatBlock<N,T> src)
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
        public static NatBlock<N,uint> AsUInt32<N,T>(this in NatBlock<N,T> src)
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
        public static NatBlock<N,long> AsInt64<N,T>(this in NatBlock<N,T> src)
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
        public static NatBlock<N,ulong> AsUInt64<N,T>(this in NatBlock<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.As<ulong>();


        [MethodImpl(Inline)]
        public static NatBlock<N,float> AsSingle<N,T>(this in NatBlock<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.As<float>();

        [MethodImpl(Inline)]
        public static NatBlock<N,double> AsDouble<N,T>(this in NatBlock<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.As<double>();


        /// <summary>
        /// Clones a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> Replicate<T>(this in Block256<T> src, bool structureOnly = false)
            where T : unmanaged
        {
            Span<T> dst = new T[src.Length];
            if(!structureOnly)
                src.CopyTo(dst);
            return Z0.Block256<T>.LoadAligned(dst);
        }

        /// <summary>
        /// Clones a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> Replicate<T>(this in ConstBlock256<T> src, bool structureOnly = false)
            where T : unmanaged
        {
            Span<T> dst = new T[src.Length];
            if(!structureOnly)
                src.CopyTo(dst);
            return Z0.Block256<T>.LoadAligned(dst);
        }





 
    }
}
