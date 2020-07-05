//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using analog = septet;

    partial class BitSet
    {
        /// <summary>
        /// Creates a 7-bit unsigned integer, equal to zero or one, according to whether the source is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint7(bool src)        
            => new analog(As.bit(src));

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint7(byte src)
            => new analog(src);

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint7(sbyte src)
            => new analog(src);

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint7(ushort src)
            => new analog(src);

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint7(short src)
            => new analog(src);

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static analog uint7(int src)
            => new analog(src);

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint7(uint src)
            => new analog(src);

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static analog uint7(long src)
            => new analog(src);

        /// <summary>
        /// Creates a 7-bit usigned integer from the least 7 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint7(ulong src)        
            => new analog((byte)((byte)src & analog.MaxVal));


        /// <summary>
        /// Constructs a uint7 value from a sequence of bits ranging from low to high
        /// </summary>
        /// <param name="x0">The first/least bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x1">The second bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x2">The third bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x3">The fourth/highest bit value, if specified; otherwise, defaults to 0</param>
        [MethodImpl(Inline), Op]
        public static analog uint7(Bit x0, Bit x1 = default, Bit x2 = default, Bit x3 = default, Bit x4 = default, Bit x5 = default, Bit x6 = default)
             => wrap7(((uint)x0 << 0) | ((uint)x1 << 1) | ((uint)x2 << 2) | ((uint)x3 << 3) | ((uint)x4 << 4) | ((uint)x5 << 5) | ((uint)x6 << 6));

        [MethodImpl(Inline), Op]
        public static analog add(analog x, analog y)
        {
            var sum = (byte)(x.data + y.data);
            return wrap7((sum >= analog.Count) ? (byte)(sum - analog.Count): sum);
        }

        [MethodImpl(Inline), Op]
        public static analog sub(analog x, analog y)
        {
            var diff = (int)x - (int)y;
            return wrap7(diff < 0 ? (uint)(diff + analog.Count) : (uint)diff);
        }

        [MethodImpl(Inline), Op]
        public static analog div (analog lhs, analog rhs) 
            => wrap7((byte)(lhs.data / rhs.data));

        [MethodImpl(Inline), Op]
        public static analog mod (analog lhs, analog rhs)
            => wrap7((byte)(lhs.data % rhs.data));

        [MethodImpl(Inline), Op]
        public static analog mul(analog lhs, analog rhs)
            => reduce7(lhs.data * rhs.data);

        [MethodImpl(Inline), Op]
        public static analog or(analog lhs, analog rhs)
            => wrap7((byte)(lhs.data | rhs.data));

        [MethodImpl(Inline), Op]
        public static analog and(analog lhs, analog rhs)
            => wrap7((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline), Op]
        public static analog xor(analog lhs, analog rhs)
            => wrap7((byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline), Op]
        public static analog srl(analog lhs, int rhs)
            => uint7(lhs.data >> rhs);

        [MethodImpl(Inline), Op]
        public static analog sll(analog lhs, int rhs)
            => uint7(lhs.data << rhs);

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
        internal static byte reduce7(uint x) 
            => (byte)(x % analog.Count);

        [MethodImpl(Inline), Op]
        internal static byte reduce7(int x) 
            => (byte)((uint)x % analog.Count);

        [MethodImpl(Inline)]
        internal static analog wrap7(uint src) 
            => new analog(src,false);

        [MethodImpl(Inline)]
        internal static analog wrap7(int src) 
            => new analog((byte)src,false);

        static BitFormatConfig FormatConfig7 
            => BitFormatter.limited(analog.Width,analog.Width);
        
        [MethodImpl(Inline)]
        public static string format(analog src)
            => BitFormatter.format(src.data, FormatConfig7);
    }
}