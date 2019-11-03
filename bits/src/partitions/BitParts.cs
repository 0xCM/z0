//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static BitMasks;
    using static As;

    /// <summary>
    /// Defines the signature of an operator that accepts a primal value and 
    /// partitions the value, or portion thereof, into segments of common length 
    /// </summary>
    /// <param name="src">The source value</param>
    /// <param name="dst">The target span of sufficent length to receive the partition segments</param>
    /// <typeparam name="S">The primal source type</typeparam>
    /// <typeparam name="T">The primal target type</typeparam>
    public delegate void Partitioner<S,T>(S src, Span<T> dst)
        where T : unmanaged;

    /// <summary>
    /// Defines bitwise partition structures and functions
    /// </summary>
    public static partial class BitParts
    {            
        [MethodImpl(Inline)]
        static ulong project(ulong src, ulong mask)
            => Bits.scatter(src,mask);    

        /// <summary>
        /// Selects the mask-identified bits from a source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The bit selection spec</param>
        [MethodImpl(Inline)]
        public static byte select(byte src, BitMask8 spec)
            => Bits.gather(src, (byte)spec);

        /// <summary>
        /// Selects the mask-identified bits from a source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The bit selection spec</param>
        [MethodImpl(Inline)]
        public static ushort select(ushort src, BitMask16 spec)
            => Bits.gather(src, (ushort)spec);

        /// <summary>
        /// Selects the mask-identified bits from a source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The bit selection spec</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, BitMask32 spec)
            => Bits.gather(src, (uint)spec);

        /// <summary>
        /// Selects the mask-identified bits from a source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The bit selection spec</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, BitMask64 spec)
            => Bits.gather(src, (ulong)spec);

    }


}