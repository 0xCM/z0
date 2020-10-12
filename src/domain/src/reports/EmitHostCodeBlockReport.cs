//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RP;

    public struct EmitHostCodeBlockSpec
    {
        public ApiHostUri ApiHost;

        public ApiMemberCodeBlocks Source;

        public FS.FilePath Target;
    }

    public struct EmitHostCodeBlockPayload
    {
        public ApiParseBlock[] Emitted;
    }

    [WfHost]
    public sealed class EmitHostCodeBlockReport : WfHost<EmitHostCodeBlockReport,EmitHostCodeBlockSpec,EmitHostCodeBlockPayload>
    {
        public static ref EmitHostCodeBlockPayload run(IWfShell wf, ApiHostUri uri, in ApiMemberCodeBlocks src, FS.FilePath dst, out EmitHostCodeBlockPayload payload)
        {
            var spec = new EmitHostCodeBlockSpec();
            spec.ApiHost = uri;
            spec.Source = src;
            spec.Target = dst;
            var host = create();
            host.Run(wf, spec, out payload);
            return ref payload;

        }

        protected override ref EmitHostCodeBlockPayload Execute(IWfShell wf, in EmitHostCodeBlockSpec spec, out EmitHostCodeBlockPayload dst)
        {
            dst = default;
            using var step = new EmitHostCodeBlockReportStep(wf, this, spec);
            step.Run();
            dst.Emitted = step.Emitted;
            return ref dst;
        }
    }

    ref struct EmitHostCodeBlockReportStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly EmitHostCodeBlockSpec Spec;

        public ApiParseBlock[] Emitted;

        [MethodImpl(Inline)]
        public EmitHostCodeBlockReportStep(IWfShell wf, WfHost host, EmitHostCodeBlockSpec spec)
        {
            Wf = wf;
            Host = host;
            Emitted = default;
            Spec = spec;
            Wf.Created(Host);
        }

        public void Run()
        {
            try
            {
                Wf.Running(Host, Spec.ApiHost);
                var report = ApiParseReport.create(Spec.ApiHost, Spec.Source);
                ApiParseReport.save(report, Spec.Target);
                Emitted = report;
                Wf.EmittedTable<ApiParseBlock>(Host, Emitted.Length, Spec.Target);
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