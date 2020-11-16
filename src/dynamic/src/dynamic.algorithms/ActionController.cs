//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct ActionController
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        int seq;

        public ActionController(IWfShell wf)
        {
            Host = WfShell.host(typeof(ActionController));
            Wf = wf.WithHost(Host);
            seq = 0;
        }

        [MethodImpl(Inline)]
        public void Invoke(in ActionDelegate action)
            => action.Invoke();

        public void Try(in ActionDelegate fx)
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

        public EvalResult Measure(ActionDelegate fx, OpUri f)
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