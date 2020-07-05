//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using analog = octet;

    partial class BitSet
    {
        /// <summary>
        /// Creates a 7-bit unsigned integer, equal to zero or one, according to whether the source is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint8(bool src)        
            => new analog(As.bit(src));

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint8(byte src)
            => new analog(src);

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint8(sbyte src)
            => new analog((byte)src);

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint8(ushort src)
            => new analog((byte)src);

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint8(short src)
            => new analog((byte)src);

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static analog uint8(int src)
            => new analog((byte)src);

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint8(uint src)
            => new analog((byte)src);

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static analog uint8(long src)
            => new analog((byte)src);

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint8(ulong src)        
            => new analog((byte)src);

        [MethodImpl(Inline), Op]
        public static Bit test(analog src, byte pos)
            => core.test(src,pos);

        [MethodImpl(Inline), Op]
        public static ref analog set(in analog src, byte pos, Bit state)
        {
            ref var dst = ref Unsafe.AsRef(src);
            if(pos < analog.Width)
                dst.data = core.set(src.data, pos, state);
            return ref dst;
        }
    }
}