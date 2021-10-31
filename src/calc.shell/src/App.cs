//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Root;
    using static core;

    using Masks = BitMaskLiterals;

    using Alg;

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

        void Run(N20 n)
        {
            BitMaskChecker.create(Wf).Run(Source);
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

        void Run(N27 n)
        {
            Parts.BitPack.Resolved.Executor.Run();
        }

        void Run(N28 n)
        {
            for(byte i = 120; i<148; i++)
            for(byte j = 120; j<148; j++)
            {
                var cin = math.odd(i + j);
                var y = math.adc(i,j, cin,out var cout);
                Write(string.Format("adc({0},{1}) carry {2} = {3} carry {4}", i,j,cin, y, (uint)cout));
            }
        }

        void RunValidators()
        {
            Md5Validator.create(Wf).Run();
        }

        void Run(string spec)
        {
            if(uint.TryParse(spec, out var n))
            {
                switch(n)
                {
                    case 4:
                        Run(n4);
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
                    case 20:
                        Run(n20);
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
                    case 27:
                        Run(n27);
                    break;
                    case 28:
                        Run(n28);
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
            if(count != 0)
            {
                for(var i=0; i<count; i++)
                    Run(skip(args,i));
            }
            else
            {
                RunValidators();
            }
        }
    }
}