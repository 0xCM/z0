//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    class CpuShell : WfService<CpuShell>
    {
        protected override void OnInit()
        {

        }

        public static void Main(params string[] args)
        {
            var parts = WfShell.parts(root.array(PartId.CpuShell, PartId.Cpu));
            using var wf = WfShell.create(parts, args).WithRandom(Rng.@default());
            using var shell = CpuShell.create(wf);
            shell.Run();
        }

        public void Run(params string[] args)
        {
            var flow = Wf.Running();
            Wf.Ran(flow);
        }
    }
}