//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using static Part;
    using static memory;

    class CpuShell : WfApp<CpuShell>
    {
        public static void Main(params string[] args)
            => run(args, PartId.Cpu, PartId.CpuShell);

        IPolySource Source;

        protected override void OnInit()
        {
            Source = Rng.@default();
        }

        // Task<uint> RunMachine(uint cycles)
        //     => Task.Factory.StartNew(() => new Vmx128x2(1024, Source).Run(cycles));

        // ulong Run(uint jobs, uint cycles)
        // {
        //     var counter = 0ul;
        //     var tasks = root.stream(0u,jobs).Map(i => RunMachine(cycles));
        //     Task.WaitAll(tasks);
        //     foreach(var t in tasks)
        //         counter += t.Result;
        //     return counter;
        // }

        // void RunWf1()
        // {
        //     var jobs = 64u;
        //     var cycles = 64u;
        //     var flow = Wf.Running();
        //     var clock = Time.counter(true);
        //     var count = Run(jobs, cycles);
        //     var time = clock.Elapsed;
        //     Wf.Ran(flow, string.Format("Processed {0:##,#} items in {1} ms", count, time.Ms));

        // }

        void RunWf2()
        {
            //VPipeRunner.test(Wf);
        }

        protected override void Run()
        {
            //RunWf1();
        }
    }
}