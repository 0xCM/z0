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

        void Run(N3 n)
        {
            var bank = PageBank16x4x4.allocated();
            var size = PageBank16x4x4.BlockSize;
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

        void Run128(PageBlock lhs, PageBlock rhs, PageBlock dst)
        {
            var size = lhs.Size;
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


        void Run(N5 n)
        {
            var bank = PageBank16x4x4.allocated();
            var size = PageBank16x4x4.BlockSize;
            var w = w128;
            //var cells = size/size<Cell128>();

            var left = bank.Block(n0);
            var right = bank.Block(n1);
            var dst = bank.Block(n2);
            Run128(left, right, dst);


            ref var lCell = ref left.Segment<Cell128>(0);
            ref var rCell = ref right.Segment<Cell128>(0);
            ref var target = ref dst.Segment<Cell128>(0);

            var cells = left.Size/size<Cell128>();
            for(var i=0u; i<cells; i++)
            {
                ref readonly var a = ref skip(lCell,i);
                ref readonly var b = ref skip(rCell,i);
                ref readonly var result = ref skip(target,i);
                Wf.Row(string.Format("{0:D6} {1}([{2}],[{3}]) = {4}", i, "f", a.V32u.FormatHex(), b.V32u.FormatHex(), result.V32u.FormatHex()));
            }
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
            TestMachine.create(Wf).Run();
        }

        void Run(N29 n)
        {

            var inputs = BinaryBitLogicOps.inputs(w1);
            var eval = BinaryBitLogicOps.canonical(w1,inputs);
            var count = inputs.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var input = ref skip(inputs,i);
                ref readonly var result = ref skip(eval,i);
                Write(string.Format("{0:D2} | {1}", i, result.Format(BinaryBitLogicOps.FormatOption.Bitstrings)));
            }

            // var dst = ByteBlock64.Empty;
            // var buffer = recover<BitOpCalc>(dst.Bytes);
            // var count = BitStates.compute(w1,buffer);
            // var formatter = BitOpFormatter.service();
            // for(var i=0; i<count; i++)
            // {
            //     ref readonly var result = ref skip(buffer,i);
            //     Write(string.Format("{0:D2} | {1}", i, result.Format(BitOpFormatter.FormatOption.Bitstrings)));
            // }

        }

        public unsafe void Run(N30 n)
        {
            var count = Pow2.T12;
            using var buffer0 = memory.native<uint>(count);
            using var buffer1 = memory.native<uint>(count);
            using var buffer2 = memory.native<uint>(count);
            var rng = Rng.pcg64(BitMaskLiterals.b01010101x64);
            rng.Fill(buffer0.Edit);
            rng.Fill(buffer1.Edit);
            var r0 = seq.reader(buffer0);
            var r1 = seq.reader(buffer1);
            var reader = seq.reader(r0,r1);
            var editor = seq.editor(buffer2);

            while(reader.Next(out var c0, out var c1))
            {
                editor.Next(out var _) = math.xor(c0,c1);
            }

            var result = seq.reader(buffer2);
            var counter = 0u;
            while(result.Next(out var r))
            {
                Write(string.Format("{0:D5} {1:x}",counter++, r.FormatHex()));
            }

        }

        void Run(N19 n)
        {
            VPipeTests.test(Wf);
        }


        void Run(N21 n)
        {
            BlitMachine.create(Wf).Run();
        }


        void Run(N26 n)
        {
            void receive(uint i, uint j)
            {
                Write(string.Format("{0} -> {1}", i, j));
            }
            var seq = SeqSpecs.finite((0u,57u), i => i + 1);
            Write(string.Format("{0}..{1}", seq.Min, seq.Max));
            var count = seq.Compute(receive);
            count += seq.Compute(receive);
            Write(string.Format("Term Count:{0}", count));
        }

        void Spin()
        {
            var counter = 0u;
            var ticks = 0L;

            void Receiver(long t)
            {
                counter++;
                ticks += t;
                Write(string.Format("{0:D4}:{1:D12}", counter, ticks));
            }

            var spinner = new Spinner(TimeSpan.FromSeconds(1), Receiver);
            spinner.Spin();
        }

        void Run(N28 n)
        {
            Spin();
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
                    case 3:
                        Run(n3);
                    break;
                    case 5:
                        Run(n5);
                    break;
                    case 10:
                        Run(n10);
                    break;
                    case 11:
                        Run(n11);
                    break;
                    case 19:
                        Run(n19);
                    break;
                    case 21:
                        Run(n21);
                    break;
                    case 22:
                        Run(n22);
                    break;
                    case 26:
                        Run(n26);
                    break;
                    case 28:
                        Run(n28);
                    break;
                    case 29:
                        Run(n29);
                    break;
                    case 30:
                        Run(n30);
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
