//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;
    using static Msg;

    [ApiHost]
    public class AsmEtl : AppService<AsmEtl>
    {
        public ReadOnlySpan<TextLine> EmitThumbprints(SortedSpan<AsmEncodingInfo> src, FS.FilePath dst)
        {
            var count = src.Length;
            var emitting = EmittingFile(dst);
            var lines = span<TextLine>(count);
            using var writer = dst.Writer();
            for(var i=0u; i<count; i++)
            {
                var content = AsmRender.thumbprint(SortedSpans.skip(src,i));
                writer.WriteLine(content);
                seek(lines,i) = (i,content);
            }
            EmittedFile(emitting, count);
            return lines;
        }

        public void EmitThumbprints(SortedSpan<ProcessAsmRecord> src, FS.FilePath dst)
            => EmitThumbprints(asm.encodings(src), dst);

        public SortedSpan<AsmThumbprint> EmitThumbprints(ReadOnlySpan<HostAsmRecord> src, FS.FilePath dst)
        {
            var distinct = asm.thumbprints(src);
            asm.emit(distinct, dst);
            return distinct;
        }

        public Index<HostAsmRecord> LoadHostAsmRows(FS.FolderPath src, bool pll = true, bool sort = true)
        {
            var files = src.Files(FS.Csv, true);
            var flow = Running(LoadingStatements.Format(src));
            var counter = 0u;
            var dst = bag<HostAsmRecord>();
            if(pll)
            {
                Status(LoadingDocs.Format(files.Length));
                var docs = TextGrids.load(files);
                Status(ParsingDocs.Format(docs.Length));
                var results = AsmParser.rows(docs, dst);
                foreach(var result in results)
                    result.OnSuccess(count => counter+=count).OnFailure(msg => Error(msg));
            }
            else
            {
                foreach(var file in files)
                {
                    var result = TextGrids.load(file, out var grid);
                    if(result.Fail)
                    {
                        Error(result.Message);
                        continue;
                    }

                    var parsed = AsmParser.rows(grid, dst);
                    if(parsed.Fail)
                        Error(FileParseError.Format(file, result.Message));
                    else
                        counter += parsed.Data;
                }
            }

            Ran(flow, ParsedStatements.Format(counter));

            var records = dst.ToArray();
            if(sort)
                Array.Sort(records);
            return records;
        }
    }
}