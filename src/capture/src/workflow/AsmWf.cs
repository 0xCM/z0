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

    public readonly struct AsmWf
    {
        public IWfShell Wf {get;}

        public IAsmContext Asm {get;}

        public IWfCaptureBroker Broker {get;}

        public IWfCaptureState State {get;}

        [MethodImpl(Inline), Op]
        public AsmWf(IWfShell wf, IAsmContext context)
        {
            Wf = wf;
            Asm = context;
            Broker = new WfCaptureBroker(wf);
            State = new WfCaptureState(wf, context);
        }
    }
}