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
    public sealed class ControlCapture : WfHost<ControlCapture>
    {
        public static ControlCaptureStep create(WfCaptureState state)
            => new ControlCaptureStep(state, new ControlCapture());
    }

    public readonly ref struct ControlCaptureStep
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        public WfCaptureState State {get;}


        public ControlCaptureStep(WfCaptureState state, WfHost host)
        {
            Host = host;
            State = state;
            Wf = state.Wf.WithHost(host);
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            Wf.Running(delimit(Wf.Init.PartIdentities));

            try
            {
                using var host = new ManageCaptureStep(State, Wf.Ct);
                host.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }

            Wf.Ran();
        }
    }
}