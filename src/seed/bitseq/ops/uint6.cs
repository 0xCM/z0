//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using analog = uint6;

    partial class BitSeqD
    {
        /// <summary>
        /// Creates a 6-bit unsigned integer, equal to zero or one, if the source value is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static analog uint6(bool src)
            => new analog(As.bit(src));

        /// <summary>
        /// Creates a 6-bit usigned integer from the least 6 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint6(byte src)
            => new analog(src);

        /// <summary>
        /// Creates a 6-bit usigned integer from the least 6 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint6(sbyte src)
            => new analog(src);

        /// <summary>
        /// Creates a 6-bit usigned integer from the least 6 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint6(ushort src)
            => new analog(src);

        /// <summary>
        /// Creates a 6-bit usigned integer from the least 6 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint6(short src)
            => new analog(src);

        /// <summary>
        /// Creates a 6-bit usigned integer from the least 6 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static analog uint6(int src)
            => new analog(src);

        /// <summary>
        /// Creates a 6-bit usigned integer from the least 6 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint6(uint src)
            => new analog(src);

        /// <summary>
        /// Creates a 6-bit usigned integer from the least 6 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static analog uint6(long src)
            => new analog(src);

        /// <summary>
        /// Creates a 6-bit usigned integer from the least 6 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint6(ulong src)        
            => new analog((byte)((byte)src & analog.MaxVal));

        /// <summary>
        /// Constructs a uint6 value from a sequence of bits ranging from low to high
        /// </summary>
        /// <param name="x0">The first/least bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x1">The second bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x2">The third bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x3">The fourth/highest bit value, if specified; otherwise, defaults to 0</param>
        [MethodImpl(Inline), Op]
        public static analog uint6(bit x0, bit x1 = default, bit x2 = default, bit x3 = default, bit x4 = default, bit x5 = default)
             => wrap6(((uint)x0 << 0) | ((uint)x1 << 1) | ((uint)x2 << 2) | ((uint)x3 << 3) | ((uint)x4 << 4) | ((uint)x5 << 5));

        [MethodImpl(Inline), Op]
        public static ref analog edit(in analog src)
            => ref Unsafe.AsRef(src);
        
        [MethodImpl(Inline), Op]
        public static analog add(analog x, analog y)
        {
            var sum = (byte)(x.data + y.data);
            return wrap6((sum >= analog.Count) ? (byte)(sum - (byte)analog.Count): sum);
        }

        [MethodImpl(Inline), Op]
        public static analog sub(analog x, analog y)
        {
            var diff = (int)x - (int)y;
            return wrap6(diff < 0 ? (uint)(diff + analog.Count) : (uint)diff);
        }

        [MethodImpl(Inline), Op]
        public static analog div (analog lhs, analog rhs) 
            => wrap6((byte)(lhs.data / rhs.data));

        [MethodImpl(Inline), Op]
        public static analog mod (analog lhs, analog rhs)
            => wrap6((byte)(lhs.data % rhs.data));

        [MethodImpl(Inline), Op]
        public static analog mul(analog lhs, analog rhs)
            => reduce6(lhs.data * rhs.data);

        [MethodImpl(Inline), Op]
        public static analog or(analog lhs, analog rhs)
            => wrap6((byte)(lhs.data | rhs.data));

        [MethodImpl(Inline), Op]
        public static analog and(analog lhs, analog rhs)
            => wrap6((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline), Op]
        public static analog xor(analog lhs, analog rhs)
            => wrap6((byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline), Op]
        public static analog srl(analog lhs, int rhs)
            => uint6(lhs.data >> rhs);

        [MethodImpl(Inline), Op]
        public static analog sll(analog lhs, int rhs)
            => uint6(lhs.data << rhs);

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
        internal static byte reduce6(uint x) 
            => (byte)(x % analog.Count);

        [MethodImpl(Inline), Op]
        internal static byte reduce6(int x) 
            => (byte)((uint)x % analog.Count);

        [MethodImpl(Inline)]
        internal static analog wrap6(uint src) 
            => new analog(src,false);

        [MethodImpl(Inline)]
        internal static analog wrap6(int src) 
            => new analog((byte)src,false);

        static BitFormatConfig FormatConfig6 
            => BitFormatter.limited(analog.Width,analog.Width);
        
        [MethodImpl(Inline)]
        public static string format(analog src)
            => BitFormatter.format(src.data, FormatConfig6);
    }
}