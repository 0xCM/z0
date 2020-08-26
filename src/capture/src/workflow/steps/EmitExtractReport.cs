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
    public ref struct EmitExtractReport
    {
        public const string ActorName = nameof(EmitExtractReport);

        readonly CorrelationToken Ct;

        readonly WfCaptureState Wf;

        readonly ApiHostUri Host;

        readonly ExtractedCode[] Source;

        readonly FilePath Target;

        ExtractReport Artifact;

        public ExtractReport Report
            => Artifact;

        [MethodImpl(Inline)]
        public EmitExtractReport(WfCaptureState wf, ApiHostUri host, ExtractedCode[] data, FilePath dst, CorrelationToken ct)
        {
            Ct = ct;
            Wf = wf;
            Host = host;
            Source = data;
            Target = dst;
            Artifact = default;
            Wf.Created(ActorName, Ct);
        }

        public void Run()
        {
            try
            {
                Artifact = ExtractReport.Create(Host, Source);
                Wf.Raise(new ExtractReportCreated(ActorName, Artifact.RecordCount, Ct));
                var result = Report.Save(Target);
                if(result)
                    Wf.Raise(new ExtractReportSaved(ActorName, Artifact, Ct));
                else
                    Wf.Error(ActorName, "Unable to save extract report", Ct);
            }
            catch(Exception e)
            {
                Wf.Error(ActorName, e, Ct);
            }
        }

        public void Dispose()
        {
            Wf.Finished(ActorName, Ct);
        }
    }
}