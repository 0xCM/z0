//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    struct App
    {
        public static void run(string[] args)
            => app(wf(args)).Run();

        IWfShell Wf;

        IAsmContext Asm;

        App(IWfShell wf, IAsmContext asm)
        {
            Wf = wf;
            Asm = asm;
        }

        static App app(IWfShell wf)
            => new App(wf, AsmWorkflows.context(wf));


        static IWfShell wf(string[] args)
            => WfShell.create(args).WithRandom(Rng.@default());

        void Run()
        {
            try
            {
                using var machine = new Machine(Wf, Asm);
                machine.Run();
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        public static void Main(params string[] args)
            => run(args);
    }

    public static partial class XTend {}
}