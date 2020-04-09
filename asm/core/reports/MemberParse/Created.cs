//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using Report = MemberParseReport;
    using Created = ParseReportCreated;

    public readonly struct ReportCreated<R> : IAppEvent<ReportCreated<R>,R>
        where R : IReport, new()
    {
        public static ReportCreated<R> Empty => new ReportCreated<R>(new R());

        public R Payload {get;}
        
        ReportCreated(R report)
        {
            this.Payload = report;
        }

        public string Description
            => $"{Payload.RecordCount} records created for {Payload.ReportName}";
        
        public string Format()
            => Description;                 
    }

    public readonly struct ParseReportCreated : IAppEvent<Created,Report>
    {
        public static Created Empty => new Created(MemberParseReport.Empty);

        [MethodImpl(Inline)]
        public static Created Define(Report report)
            => new Created(report);

        [MethodImpl(Inline)]
        ParseReportCreated(Report report)
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