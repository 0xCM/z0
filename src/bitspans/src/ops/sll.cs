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
        public static ref readonly BitSpan sll(in BitSpan a, int offset, in BitSpan dst)
        {
            memory.slice(a.Storage,0, offset).CopyTo(dst.Storage, offset);
            for(var i=0; i<offset; i++)
                dst[i] = bit.Off;
            return ref dst;
        }
    }
}