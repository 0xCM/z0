//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using R = MemberParseReport;
    using E = CaptureWorkflowEvents.ParseReportCreated;

    partial class CaptureWorkflowEvents
    {
        [MethodImpl(Inline)]
        public static E Define(R src)
            => E.Define(src);

        public readonly struct ParseReportCreated : IAppEvent<E>
        {
            public static E Empty => new E(MemberParseReport.Empty);

            [MethodImpl(Inline)]
            public static E Define(R report) => new E(report);

            [MethodImpl(Inline)]
            ParseReportCreated(R report)
            {
                this.Payload = report;
            }

            public R Payload {get;}

            public string Description
                => $"{Payload.RecordCount} records created for {Payload.ReportName}";
            
            public E Zero => Empty;
        }        
    }
}