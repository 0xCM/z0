//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    struct Machine
    {
        public static void run(string[] args)
            => app(shell(args)).Run();

        static Machine app(IWfShell wf)
            => new Machine(wf);

        static IWfShell shell(string[] args)
            => WfShell.create(args).WithRandom(Rng.@default());

        IWfShell Wf;

        Machine(IWfShell wf)
        {
            Wf = wf;
        }

        void Run()
        {
            try
            {
                using var machine = MachineRunner.create(Wf);
                machine.Run(MachineOptions.@default());
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