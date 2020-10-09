//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using Z0.Asm;

    [WfHost]
    public sealed class EmitExtractReport : WfHost<EmitExtractReport>
    {
        protected override void Execute(IWfShell shell)
            => throw missing();
    }

    public ref struct EmitExtractReportStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly ApiHostUri Uri;

        readonly ApiMemberExtract[] Source;

        readonly FS.FilePath Target;

        ApiExtractReport Artifact;

        public ApiExtractReport Report
            => Artifact;

        [MethodImpl(Inline)]
        public EmitExtractReportStep(IWfShell wf,  WfHost host, ApiHostUri uri, ApiMemberExtract[] data, FS.FilePath dst)
        {
            Wf = wf;
            Host = host;
            Uri = uri;
            Source = data;
            Target = dst;
            Artifact = default;
            Wf.Created(Host);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        public void Run()
        {
            try
            {
                Artifact = ApiExtractReport.Create(Uri, Source);
                Wf.Raise(new ExtractReportCreated(Host, Uri, Artifact.RecordCount, Wf.Ct));
                var result = Report.Save(FilePath.Define(Target.Name));
                if(result)
                    Wf.Raise(new ExtractReportSaved(Host, Artifact.RecordCount, Target, Wf.Ct));
                else
                    Wf.Error(Host, "Unable to save extract report");
            }
            catch(Exception e)
            {
                Wf.Error(Host, e);
            }
        }
    }
}