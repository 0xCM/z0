//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using analog = uint3;

    partial class BitSeqD
    {
        /// <summary>
        /// Creates a 3-bit unsigned integer, equal to zero or one, if the source value is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static analog uint3(bool src)
            => new analog(As.bit(src));

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint3(byte src)
            => new analog(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint3(sbyte src)
            => new analog(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint3(ushort src)
            => new analog(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint3(short src)
            => new analog(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static analog uint3(int src)
            => new analog(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint3(uint src)
            => new analog(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static analog uint3(long src)
            => new analog(src);

        /// <summary>
        /// Creates a 3-bit unsigned integer from the least 3 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint3(ulong src)        
            => new analog((byte)((byte)src & analog.MaxVal));


        /// <summary>
        /// Creates a 3-bit unsigned integer from a 3-term bit sequence
        /// </summary>
        /// <param name="x0">The term at index 0</param>
        /// <param name="x1">The term at index 1</param>
        /// <param name="x2">The term at index 2</param>
        [MethodImpl(Inline), Op]
        public static analog uint3(Bit x0, Bit x1 = default, Bit x2 = default)
             => wrap3(((uint)x0 << 0) | ((uint)x1 << 1) | ((uint)x2 << 2));

        [MethodImpl(Inline), Op]
        public static ref analog edit(in analog src)
            => ref Unsafe.AsRef(src);
        
        [MethodImpl(Inline), Op]
        public static analog add(analog x, analog y)
        {
            var sum = x.data + y.data;
            return wrap3((sum >= analog.Count) ? sum - analog.Count: sum);
        }

        [MethodImpl(Inline), Op]
        public static analog sub(analog x, analog y)
        {
            var diff = (int)x - (int)y;
            return wrap3(diff < 0 ? (byte)(diff + analog.Count) : (byte)diff);
        }

        [MethodImpl(Inline), Op]
        public static analog mul(analog lhs, analog rhs)
            => reduce4((byte)(lhs.data * rhs.data));

        [MethodImpl(Inline), Op]
        public static analog div (analog lhs, analog rhs) 
            => wrap3((byte)(lhs.data / rhs.data));

        [MethodImpl(Inline), Op]
        public static analog mod (analog lhs, analog rhs)
            => wrap3((byte)(lhs.data % rhs.data));

        [MethodImpl(Inline), Op]
        public static analog or(analog lhs, analog rhs)
            => wrap3((byte)(lhs.data | rhs.data));

        [MethodImpl(Inline), Op]
        public static analog and(analog lhs, analog rhs)
            => wrap3((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline), Op]
        public static analog xor(analog lhs, analog rhs)
            => wrap3((byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline), Op]
        public static analog srl(analog lhs, int rhs)
            => uint3(lhs.data >> rhs);

        [MethodImpl(Inline), Op]
        public static analog sll(analog lhs, int rhs)
            => uint3(lhs.data << rhs);

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

        [MethodImpl(Inline), Op]
        public static bool eq(analog x, analog y)
            => x.data == y.data;

        [MethodImpl(Inline), Op]
        internal static uint reduce3(uint x) 
            => x % analog.Count;

        [MethodImpl(Inline), Op]
        internal static byte reduce3(byte x) 
            => (byte)(x % analog.Count);

        [MethodImpl(Inline)]
        internal static analog wrap3(uint src) 
            => new analog((byte)src,false);

        [MethodImpl(Inline)]
        internal static analog wrap3(int src)         
            => new analog((byte)src,false);

        static BitFormatConfig FormatConfig3 
            => BitFormatter.limited(analog.Width,analog.Width);
        
        [MethodImpl(Inline)]
        public static string format(analog src)
            => BitFormatter.format(src.data, FormatConfig3);

        /// <summary>
        /// Promotes a triad to an quartet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint4 extend(analog src, W4 w)
            => src;

        /// <summary>
        /// Promotes a triad to an quintet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint5 extend(analog src, W5 w)
            => src;

        /// <summary>
        /// Promotes a triad to an quintet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static uint6 extend(analog src, W6 w)
            => src;

        /// <summary>
        /// Promotes a triad to an octet
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static octet extend(analog src, W8 w)
            => src;
    }
}