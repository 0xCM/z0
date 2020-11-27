//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class BitSpans
    {
        [MethodImpl(Inline), Op]
        public static ref readonly BitSpan and(in BitSpan x, in BitSpan y, in BitSpan z)
        {
            var count = z.BitCount;
            for(var i=0u; i<count; i++)
                z[i] = x[i] & y[i];
            return ref z;
        }

        [MethodImpl(Inline), Op]
        public static BitSpan and(in BitSpan x, in BitSpan y)
            => and(x,y, alloc(y.BitCount));

        [MethodImpl(Inline), Op]
        public static ref readonly BitSpan or(in BitSpan x, in BitSpan y, in BitSpan z)
        {
            var bitcount = z.Length;
            for(var i=0; i< bitcount; i++)
                z[i] = x[i] | y[i];
            return ref z;
        }

        [MethodImpl(Inline), Op]
        public static BitSpan or(in BitSpan x, in BitSpan y)
            => or(x,y, alloc(y.BitCount));

        [MethodImpl(Inline), Op]
        public static ref readonly BitSpan xor(in BitSpan x, in BitSpan y, in BitSpan z)
        {
            var bitcount = z.Length;
            for(var i=0; i< bitcount; i++)
                z[i] = x[i] ^ y[i];
            return ref z;
        }

        [MethodImpl(Inline), Op]
        public static BitSpan xor(in BitSpan x, in BitSpan y)
            => xor(x,y, alloc(y.BitCount));

        [MethodImpl(Inline), Op]
        public static ref readonly BitSpan not(in BitSpan x, in BitSpan z)
        {
            var bitcount = z.Length;
            for(var i=0; i< bitcount; i++)
                z[i] = ~ x[i];
            return ref z;
        }

        [MethodImpl(Inline), Op]
        public static BitSpan not(in BitSpan x)
            => not(x,alloc(x.BitCount));

        [MethodImpl(Inline), Op]
        public static ref readonly BitSpan select(in BitSpan a, in BitSpan b, in BitSpan c, in BitSpan z)
        {
            var tmp = alloc(z.BitCount);
            not(a,tmp);
            and(a,b,z);
            and(tmp,c, tmp);
            or(z,tmp,z);
            return ref z;
        }

        /// <summary>
        /// Computes the ternary select s := a ? b : c = (a & b) | (~a & c)
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline), Op]
        public static BitSpan select(in BitSpan a, in BitSpan b, in BitSpan c)
            => select(a,b,c, alloc(c.BitCount));

        [MethodImpl(Inline), Op]
        public static ref readonly BitSpan sll(in BitSpan a, int offset, in BitSpan z)
        {
            a.Storage.Slice(0, offset).CopyTo(z.Storage, offset);
            for(var i=0; i<offset; i++)
                z[i] = bit.Off;
            return ref z;
        }

        [MethodImpl(Inline), Op]
        public static bit same(in BitSpan a, in BitSpan b)
        {
            if(a.Length != b.Length)
                return false;

            for(var i=0; i<a.Length; i++)
                if(a[i] != b[i])
                    return false;

            return true;
        }

        /// <summary>
        /// Computes the number of enabled bits covered by source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static int pop(in BitSpan src)
        {
            var enabled = 0;
            var bitcount = src.Length;
            for(var i=0; i< bitcount; i++)
                enabled += (int)src[i];
            return enabled;
        }
    }
}