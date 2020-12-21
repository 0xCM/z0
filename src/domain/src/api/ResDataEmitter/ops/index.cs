//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static z;

    using F = ContentLibField;

    partial struct ResDataEmitter
    {
        public static void index(IWfShell wf)
        {
            wf.Running();

            var provider = TableContentProvider.create(Parts.Res.Assembly);
            var entries = provider.Entries;
            var count = (uint)entries.Length;

            var f = Table.formatter<ContentLibField>();
            var target = wf.Db().RefDataRoot() + FS.file("index", FileExtensions.Csv);
            for(var i=0u; i<count; i++)
            {
                ref readonly var entry = ref skip(entries, i);
                f.Append(F.Type, entry.Type);
                f.Delimit(F.Name, entry.Name);
                f.EmitEol();
            }

            using var dst = target.Writer();
            dst.Write(f.Format());

            wf.EmittedTable<DocLibEntry>(count, target);
        }
    }
}