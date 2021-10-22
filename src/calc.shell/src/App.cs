//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;


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


        void Run(N9 n)
        {
            var checker = BitLogicChecker.create(Wf, Rng.@default());
            checker.Validate();
        }

        void Run(N8 n)
        {
            var buffer = PageBank16x4x4.allocated();
            var block = buffer.Block(n0);
            var segsize = size<Cell256>();
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

        void Run(N13 n)
        {
            ApiKeyChecks.create(Wf).Run();
        }

        void Run(N7 n)
        {
            var buffer = span<char>(Pow2.T12);
            var src = (uint)Masks.Hi32x16;
            var dst = ByteBlock32.Empty.Bytes;
            BitPack.unpack1x32(src, dst);
            var count = Hex.render(UpperCase, dst, buffer);
            var hex = text.format(slice(buffer,0,count));
            Wf.Row(hex);

            buffer.Clear();
            var k=0;
            for(var i=0; i<32; i++)
            {
                ref readonly var a = ref skip(dst,i);
                for(byte j=0; j<7; j++)
                {
                    seek(buffer,k++) = bit.test(a,j).ToChar();
                }
                seek(buffer,k++) = Chars.Space;
            }

            // count = BitRender.render(dst, buffer);
            var bitstring = text.format(slice(buffer,0,k));
            Wf.Row(bitstring);
        }

        void Run(N4 n)
        {
            var checker = BitLogicChecker.create(Wf, Rng.@default());
            checker.Validate();
        }

        void Run(N6 n)
        {
            var provider = PageBank16x4x4.allocated();
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

        // void Run(N14 x)
        // {
        //     var n = n2;
        //     var t = z32;
        //     var m = CaseMethods.BinaryAdd_Method;
        //     var id = m.Identify();
        //     var factory = Dynamic.Factory(OperatorClasses.binary(t));
        //     var fx = factory.Create(m);
        //     Wf.Row(fx(3,4).ToString());
        // }

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

        void Run(N15 n)
        {
            Size<byte> a = 31;
            var b = a.Align(4);
            Wf.Row(a.Measure);
            Wf.Row(a.Untyped);
            Wf.Row(b.Measure);

            Wf.Row(string.Format("Align({0}) = {1}", a, b));
        }

        void Run(N16 n)
        {
            Test6(PartId.Cpu);
        }

        void Test6(PartId part)
        {
            Reader(part, out var reader);
            var strings = reader.ReadStrings(CliStringKind.User);
            var count = strings.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var s = ref skip(strings,i);
                Wf.Row(string.Format("{0:D5}:{1}", i, s));
            }
        }

        bool Reader(PartId part, out CliReader dst)
        {
            if(Wf.ApiCatalog.FindComponent(part, out var component))
            {
                dst = CliReader.read(component);
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }

        void Run(N17 n)
        {
            BitfieldChecks.create(Wf).Run();
        }

        void Run(N18 n)
        {
            var m0 = BitMaskLiterals.b00001111x32;
            var m1 = BitMaskLiterals.Even32;
            var m = (ulong)m0 | ((ulong)m1 << 32);
            var bf = Bitfields.create(m);
            var bytes = bf.Bytes;
            var buffer = CharBlock128.Null;
            var count = BitRender.render4x4(bytes, buffer.Data);
            var chars = slice(buffer.Data,0,count);
            var fmt = text.format(chars);
            Wf.Row(fmt);
        }

        void Run(N19 n)
        {
            VPipeTests.test(Wf);
        }

        void Run(N20 n)
        {
            BitMaskChecker.create(Wf).Run(Source);
        }

        void Run(N21 n)
        {
            BlitMachine.create(Wf).Run();
        }


        void Run(N23 n)
        {
            BitFormatChecks.create(Wf).Run(Rng.wyhash64());
        }

        void Run(N24 n)
        {
            CalcBuilder.create(Wf).Calc(w128);
        }

        void Run(N25 n)
        {
            Fsm.example1();
            Fsm.example2();
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

        void Run(N27 n)
        {
            Parts.BitPack.Resolved.Executor.Run();
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


        void Run(string spec)
        {
            if(uint.TryParse(spec, out var n))
            {
                switch(n)
                {
                    case 3:
                        Run(n3);
                    break;
                    case 4:
                        Run(n4);
                    break;
                    case 5:
                        Run(n5);
                    break;
                    case 6:
                        Run(n6);
                    break;
                    case 7:
                        Run(n7);
                    break;
                    case 8:
                        Run(n8);
                    break;
                    case 9:
                        Run(n9);
                    break;
                    case 13:
                        Run(n13);
                    break;
                    // case 14:
                    //     Run(n14);
                    // break;
                    case 15:
                        Run(n15);
                    break;
                    case 16:
                        Run(n16);
                    break;
                    case 17:
                        Run(n17);
                    break;
                    case 18:
                        Run(n18);
                    break;
                    case 19:
                        Run(n19);
                    break;
                    case 20:
                        Run(n20);
                    break;
                    case 21:
                        Run(n21);
                    break;
                    case 23:
                        Run(n23);
                    break;
                    case 24:
                        Run(n24);
                    break;
                    case 25:
                        Run(n25);
                    break;
                    case 26:
                        Run(n26);
                    break;
                    case 27:
                        Run(n27);
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
                    default:
                     Error(string.Format("Command '{0}' unrecognized", spec));
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