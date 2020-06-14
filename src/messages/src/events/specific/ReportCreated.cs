//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct ReportCreated<R> : IAppEvent<ReportCreated<R>>
        where R : IReport, new()
    {
        public static ReportCreated<R> Empty => new ReportCreated<R>(new R());

        public R Report {get;}
        
        ReportCreated(R report)
        {
            this.Report = report;
        }

        public string Description
            => $"{Report.RecordCount} records created for {Report.ReportName}";
        
        public ReportCreated<R> Zero => Empty;
    }
}