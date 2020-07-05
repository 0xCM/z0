//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using S = uint3;

    partial class BitSeqD
    {
        /// <summary>
        /// Creates a 3-bit unsigned integer, equal to zero or one, if the source value is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static S uint3(bool src)
            => new S(As.bit(src));

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint3(byte src)
            => new S(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint3(sbyte src)
            => new S(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint3(ushort src)
            => new S(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint3(short src)
            => new S(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static S uint3(int src)
            => new S(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint3(uint src)
            => new S(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static S uint3(long src)
            => new S(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint3(ulong src)        
            => new S((byte)((byte)src & S.MaxVal));

        /// <summary>
        /// Creates a 3-bit unsigned integer from a 3-term bit sequence
        /// </summary>
        /// <param name="x0">The term at index 0</param>
        /// <param name="x1">The term at index 1</param>
        /// <param name="x2">The term at index 2</param>
        [MethodImpl(Inline), Op]
        public static S uint3(Bit x0, Bit x1 = default, Bit x2 = default)
             => wrap3((byte)(
                 ((uint)x0 << 0) | 
                 ((uint)x1 << 1) | 
                 ((uint)x2 << 2)
                 ));
        
        [MethodImpl(Inline), Op]
        public static S add(S x, S y)
        {
            var sum = x.data + y.data;
            return wrap3((sum >= S.Count) ? (byte)(sum - S.Count): (byte)sum);
        }

        [MethodImpl(Inline), Op]
        public static S sub(S x, S y)
        {
            var diff = (int)x - (int)y;
            return wrap3(diff < 0 ? (byte)(diff + S.Count) : (byte)diff);
        }

        [MethodImpl(Inline), Op]
        public static S mul(S lhs, S rhs)
            => reduce4((byte)(lhs.data * rhs.data));

        [MethodImpl(Inline), Op]
        public static S div (S lhs, S rhs) 
            => wrap3((byte)(lhs.data / rhs.data));

        [MethodImpl(Inline), Op]
        public static S mod (S lhs, S rhs)
            => wrap3((byte)(lhs.data % rhs.data));

        [MethodImpl(Inline), Op]
        public static S or(S lhs, S rhs)
            => wrap3((byte)(lhs.data | rhs.data));

        [MethodImpl(Inline), Op]
        public static S and(S lhs, S rhs)
            => wrap3((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline), Op]
        public static S xor(S lhs, S rhs)
            => wrap3((byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline), Op]
        public static S srl(S lhs, byte rhs)
            => uint3(lhs.data >> rhs);

        [MethodImpl(Inline), Op]
        public static S sll(S lhs, byte rhs)
            => uint3(lhs.data << rhs);

        [MethodImpl(Inline), Op]
        public static S inc(S x)
            => !x.IsMax ? new S(core.add(x.data, 1), false) : S.Min;

        [MethodImpl(Inline), Op]
        public static S dec(S x)
            => !x.IsMin ? new S(core.sub(x.data, 1), false) : S.Max;

        [MethodImpl(Inline), Op]
        public static Bit test(S src, byte pos)
            => core.test(src,pos);

        [MethodImpl(Inline), Op]
        public static S set(S src, byte pos, Bit state)
        {
            if(pos < S.Width)
                return wrap3(core.set(src.data, pos, state));
            else
                return src;
        }

        [MethodImpl(Inline), Op]
        public static bool eq(S x, S y)
            => x.data == y.data;

        [MethodImpl(Inline), Op]
        internal static byte reduce3(byte x) 
            => (byte)(x % S.Count);

        [MethodImpl(Inline)]
        internal static S wrap3(byte src) 
            => new S(src,false);

        [MethodImpl(Inline)]
        internal static S wrap3(int src)         
            => new S((byte)src,false);

        [MethodImpl(Inline)]
        internal static byte crop3(byte x) 
            => (byte)(S.MaxVal & x);
        
        static BitFormatConfig FormatConfig3 
            => BitFormatter.limited(S.Width,S.Width);
        
        [MethodImpl(Inline)]
        public static string format(S src)
            => BitFormatter.format(src.data, FormatConfig3);

        /// <summary>
        /// Promotes a triad to an quartet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint4 extend(S src, W4 w)
            => src;

        /// <summary>
        /// Promotes a triad to an quintet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint5 extend(S src, W5 w)
            => src;

        /// <summary>
        /// Promotes a triad to an quintet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint6 extend(S src, W6 w)
            => src;

        /// <summary>
        /// Promotes a triad to an octet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static octet extend(S src, W8 w)
            => src;
    }
}