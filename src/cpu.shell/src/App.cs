//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    class CpuShell : WfApp<CpuShell>
    {
        public static void Main(params string[] args)
            => run(args, PartId.Cpu, PartId.CpuShell);

        protected override void OnInit()
        {
            Wf.WithRandom(Rng.@default());
        }

        protected override void Run()
        {
            var flow = Wf.Running();
            Wf.Ran(flow);
        }
    }
}