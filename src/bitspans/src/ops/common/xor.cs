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
        public static ref readonly BitSpan xor(in BitSpan x, in BitSpan y, in BitSpan z)
        {
            var bitcount = z.Length;
            for(var i=0; i< bitcount; i++)
                z[i] = x[i] ^ y[i];
            return ref z;
        }

        [Op]
        public static BitSpan xor(in BitSpan x, in BitSpan y)
            => xor(x,y, alloc(y.BitCount));
    }
}