//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct BlockPipe128<S,T> : IBlockPipe128<S,T>
        where S : unmanaged
        where T : unmanaged
    {
        readonly IBlockSource128<S> Source;

        readonly IBlockSink128<T> Target;

        readonly IPipeline Pipes;

        [MethodImpl(Inline)]
        public BlockPipe128(IPipeline pipes, IBlockSource128<S> src, IBlockSink128<T> dst)
        {
            Pipes = pipes;
            Source = src;
            Target = dst;
        }

        public uint BlockCount
        {
            [MethodImpl(Inline)]
            get => Source.BlockCount;
        }

        [MethodImpl(Inline)]
        public void Deposit(in SpanBlock128<T> src)
            => Target.Deposit(src);

        [MethodImpl(Inline)]
        public SpanBlock128<S> Emit(uint index)
            => Source.Emit(index);
    }

    public readonly struct BlockPipe128<A,S,B,T> : IBlockPipe128<S,T>
        where S : unmanaged
        where A : IBlockSource128<S>
        where T : unmanaged
        where B : IBlockSink128<T>
    {
        readonly A Source;

        readonly B Sink;

        readonly IPipeline Pipes;

        [MethodImpl(Inline)]
        public BlockPipe128(IPipeline pipes, A src, B dst)
        {
            Pipes = pipes;
            Source = src;
            Sink = dst;
        }

        public uint BlockCount
        {
            [MethodImpl(Inline)]
            get => Source.BlockCount;
        }

        [MethodImpl(Inline)]
        public void Deposit(in SpanBlock128<T> src)
            => Sink.Deposit(src);

        [MethodImpl(Inline)]
        public SpanBlock128<S> Emit(uint index)
            => Source.Emit(index);
    }
}