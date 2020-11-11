//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using Z0.Asm;

    using static z;

    [WfHost]
    sealed class Runner : WfHost<Runner>
    {
        WfCaptureState State;

        public static WfHost create(in WfCaptureState state)
        {
            var host = new Runner();
            host.State = state;
            return host;
        }

        protected override void Execute(IWfShell wf)
        {
            using var machine = new Machine(State, this);
            machine.Run();
        }
    }

    struct App
    {
        static void RunCapture(WfCaptureState cstate)
        {
            using var control = CaptureWorkflow.create(cstate);
            control.Run();
        }
        public static void Main(params string[] args)
        {
            try
            {
                using var wf = WfShellInit.create(args).WithRandom(Polyrand.@default());
                var app = Apps.context(wf);
                var asm = new AsmContext(app, wf);
                var state = new WfCaptureState(wf, asm);
                RunCapture(state);
                Runner.create(state).Run(wf);
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }
    }

    public static partial class XTend {}
}