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

    using S = uint7;

    partial class BitSeqD
    {
        /// <summary>
        /// Creates a 7-bit unsigned integer, equal to zero or one, according to whether the source is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint7(bool src)        
            => new S(As.bit(src));

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint7(byte src)
            => new S(src);

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint7(sbyte src)
            => new S(src);

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint7(ushort src)
            => new S(src);

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint7(short src)
            => new S(src);

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static S uint7(int src)
            => new S(src);

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint7(uint src)
            => new S(src);

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static S uint7(long src)
            => new S(src);

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint7(ulong src)        
            => new S((byte)((byte)src & S.MaxVal));


        /// <summary>
        /// Constructs a uint7 value from a sequence of bits ranging from low to high
        /// </summary>
        /// <param name="x0">The first/least bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x1">The second bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x2">The third bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x3">The fourth/highest bit value, if specified; otherwise, defaults to 0</param>
        [MethodImpl(Inline), Op]
        public static S uint7(Bit x0, Bit x1 = default, Bit x2 = default, Bit x3 = default, Bit x4 = default, Bit x5 = default, Bit x6 = default)
             => wrap7(((uint)x0 << 0) | ((uint)x1 << 1) | ((uint)x2 << 2) | ((uint)x3 << 3) | ((uint)x4 << 4) | ((uint)x5 << 5) | ((uint)x6 << 6));
        
        [MethodImpl(Inline), Op]
        public static S add(S x, S y)
        {
            var sum = (byte)(x.data + y.data);
            return wrap7((sum >= S.Count) ? (byte)(sum - S.Count): sum);
        }

        [MethodImpl(Inline), Op]
        public static S sub(S x, S y)
        {
            var diff = (int)x - (int)y;
            return wrap7(diff < 0 ? (uint)(diff + S.Count) : (uint)diff);
        }

        [MethodImpl(Inline), Op]
        public static S div (S x, S y) 
            => wrap7((byte)(x.data / y.data));

        [MethodImpl(Inline), Op]
        public static S mod (S lhs, S rhs)
            => wrap7((byte)(lhs.data % rhs.data));

        [MethodImpl(Inline), Op]
        public static S mul(S lhs, S rhs)
            => reduce7((byte)(lhs.data * rhs.data));

        [MethodImpl(Inline), Op]
        public static S or(S lhs, S rhs)
            => wrap7((byte)(lhs.data | rhs.data));

        [MethodImpl(Inline), Op]
        public static S and(S lhs, S rhs)
            => wrap7((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline), Op]
        public static S xor(S lhs, S rhs)
            => wrap7((byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline), Op]
        public static S srl(S lhs, byte rhs)
            => uint7(lhs.data >> rhs);

        [MethodImpl(Inline), Op]
        public static S sll(S lhs, byte rhs)
            => uint7(lhs.data << rhs);


        [MethodImpl(Inline), Op]
        public static Bit test(S src, byte pos)
            => core.test(src,pos);

        [MethodImpl(Inline), Op]
        public static S set(S src, byte pos, Bit state)
        {
            if(pos < S.Width)
                return wrap7(core.set(src.data, pos, state));
            else
                return src;
        }

        [MethodImpl(Inline)]
        public static bool eq(S x, S y)
            => x.data == y.data;

        [MethodImpl(Inline)]
        internal static byte crop7(byte x) 
            => (byte)(S.MaxVal & x);

        [MethodImpl(Inline), Op]
        internal static byte reduce7(byte x) 
            => (byte)(x % S.Count);
 
        [MethodImpl(Inline)]
        internal static S wrap7(byte src) 
            => new S(src,false);

        [MethodImpl(Inline)]
        internal static S wrap7(uint src) 
            => new S(src,false);

        static BitFormatConfig FormatConfig7 
            => BitFormatter.limited(S.Width,S.Width);
        
        [MethodImpl(Inline)]
        public static string format(S src)
            => BitFormatter.format(src.data, FormatConfig7);
    }
}