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

    [ApiHost]
    public sealed partial class StringTables : AppService<StringTables>
    {
        const NumericKind Closure = UnsignedInts;

        public Outcome Emit(StringTableSpec spec, FS.FolderPath outdir)
        {
            var result = Outcome.Success;
            var csdst = outdir + FS.file(spec.TableName.Format(), FS.Cs);
            var rowdst = outdir + FS.file(spec.TableName.Format(), FS.Csv);
            var emitting = EmittingFile(csdst);
            using var cswriter = csdst.Writer();
            var cscount = csharp(spec, cswriter);
            EmittedFile(emitting, cscount);

            var buffer = alloc<StringTableRow>(spec.Entries.Length);
            rows(spec, buffer);
            TableEmit(@readonly(buffer), StringTableRow.RenderWidths, rowdst);
            return result;
        }
    }
}