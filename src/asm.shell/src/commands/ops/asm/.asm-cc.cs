//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;
    using static WsAtoms;

    using System;

    partial class AsmCmdService
    {
        [CmdOp(".asm-cc")]
        Outcome DocCc(CmdArgs args)
        {
            const string Pattern = "{0,-4} rel{1} [{2}:{3}b] => {4}";
            var result = Outcome.Success;
            var jcc8 = Ws.Tables().Subdir(WsAtoms.machine) + FS.file("jcc8", FS.Txt);
            EmitConditionDocs(Conditions.jcc8(), jcc8);
            using var jcc8Reader = jcc8.AsciLineReader();
            while(jcc8Reader.Next(out var line))
                Write(SymbolicRender.format(line.Content));

            var jcc32 = Ws.Tables().Subdir(WsAtoms.machine) + FS.file("jcc32", FS.Txt);
            EmitConditionDocs(Conditions.jcc32(), jcc32);
            using var jcc32Reader = jcc32.AsciLineReader();
            while(jcc32Reader.Next(out var line))
                Write(SymbolicRender.format(line.Content));

            return result;
        }

        uint EmitConditionDocs<T>(ReadOnlySpan<T> src, FS.FilePath dst)
            where T : IConditional
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

        // uint EmitConditionDocs(ReadOnlySpan<Jcc32Conditions> src, FS.FilePath dst)
        // {
        //     using var writer = dst.AsciWriter();
        //     var count = src.Length;
        //     var counter = 0u;
        //     for(var i=0; i<count; i++)
        //     {
        //         ref readonly var info = ref skip(src,i);
        //         writer.WriteLine(info.Format(false));
        //         counter++;
        //         if(!info.Identical)
        //         {
        //             writer.WriteLine(info.Format(true));
        //             counter++;
        //         }
        //     }
        //     return counter;
        // }
    }
}