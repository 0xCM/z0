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

    public ref struct EmitApiParseReport
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly ApiHostUri Uri;

        readonly ApiMemberCodeTable Source;

        readonly FS.FilePath Target;

        public Span<ApiParseBlock> Emitted;

        [MethodImpl(Inline)]
        public EmitApiParseReport(IWfShell wf, WfHost host, ApiHostUri uri, ApiMemberCodeTable src, FS.FilePath dst)
        {
            Wf = wf;
            Host = host;
            Emitted = default;
            Uri = uri;
            Source = src;
            Target = dst;
            Wf.Created(Host);
        }

        public void Run()
        {
            try
            {
                Wf.Running(Host, Uri);
                var report = ApiParseReport.create(Uri, Source);
                ApiParseReport.save(report,Target);
                Emitted = report;
                Wf.Ran(Host, text.format(PSx2, Uri, Emitted.Length));
            }
            catch(Exception e)
            {
                Wf.Error(Host, e);
            }
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }
    }
}