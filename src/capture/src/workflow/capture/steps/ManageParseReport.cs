//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static AsmEvents;

    partial class HostCaptureSteps
    {
        public readonly struct ManageParseReport
        {
            readonly CaptureWorkflowContext Context;

            [MethodImpl(Inline)]
            internal static ManageParseReport Create(CaptureWorkflowContext context)
                => new ManageParseReport(context);

            [MethodImpl(Inline)]
            ManageParseReport(CaptureWorkflowContext context)
            {
                this.Context = context;
            }

            public void SaveReport(MemberParseReport src, FilePath dst)
            {
                var context = Context;
                src.Save(dst)
                    .OnSome(f => context.Raise(ExtractReportSaved.Define(src.ApiHost, src.GetType(), src.RecordCount, f)));
            }

            public MemberParseReport CreateReport(ApiHostUri host, ParsedMemberExtract[] src)
            {
                var report = MemberParseReport.Create(host, src);                    
                Context.Raise(ParseReportCreated.Define(report));
                return report;
            }

        }
    }
}