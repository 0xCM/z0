//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct DynamicActionRunner
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        int seq;

        public DynamicActionRunner(IWfShell wf)
        {
            Host = WfShell.host(typeof(DynamicActionRunner));
            Wf = wf.WithHost(Host);
            seq = 0;
        }

        [MethodImpl(Inline)]
        public void Invoke(in DynamicAction action)
            => action.Invoke();

        public void Try(in DynamicAction fx)
        {
            try
            {
                Invoke(fx);
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        public EvalResult Measure(DynamicAction fx, OpUri f)
        {
            var clock = Time.counter(true);
            try
            {
                Invoke(fx);
                return Eval.result(seq, fx.Id, clock, true);
            }
            catch(Exception e)
            {
                return Eval.result(seq, fx.Id, clock, e);
            }
        }
    }
}