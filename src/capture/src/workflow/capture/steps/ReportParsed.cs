//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static CaptureWorkflowEvents;

    partial class HostCaptureSteps
    {
        public readonly struct EmitParsedReport : IEmitParsedReportStep
        {
            public ICaptureWorkflow Workflow {get;}

            public ICaptureContext Context 
                => Workflow.Context;

            [MethodImpl(Inline)]
            internal EmitParsedReport(ICaptureWorkflow workflow)
                => Workflow = workflow;

            public void Emit(ApiHostUri host, ParsedMember[] src, FilePath dst)
            {
                var context = Context;
                var report = MemberParseReport.Create(host, src);                    
                var saved = report.Save(dst);
                if(saved)
                    Context.Raise(new ParseReportEmitted(report, dst));
                else
                    term.error($"Report emission failed");
            }
        }
    }
}