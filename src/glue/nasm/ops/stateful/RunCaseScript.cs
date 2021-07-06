//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Linq;

    using static Root;
    using static core;

    partial class Nasm
    {
        public ReadOnlySpan<NasmListEntry> RunCaseScript(Identifier name)
        {
            var @case = name.Format();
            using var log = ShowLog(Id.Format() + "." + @case, FS.Log);
            var runner = Wf.ScriptRunner();
            var output = runner.RunToolCmd(Id, @case);
            iter(output, x => log.Show(x));
            var listpath = Listings().Where(l => l.Name.Contains(@case)).Single();
            var listing = ReadListing(listpath);
            var entries = list<NasmListEntry>();
            var lines = listing.Lines.View;
            log.Title(listpath.ToUri());
            var count = lines.Length;
            for(var j=0; j<count; j++)
            {
                ref readonly var line = ref skip(lines,j);
                var content = span(line.Content);

                if(!Nasm.entry(line, out var entry))
                    Wf.Error("Parse entry failed");
                else
                {
                    RenderListEntry(entry, log.Buffer);
                    log.ShowBuffer();
                    entries.Add(entry);
                }
            }
            return entries.ViewDeposited();
        }
    }
}
