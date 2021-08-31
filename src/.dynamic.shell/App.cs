//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    class App : WfApp<App>
    {
        public static void Main(params string[] args)
            => run(args, PartId.Dynamic, PartId.DynamicShell, PartId.Cpu, PartId.Math, PartId.GMath, PartId.Part);

        public App()
        {
        }

        protected override void Run()
        {
            var flow = Wf.Running();
            Wf.Ran(flow);
        }
    }
}