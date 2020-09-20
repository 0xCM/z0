//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct WfStatusRelay
    {
        readonly IWfShell Wf;

        readonly WfStepId Step;

        [MethodImpl(Inline)]
        public WfStatusRelay(IWfShell wf, WfStepId step)
        {
            Wf = wf;
            Step = step;
        }

        [MethodImpl(Inline)]
        public void OnInfo(string data)
            => Wf.Status(Step, data);

        [MethodImpl(Inline)]
        public void OnError(string data)
            => Wf.Error(Step, data);
    }
}