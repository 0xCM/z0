//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using analog = quintet;

    partial class BitSet
    {
        /// <summary>
        /// Creates a 5-bit unsigned integer, equal to zero or one, if the source value is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static analog uint5(bool src)
            => new analog(As.bit(src));

        /// <summary>
        /// Creates a 5-bit usigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint5(byte src)
            => new analog(src);

        /// <summary>
        /// Creates a 5-bit usigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint5(sbyte src)
            => new analog(src);

        /// <summary>
        /// Creates a 5-bit usigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint5(ushort src)
            => new analog(src);

        /// <summary>
        /// Creates a 5-bit usigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint5(short src)
            => new analog(src);

        /// <summary>
        /// Creates a 5-bit usigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static analog uint5(int src)
            => new analog(src);

        /// <summary>
        /// Creates a 5-bit usigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint5(uint src)
            => new analog(src);

        /// <summary>
        /// Creates a 5-bit usigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static analog uint5(long src)
            => new analog(src);

        /// <summary>
        /// Creates a 5-bit usigned integer from the least 5 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint5(ulong src)        
            => new analog((byte)((byte)src & analog.MaxVal));

        /// <summary>
        /// Creates a 5-bit unsigned integer from a 5-term bit sequence
        /// </summary>
        /// <param name="x0">The term at index 0</param>
        /// <param name="x1">The term at index 1</param>
        /// <param name="x2">The term at index 2</param>
        /// <param name="x3">The term at index 3</param>
        /// <param name="x4">The term at index 4</param>
        [MethodImpl(Inline), Op]
        public static analog uint5(Bit x0, Bit x1 = default, Bit x2 = default, Bit x3 = default, Bit x4 = default)
             => wrap5(((uint)x0 << 0) | ((uint)x1 << 1) | ((uint)x2 << 2) | ((uint)x3 << 3) | ((uint)x4 << 4));

        [MethodImpl(Inline), Op]
        public static analog add(analog x, analog y)
        {
            var sum = (byte)(x.data + y.data);
            return wrap5((sum >= analog.Count) ? (byte)(sum - analog.Count): sum);
        }

        [MethodImpl(Inline), Op]
        public static analog sub(analog x, analog y)
        {
            var diff = (int)x - (int)y;
            return wrap5(diff < 0 ? (uint)(diff + analog.Count) : (uint)diff);
        }

        [MethodImpl(Inline), Op]
        public static analog div (analog lhs, analog rhs) 
            => wrap5((byte)(lhs.data / rhs.data));

        [MethodImpl(Inline), Op]
        public static analog mod (analog lhs, analog rhs)
            => wrap5((byte)(lhs.data % rhs.data));

        [MethodImpl(Inline), Op]
        public static analog mul(analog lhs, analog rhs)
            => reduce5(lhs.data * rhs.data);

        [MethodImpl(Inline), Op]
        public static analog or(analog lhs, analog rhs)
            => wrap5((byte)(lhs.data | rhs.data));

        [MethodImpl(Inline), Op]
        public static analog and(analog lhs, analog rhs)
            => wrap5((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline), Op]
        public static analog xor(analog lhs, analog rhs)
            => wrap5((byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline), Op]
        public static analog srl(analog lhs, int rhs)
            => uint5(lhs.data >> rhs);

        [MethodImpl(Inline), Op]
        public static analog sll(analog lhs, int rhs)
            => uint5(lhs.data << rhs);

        [MethodImpl(Inline), Op]
        public static analog inc(analog x)
        {
            if(x.data != analog.MaxVal)
                return ++x.data;
            else
                return  analog.MinVal;
        }

        [MethodImpl(Inline), Op]
        public static analog dec(analog src)
        {
            if(src.data != analog.MinVal)
                src.data--;
            else
                src.data = analog.MaxVal;
            return src;
        }

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
        
        [MethodImpl(Inline)]
        public static bool eq(analog x, analog y)
            => x.data == y.data;

        [MethodImpl(Inline), Op]
        internal static byte reduce5(uint x) 
            => (byte)(x % analog.Count);

        [MethodImpl(Inline), Op]
        internal static byte reduce5(int x) 
            => (byte)((uint)x % analog.Count);

        [MethodImpl(Inline)]
        internal static analog wrap5(uint src) 
            => new analog(src,false);

        [MethodImpl(Inline)]
        internal static analog wrap5(int src) 
            => new analog((byte)src,false);

        static BitFormatConfig FormatConfig5 
            => BitFormatter.limited(analog.Width,analog.Width);
        
        [MethodImpl(Inline)]
        public static string format(analog src)
            => BitFormatter.format(src.data, FormatConfig5);

    }
}