//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static StringTableOps;

    public sealed class StringTables : AppService<StringTables>
    {
        public Outcome Emit(StringTableSpec spec, FS.FolderPath outdir)
        {
            var result = Outcome.Success;
            var csdst = outdir + FS.file(spec.TableName.Format(), FS.Cs);
            var rowdst = outdir + FS.file(spec.TableName.Format(), FS.Csv);
            var emitting = EmittingFile(csdst);
            using var cswriter = csdst.Writer();
            var cscount = encode(spec, cswriter);
            EmittedFile(emitting, cscount);

            var buffer = alloc<StringTableRow>(spec.Entries.Length);
            rows(spec, buffer);
            TableEmit(@readonly(buffer), StringTableRow.RenderWidths, rowdst);
            return result;
        }
    }
}