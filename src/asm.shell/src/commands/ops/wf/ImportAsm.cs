//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        Outcome ImportAsm()
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
                var count = AsmEtl.load(path, lines);
                counter += count;
                var desc = string.Format("{0}[{1}]:", path.ToUri(), count);
                writer.WriteLine(string.Format("; {0}", desc));
                iter(lines, line => writer.WriteLine(line.Format()));
            }
            Write(string.Format("Imported {0} asm lines to {1}", counter, dst));
            return result;
        }
    }
}