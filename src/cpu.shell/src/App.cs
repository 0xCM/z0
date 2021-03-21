//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    class CpuShell : WfApp<CpuShell>
    {
        public static void Main(params string[] args)
            => run(args, PartId.Cpu, PartId.CpuShell);

        IPolySource Source;

        protected override void OnInit()
        {
            Source = Rng.@default();
        }

        protected override void Run()
        {
            var flow = Wf.Running();
            var source = gcpu.vinc<byte>(w128,0);

            Wf.Ran(flow);
        }
    }
}