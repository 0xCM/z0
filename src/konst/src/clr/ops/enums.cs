//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct ClrQuery
    {
        [MethodImpl(Inline), Op]
        public readonly void enums(in ReadOnlySpan<Type> src, Span<ClrEnum> dst)
        {
            var count = src.Length;
            for(uint i=0, j=0; i<count; i++)
            {
                ref readonly var candidate = ref skip(src,i);
                if(candidate.IsEnum)
                    seek(dst, j++) = candidate;
            }
        }
    }
}