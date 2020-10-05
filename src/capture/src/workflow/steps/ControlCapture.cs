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
        readonly IWfShell Wf;

        public WfCaptureState State {get;}

        readonly WfHost Host;

        public ControlCaptureStep(WfCaptureState state, WfHost host)
        {
            State = state;
            Wf = state.Wf;
            Host = host;
            Wf.Created(Host);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        public void Run()
        {
            Wf.Running(Host, delimit(Wf.Init.PartIdentities));

            try
            {
                using var host = new ManageCaptureStep(State, Wf.Ct);
                host.Run();
            }
            catch(Exception e)
            {
                State.Error(Host, e);
            }

            Wf.Ran(Host);
        }
    }
}