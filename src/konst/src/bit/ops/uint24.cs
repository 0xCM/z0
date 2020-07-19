//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using S = uint24;

    partial class Bit
    {
        /// <summary>
        /// Creates a 24-bit unsigned integer, equal to zero or one, according to whether the source is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint24(bool src)        
            => new S(z.@byte(src));

        /// <summary>
        /// Creates a 24-bit usigned integer from the least 24 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint24(byte src)
            => new S(src);

        /// <summary>
        /// Creates a 24-bit usigned integer from the least 24 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint24(sbyte src)
            => new S((byte)src);

        /// <summary>
        /// Creates a 24-bit usigned integer from the least 24 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint24(ushort src)
            => new S((byte)src);

        /// <summary>
        /// Creates a 24-bit usigned integer from the least 24 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint24(short src)
            => new S((byte)src);

        /// <summary>
        /// Creates a 24-bit usigned integer from the least 24 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static S uint24(int src)
            => new S((byte)src);

        /// <summary>
        /// Creates a 24-bit usigned integer from the least 24 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint24(uint src)
            => new S((byte)src);

        /// <summary>
        /// Creates a 24-bit usigned integer from the least 24 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static S uint24(long src)
            => new S((byte)src);

        /// <summary>
        /// Creates a 24-bit usigned integer from the least 24 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static S uint24(ulong src)        
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

        [MethodImpl(Inline), Op]
        public static S add(S x, S y)
        {
            var sum = (ulong)x.data + (ulong)y.data;
            return wrap24(sum >= S.Count ? (uint)(sum - S.Count) : (uint)sum);
        }

        [MethodImpl(Inline), Op]
        public static S sub(S x, S y)
        {
            var diff = (long)x - (long)y;
            return wrap24(diff < 0 ? (uint)(diff + S.Count) : (uint)diff);
        }

        [MethodImpl(Inline), Op]
        public static S div (S x, S y) 
            => wrap24((uint)(x.data / y.data));

        [MethodImpl(Inline), Op]
        public static S mod (S lhs, S rhs)
            => wrap24((uint)(lhs.data % rhs.data));

        [MethodImpl(Inline), Op]
        public static S mul(S lhs, S rhs)
            => reduce24((ulong)lhs.data * (ulong)rhs.data);

        [MethodImpl(Inline), Op]
        public static S or(S lhs, S rhs)
            => wrap24((uint)(lhs.data | rhs.data));

        [MethodImpl(Inline), Op]
        public static S and(S lhs, S rhs)
            => wrap24((uint)(lhs.data & rhs.data));

        [MethodImpl(Inline), Op]
        public static S xor(S lhs, S rhs)
            => wrap24((uint)(lhs.data ^ rhs.data));

        [MethodImpl(Inline), Op]
        public static S srl(S lhs, byte rhs)
            => uint24(lhs.data >> rhs);

        [MethodImpl(Inline), Op]
        public static S sll(S lhs, byte rhs)
            => uint24(lhs.data << rhs);

        [MethodImpl(Inline), Op]
        public static S inc(S x) 
        {
            var y = (ulong)x.data + 1;
            return y > (ulong)S.MaxVal ? S.Min : wrap24(y);
        }

        [MethodImpl(Inline), Op]
        public static S dec(S x) 
        {
            var y = (long)x.data - 1;
            return y < 0 ? S.Max : wrap24(y);
        }

        [MethodImpl(Inline), Op]
        public static bool eq(S x, S y)
            => x.data == y.data;

        [MethodImpl(Inline)]
        internal static uint crop24(uint x) 
            => (uint)S.MaxVal & x;

        [MethodImpl(Inline), Op]
        internal static uint reduce24(uint x) 
            => x % S.Count;
 
        [MethodImpl(Inline), Op]
        internal static S reduce24(ulong x) 
            => wrap24((uint)(x % S.Count));
 
        [MethodImpl(Inline)]
        internal static S wrap24(uint src) 
            => new S(src);        

        [MethodImpl(Inline)]
        internal static S wrap24(long src) 
            => new S(src);        

        [MethodImpl(Inline)]
        internal static S wrap24(ulong src) 
            => new S(src);        
    }
}