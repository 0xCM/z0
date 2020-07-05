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

    using S = uint1;

    partial class BitSeqD
    {
        [MethodImpl(Inline), Op]    
        public static S uint1(bool src)
            => new S(As.bit(src));

        /// <summary>
        /// Creates a 1-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint1(byte src)
            => new S(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint1(sbyte src)
            => new S(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint1(ushort src)
            => new S(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint1(short src)
            => new S(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static S uint1(int src)
            => new S(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint1(uint src)
            => new S(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static S uint1(long src)
            => new S((byte)src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint1(ulong src)        
            => new S((byte)((byte)src & S.MaxVal));

        [MethodImpl(Inline), Op]
        public static S add(S x, S y)
        {
            var sum = x.data + y.data;
            return wrap1((sum >= S.Count) ? (byte)sum - (byte)S.Count: sum);
        }

        [MethodImpl(Inline), Op]
        public static S sub(S x, S y)
        {
            var diff = (int)x - (int)y;
            return wrap1(diff < 0 ? (byte)(diff + S.Count) : (byte)diff);
        }

        [MethodImpl(Inline), Op]
        public static S mul(S lhs, S rhs)
            => reduce4((byte)(lhs.data * rhs.data));

        [MethodImpl(Inline), Op]
        public static S div (S lhs, S rhs) 
            => wrap1((byte)(lhs.data / rhs.data));

        [MethodImpl(Inline), Op]
        public static S mod (S lhs, S rhs)
            => wrap1((byte)(lhs.data % rhs.data));

        [MethodImpl(Inline), Op]
        public static S or(S lhs, S rhs)
            => wrap1((byte)(lhs.data | rhs.data));

        [MethodImpl(Inline), Op]
        public static S and(S lhs, S rhs)
            => wrap1((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline), Op]
        public static S xor(S lhs, S rhs)
            => wrap1((byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline), Op]
        public static S srl(S lhs, byte rhs)
            => uint1((byte)(lhs.data >> rhs));

        [MethodImpl(Inline), Op]
        public static S sll(S lhs, byte rhs)
            => uint1((byte)(lhs.data << rhs));

        [MethodImpl(Inline), Op]
        public static S inc(S x)
            => !x.IsMax ? new S(core.add(x.data, 1), false) : S.Min;

        [MethodImpl(Inline), Op]
        public static S dec(S x)
            => !x.IsMin ? new S(core.sub(x.data, 1), false) : S.Max;

        [MethodImpl(Inline), Op]
        public static Bit test(S x)
            => core.test(x.data, 0);

        [MethodImpl(Inline), Op]
        public static S set(S src, byte pos, Bit state)
        {
            if(pos < S.Width)
                return wrap1(core.set(src.data, pos, state));
            else 
                return src;
        }
        
        [MethodImpl(Inline), Op]
        public static bool eq(S x, S y)
            => x.data == y.data;

        [MethodImpl(Inline)]
        internal static byte crop1(byte x) 
            => (byte)(S.MaxVal & x);

        [MethodImpl(Inline), Op]
        internal static byte reduce1(byte x) 
            => (byte)(x % S.Count);

        [MethodImpl(Inline)]
        internal static S wrap1(int src) 
            => new S((byte)src, false);
    }
}