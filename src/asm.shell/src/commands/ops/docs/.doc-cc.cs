//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    using System;

    partial class AsmCmdService
    {
        [CmdOp(".doc-cc")]
        Outcome DocCc(CmdArgs args)
        {
            const string Pattern = "{0,-4} rel{1} [{2}:{3}b] => {4}";
            var result = Outcome.Success;
            var dst = Ws.Docs().Subdir("generated") + FS.file("jcc8.txt");
            var conditions = Conditions.create();
            var buffer = alloc<Jcc8Conditions>(32);
            var count = Conditions.jcc8(conditions,buffer);
            var output = slice(span(buffer),0, count);
            EmitConditionDocs(output, dst);
            using var reader = dst.AsciLineReader();
            while(reader.Next(out var line))
            {
                Write(SymbolicRender.format(line.Content));
            }

            return result;
        }

        uint EmitConditionDocs(ReadOnlySpan<Jcc8Conditions> src, FS.FilePath dst)
        {
            using var writer = dst.AsciWriter();
            var count = src.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var info = ref skip(src,i);
                writer.WriteLine(info.Format(false));
                counter++;
                if(!info.Identical)
                {
                    writer.WriteLine(info.Format(true));
                    counter++;
                }
            }
            return counter;
        }
    }
}