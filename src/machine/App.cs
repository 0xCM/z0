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

        WfCaptureState State;

        App(IWfShell wf, WfCaptureState state)
        {
            Wf = wf;
            State = state;
        }

        void Run()
            => MachineRunner.create(State).Run(Wf);

        static App app(IWfShell wf)
            => new App(wf, WfCaptureState.create(wf));

        public static IWfShell wf(string[] args)
            => WfShell.create(args).WithRandom(Rng.@default());

        public static void Main(params string[] args)
            => @try(() => app(wf(args)).Run());
    }

    public static partial class XTend {}
}