//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using F = MemberParseField;
    using R = MemberParseRecord;
    using Report = MemberParseReport;
    using Created = AsmEvents.ParseReportCreated;

    public class MemberParseReport : Report<Report,F,R>
    {             
        public ApiHostUri ApiHost {get;}

        [MethodImpl(Inline)]
        public static Report Create(ApiHostUri host, params R[] records)
            => new Report(records);

        public static Report Create(ApiHostUri host, ParsedExtract[] extracts)
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

        public Created CreatedEvent()
            => Created.Define(this);
    }
}