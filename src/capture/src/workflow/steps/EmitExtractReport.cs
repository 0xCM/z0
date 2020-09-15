//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Z0.Asm;

    using static EmitExtractReportStep;

    public ref struct EmitExtractReport
    {
        public const string ActorName = nameof(EmitExtractReport);

        readonly CorrelationToken Ct;

        readonly IWfShell Wf;

        readonly IWfCaptureState State;

        readonly ApiHostUri Host;

        readonly X86ApiExtract[] Source;

        readonly FilePath Target;

        MemberExtractReport Artifact;

        public MemberExtractReport Report
            => Artifact;

        [MethodImpl(Inline)]
        public EmitExtractReport(IWfCaptureState state, ApiHostUri host, X86ApiExtract[] data, FilePath dst, CorrelationToken ct)
        {
            Ct = ct;
            State = state;
            Wf = State.Wf;
            Host = host;
            Source = data;
            Target = dst;
            Artifact = default;
            Wf.Created(StepId);
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }

        public void Run()
        {
            try
            {
                Artifact = MemberExtractReport.Create(Host, Source);
                Wf.Raise(new ExtractReportCreated(StepId, Host, Artifact.RecordCount, Ct));
                var result = Report.Save(Target);
                if(result)
                    Wf.Raise(new ExtractReportSaved(StepId, Artifact.RecordCount, FS.path(Target.Name), Ct));
                else
                    Wf.Error(StepId, "Unable to save extract report");
            }
            catch(Exception e)
            {
                Wf.Error(StepId, e);
            }
        }
    }
}