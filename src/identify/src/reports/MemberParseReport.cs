//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;

    using F = MemberParseField;
    using R = MemberParseRecord;

    public class MemberParseReport : Report<MemberParseReport,F,R>
    {             
        public ApiHostUri ApiHost {get;}

        [MethodImpl(Inline)]
        public static MemberParseReport Create(ApiHostUri host, params R[] records)
            => new MemberParseReport(host, records);

        public static R Record(in ParsedExtract extract, int seq)
            => new R
                (
                    Seq : seq,
                    SourceSequence: extract.Sequence,
                    Address : extract.Address,
                    Length : extract.Encoded.Length,
                    TermCode: extract.TermCode,
                    Uri : extract.OpUri,
                    OpSig : extract.Method.Signature().Format(),
                    Data : extract.Encoded
                );

        public static MemberParseReport Create(ApiHostUri host, ParsedExtract[] extracts)
        {
            var count = extracts.Length;
            var buffer = alloc<R>(count);            
            var dst = span(buffer);
            var src = span(extracts);

            for(var i=0; i<count; i++)
            {
                ref readonly var extract = ref skip(src,i);
                seek(dst,i) = Record(extract, i);                
            }
            
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