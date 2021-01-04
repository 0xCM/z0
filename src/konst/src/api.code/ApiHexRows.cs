//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    using F = ApiHexField;

    [ApiHost]
    public readonly partial struct ApiHexRows
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
            {
                var formatter = Table.formatter<F>(FieldDelimiter);
                using var writer = dst.Writer();
                writer.WriteLine(Table.header53<ApiHexField>());

                ref readonly var row = ref first(src);
                for(var i=0; i<count; i++)
                    writer.WriteLine(format(skip(row,i), formatter));
            }
        }

        [Op]
        public static ParseResult<ApiHexRow[]> load(FS.FilePath src)
        {
            var attempts = src.ReadLines().Skip(1).Select(row);
            var failed = attempts.Where(r => !r.Succeeded);
            var success = attempts.Where(r => r.Succeeded).Select(r => r.Value);
            if(failed.Length != 0 && success.Length == 0)
                return ParseResult.fail<ApiHexRow[]>(src.Name, failed[0].Message);
            else
                return ParseResult.win<ApiHexRow[]>(src.Name, success);
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
            dst.Data = new CodeBlock(src.Address, src.Encoded.Data);
            return dst;
        }

        static string format(in ApiHexRow src, DatasetFieldFormatter<F> dst)
        {
            dst.Delimit(F.Seq, src.Seq);
            dst.Delimit(F.SourceSeq, src.SourceSeq);
            dst.Delimit(F.Address, src.Address);
            dst.Delimit(F.Length, src.Length);
            dst.Delimit(F.TermCode, src.TermCode);
            dst.Delimit(F.Uri, src.Uri);
            dst.Delimit(F.Data, src.Data.Format());
            return dst.Emit();
        }

        [Op]
        static ParseResult<ApiHexRow> row(string src)
        {
            try
            {
                var fields = src.SplitClean(FieldDelimiter);
                if(fields.Length !=  (uint)ApiHexRowSpec.FieldCount)
                    return ParseResult.fail<ApiHexRow>(src,"No data");

                var dst = new ApiHexRow();
                var index = 0;
                dst.Seq = NumericParser.succeed<int>(fields[index++]);
                dst.SourceSeq = NumericParser.succeed<int>(fields[index++]);
                dst.Address = MemoryAddressParser.succeed(fields[index++]);
                dst.Length = NumericParser.succeed<int>(fields[index++]);
                dst.TermCode = Enums.parse(fields[index++], ExtractTermCode.None);
                dst.Uri = ApiUri.parse(fields[index++]).Require();
                dst.Data = new CodeBlock(dst.Address, HexParsers.bytes().ParseData(fields[index++], sys.empty<byte>()));
                return ParseResult.win(src, dst);
            }
            catch(Exception e)
            {
                return ParseResult.fail<ApiHexRow>(src, e);
            }
        }
    }
}