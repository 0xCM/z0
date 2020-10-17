//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static z;

    [WfHost]
    public sealed class CaptureApiHost : WfHost<CaptureApiHost>
    {
        WfCaptureState State;

        IApiHost Api;
        public static WfHost create(WfCaptureState state, IApiHost api)
        {
            var host = new CaptureApiHost();
            host.State = state;
            host.Api = api;
            return host;
        }

        protected override void Execute(IWfShell wf)
        {
            using var step = new CaptureApiHostStep(State, this, Api);
            step.Run();
        }
    }

    readonly ref struct CaptureApiHostStep
    {
        public WfCaptureState State {get;}

        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IApiHost Api;

        [MethodImpl(Inline)]
        public CaptureApiHostStep(WfCaptureState state, WfHost host, IApiHost api)
        {
            Host = host;
            Wf = state.Wf.WithHost(Host);
            Api = api;
            State = state;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            Wf.Running(Api);

            try
            {
                using var extract = new ExtractHostMembersStep(Wf, new ExtractHostMembers(), Api);
                extract.Run();

                using var emit = new EmitCaptureArtifactsStep(State, new EmitCaptureArtifacts(), Api.Uri, extract.Extracts);
                emit.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }

            Wf.Ran2(Api);
        }
    }
}