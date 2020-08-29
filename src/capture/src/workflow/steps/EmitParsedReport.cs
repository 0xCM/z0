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
        readonly WfCaptureState Wf ;

        readonly CorrelationToken Ct;

        readonly ApiHostUri Host;

        readonly X86MemberRefinement[] Source;

        readonly FilePath Target;

        [MethodImpl(Inline)]
        internal EmitParsedReport(WfCaptureState wf, ApiHostUri host, X86MemberRefinement[] src, FilePath dst, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Host = host;
            Source = src;
            Target = dst;
            Wf.Created(StepName, Ct);
        }

        public void Run()
        {
            try
            {
                Wf.Running(StepName, Host, Ct);
                var report = MemberParseReport.Create(Host, Source);
                report.Save(Target);
                Wf.Ran(StepName, text.format(PSx2, Host, report.RecordCount), Ct);
            }
            catch(Exception e)
            {
                Wf.Error(StepName, e, Ct);
            }
        }

        public void Dispose()
        {
            Wf.Finished(StepName, Ct);
        }
    }
}