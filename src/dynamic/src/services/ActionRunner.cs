//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public sealed class ActionRunner : AppService<ActionRunner>, IActionRunner
    {
        int seq;

        [MethodImpl(Inline)]
        public void Invoke(in DynamicAction action)
            => action.Invoke();

        public void Run(in DynamicAction fx)
        {
            var flow = Wf.Running(fx.Id);
            try
            {
                fx.Invoke();
            }
            catch(Exception e)
            {
                Error(e);
            }
        }

        public EvalResult Measure(in DynamicAction fx)
        {
            var clock = Time.counter(true);
            try
            {
                fx.Invoke();
                return Eval.result(seq, fx.Id, clock, true);
            }
            catch(Exception e)
            {
                return Eval.result(seq, fx.Id, clock, e);
            }
        }
    }
}