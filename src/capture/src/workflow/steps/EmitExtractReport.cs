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
        readonly IWfShell Wf;

        readonly EmitExtractReportHost Host;

        readonly ApiHostUri Uri;

        readonly X86ApiExtract[] Source;

        readonly FS.FilePath Target;

        MemberExtractReport Artifact;

        public MemberExtractReport Report
            => Artifact;

        [MethodImpl(Inline)]
        public EmitExtractReport(IWfShell wf,  EmitExtractReportHost host, ApiHostUri uri, X86ApiExtract[] data, FS.FilePath dst)
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
                Artifact = MemberExtractReport.Create(Uri, Source);
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