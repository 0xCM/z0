//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".import-lists")]
        Outcome ImportLists(CmdArgs args)
        {
            var input = Files(FS.List).View;
            var count = input.Length;
            var formatter = Tables.formatter<ListItemRecord>(ListItemRecord.RenderWidths);

            for(var i=0; i<count; i++)
            {
                ref readonly var src = ref skip(input,i);
                var name = src.FileName.WithoutExtension.Format();
                var members = items(src.ReadText().SplitClean(Chars.Comma).Select(x => x.Trim()).Where(text.nonempty).ToReadOnlySpan()).View;
                var mCount = members.Length;
                var dst = TableWs().Subdir("lists") + src.FileName.ChangeExtension(FS.Csv);
                using var writer = dst.AsciWriter();
                writer.WriteLine(formatter.FormatHeader());
                for(var j=0; j<mCount; j++)
                {
                    ref readonly var member = ref skip(members,j);
                    var row = member.ToRecord(name);
                    writer.WriteLine(formatter.Format(row));
                }
                Status(string.Format("{0} -> {1}", src.ToUri(), dst.ToUri()));
            }

            return true;
        }
    }
}