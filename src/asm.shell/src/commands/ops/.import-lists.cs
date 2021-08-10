//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".import-lists")]
        Outcome ImportLists(CmdArgs args)
        {
            var dataset = arg(args,0).Value;
            var input = DataSources.Dataset(dataset).Files(FS.List);
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
                Write(FS.flow(src,dst));
            }

            return true;
        }

        [CmdOp(".load-list")]
        Outcome LoadListImport(CmdArgs args)
        {
            var lists = TableWs().Subdir("lists").AllFiles.View;
            var match = arg(args,0).Value;
            var count = lists.Length;
            var items = list<ListItem<string>>();
            var result = Outcome.Success;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(lists,i);
                if(path.FileName.WithoutExtension.Format().Contains(match, NoCase))
                {
                    using var reader = path.Utf8LineReader();
                    while(reader.Next(out var line))
                    {
                        if(counter == 0)
                        {
                            counter++;
                            continue;
                        }

                        var content = line.Content;
                        var parts = content.SplitClean(Chars.Pipe).ToReadOnlySpan();
                        if(parts.Length != 3)
                            return (false, Tables.FieldCountMismatch.Format(3,parts.Length));


                        result = DataParser.parse(skip(parts,1), out uint index);
                        if(result.Fail)
                            return result;

                        items.Add(new ListItem<string>(index,skip(parts,2)));
                        counter++;
                    }
                }
            }

            var max = 0u;
            foreach(var item in items)
            {
                var len = item.Content.Length;
                if(len > max)
                    max = (uint)len;
                Write(item);
            }
            Write(string.Format("Max item length:{0}", max));
            return result;
        }
    }
}