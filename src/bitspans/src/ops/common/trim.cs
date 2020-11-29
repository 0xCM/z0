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
        public static BitSpan trim(in BitSpan src)
        {
            var pos = msb(src);
            if(pos != 0 && pos != src.Length - 1)
                return load(memory.slice(src.Storage,0, pos + 1));
            else
                return src;
        }
    }
}