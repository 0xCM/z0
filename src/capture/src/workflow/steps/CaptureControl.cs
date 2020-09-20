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
        readonly IWfShell Wf;

        public WfCaptureState State {get;}

        readonly WfHost Host;

        public CaptureControl(WfCaptureState state, WfHost host)
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
                using var host = new ManageCapture(State, Wf.Ct);
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