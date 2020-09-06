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

        [MethodImpl(Inline)]
        public static MemberParseReport create(ApiHostUri host, params R[] records)
            => new MemberParseReport(host, records);

        static R Record(in X86MemberRefinement extract, uint seq)
            => new R
                (
                    Seq : (int)seq,
                    SourceSequence: extract.Sequence,
                    Address : extract.Address,
                    Length : extract.Encoded.Length,
                    TermCode: extract.TermCode,
                    Uri : extract.OpUri,
                    OpSig : extract.Method.Signature().Format(),
                    Data : extract.Encoded
                );

        public static MemberParseReport create(ApiHostUri host, X86MemberRefinement[] extracts)
        {
            var count = extracts.Length;
            var buffer = alloc<R>(count);
            var dst = span(buffer);
            var src = span(extracts);

            for(var i=0u; i<count; i++)
                seek(dst,i) = Record(skip(src,i), i);

            return new MemberParseReport(host, buffer);
        }

        public MemberParseReport(){}

        [MethodImpl(Inline)]
        internal MemberParseReport(ApiHostUri host, params R[] records)
            : base(records)
        {
            ApiHost = host;
        }
    }
}