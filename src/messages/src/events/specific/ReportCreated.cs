//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
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
        
        public ReportCreated<R> Zero => Empty;
    }
}