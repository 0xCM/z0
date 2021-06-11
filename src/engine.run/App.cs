//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using static Root;
    using static core;
    using static Typed;

    using Z0.Asm;

    class App : AppService<App>
    {

        FS.FolderPath AssetRoot;

        EventQueue Queue;

        Index<IWfEvent> EventBuffer;

        protected override void OnInit()
        {
            AssetRoot = Db.ZSrc("engine.run", "assets");
            Configure();
        }

        public App()
        {
            Queue = EventQueue.allocate();
            EventBuffer = alloc<IWfEvent>(Pow2.T08);
        }

        void EmptyQueue()
        {
            while(Queue.Emit(out var e))
                Wf.Raise(e);
        }

        public void Run()
        {
            var engine = Engine.create(Wf);
            engine.Run(AsmHexCode.Empty);
        }

        void Configure()
        {
            var settings = new EngineSettings();
            settings.Affinity = 0b10101101u;
            Wf.Row(settings.Affinity);
        }

        public void CheckStack()
        {
            var stack = StackMachines.create(Pow2.T08);
            stack.Push(2);
            Queue.Status(stack.state());
            stack.Push(4);
            Queue.Status(stack.state());
            stack.Push(6);
            Queue.Status(stack.state());
        }

        void LoadBlocks()
        {
            var hex = Wf.ApiHexPacks();
            var packs = hex.LoadParsed(AssetRoot);
            // var entries = packs.Entries;
            // var outcount = entries.Length;

            // for(var i=0; i<outcount; i++)
            // {
            //     ref readonly var entry = ref skip(entries,i);
            //     var path = entry.Key;
            //     var blocks = entry.Value.Blocks;
            //     var count = blocks.Length;
            //     var host = path.FileName.Format().Remove(".extracts.parsed.xpack").Replace(".","/");
            //     Wf.Row(string.Format("Loaded {0} {1} blocks from {2}", count, host, path.ToUri()));
            // }
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
            var time = clock.Elapsed();
            Wf.Ran(flow, string.Format("Processed {0:##,#} items in {1} ms", count, time.Ms));

        }

        void RunChecks()
        {
            var checker = BitLogicChecker.create(Wf, Rng.@default());
            checker.Validate();

        }

        void BasicPageTest()
        {
            var provider = PageBanks.service();
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

        void Run128(PageBlock lhs, PageBlock rhs, PageBlock dst)
        {
            var provider = PageBanks.service();
            var size = provider.BlockSize;
            var w = w128;
            var cells = size/size<Cell128>();
            ref var left = ref lhs.Segment<Cell128>(0);
            ref var right = ref rhs.Segment<Cell128>(1);
            ref var target = ref dst.Segment<Cell128>(2);
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

        protected override void Disposing()
        {
            EmptyQueue();
            Queue.Dispose();
        }

        void Test2()
        {
            var bank = PageBanks.service();
            var size = bank.BlockSize;
            var w = w128;
            var cells = size/size<Cell128>();

            var left = bank.Block(n0);
            var right = bank.Block(n1);
            var dst = bank.Block(n2);
            Run128(left, right, dst);

            ref var lCell = ref left.Segment<Cell128>(0);
            ref var rCell = ref right.Segment<Cell128>(0);
            ref var target = ref dst.Segment<Cell128>(0);

            for(var i=0u; i<cells; i++)
            {
                ref readonly var a = ref skip(lCell,i);
                ref readonly var b = ref skip(rCell,i);
                ref readonly var result = ref skip(target,i);
                Wf.Row(string.Format("{0:D6} {1}([{2}],[{3}]) = {4}", i, "f", a.V32u.FormatHex(), b.V32u.FormatHex(), result.V32u.FormatHex()));
            }
        }

        public static void Main(string[] args)
            => app(shell(args)).Run();

        static App app(IWfRuntime wf)
            => App.create(wf);

        static IWfRuntime shell(string[] args)
            => WfRuntime.create(ApiParts.load(core.controller(), args), args).WithSource(Rng.@default());
    }
}