//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".lines")]
        Outcome ReadLines(CmdArgs args)
        {
            var result = Outcome.Success;

            return ReadAsciLines();
        }

        Outcome ReadAsciLines()
        {
            var result = Outcome.Success;
            var src = State.Files().View;
            var count = src.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                var path = skip(src,i);
                using var reader = path.AsciLineReader2();
                while(reader.Next(out var line))
                {
                    Write(line);
                    counter++;
                }
            }

            return result;
        }
    }
}