//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using S = uint6;

    partial class Bit
    {
        /// <summary>
        /// Creates a 6-bit unsigned integer, equal to zero or one, if the source value is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static S uint6(bool src)
            => new S(z.bitstate(src));

        /// <summary>
        /// Creates a 6-bit usigned integer from the least 6 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint6(byte src)
            => new S(src);

        /// <summary>
        /// Creates a 6-bit usigned integer from the least 6 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint6(sbyte src)
            => new S(src);

        /// <summary>
        /// Creates a 6-bit usigned integer from the least 6 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint6(ushort src)
            => new S(src);

        /// <summary>
        /// Creates a 6-bit usigned integer from the least 6 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint6(short src)
            => new S(src);

        /// <summary>
        /// Creates a 6-bit usigned integer from the least 6 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static S uint6(int src)
            => new S(src);

        /// <summary>
        /// Creates a 6-bit usigned integer from the least 6 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint6(uint src)
            => new S(src);

        /// <summary>
        /// Creates a 6-bit usigned integer from the least 6 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static S uint6(long src)
            => new S(src);

        /// <summary>
        /// Creates a 6-bit usigned integer from the least 6 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint6(ulong src)        
            => new S((byte)((byte)src & S.MaxVal));

        /// <summary>
        /// Constructs a uint6 value from a sequence of bits ranging from low to high
        /// </summary>
        /// <param name="x0">The first/least bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x1">The second bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x2">The third bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x3">The fourth/highest bit value, if specified; otherwise, defaults to 0</param>
        [MethodImpl(Inline), Op]
        public static S uint6(BitState x0, BitState x1 = default, BitState x2 = default, BitState x3 = default, BitState x4 = default, BitState x5 = default)
             => wrap6((byte)(
                 ((uint)x0 << 0) | 
                 ((uint)x1 << 1) | 
                 ((uint)x2 << 2) | 
                 ((uint)x3 << 3) | 
                 ((uint)x4 << 4) | 
                 ((uint)x5 << 5)
                ));
        
        [MethodImpl(Inline), Op]
        public static S add(S x, S y)
        {
            var sum = (byte)(x.data + y.data);
            return wrap6((sum >= S.Count) ? (byte)(sum - S.Count): sum);
        }

        [MethodImpl(Inline), Op]
        public static S sub(S x, S y)
        {
            var diff = (int)x - (int)y;
            return wrap6(diff < 0 ? (byte)(diff + S.Count) : (byte)diff);
        }

        [MethodImpl(Inline), Op]
        public static S div (S lhs, S rhs) 
            => wrap6((byte)(lhs.data / rhs.data));

        [MethodImpl(Inline), Op]
        public static S mod (S lhs, S rhs)
            => wrap6((byte)(lhs.data % rhs.data));

        [MethodImpl(Inline), Op]
        public static S mul(S lhs, S rhs)
            => reduce6((byte)(lhs.data * rhs.data));

        [MethodImpl(Inline), Op]
        public static S or(S lhs, S rhs)
            => wrap6((byte)(lhs.data | rhs.data));

        [MethodImpl(Inline), Op]
        public static S and(S lhs, S rhs)
            => wrap6((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline), Op]
        public static S xor(S lhs, S rhs)
            => wrap6((byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline), Op]
        public static S srl(S lhs, byte rhs)
            => uint6(lhs.data >> rhs);

        [MethodImpl(Inline), Op]
        public static S sll(S lhs, byte rhs)
            => uint6(lhs.data << rhs);


        [MethodImpl(Inline), Op]
        public static BitState test(S src, byte pos)
            => z.test(src,pos);

        [MethodImpl(Inline), Op]
        public static S set(S src, byte pos, BitState state)
        {
            if(pos < S.Width)
                return wrap6(z.set(src.data, pos, state));
            else
                return src;
        }

        [MethodImpl(Inline)]
        public static bool eq(S x, S y)
            => x.data == y.data;

        [MethodImpl(Inline)]
        internal static byte crop6(byte x) 
            => (byte)(S.MaxVal & x);

        [MethodImpl(Inline), Op]
        internal static byte reduce6(byte x) 
            => (byte)(x % S.Count);

        [MethodImpl(Inline)]
        internal static S wrap6(byte src) 
            => new S(src,false);

        static BitFormatConfig FormatConfig6 
            => BitFormatter.limited(S.Width,S.Width);
        
        [MethodImpl(Inline)]
        public static string format(S src)
            => BitFormatter.format(src.data, FormatConfig6);
    }
}