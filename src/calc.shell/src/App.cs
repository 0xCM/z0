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

    class App : WfApp<App>
    {
        public static void Main(params string[] args)
            => run(args, PartId.Cpu, PartId.CalcShell);

        IPolySource Source;

        protected override void OnInit()
        {
            Source = Rng.@default();
        }

        Task<uint> RunMachine(uint cycles)
            => Task.Factory.StartNew(() => new Vmx128x2(1024, Rng.@default()).Run(cycles));

        ulong Run(uint count, uint cycles)
        {
            var counter = 0ul;
            var tasks = root.stream(0u,count).Map(i => RunMachine(cycles));
            Task.WaitAll(tasks);
            foreach(var t in tasks)
                counter += t.Result;
            return counter;
        }


        void RunWf1()
        {
            var jobs = 64u;
            var cycles = 64u;
            var flow = Wf.Running();
            var clock = Time.counter(true);
            var count = Run(jobs, cycles);
            var time = clock.Elapsed;
            Wf.Ran(flow, string.Format("Processed {0:##,#} items in {1} ms", count, time.Ms));

        }

        void RunChecks()
        {
            var checker = BitLogicChecker.create(Wf, Rng.@default());
            checker.Validate();

        }

        void BasicPageTest()
        {
            var provider = PageBlockProvider.service();
            var block = provider.Block(n0);
            var segsize = 32;
            uint count = block.Size/segsize;
            ref var src = ref block.Segment<Cell256>(0);
            for(var i=0u; i<count; i++)
                seek(src,i) = i;

            for(var i=0; i<count; i++)
            {
                ref readonly var j = ref first(recover<uint>(skip(src,i).Bytes));
                Wf.Row(string.Format("{0:D4}:{1}",i, j.FormatHex()));
            }

            Wf.Row(block.Describe());

        }

        void Run128()
        {
            var provider = PageBlockProvider.service();
            var size = provider.BlockSize;
            var w = w128;
            var cells = size/size<Cell128>();
            ref var left = ref provider.Block(n0).Segment<Cell128>(0);
            ref var right = ref provider.Block(n1).Segment<Cell128>(1);
            ref var target = ref provider.Block(n2).Segment<Cell128>(2);
            var f = Calcs.vor<uint>(w);
            for(var i=0u; i<cells; i++)
            {
                ref var a = ref seek(left,i);
                a = cpu.vbroadcast(w,i);
                ref var b = ref seek(right,i);
                b = cpu.vbroadcast(w,i + Pow2.T12);
                seek(target,i) = f.Invoke(a,b);
            }
        }

        void Test2()
        {
            var provider = PageBlockProvider.service();
            var size = provider.BlockSize;
            var w = w128;
            var cells = size/size<Cell128>();
            ref var left = ref provider.Block(n0).Segment<Cell128>(0);
            ref var right = ref provider.Block(n1).Segment<Cell128>(1);
            ref var target = ref provider.Block(n2).Segment<Cell128>(2);
            var f = Calcs.vor<uint>(w);
            for(var i=0u; i<cells; i++)
            {
                ref var a = ref seek(left,i);
                a = cpu.vbroadcast(w,i);
                ref var b = ref seek(right,i);
                b = cpu.vbroadcast(w,i + Pow2.T12);
                seek(target,i) = f.Invoke(a,b);

            }

            for(var i=0u; i<cells; i++)
            {
                ref readonly var a = ref skip(left,i);
                ref readonly var b = ref skip(right,i);
                ref readonly var result = ref skip(target,i);
                Wf.Row(string.Format("{0}([{1}],{2}) = {3}", "f", a.V32u.FormatHex(), b.V32u.FormatHex(), result.V32u.FormatHex()));
            }

        }

        protected override void Run()
        {
            var flow = Wf.Running("Running checks");
            Test2();
            Wf.Ran(flow, "Ran checks");
        }

    }
}