//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using analog = duet;

    partial class BitSet
    {
        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint2(byte src)
            => new analog(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint2(sbyte src)
            => new analog(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint2(ushort src)
            => new analog(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint2(short src)
            => new analog(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static analog uint2(int src)
            => new analog(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint2(uint src)
            => new analog(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static analog uint2(long src)
            => new analog(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint2(ulong src)        
            => new analog((byte)((byte)src & analog.Max8u));

        [MethodImpl(Inline), Op]    
        public static analog uint2(bool x)
            => x ? analog.One : analog.Zero;

        /// <summary>
        /// Constructs a uint2 value from a sequence of bits ranging from low to high
        /// </summary>
        /// <param name="x0">The first/least bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x1">The second bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x2">The third bit value, if specified; otherwise, defaults to 0</param>
        /// <param name="x3">The fourth/highest bit value, if specified; otherwise, defaults to 0</param>
        [MethodImpl(Inline), Op]
        public static analog uint2(bit x0, bit x1 = default, bit x2 = default)
             => wrap2(((uint)x0 << 0) | ((uint)x1 << 1) | ((uint)x2 << 2));

        [MethodImpl(Inline), Op]
        public static analog add(analog x, analog y)
        {
            var sum = x.data + y.data;
            return wrap2((sum >= analog.Base) ? sum - analog.Base: sum);
        }

        [MethodImpl(Inline), Op]
        public static analog sub(analog x, analog y)
        {
            var diff = (int)x - (int)y;
            return wrap2(diff < 0 ? (byte)(diff + analog.Base) : (byte)diff);
        }

        [MethodImpl(Inline), Op]
        public static analog mul(analog lhs, analog rhs)
            => reduce4((byte)(lhs.data * rhs.data));

        [MethodImpl(Inline), Op]
        public static analog div (analog lhs, analog rhs) 
            => wrap2((byte)(lhs.data / rhs.data));

        [MethodImpl(Inline), Op]
        public static analog mod (analog lhs, analog rhs)
            => wrap2((byte)(lhs.data % rhs.data));

        [MethodImpl(Inline), Op]
        public static analog or(analog lhs, analog rhs)
            => wrap2((byte)(lhs.data | rhs.data));

        [MethodImpl(Inline), Op]
        public static analog and(analog lhs, analog rhs)
            => wrap2((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline), Op]
        public static analog xor(analog lhs, analog rhs)
            => wrap2((byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline), Op]
        public static analog srl(analog lhs, int rhs)
            => uint2(lhs.data >> rhs);

        [MethodImpl(Inline), Op]
        public static analog sll(analog lhs, int rhs)
            => uint2(lhs.data << rhs);

        [MethodImpl(Inline), Op]
        public static analog inc(analog x)
        {
            if(x.data != analog.Max8u)
                return ++x.data;
            else
                return  analog.Min8u;
        }

        [MethodImpl(Inline), Op]
        public static analog dec(analog src)
        {
            if(src.data != analog.Min8u)
                src.data--;
            else
                src.data = analog.Max8u;
            return src;
        }

        [MethodImpl(Inline), Op]
        public static bit bit(analog src, int pos)
            => pos < analog.Width ? Z0.bit.test(src.data, pos) : Z0.bit.Off;

        [MethodImpl(Inline), Op]
        public static analog bit(analog src, int pos, bit bit)
        {
            if(pos < analog.Width)
                return bit.set(src.data, (byte)pos, bit);
            else
                return src;
        }

        [MethodImpl(Inline), Op]
        public static ref analog bit(ref analog src, int pos, bit bit)
        {
            if(pos < analog.Width)
                src.data = Z0.bit.set(src.data, (byte)pos, bit);
            return ref src;
        }

        [MethodImpl(Inline), Op]
        public static bool eq(analog x, analog y)
            => x.data == y.data;

        [MethodImpl(Inline), Op]
        internal static uint reduce2(uint x) 
            => x % analog.Base;

        [MethodImpl(Inline), Op]
        internal static byte reduce2(byte x) 
            => (byte)(x % analog.Base);

        [MethodImpl(Inline)]
        internal static analog wrap2(uint src) 
            => new analog((byte)src,false);

        [MethodImpl(Inline)]
        internal static analog wrap2(int src) 
            => new analog((byte)src,false);

        static BitFormatConfig FormatConfig2 
            => BitFormatConfig.Limited(analog.Width, analog.Width);
        
        [MethodImpl(Inline)]
        public static string format(analog src)
            => BitFormatter.format(src.data, FormatConfig2);        
    }
}