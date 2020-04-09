//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using Report = MemberExtractReport;
    using Created = ExtractReportCreated;

    public readonly struct ExtractReportCreated : IAppEvent<Created,Report>
    {
        public static Created Empty => new ExtractReportCreated(Report.Empty);
        
        [MethodImpl(Inline)]
        public static Created Define(Report report)
            => new Created(report);

        [MethodImpl(Inline)]
        public ExtractReportCreated(Report report)
        {
            this.Payload = report;
        }

        public Report Payload {get;}

        public string Description
            => $"{Payload.RecordCount} records created for {Payload.ReportName}";
        
        public string Format()
            => Description;         
    }    
}