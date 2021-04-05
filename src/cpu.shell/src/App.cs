//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Linq;


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

        Task<uint> RunMachine(uint cycles)
            => Task.Factory.StartNew(() => VectorMachine.create(Wf).Run(cycles));


        ulong Run(uint count, uint cycles)
        {
            var counter = 0ul;
            var tasks = root.seq(0,count).Map(i => RunMachine(cycles));
            Task.WaitAll(tasks);
            foreach(var t in tasks)
                counter += t.Result;
            return counter;
        }
        protected override void Run()
        {
            var jobs = 128u;
            var cycles = Pow2.T14;
            var flow = Wf.Running();
            var clock = Time.counter(true);
            var count = Run(jobs, cycles);
            var time = clock.Elapsed;
            Wf.Ran(flow, string.Format("Processed {0:##,#} items in {1} ms", count, time.Ms));
        }
    }
}