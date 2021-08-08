//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        Outcome ImportAsm(string label)
        {
            var result = Outcome.Success;
            var paths = Files(FS.Asm);
            var lines = list<AsmLine>();
            var counter = 0u;
            var dst = Imports().Path("asm", label, FS.Asm);
            using var writer = dst.AsciWriter();
            foreach(var path in paths)
            {
                lines.Clear();
                var count = AsmEtl.load(path, lines);
                counter += count;
                var desc = string.Format("Source: {0}, {1} lines", path.ToUri(), count);

                writer.WriteLine(asm.comment(desc));
                writer.WriteLine(asm.comment(RP.PageBreak80));
                writer.WriteLine();

                iter(lines, line => writer.WriteLine(line.Format()));
            }
            Write(string.Format("Imported {0} asm lines to {1}", counter, dst));
            return result;
        }

        // .asm-outfiles llvm-llc/dumps *.asm
        // .asm-import llvm-llc
    }
}