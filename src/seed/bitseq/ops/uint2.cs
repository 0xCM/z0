//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using S = uint2;

    partial class BitSeqD
    {
        /// <summary>
        /// Creates a 2-bit unsigned integer, equal to zero or one, if the source value is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static S uint2(bool src)
            => new S(As.bit(src));

        /// <summary>
        /// Creates a 2-bit usigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint2(byte src)
            => new S(src);

        /// <summary>
        /// Creates a 2-bit usigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint2(sbyte src)
            => new S(src);

        /// <summary>
        /// Creates a 2-bit usigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint2(ushort src)
            => new S(src);

        /// <summary>
        /// Creates a 2-bit usigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint2(short src)
            => new S(src);

        /// <summary>
        /// Creates a 2-bit usigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static S uint2(int src)
            => new S(src);

        /// <summary>
        /// Creates a 2-bit usigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint2(uint src)
            => new S(src);

        /// <summary>
        /// Creates a 2-bit usigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static S uint2(long src)
            => new S(src);

        /// <summary>
        /// Creates a 2-bit usigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint2(ulong src)        
            => new S((byte)((byte)src & S.MaxVal));

        /// <summary>
        /// Creates a 2-bit unsigned integer from a 2-term bit sequence
        /// </summary>
        /// <param name="x0">The term at index 0</param>
        /// <param name="x1">The term at index 1</param>
        [MethodImpl(Inline), Op]
        public static S uint2(bit x0, bit x1 = default)
             => wrap2(((uint)x0 << 0) | ((uint)x1 << 1));

        [MethodImpl(Inline), Op]
        public static S add(S x, S y)
        {
            var sum = x.data + y.data;
            return wrap2((sum >= S.Count) ? sum - (byte)S.Count: sum);
        }

        [MethodImpl(Inline), Op]
        public static S sub(S x, S y)
        {
            var diff = (int)x - (int)y;
            return wrap2(diff < 0 ? (byte)(diff + S.Count) : (byte)diff);
        }

        [MethodImpl(Inline), Op]
        public static S mul(S lhs, S rhs)
            => reduce4((byte)(lhs.data * rhs.data));

        [MethodImpl(Inline), Op]
        public static S div (S lhs, S rhs) 
            => wrap2((byte)(lhs.data / rhs.data));

        [MethodImpl(Inline), Op]
        public static S mod (S lhs, S rhs)
            => wrap2((byte)(lhs.data % rhs.data));

        [MethodImpl(Inline), Op]
        public static S or(S lhs, S rhs)
            => wrap2((byte)(lhs.data | rhs.data));

        [MethodImpl(Inline), Op]
        public static S and(S lhs, S rhs)
            => wrap2((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline), Op]
        public static S xor(S lhs, S rhs)
            => wrap2((byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline), Op]
        public static S srl(S lhs, byte rhs)
            => uint2(lhs.data >> rhs);

        [MethodImpl(Inline), Op]
        public static S sll(S lhs, byte rhs)
            => uint2(lhs.data << rhs);

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
                return wrap2(core.set(src.data, pos, state));
            else
                return src;
        }

        [MethodImpl(Inline), Op]
        public static ref S edit(in S src)
            => ref Unsafe.AsRef(src);    

        [MethodImpl(Inline), Op]
        public static bool eq(S x, S y)
            => x.data == y.data;

        [MethodImpl(Inline)]
        internal static byte crop2(byte x) 
            => (byte)(S.MaxVal & x);

        [MethodImpl(Inline), Op]
        internal static byte reduce2(byte x) 
            => (byte)(x % S.Count);

        [MethodImpl(Inline)]
        internal static S wrap2(uint src) 
            => new S((byte)src,false);

        [MethodImpl(Inline)]
        internal static S wrap2(int src) 
            => new S((byte)src,false);

        static BitFormatConfig FormatConfig2 
            => BitFormatter.limited(S.Width, S.Width);
        
        [MethodImpl(Inline)]
        public static string format(S src)
            => BitFormatter.format(src.data, FormatConfig2);

        /// <summary>
        /// Promotes a <see cref='Z0.uint2'/> to a <see cref='Z0.uint3'/>, as indicated by the <see cref='W3'/> selector 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint3 extend(S src, W3 w)
            => src;

        /// <summary>
        /// Promotes a <see cref='Z0.uint2'/> to a <see cref='Z0.uint3'/>, as indicated by the <see cref='W3'/> selector 
        /// and shifts the result <see cref='N1'/> bit leftward
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        /// <param name="n">The leftward shift count</param>
        [MethodImpl(Inline), Op]
        public static uint3 extend(S src, W3 w, N1 n)
            => (uint3)src << 1;

        /// <summary>
        /// Promotes a <see cref='Z0.uint2'/> to a <see cref='Z0.uint4'/>, as indicated by the <see cref='W4'/> selector 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint4 extend(S src, W4 w)
            => src;

        /// <summary>
        /// Promotes a <see cref='Z0.uint2'/> to a <see cref='Z0.uint5'/>, as indicated by the <see cref='W5'/> selector 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint5 extend(S src, W5 w)
            => src;

        /// <summary>
        /// Promotes a <see cref='Z0.uint2'/> to a <see cref='Z0.uint6'/>, as indicated by the <see cref='W6'/> selector 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint6 extend(S src, W6 w)
            => src;

        /// <summary>
        /// Promotes a <see cref='Z0.uint2'/> to a <see cref='octet'/>, as indicated by the <see cref='W8'/> selector 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static octet extend(S src, W8 w)
            => src;

        /// <summary>
        /// Promotes a <see cref='Z0.uint2'/> to a <see cref='octet'/>, as indicated by the <see cref='W8'/> selector, 
        /// and shifts the result <see cref='N2'/> bits leftward
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        /// <param name="n">The leftward shift count</param>
        [MethodImpl(Inline), Op]
        public static octet extend(S src, W8 w, N2 n)
            => (octet)src << 2;

        /// <summary>
        /// Promotes a <see cref='Z0.uint2'/> to a <see cref='octet'/>, as indicated by the <see cref='W8'/> selector, 
        /// and shifts the result <see cref='N3'/> bits leftward
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        /// <param name="n">The leftward shift count</param>
        [MethodImpl(Inline), Op]
        public static octet extend(S src, W8 w, N3 n)
            => (octet)src << 3;

        /// <summary>
        /// Promotes a <see cref='Z0.uint2'/> to a <see cref='octet'/> as indicated by the <see cref='W8'/> selector 
        /// and shifts the result <see cref='N4'/> bits bits leftward
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        /// <param name="n">The leftward shift count</param>
        [MethodImpl(Inline), Op]
        public static octet extend(S src, W8 w, N4 n)
            => (octet)src << 4;
    }
}