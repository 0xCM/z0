//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Collections.Generic;

    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".import-asm")]
        Outcome ImportAsm(CmdArgs args)
        {
            var result = Outcome.Success;
            var paths = Files(FS.Asm);
            var dst = list<AsmLine>();
            foreach(var path in paths)
            {
                dst.Clear();
                var count = ImportAsm(path,dst);
                Write(string.Format("{0}[{1}]:",path.ToUri(), count));
                iter(dst, token => Write(token.Format()));
            }
            return result;
        }

        // .tool-out-files dumpbin *.asm
        uint ImportAsm(FS.FilePath src, List<AsmLine> dst)
        {
            var counter = 0u;
            using var reader = src.AsciLineReader();
            while(reader.Next(out var line))
            {
                if(AsmParser.parse(line, out AsmBlockLabel label, out AsmExpr expr))
                {
                    if(AsmParser.parse(label, out AsmOffsetLabel offset))
                    {
                        dst.Add(asm.line(offset,expr));
                        counter++;
                    }
                    else
                    {
                        if(expr.IsNonEmpty)
                        {
                            dst.Add(asm.line(label,expr));
                            counter++;
                        }
                        else
                        {
                            dst.Add(asm.line(label));
                            counter++;

                        }
                    }
                }
            }
            return counter;
        }
    }
}