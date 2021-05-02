//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Linq;

    using static Root;
    using static memory;

    partial class Nasm
    {
        public Index<NasmListEntry> RunCaseScript(Identifier name)
        {
            var @case = name.Format();
            using var log = ShowLog(Id.Format() + "." + @case, FS.Log);
            var runner = ScriptRunner.create(Db);
            var ran = runner.RunToolCmd(Id, @case);
            if(ran)
                root.iter(ran.Data, x => log.Show(x));
            else
                Wf.Error(string.Format("{0}/{1} execution failed", Id, @case));

            var listpath = Listings().Where(l => l.Name.Contains(@case)).Single();
            var listing = ReadListing(listpath);
            var entries = root.list<NasmListEntry>();
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
            return entries.ToArray();
        }
    }
}
