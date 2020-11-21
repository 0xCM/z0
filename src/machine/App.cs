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
    sealed class MachineRunner : WfHost<MachineRunner>
    {
        WfCaptureState State;

        public static WfHost create(in WfCaptureState state)
        {
            var host = new MachineRunner();
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
        IWfShell Wf;

        bool RunCapture {get;}

        bool RunMachine {get;}

        App(IWfShell wf)
        {
            Wf = wf;
            RunCapture = true;
            RunMachine = true;
        }

        void Run()
        {

            var ctx = Apps.context(Wf);
            var asm = new AsmContext(ctx, Wf);
            var state = new WfCaptureState(Wf, asm);
            var capture = CaptureWorkflow.create(state);

            if(RunCapture)
                capture.Run();

            if(RunMachine)
                MachineRunner.create(state).Run(Wf);
        }

        public static void Main(params string[] args)
        {
            try
            {
                using var wf = WfShell.create(args).WithRandom(Rng.@default());
                var app = new App(wf);
                app.Run();
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }
    }

    public static partial class XTend {}
}