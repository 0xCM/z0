//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using R = ExtractReport;
    using E = CaptureWorkflowEvents.ExtractReportCreated;

    partial class CaptureWorkflowEvents
    {
        public readonly struct ExtractReportCreated : IAppEvent<E>
        {
            public static E Empty => new E(R.Empty);
            
            [MethodImpl(Inline)]
            public static E Define(R report)
                => new E(report);

            [MethodImpl(Inline)]
            public ExtractReportCreated(R report)
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