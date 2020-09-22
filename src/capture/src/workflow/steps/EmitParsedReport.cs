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

    public ref struct EmitParsedReport
    {
        readonly IWfShell Wf;

        readonly EmitParsedReportHost Host;

        readonly ApiHostUri Uri;

        readonly ApiHexTable Source;

        readonly FS.FilePath Target;

        public Span<MemberParseRow> Emitted;

        [MethodImpl(Inline)]
        public EmitParsedReport(IWfCaptureState state, EmitParsedReportHost host, ApiHostUri uri, ApiHexTable src, FS.FilePath dst)
        {
            Wf = state.Wf;
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
                var report = MemberParseReport.create(Uri, Source);
                MemberParseReport.save(report,Target);
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