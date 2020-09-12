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
    using R = MemberParseRecord;

    public class MemberParseReport : Report<MemberParseReport,F,R>
    {
        public ApiHostUri ApiHost {get;}

        public static ParseResult<MemberParseReport> parse(FilePath src)
        {
            var result = MemberParseRecord.load(src);
            if(result.Succeeded && (result.Value.Length != 0))
            {
                var records = result.Value;
                return ParseResult.Success(src.Name, MemberParseReport.create(records[0].Uri.Host, records));
            }
            else
            {
                if(result.Succeeded)
                    return ParseResult.Success(src.Name, MemberParseReport.Empty);
                else
                    return ParseResult.Fail<MemberParseReport>(src.Name);
            }
        }

        [MethodImpl(Inline)]
        public static MemberParseReport create(ApiHostUri host, params MemberParseRecord[] src)
            => new MemberParseReport(host, src);

        static MemberParseRecord record(in X86ApiMember extract, uint seq)
            => new MemberParseRecord
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

        public static MemberParseReport create(ApiHostUri host, X86ApiMembers members)
        {
            var count = members.Count;
            var buffer = alloc<R>(count);
            var dst = span(buffer);
            var src = members.View;

            for(var i=0u; i<count; i++)
                seek(dst,i) = record(skip(src,i), i);

            return new MemberParseReport(host, buffer);
        }

        public MemberParseReport(){}

        [MethodImpl(Inline)]
        internal MemberParseReport(ApiHostUri host, params MemberParseRecord[] src)
            : base(src)
        {
            ApiHost = host;
        }
    }
}