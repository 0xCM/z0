//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using analog = quartet;

    partial class BitSet
    {
        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint4(byte src)
            => new analog(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint4(sbyte src)
            => new analog(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint4(ushort src)
            => new analog(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint4(short src)
            => new analog(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static analog uint4(int src)
            => new analog(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint4(uint src)
            => new analog(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static analog uint4(long src)
            => new analog(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint4(ulong src)        
            => new analog((byte)((byte)src & analog.MaxVal));

        /// <summary>
        /// Constructs a uint4 value from a sequence of bits ranging from low to high
        /// </summary>
        /// <param name="x0">The first/least bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x1">The second bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x2">The third bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x3">The fourth/highest bit value, if specified; otherwise, defaults to 0</param>
        [MethodImpl(Inline), Op]
        public static analog uint4(bit x0, bit x1 = default, bit x2 = default, bit x3 = default)
             => analog.Wrap(((uint)x0 << 0) | ((uint)x1 << 1) | ((uint)x2 << 2) | ((uint)x3 << 3));

        [MethodImpl(Inline), Op]
        public static analog add(analog x, analog y)
        {
            const byte modulus = 16;
            var sum = (byte)(x.data + y.data);
            return analog.Wrap((sum >= modulus) ? (byte)(sum - modulus): sum);
        }

        [MethodImpl(Inline), Op]
        public static analog sub(analog x, analog y)
        {
            const byte modulus = 16;
            var diff = (int)x - (int)y;
            return analog.Wrap(diff < 0 ? (uint)(diff + modulus) : (uint)diff);
        }

        [MethodImpl(Inline), Op]
        public static analog mul(analog lhs, analog rhs)
            => reduce4(lhs.data * rhs.data);

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
        public static analog hi(analog src)
            => wrap4(src.data >> 2 & 0b11);

        [MethodImpl(Inline), Op]
        public static analog lo(analog src)
            => wrap4(src.data & 0b11);

        [MethodImpl(Inline), Op]
        public static bit bit(analog src, int pos)
            => pos < analog.BitWidth ? Z0.bit.test(src.data, pos) : Z0.bit.Off;

        [MethodImpl(Inline), Op]
        public static analog bit(analog src, int pos, bit bit)
        {
            if(pos < analog.BitWidth)
                return bit.set(src.data, (byte)pos, bit);
            else
                return src;
        }

        [MethodImpl(Inline), Op]
        public static ref analog bit(ref analog src, int pos, bit bit)
        {
            if(pos < analog.BitWidth)
                src.data = Z0.bit.set(src.data, (byte)pos, bit);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static bool eq(analog x, analog y)
            => x.data == y.data;

        [MethodImpl(Inline), Op]
        internal static byte reduce4(uint x) 
            => (byte)(x % analog.Base);

        [MethodImpl(Inline), Op]
        internal static byte reduce4(int x) 
            => (byte)((uint)x % analog.Base);

        [MethodImpl(Inline)]
        internal static analog wrap4(uint src) 
            => new analog(src,false);

        [MethodImpl(Inline)]
        internal static analog wrap4(int src) 
            => new analog((byte)src,false);

        static BitFormatConfig FormatConfig4 
            => BitFormatConfig.Limited(analog.BitWidth,analog.BitWidth);
        
        [MethodImpl(Inline)]
        public static string format(analog src)
            => BitFormatter.format(src.data, FormatConfig4);

    }
}