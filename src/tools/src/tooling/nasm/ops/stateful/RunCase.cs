//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Linq;

    using static Root;
    using static memory;

    partial class Nasm
    {
        public Index<NasmListEntry> RunCase(string name)
        {
            var tool = Tools.nasm(Wf);
            var @case = name;
            using var log = ShowLog(tool.Id.Format() + "." + @case, FS.Log);
            var runner = ScriptRunner.create(Db);
            var ran = runner.RunToolCmd(tool.Id, @case);
            if(ran)
                root.iter(ran.Data, x => log.Show(x));
            else
                Wf.Error(string.Format("{0}/{1} execution failed", tool.Id, @case));

            var listpath = tool.Listings().Where(l => l.Name.Contains(@case)).Single();
            var listing = tool.Listing(listpath);
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
                    tool.RenderEntry(entry, log.Buffer);
                    log.ShowBuffer();
                    entries.Add(entry);
                }
            }
            return entries.ToArray();
        }
    }
}
