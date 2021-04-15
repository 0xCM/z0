//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using static memory;

    [ApiHost]
    public sealed class AsmRoutines : AsmWfService<AsmRoutines>
    {
        [Op]
        public static uint filter(ReadOnlySpan<AsmMemberRoutine> src, Predicate<AsmMemberRoutine> predicate, Span<AsmMemberRoutine> dst)
        {
            var j=0u;
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var candidate = ref skip(src,i);
                if(predicate(candidate))
                    seek(dst,j++) = candidate;
            }
            return j;
        }
    }
}