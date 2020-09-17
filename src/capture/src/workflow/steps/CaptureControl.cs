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

    public readonly ref struct CaptureControl
    {
        readonly CorrelationToken Ct;

        readonly IWfShell Wf;

        public WfCaptureState State {get;}

        readonly CaptureControlHost Host;

        public CaptureControl(WfCaptureState state, CaptureControlHost host)
        {
            State = state;
            Wf = state.Wf;
            Host = host;
            Ct = Wf.Ct;
            Wf.Created(Host);
        }

        public void Run()
        {
            Wf.Running(Host, delimit(Wf.Init.PartIdentities));

            try
            {
                using var host = new ManageCapture(State, Ct);
                host.Run();
            }
            catch(Exception e)
            {
                State.Error(Host, e);
            }

            Wf.Ran(Host);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }
    }
}