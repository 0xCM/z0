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
        public Index<AsmHostStatement> LoadHostStatements(FS.FilePath src)
        {
            var result = TextGrids.load(src, out var doc);
            if(!result)
            {
                Error(result.Message);
                return default;
            }
            else
            {
                var dst = alloc<AsmHostStatement>(doc.RowCount);
                var count = AsmParser.parse(doc, dst);
                if(count)
                    return dst;

                Error(count.Message);
                return default;
            }
        }

        public Index<AsmHostStatement> LoadHostStatements(FS.FolderPath src)
        {
            var files = src.Files(FS.Csv, true);
            var flow = Running(LoadingStatements.Format(src));
            var dst = bag<AsmHostStatement>();
            Status(LoadingDocs.Format(files.Length));
            var docs = TextGrids.load(files);
            var counter = 0u;

            Status(ParsingDocs.Format(docs.Length));
            var results = parse(docs, dst);
            foreach(var result in results)
                result.OnSuccess(count => counter+=count).OnFailure(msg => Error(msg));

            Ran(flow, ParsedStatements.Format(counter));

            return dst.ToArray();
        }

        public static Outcome<uint> LoadProcessAsm(FS.FilePath src, Span<ProcessAsm> dst)
        {
            var counter = 1u;
            var i = 0u;
            var max = dst.Length;
            using var reader = src.Utf8Reader();
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

        static Index<Outcome<uint>> parse(ReadOnlySpan<TextGrid> src, ConcurrentBag<AsmHostStatement> dst)
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