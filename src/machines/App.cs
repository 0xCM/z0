//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Threading.Tasks;

    using X86;

    using static Root;
    using static core;

    using Masks = BitMaskLiterals;

    class App : WfApp<App>
    {
        public static void Main(params string[] args)
            => run(args, PartId.Cpu, PartId.CalcShell);

        IPolySource Source;

        EventQueue Queue;

        void EventRaised(IWfEvent e)
        {

        }

        protected override void OnInit()
        {
            Queue = EventQueue.allocate(GetType(), EventRaised);
            Source = Rng.@default();
        }

        protected override void Disposing()
        {
            EmptyQueue();
            Queue.Dispose();
        }

        void EmptyQueue()
        {
            while(Queue.Emit(out var e))
                Wf.Raise(e);
        }

        public void Run(N2 n)
        {
            var settings = new EngineSettings();
            settings.Affinity = 0b10101101u;
            Wf.Row(settings.Affinity);

            var engine = Engine.create(Wf);
            engine.Run();
        }

        public void Run(N10 n)
        {
            var stack = StackMachines.create(Pow2.T08);
            stack.Push(2);
            Queue.Deposit(EventFactory.data(stack.state()));
            stack.Push(4);
            Queue.Deposit(EventFactory.data(stack.state()));
            stack.Push(6);
            Queue.Deposit(EventFactory.data(stack.state()));
        }

        void Run(N11 n)
        {
            const uint CellCount = 1024;
            const uint JobCount = 128;
            const uint CycleCount = 64;

            Task<uint> RunMachine(uint cycles)
                => Task.Factory.StartNew(() => new Vmx128x2(CellCount, Rng.@default()).Run(cycles));

            var flow = Wf.Running();
            var clock = Time.counter(true);
            var count = 0ul;
            var tasks = core.stream(0u,JobCount).Map(i => RunMachine(CycleCount));
            Task.WaitAll(tasks);
            foreach(var t in tasks)
                count += t.Result;

            var time = clock.Elapsed();
            Wf.Ran(flow, string.Format("Processed {0:##,#} items in {1} ms", count, time.Ms));
        }

        void Run(N22 n)
        {
            X86Emulator.create(Wf).Run();
        }

        void Run(string spec)
        {
            if(uint.TryParse(spec, out var n))
            {
                switch(n)
                {
                    case 2:
                        Run(n2);
                    break;
                    case 10:
                        Run(n10);
                    break;
                    case 11:
                        Run(n11);
                    break;
                    case 22:
                        Run(n22);
                    break;
                }
            }
        }


        protected override void Run()
        {
        }

        protected override void Run(string[] args)
        {
            var count = args.Length;
            for(var i=0; i<count; i++)
                Run(skip(args,i));
        }

    }
}
