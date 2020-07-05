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
        /// Creates a 2-bit unsigned integer, equal to zero or one, if the source value is respectively false or true
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static analog uint2(bool src)
            => new analog(As.bit(src));

        /// <summary>
        /// Creates a 2-bit usigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint2(byte src)
            => new analog(src);

        /// <summary>
        /// Creates a 2-bit usigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint2(sbyte src)
            => new analog(src);

        /// <summary>
        /// Creates a 2-bit usigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint2(ushort src)
            => new analog(src);

        /// <summary>
        /// Creates a 2-bit usigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint2(short src)
            => new analog(src);

        /// <summary>
        /// Creates a 2-bit usigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static analog uint2(int src)
            => new analog(src);

        /// <summary>
        /// Creates a 2-bit usigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint2(uint src)
            => new analog(src);

        /// <summary>
        /// Creates a 2-bit usigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static analog uint2(long src)
            => new analog(src);

        /// <summary>
        /// Creates a 2-bit usigned integer from the least 2 source bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint2(ulong src)        
            => new analog((byte)((byte)src & analog.MaxVal));

        /// <summary>
        /// Creates a 2-bit unsigned integer from a 2-term bit sequence
        /// </summary>
        /// <param name="x0">The term at index 0</param>
        /// <param name="x1">The term at index 1</param>
        [MethodImpl(Inline), Op]
        public static analog uint2(bit x0, bit x1 = default)
             => wrap2(((uint)x0 << 0) | ((uint)x1 << 1));

        [MethodImpl(Inline), Op]
        public static analog add(analog x, analog y)
        {
            var sum = x.data + y.data;
            return wrap2((sum >= analog.Count) ? sum - (byte)analog.Count: sum);
        }

        [MethodImpl(Inline), Op]
        public static analog sub(analog x, analog y)
        {
            var diff = (int)x - (int)y;
            return wrap2(diff < 0 ? (byte)(diff + analog.Count) : (byte)diff);
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
        internal static uint reduce2(uint x) 
            => x % analog.Count;

        [MethodImpl(Inline), Op]
        internal static byte reduce2(byte x) 
            => (byte)(x % analog.Count);

        [MethodImpl(Inline)]
        internal static analog wrap2(uint src) 
            => new analog((byte)src,false);

        [MethodImpl(Inline)]
        internal static analog wrap2(int src) 
            => new analog((byte)src,false);

        static BitFormatConfig FormatConfig2 
            => BitFormatter.limited(analog.Width, analog.Width);
        
        [MethodImpl(Inline)]
        public static string format(analog src)
            => BitFormatter.format(src.data, FormatConfig2);        

        /// <summary>
        /// Promotes a <see cref='duet'/> to a <see cref='triad'/>, as indicated by the <see cref='W3'/> selector 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static triad extend(analog src, W3 w)
            => src;

        /// <summary>
        /// Promotes a <see cref='duet'/> to a <see cref='triad'/>, as indicated by the <see cref='W3'/> selector 
        /// and shifts the result <see cref='N1'/> bit leftward
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        /// <param name="n">The leftward shift count</param>
        [MethodImpl(Inline), Op]
        public static triad extend(analog src, W3 w, N1 n)
            => (triad)src << 1;

        /// <summary>
        /// Promotes a <see cref='duet'/> to a <see cref='quartet'/>, as indicated by the <see cref='W4'/> selector 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static quartet extend(analog src, W4 w)
            => src;

        /// <summary>
        /// Promotes a <see cref='duet'/> to a <see cref='quintet'/>, as indicated by the <see cref='W5'/> selector 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static quintet extend(analog src, W5 w)
            => src;

        /// <summary>
        /// Promotes a <see cref='duet'/> to a <see cref='sextet'/>, as indicated by the <see cref='W6'/> selector 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static sextet extend(analog src, W6 w)
            => src;

        /// <summary>
        /// Promotes a <see cref='duet'/> to a <see cref='octet'/>, as indicated by the <see cref='W8'/> selector 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static octet extend(analog src, W8 w)
            => src;

        /// <summary>
        /// Promotes a <see cref='duet'/> to a <see cref='octet'/>, as indicated by the <see cref='W8'/> selector, 
        /// and shifts the result <see cref='N2'/> bits leftward
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        /// <param name="n">The leftward shift count</param>
        [MethodImpl(Inline), Op]
        public static octet extend(analog src, W8 w, N2 n)
            => (octet)src << 2;

        /// <summary>
        /// Promotes a <see cref='duet'/> to a <see cref='octet'/>, as indicated by the <see cref='W8'/> selector, 
        /// and shifts the result <see cref='N3'/> bits leftward
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        /// <param name="n">The leftward shift count</param>
        [MethodImpl(Inline), Op]
        public static octet extend(analog src, W8 w, N3 n)
            => (octet)src << 3;

        /// <summary>
        /// Promotes a <see cref='duet'/> to a <see cref='octet'/> as indicated by the <see cref='W8'/> selector 
        /// and shifts the result <see cref='N4'/> bits bits leftward
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        /// <param name="n">The leftward shift count</param>
        [MethodImpl(Inline), Op]
        public static octet extend(analog src, W8 w, N4 n)
            => (octet)src << 4;
    }
}