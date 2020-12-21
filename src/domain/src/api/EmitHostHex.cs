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

    public struct EmitHostCodeBlockPayload
    {
        public ApiHexRow[] Emitted;
    }

    [WfHost]
    public sealed class EmitHostHex : WfHost<EmitHostHex,EmitHostHexCmd,EmitHostCodeBlockPayload>
    {
        public static ref EmitHostCodeBlockPayload run(IWfShell wf, ApiHostUri uri, in ApiMemberCodeBlocks src, out EmitHostCodeBlockPayload payload)
        {
            var spec = new EmitHostHexCmd();
            spec.ApiHost = uri;
            spec.Source = src;
            var host = create();
            host.Run(wf, spec, out payload);
            return ref payload;
        }

        protected override ref EmitHostCodeBlockPayload Execute(IWfShell wf, in EmitHostHexCmd spec, out EmitHostCodeBlockPayload dst)
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

        readonly EmitHostHexCmd Spec;

        public ApiHexRow[] Emitted;

        [MethodImpl(Inline)]
        public EmitHostHexStep(IWfShell wf, WfHost host, EmitHostHexCmd spec)
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
                var source = Spec.Source.Storage;
                var target = Wf.Db().CapturedHexFile(Spec.ApiHost);
                Wf.Status($"Emitting {source.Length} blocks to {target}");
                var report = ApiParseBlocks.create(Spec.ApiHost, source);
                ApiParseBlocks.save(report, target);
                Emitted = report;
                Wf.EmittedTable<ApiHexRow>(Emitted.Length, target);
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }
    }
}