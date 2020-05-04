//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using F = MemberParseField;
    using R = MemberParseRecord;
    using Report = MemberParseReport;

    public enum MemberParseField : ulong
    {
        Seq = 0 | 12ul << 32,

        SourceSeq = 1 | 12ul << 32,

        Address = 2 | 16ul << 32,

        Length = 3 | 8ul << 32,

        TermCode = 4 | 20ul << 32,

        Uri = 5 | 110ul << 32,

        OpSig = 6 | 110ul << 32,

        Data = 6 | 1ul << 32
    }    


    public class MemberParseReport : Report<Report,F,R>
    {             
        public ApiHostUri ApiHost {get;}

        [MethodImpl(Inline)]
        public static Report Create(ApiHostUri host, params R[] records)
            => new Report(records);

        public static Report Create(ApiHostUri host, ParsedMember[] extracts)
        {
            var records = new MemberParseRecord[extracts.Length];
            for(var i=0; i< records.Length; i++)
            {
                ref readonly var extract = ref extracts[i];
                records[i] = R.From(extract, i);
                
            }
            return new Report(records);
        }

        public MemberParseReport(){}
        
        [MethodImpl(Inline)]
        MemberParseReport(params R[] records)
            : base(records)
        {

        }
    }    
}