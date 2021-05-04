//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static memory;

    partial class ApiExtractor
    {
        Index<AsmRoutine> DecodeMembers(ReadOnlySpan<ApiMemberCode> src)
        {
            var count = src.Length;
            var buffer = alloc<AsmRoutine>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var member = ref skip(src,i);
                var decoded = Decoder.Decode(member);
                if(decoded)
                {
                    seek(dst,i) = decoded.Value;
                }
            }
            return buffer;
        }
    }
}