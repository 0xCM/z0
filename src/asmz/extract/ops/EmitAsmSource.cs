//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using Z0.Asm;

    using static memory;

    partial class ApiExtractor
    {
        uint EmitAsmSource(ApiHostUri host, ReadOnlySpan<AsmRoutine> src)
        {
            var counter = 0u;
            var count = (uint)src.Length;
            if(count == 0)
                return 0;
            var dst = Paths.AsmPath(host);
            var flow = Wf.EmittingFile(dst);
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
            {
                ref readonly var routine = ref skip(src,i);
                if(routine.IsNonEmpty)
                {
                    var formatted = Formatter.Format(routine);
                    writer.Write(formatted);
                    counter++;
                }
            }
            Wf.EmittedFile(flow, counter);

            return counter;
        }
    }
}