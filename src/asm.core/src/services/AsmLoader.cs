//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Concurrent;

    using static Root;
    using static core;

    public class AsmLoader : Service<AsmLoader>
    {
        public Index<HostAsmRecord> LoadHostAsmRows(FS.FilePath src)
        {
            var result = TextGrids.load(src, out var doc);
            if(!result)
            {
                Error(result.Message);
                return default;
            }
            else
            {
                var dst = alloc<HostAsmRecord>(doc.RowCount);
                var count = AsmParser.parse(doc, dst);
                if(count)
                    return dst;

                Error(count.Message);
                return default;
            }
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
                var results = parse(docs, dst);
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

                    var parsed = AsmParser.parse(grid, dst);
                    if(parsed.Fail)
                        Error(string.Format("Error parsing {0}:{1}", file.ToUri(), result.Message));
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

        public static uint ProcessAsmCount(FS.FilePath src)
        {
            var counter = 0u;
            using var reader = src.AsciReader();
            var header = reader.ReadLine();
            var line = reader.ReadLine();
            while(line != null)
            {
                counter++;
                line = reader.ReadLine();
            }

            return counter;
        }

        public static Outcome<uint> LoadProcessAsm(FS.FilePath src, Span<ProcessAsmRecord> dst)
        {
            var counter = 1u;
            var i = 0u;
            var max = dst.Length;
            using var reader = src.AsciReader();
            var header = reader.ReadLine();
            var line = reader.ReadLine();
            var result = Outcome.Success;
            while(line != null && result.Ok)
            {
                result = AsmParser.parse(counter++, line, out seek(dst,i));
                if(result.Fail)
                    return result;
                else
                    i++;

                line = reader.ReadLine();
            }
            return i;
        }

        static Index<Outcome<uint>> parse(ReadOnlySpan<TextGrid> src, ConcurrentBag<HostAsmRecord> dst)
        {
            var results = bag<Outcome<uint>>();
            iter(src, doc => {
                results.Add(AsmParser.parse(doc, dst));
            }, true);
            return results.ToArray();
        }

        static MsgPattern<FS.FolderPath> LoadingStatements => "Loading asm statement rows from {0}";

        static MsgPattern<Count> ParsedStatements => "Parsed {0} asm statement rows";

        static MsgPattern<Count> LoadingDocs => "Loading {0} documents";

        static MsgPattern<Count> ParsingDocs => "Parsing {0} documents";
    }
}