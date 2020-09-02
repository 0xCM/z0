//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RenderPatterns;
    using static EmitParsedReportStep;

    using Z0.Asm;

    public readonly ref struct EmitParsedReport
    {

        readonly CorrelationToken Ct;

        readonly ApiHostUri Host;

        readonly X86MemberRefinement[] Source;

        readonly FilePath Target;

        readonly IWfShell Wf;

        [MethodImpl(Inline)]
        internal EmitParsedReport(IWfCaptureState state, ApiHostUri host, X86MemberRefinement[] src, FilePath dst, CorrelationToken ct)
        {
            Wf = state.Wf;
            Ct = ct;
            Host = host;
            Source = src;
            Target = dst;
            Wf.Created(StepId);
        }

        public void Run()
        {
            try
            {
                Wf.Running(StepId, Host);
                var report = MemberParseReport.create(Host, Source);
                report.Save(Target);
                Wf.Ran(StepId, text.format(PSx2, Host, report.RecordCount));
            }
            catch(Exception e)
            {
                Wf.Error(StepId, e);
            }
        }

        public void Dispose()
        {
            Wf.Finished(StepId);
        }
    }
}