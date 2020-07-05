//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using analog = uint1;

    partial class BitSeqD
    {
        [MethodImpl(Inline), Op]    
        public static analog uint1(bool src)
            => new analog(As.bit(src));

        /// <summary>
        /// Creates a 1-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint1(byte src)
            => new analog(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint1(sbyte src)
            => new analog(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint1(ushort src)
            => new analog(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint1(short src)
            => new analog(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static analog uint1(int src)
            => new analog(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint1(uint src)
            => new analog(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]    
        public static analog uint1(long src)
            => new analog(src);

        /// <summary>
        /// Creates a 4-bit usigned integer from the least 4 bits of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static analog uint1(ulong src)        
            => new analog((byte)((byte)src & analog.MaxVal));

        [MethodImpl(Inline), Op]
        public static analog add(analog x, analog y)
        {
            var sum = x.data + y.data;
            return wrap1((sum >= analog.Count) ? sum - (byte)analog.Count: sum);
        }

        [MethodImpl(Inline), Op]
        public static analog sub(analog x, analog y)
        {
            var diff = (int)x - (int)y;
            return wrap1(diff < 0 ? (byte)(diff + analog.Count) : (byte)diff);
        }

        [MethodImpl(Inline), Op]
        public static analog mul(analog lhs, analog rhs)
            => reduce4((byte)(lhs.data * rhs.data));

        [MethodImpl(Inline), Op]
        public static analog div (analog lhs, analog rhs) 
            => wrap1((byte)(lhs.data / rhs.data));

        [MethodImpl(Inline), Op]
        public static analog mod (analog lhs, analog rhs)
            => wrap1((byte)(lhs.data % rhs.data));

        [MethodImpl(Inline), Op]
        public static analog or(analog lhs, analog rhs)
            => wrap1((byte)(lhs.data | rhs.data));

        [MethodImpl(Inline), Op]
        public static analog and(analog lhs, analog rhs)
            => wrap1((byte)(lhs.data & rhs.data));

        [MethodImpl(Inline), Op]
        public static analog xor(analog lhs, analog rhs)
            => wrap1((byte)(lhs.data ^ rhs.data));

        [MethodImpl(Inline), Op]
        public static analog srl(analog lhs, int rhs)
            => uint1(lhs.data >> rhs);

        [MethodImpl(Inline), Op]
        public static analog sll(analog lhs, int rhs)
            => uint1(lhs.data << rhs);

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
        public static Bit test(analog src)
            => core.test(src.data, 0);

        [MethodImpl(Inline), Op]
        public static ref analog set(in analog src, byte pos, Bit state)
        {
            ref var dst = ref Unsafe.AsRef(src);
            if(pos < analog.Width)
                dst.data = core.set(src.data, pos, state);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref analog edit(in analog src)
            => ref Unsafe.AsRef(src);
        
        [MethodImpl(Inline), Op]
        public static bool eq(analog x, analog y)
            => x.data == y.data;

        [MethodImpl(Inline), Op]
        internal static uint reduce1(uint x) 
            => x % analog.Count;

        [MethodImpl(Inline), Op]
        internal static byte reduce1(byte x) 
            => (byte)(x % analog.Count);

        [MethodImpl(Inline)]
        internal static analog wrap1(uint src) 
            => new analog((byte)src,false);

        [MethodImpl(Inline)]
        internal static analog wrap1(int src) 
            => new analog((byte)src,false);
    }
}