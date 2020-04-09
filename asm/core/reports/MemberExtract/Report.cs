//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using F = MemberExtractField;
    using R = MemberExtractRecord;
    using Report = MemberExtractReport;
    using Created = ExtractReportCreated;

    public class MemberExtractReport : Report<Report,F,R>
    {        
        public ApiHostUri ApiHost {get;}

        public override string ReportName => $"Extract report for {ApiHost.Format()}";

        public static Report Create(ApiHostUri host, MemberExtract[] extracts)
        {
            var records = new MemberExtractRecord[extracts.Length];
            for(var i=0; i< extracts.Length; i++)
            {
                var op = extracts[i];
                records[i] = new MemberExtractRecord(                
                    Sequence : i,
                    Address : op.Member.Address,
                    Length : op.EncodedData.Length,
                    Uri : op.Uri,
                    OpSig : op.Member.Method.Signature().Format(),
                    Data : op.EncodedData
                    );

            }

            return new Report(host, records);
        }
        
        public MemberExtractReport(){}

        MemberExtractReport(ApiHostUri host, MemberExtractRecord[] records)
            : base(records)
        {
            this.ApiHost = host;
        }        
        
        public Created CreatedEvent()
            => Created.Define(this);
    }     
}