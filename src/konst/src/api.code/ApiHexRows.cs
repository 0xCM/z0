//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct ApiHexRows
    {
        public static Index<ApiHexRow> emit(IWfShell wf, ApiHostUri uri, ReadOnlySpan<ApiMemberCode> src)
        {
            var count = src.Length;
            if(count == 0)
                wf.Warn($"No {uri} records were provided");

            if(count != 0)
            {
                var rows = create(uri, src);
                if(rows.Length != count)
                {
                    wf.Error($"The distilled row count of {rows.Length} does not match the input count of {count}");
                }
                else
                {
                    var f1 = wf.Db().CapturedHexFile(uri);
                    wf.EmittingTable<ApiHexRow>(f1);
                    emit(rows, f1);

                    var f2 = wf.Db().ParsedExtractFile(uri);
                    wf.EmittingTable<ApiHexRow>(f2);
                    emit(rows, f2);
                }
                return rows;
            }
            else
                return Index<ApiHexRow>.Empty;
        }

        [MethodImpl(Inline), Op]
        public static void emit(ReadOnlySpan<ApiHexRow> src, FS.FilePath dst)
        {
            var count = src.Length;
            if(count != 0)
                Records.emit(src,dst);
        }

        [Op]
        public static Index<ApiHexRow> load(FS.FilePath src)
        {
            var data = @readonly(src.ReadLines().Storage.Skip(1));
            var count = data.Length;
            var buffer = root.list<ApiHexRow>(count);
            for(var i=0; i<count; i++)
            {
                if(ApiHexParser.parse(skip(data,i), out var dst))
                {
                    buffer.Add(dst);
                }
            }
            return buffer.ToArray();
            // var attempts = src.ReadLines().Storage.Skip(1).Select(row);
            // var failed = attempts.Where(r => !r.Succeeded);
            // var success = attempts.Where(r => r.Succeeded).Select(r => r.Value);
            // if(failed.Length != 0 && success.Length == 0)
            //     return root.unparsed<ApiHexRow[]>(src.Name, failed[0].Message?.ToString() ?? EmptyString);
            // else
            //     return root.parsed<ApiHexRow[]>(src.Name, success);
        }

        [Op]
        static ApiHexRow[] create(ApiHostUri host, ReadOnlySpan<ApiMemberCode> src)
        {
            var count = src.Length;
            var buffer = alloc<ApiHexRow>(count);
            if(count != 0)
            {
                var dst = span(buffer);
                for(var i=0u; i<count; i++)
                    seek(dst, i) = row(skip(src, i), i);
            }
            return buffer;
        }

        [MethodImpl(Inline), Op]
        static ApiHexRow row(in ApiMemberCode src, uint seq)
        {
            var dst = new ApiHexRow();
            dst.Seq = (int)seq;
            dst.SourceSeq = (int)src.Sequence;
            dst.Address = src.Address;
            dst.Length = src.Encoded.Length;
            dst.TermCode = src.TermCode;
            dst.Uri = src.OpUri;
            dst.Data = src.Encoded;
            return dst;
        }

        // [Op]
        // static ParseResult<ApiHexRow> row(string src)
        // {
        //     try
        //     {
        //         var fields = src.SplitClean(FieldDelimiter);
        //         if(fields.Length !=  (uint)ApiHexRowSpec.FieldCount)
        //             return root.unparsed<ApiHexRow>(src,"No data");

        //         var dst = new ApiHexRow();
        //         var index = 0;
        //         dst.Seq = Numeric.parse<int>(fields[index++]).ValueOrDefault();
        //         dst.SourceSeq = Numeric.parse<int>(fields[index++]).ValueOrDefault();
        //         dst.Address = MemoryAddressParser.succeed(fields[index++]);
        //         dst.Length = Numeric.parse<int>(fields[index++]).ValueOrDefault();
        //         dst.TermCode = Enums.parse(fields[index++], ExtractTermCode.None);
        //         dst.Uri = ApiUri.parse(fields[index++]).Require();
        //         dst.Data = new CodeBlock(dst.Address, HexParsers.bytes().ParseData(fields[index++], sys.empty<byte>()));
        //         return root.parsed(src, dst);
        //     }
        //     catch(Exception e)
        //     {
        //         return root.unparsed<ApiHexRow>(src, e);
        //     }
        // }
    }
}