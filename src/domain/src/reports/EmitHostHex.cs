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
    }

    public struct EmitHostCodeBlockPayload
    {
        public ApiParseBlock[] Emitted;
    }

    [WfHost]
    public sealed class EmitHostHex : WfHost<EmitHostHex,EmitHostCodeBlockSpec,EmitHostCodeBlockPayload>
    {
        public static ref EmitHostCodeBlockPayload run(IWfShell wf, ApiHostUri uri, in ApiMemberCodeBlocks src, out EmitHostCodeBlockPayload payload)
        {
            var spec = new EmitHostCodeBlockSpec();
            spec.ApiHost = uri;
            spec.Source = src;
            var host = create();
            host.Run(wf, spec, out payload);
            return ref payload;
        }

        protected override ref EmitHostCodeBlockPayload Execute(IWfShell wf, in EmitHostCodeBlockSpec spec, out EmitHostCodeBlockPayload dst)
        {
            dst = default;
            using var step = new EmitHostHexStep(wf, this, spec);
            step.Run();
            dst.Emitted = step.Emitted;
            return ref dst;
        }
    }

    ref struct EmitHostHexStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly EmitHostCodeBlockSpec Spec;

        public ApiParseBlock[] Emitted;

        [MethodImpl(Inline)]
        public EmitHostHexStep(IWfShell wf, WfHost host, EmitHostCodeBlockSpec spec)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Emitted = default;
            Spec = spec;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            try
            {
                Wf.Running(Spec.ApiHost);
                var report = ApiParseReport.create(Spec.ApiHost, Spec.Source);
                var target = Wf.Db().CapturedHexFile(Spec.ApiHost);
                ApiParseReport.save(report, target);
                Emitted = report;
                Wf.EmittedTable<ApiParseBlock>(Emitted.Length, target);
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }
    }
}