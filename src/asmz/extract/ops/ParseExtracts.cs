//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using Z0.Asm;

    using static memory;
    using static ApiExtractReceivers;

    partial class ApiExtractor
    {
        ApiMemberBlocks ParseExtracts(ReadOnlySpan<ApiMemberExtract> src)
        {
            var count = src.Length;
            var buffer = alloc<ApiMemberCode>(count);
            ref var parsed = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var input = ref skip(src,i);
                ref var output = ref seek(parsed,i);
                if(Parser.Parse(input, out output))
                {
                    Receivers.Raise(new MemberParsedEvent(input,output));
                }

            }
            return buffer;
        }
    }
}