//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static CaptureWorkflowEvents;

    partial class HostCaptureSteps
    {
        public readonly struct ReportParsedStep : IReportParsedStep
        {
            public ICaptureWorkflow Workflow {get;}

            public ICaptureContext Context => Workflow.Context;

            [MethodImpl(Inline)]
            internal ReportParsedStep(ICaptureWorkflow workflow)
            {
                Workflow = workflow;
            }

            public MemberParseReport CreateParseReport(ApiHostUri host, ParsedMember[] src)
            {
                var report = MemberParseReport.Create(host, src);                    
                Context.Raise(ParseReportCreated.Define(report));
                return report;
            }

            public void SaveParseReport(MemberParseReport src, FilePath dst)
            {
                var context = Context;
                src.Save(dst)
                    .OnSome(f => context.Raise(ExtractReportSaved.Define(src.ApiHost, src.GetType(), src.RecordCount, f)));
            }

        }
    }
}