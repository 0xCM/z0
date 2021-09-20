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

    partial struct StringTableOps
    {
        // public static Outcome emit(StringTableSpec spec, FS.FolderPath outdir)
        // {
        //     var result = Outcome.Success;
        //     var csdst = outdir + FS.file(spec.TableName.Format(), FS.Cs);
        //     var rowdst = outdir + FS.file(spec.TableName.Format(), FS.Csv);
        //     using var cswriter = csdst.Writer();
        //     encode(spec, cswriter);
        //     var count = spec.Entries.Length;
        //     var buffer = alloc<StringTableRow>(count);
        //     rows(spec, buffer);
        //     Tables.emit(@readonly(buffer), StringTableRow.RenderWidths, rowdst);
        //     return result;
        // }
    }
}