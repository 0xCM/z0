//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    class App : WfApp<App>
    {
        public static void Main(params string[] args)
            => run(args, PartId.CliShell, PartId.Cli, PartId.Part, PartId.Cpu, PartId.AsmCore);

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