//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Z0.Asm;

    sealed class TestDriver : WfHost<TestDriver>
    {
        public TestDriver()
        {

        }

        public static void Main(params string[] args)
        {
            try
            {
                using var wf = WfShell.create(args).WithRandom(Rng.@default());
                using var control = wf.CaptureRunner(new AsmContext(Apps.context(wf), wf));
                control.Run();
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

        protected override void Execute(IWfShell wf)
        {
            using var runner = new TestRunner(wf);
            runner.Run();
        }
    }

    public static partial class XTend { }
}