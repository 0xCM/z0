//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Seed;

    using F = MemberExtractField;
    using R = MemberExtractRecord;
    using Report = MemberExtractReport;
    using Created = AsmEvents.ExtractReportCreated;

    public class MemberExtractReport : Report<Report,F,R>
    {        
        /// <summary>
        /// Loads a saved extract report
        /// </summary>
        /// <param name="src">The report path</param>
        public static MemberExtractReport Load(FilePath src)
        {
            var lines = src.ReadLines().Skip(1). Select(R.Parse).ToArray();
            if(lines.Length != 0)
                return new MemberExtractReport(lines[0].Uri.HostPath, lines);
            else
                return Empty;
        }        

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

        MemberExtractReport(ApiHostUri host, R[] records)
            : base(records)
        {
            this.ApiHost = host;
        }        
        
        public Created CreatedEvent()
            => Created.Define(this);
    }     
}