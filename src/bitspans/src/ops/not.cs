//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class BitSpans
    {
        [MethodImpl(Inline), Op]
        public static ref readonly BitSpan not(in BitSpan x, in BitSpan z)
        {
            var bitcount = z.Length;
            for(var i=0; i< bitcount; i++)
                z[i] = ~ x[i];
            return ref z;
        }

        [Op]
        public static BitSpan not(in BitSpan x)
            => not(x, alloc(x.BitCount));
    }
}