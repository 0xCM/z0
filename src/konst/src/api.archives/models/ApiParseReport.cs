//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using F = ApiParseField;
    using R = ApiParseRow;

    public class ApiParseReport : Report<ApiParseReport,F,R>
    {
        public ApiHostUri ApiHost {get;}

        public static ParseResult<ApiParseRow[]> load(FS.FilePath src)
            => load(FilePath.Define(src.Name));

        static ParseResult<ApiParseRow[]> load(FilePath src)
        {
            var attempts = src.ReadLines().Skip(1).Select(ApiParseReport.row);
            var failed = attempts.Where(r => !r.Succeeded);
            var success = attempts.Where(r => r.Succeeded).Select(r => r.Value);
            if(failed.Length != 0 && success.Length == 0)
                return ParseResult.Fail<ApiParseRow[]>(src.Name, failed[0].Reason);
            else
                return ParseResult.Success(src.Name, success);
        }

        static ApiParseRow record(in ApiMemberCode extract, uint seq)
            => new ApiParseRow
                (
                    Seq : (int)seq,
                    SourceSequence: (int)extract.Sequence,
                    Address : extract.Address,
                    Length : extract.Encoded.Length,
                    TermCode: extract.TermCode,
                    Uri : extract.OpUri,
                    OpSig : extract.Method.Signature().Format(),
                    Data : extract.Encoded
                );

        public static ApiParseRow[] create(ApiHostUri host, ApiMemberCodeTable members)
        {
            var count = members.Count;
            var buffer = alloc<R>(count);
            var dst = span(buffer);
            var src = members.View;
            for(var i=0u; i<count; i++)
                seek(dst,i) = record(skip(src,i), i);
            return buffer;
        }

        [MethodImpl(Inline)]
        public static Option<FilePath> save(ApiParseRow[] src, FS.FilePath dst)
            => Log.Save(src, dst);

        static ParseResult<ApiParseRow> row(string src)
        {
            try
            {
                var fields = src.SplitClean(FieldDelimiter);
                if(fields.Length !=  (uint)R.FieldCount)
                    return ParseResult.Fail<ApiParseRow>(src,"No data");

                var dst = new R();
                var index = 0;
                dst.Seq = NumericParser.succeed<int>(fields[index++]);
                dst.SourceSeq = NumericParser.succeed<int>(fields[index++]);
                dst.Address = MemoryAddressParser.succeed(fields[index++]);
                dst.Length = NumericParser.succeed<int>(fields[index++]);
                dst.TermCode = Enums.Parse(fields[index++], ExtractTermCode.None);
                dst.Uri = ApiUriParser.Service.Parse(fields[index++]).Require();
                dst.OpSig = fields[index++];
                dst.Data = new BasedCodeBlock(dst.Address, Parsers.hex(true).ParseData(fields[index++], sys.empty<byte>()));
                return ParseResult.Success(src, dst);
            }
            catch(Exception e)
            {
                return ParseResult.Fail<ApiParseRow>(src, e);
            }
        }

        public ApiParseReport(){}

        [MethodImpl(Inline)]
        internal ApiParseReport(ApiHostUri host, params ApiParseRow[] src)
            : base(src)
        {
            ApiHost = host;
        }
    }
}