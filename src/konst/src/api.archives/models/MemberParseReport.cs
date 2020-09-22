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

    using F = MemberParseField;
    using R = MemberParseRow;

    public class MemberParseReport : Report<MemberParseReport,F,R>
    {
        public ApiHostUri ApiHost {get;}

        public static ParseResult<MemberParseRow[]> load(FS.FilePath src)
            => load(FilePath.Define(src.Name));

        static ParseResult<MemberParseRow[]> load(FilePath src)
        {
            var attempts = src.ReadLines().Skip(1).Select(MemberParseReport.row);
            var failed = attempts.Where(r => !r.Succeeded);
            var success = attempts.Where(r => r.Succeeded).Select(r => r.Value);
            if(failed.Length != 0 && success.Length == 0)
                return ParseResult.Fail<MemberParseRow[]>(src.Name, failed[0].Reason);
            else
                return ParseResult.Success(src.Name, success);
        }

        static MemberParseRow record(in ApiMemberHex extract, uint seq)
            => new MemberParseRow
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

        public static MemberParseRow[] create(ApiHostUri host, ApiHexTable members)
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
        public static Option<FilePath> save(MemberParseRow[] src, FS.FilePath dst)
            => Log.Save(src, dst);

        static ParseResult<MemberParseRow> row(string src)
        {
            try
            {
                var fields = src.SplitClean(FieldDelimiter);
                if(fields.Length !=  (uint)R.FieldCount)
                    return ParseResult.Fail<MemberParseRow>(src,"No data");

                var dst = new R();
                var index = 0;
                dst.Seq = NumericParser.succeed<int>(fields[index++]);
                dst.SourceSeq = NumericParser.succeed<int>(fields[index++]);
                dst.Address = MemoryAddressParser.succeed(fields[index++]);
                dst.Length = NumericParser.succeed<int>(fields[index++]);
                dst.TermCode = Enums.Parse(fields[index++], ExtractTermCode.None);
                dst.Uri = ApiUriParser.Service.Parse(fields[index++]).Require();
                dst.OpSig = fields[index++];
                dst.Data = new X86Code(dst.Address, Parsers.hex(true).ParseData(fields[index++], sys.empty<byte>()));
                return ParseResult.Success(src, dst);
            }
            catch(Exception e)
            {
                return ParseResult.Fail<MemberParseRow>(src, e);
            }
        }

        public MemberParseReport(){}

        [MethodImpl(Inline)]
        internal MemberParseReport(ApiHostUri host, params MemberParseRow[] src)
            : base(src)
        {
            ApiHost = host;
        }
    }
}