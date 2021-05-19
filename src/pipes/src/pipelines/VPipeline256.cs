//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static SFx;

    public struct VPipeline256<B,M,R,S,T>
        where R : IBlockSink256<R,T>
        where M : IVMap256<M,S,T>
        where B : IBlockSource256<S>
        where S : unmanaged
        where T : unmanaged
    {
        B Blocks;

        M Mapper;

        R Receiver;

        VPipe256<M,S,T> Pipe;

        static W256 W => default;

        [MethodImpl(Inline)]
        public VPipeline256(B blocks, M mapper, R receiver)
        {
            Blocks = blocks;
            Mapper = mapper;
            Receiver = receiver;
            Pipe = Pipes.vpipe<M,S,T>(W, mapper);
        }

        [MethodImpl(Inline)]
        void Run(uint index)
        {
            var dst = SpanBlocks.single<T>(W);
            Pipe.Flow(Blocks.Emit(index),dst);
            Receiver.Deposit(dst);
        }

        [MethodImpl(Inline)]
        public Paired<uint,ByteSize> Run()
        {
            var count = Blocks.BlockCount;
            for(var j=0u; j<count; j++)
                Run(j);
            return (count, count*16);
        }
    }
}