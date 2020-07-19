//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using S = octet;

    partial class Bit
    {
        /// <summary>
        /// Creates a 8-bit unsigned integer, equal to zero or one, according to whether the source is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint8(bool src)        
            => new S(z.bitstate(src));

        /// <summary>
        /// Creates a 8-bit usigned integer from the least 8 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint8(byte src)
            => new S(src);

        /// <summary>
        /// Creates a 8-bit usigned integer from the least 8 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint8(sbyte src)
            => new S((byte)src);

        /// <summary>
        /// Creates a 8-bit usigned integer from the least 8 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint8(ushort src)
            => new S((byte)src);

        /// <summary>
        /// Creates a 8-bit usigned integer from the least 8 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint8(short src)
            => new S((byte)src);

        /// <summary>
        /// Creates a 8-bit usigned integer from the least 8 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static S uint8(int src)
            => new S((byte)src);

        /// <summary>
        /// Creates a 8-bit usigned integer from the least 8 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint8(uint src)
            => new S((byte)src);

        /// <summary>
        /// Creates a 8-bit usigned integer from the least 8 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static S uint8(long src)
            => new S((byte)src);

        /// <summary>
        /// Creates a 8-bit usigned integer from the least 8 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint8(ulong src)        
            => new S((byte)src);

        [MethodImpl(Inline), Op]
        public static BitState test(S src, byte pos)
            => z.test(src,pos);
        
        [MethodImpl(Inline), Op]
        public static S set(S src, byte pos, BitState state)
        {
            if(pos < S.Width)
                return new S(z.set(src.data, pos, state));
            else
                return src;
        }
    }
}