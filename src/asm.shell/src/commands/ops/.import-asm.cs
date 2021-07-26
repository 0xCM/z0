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
            var lines = list<AsmLine>();
            var counter = 0u;
            var dst = ImportWs().Path("asm", "test", FS.Asm);
            using var writer = dst.AsciWriter();
            foreach(var path in paths)
            {
                lines.Clear();
                var count = ImportAsm(path, lines);
                counter += count;
                var desc = string.Format("{0}[{1}]:", path.ToUri(), count);
                writer.WriteLine(string.Format("; {0}", desc));
                iter(lines, line => writer.WriteLine(line.Format()));
            }
            Write(string.Format("Imported {0} asm lines to {1}", counter, dst));
            return result;
        }

        // .project ll
        // .outfiles dumps/*.asm
        // .import-asm

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
                        dst.Add(asm.line(offset, expr));
                        counter++;
                    }
                    else
                    {
                        if(expr.IsNonEmpty)
                        {
                            dst.Add(asm.line(label, expr));
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