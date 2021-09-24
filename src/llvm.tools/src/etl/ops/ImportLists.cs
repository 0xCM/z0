//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;

    partial class EtlWorkflow
    {
        public Outcome ImportLists()
        {
            var project = Ws.Project("llvm.data");
            var target = project.Tables();
            var input = project.OutFiles(FS.List).View;
            var count = input.Length;
            var formatter = Tables.formatter<ListItem>(ListItem.RenderWidths);
            var result = list<ListItem>();
            for(var i=0; i<count; i++)
            {
                ref readonly var src = ref skip(input,i);
                var name = src.FileName.WithoutExtension.Format();
                var members = items(src.ReadText().SplitClean(Chars.Comma).Select(x => x.Trim()).Where(text.nonempty).ToReadOnlySpan()).View;
                var mCount = members.Length;
                var dst = target + src.FileName.ChangeExtension(FS.Csv);
                using var writer = dst.AsciWriter();
                writer.WriteLine(formatter.FormatHeader());
                for(var j=0; j<mCount; j++)
                {
                    ref readonly var member = ref skip(members,j);
                    var row = member.ToRecord(name);
                    result.Add(row);
                    writer.WriteLine(formatter.Format(row));
                }
                Write(FS.flow(src,dst));
            }
            return true;
        }
    }
}