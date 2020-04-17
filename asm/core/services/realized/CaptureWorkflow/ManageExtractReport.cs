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
        public readonly struct ManageExtractReport
        {
            readonly CaptureWorkflowContext Context;
            
            [MethodImpl(Inline)]
            internal static ManageExtractReport Create(CaptureWorkflowContext context)
                => new ManageExtractReport(context);

            [MethodImpl(Inline)]
            ManageExtractReport(CaptureWorkflowContext context)
            {
                this.Context = context;
            }
            
            public MemberExtractReport CreateReport(in ApiHost host, ExtractedMember[] src)
            {
                var report = MemberExtractReport.Create(host.UriPath, src); 
                Context.Raise(ExtractReportCreated.Define(report));                
                return report;
            }

            public void SaveReport(MemberExtractReport src, FilePath dst)
            {
                var context = Context;
                src.Save(dst)
                    .OnSome(f => context.Raise(ExtractReportSaved.Define(src.ApiHost, src.GetType(), src.RecordCount, f)));
            }
        }
    }
}