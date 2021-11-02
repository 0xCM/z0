//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;

    [ApiHost]
    public readonly struct VPipeTests
    {
        [Op]
        public static void test(IWfRuntime wf)
        {
            var flow = wf.Running();
            (var count, var size)  = run(w128,blocks(Rng.@default(), Pow2.T08), mapper(), sink(signal(wf)));
            wf.Ran(flow, string.Format("Processed {0} blocks covering {1} bytes", count, size));
        }

        [Op]
        public static Paired<uint,ByteSize> run(W128 w, BlockSource01 source, VMap01 mapper, BlockSink01 sink)
            => BlockPipes.vpipeline(w128, source, mapper, sink, z8, z8).Run();

        [MethodImpl(Inline), Op]
        static EventSignal signal(IWfRuntime wf)
            => EventSignals.signal(wf.EventSink, typeof(VPipeTests));

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

        readonly IRangeSource PolySource;

        [MethodImpl(Inline)]
        public BlockSource01(IRangeSource source, uint count)
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