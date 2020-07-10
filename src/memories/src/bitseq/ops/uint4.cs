//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;
    using static BitSeq;

    using S = uint4;
    
    partial class BitSeqD
    {
        /// <summary>
        /// Creates a 4-bit unsigned integer, equal to zero or one, if the source value is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static S uint4(bool src)
            => wrap4((byte)As.bit(src));

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint4(byte src)
            => new S(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint4(sbyte src)
            => new S((byte)src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint4(ushort src)
            => new S((byte)src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint4(short src)
            => new S((byte)src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static S uint4(int src)
            => new S((byte)src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint4(uint src)
            => new S((byte)src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static S uint4(long src)
            => new S((byte)src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint4(ulong src)        
            => new S((byte)((byte)src & S.MaxVal));

        /// <summary>
        /// Creates a 4-bit unsigned integer from a 4-term bit sequence
        /// </summary>
        /// <param name="x0">The term at index 0</param>
        /// <param name="x1">The term at index 1</param>
        /// <param name="x2">The term at index 2</param>
        /// <param name="x3">The term at index 3</param>
        [MethodImpl(Inline), Op]
        public static S uint4(Bit x0, Bit x1 = default, Bit x2 = default, Bit x3 = default)
             => wrap4(z.or(
                 z.sll((byte)x0, 0),
                 z.sll((byte)x1, 1),
                 z.sll((byte)x2, 2),
                 z.sll((byte)x3, 3)
                 ));
                 
        [MethodImpl(Inline), Op]
        public static S add(S x, S y)
        {
            var sum = z.add(x.data,y.data);
            var result = z.gteq(sum, S.Count) ? z.sub(sum, S.Count) : sum;
            return new S(result, true);
        }

        [MethodImpl(Inline), Op]
        public static S sub(S x, S y)
        {
            var delta = x.data - y.data;
            if(delta < 0)
                return wrap4((byte)(delta + S.Count));
            else
                return wrap4((byte)delta);            
        }

        [MethodImpl(Inline), Op]
        public static S mul(S lhs, S rhs)
            => reduce4((byte)(lhs.data * rhs.data));

        [MethodImpl(Inline), Op]
        public static S hi(S src)
            => wrap4((byte)(src.data >> 2 & 0b11));

        [MethodImpl(Inline), Op]
        public static S lo(S src)
            => wrap4((byte)(src.data & 0b11));

        [MethodImpl(Inline), Op]
        public static Bit test(S src, byte pos)
            => z.test(src,pos);

        [MethodImpl(Inline), Op]
        public static S set(S src, byte pos, Bit state)
        {
            if(pos < S.Width)
                return wrap4(z.set(src.data, pos, state));
            else
                return src;
        }

        [MethodImpl(Inline)]
        public static bool eq(S x, S y)
            => x.data == y.data;

        [MethodImpl(Inline), Op]
        internal static byte reduce4(byte x) 
            => (byte)(x % S.Count);

        [MethodImpl(Inline)]
        internal static S wrap4(byte src) 
            => new S(src, false);

        [MethodImpl(Inline)]
        internal static byte crop4(byte x) 
            => (byte)(S.MaxVal & x);

        static BitFormatConfig FormatConfig4 
            => BitFormatter.limited(S.Width, S.Width);
        
        [MethodImpl(Inline)]
        public static string format(S src)
            => BitFormatter.format(src.data, FormatConfig4);
    }
}