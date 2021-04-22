//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static SFx;

    [ApiHost]
    public readonly struct VPipeTests
    {
        [Op]
        public static void test(IWfRuntime wf)
        {
            var flow = wf.Running();
            var runner = Pipes.vrunner(w128, blocks(Rng.@default(), Pow2.T08), mapper(), sink(signal(wf)), z8,z8);
            (var count, var size) = runner.Run();
            wf.Ran(flow, string.Format("Processed {0} blocks covering {1} bytes", count, size));
        }

        [MethodImpl(Inline), Op]
        static EventSignal signal(IWfRuntime wf)
            => EventSignal.create(wf.EventSink, typeof(VPipeTests));

        [MethodImpl(Inline), Op]
        static VMap01 mapper()
            => new VMap01();

        [MethodImpl(Inline), Op]
        static BlockSink01 sink(EventSignal signal)
            => new BlockSink01(signal);

        [MethodImpl(Inline), Op]
        static BlockSource01 blocks(IPolySource poly, uint blocks)
            => new BlockSource01(poly, blocks);
    }


    public readonly struct VMap01 : IVMap128<VMap01,byte,byte>
    {
        [MethodImpl(Inline)]
        public Vector128<byte> Invoke(Vector128<byte> a)
        {
            var mask = BitMasks.even<byte>(n2,n1);
            var bcast = cpu.vbroadcast(w128, mask);
            return cpu.vand(a, bcast);
        }

        [MethodImpl(Inline)]
        public VPipe128<VMap01,byte,byte> ToPipe()
            => Pipes.vpipe(w128,this,z8,z8);

        [MethodImpl(Inline)]
        public static implicit operator VPipe128<VMap01,byte,byte>(VMap01 src)
            => src.ToPipe();
    }

    public struct BlockSink01 : IBlockSink128<BlockSink01,byte>
    {
        readonly EventSignal Wf;

        uint Counter;

        public ByteSize ReceivedBytes
        {
            [MethodImpl(Inline)]
            get => Counter*16;
        }

        public uint ReceivedCount
        {
            [MethodImpl(Inline)]
            get => Counter;
        }

        [MethodImpl(Inline)]
        public BlockSink01(EventSignal wf)
        {
            Wf = wf;
            Counter = 0;
        }

        [MethodImpl(Inline)]
        public void Deposit(in SpanBlock128<byte> src)
        {
            Counter++;
        }
    }

    public readonly struct BlockSource01 : IBlockSource128<BlockSource01, byte>
    {
        public uint BlockCount {get;}

        readonly IPolySource PolySource;

        [MethodImpl(Inline)]
        public BlockSource01(IPolySource source, uint count)
        {
            PolySource = source;
            BlockCount = count;
        }

        public SpanBlock128<byte> Emit(uint index)
        {
            var buffer = SpanBlocks.single<byte>(w128);
            PolySource.Fill(buffer);
            return buffer;
        }
    }
}