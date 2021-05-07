//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using api = Pipes;

    public readonly struct BlockPipe256<S,T> : IBlockPipe256<S,T>
        where S : unmanaged
        where T : unmanaged
    {
        readonly IBlockSource256<S> Source;

        readonly IBlockSink256<T> Target;

        static W256 W => default;

        [MethodImpl(Inline)]
        public BlockPipe256(IPipeline pipes, IBlockSource256<S> src, IBlockSink256<T> dst)
        {
            Source = src;
            Target = dst;
        }

        public uint BlockCount
        {
            [MethodImpl(Inline)]
            get => Source.BlockCount;
        }

        [MethodImpl(Inline)]
        public void Run<P>(P projector)
            where P : IBlockProjector256<P,S,T>
                => api.flow(this,projector);

        [MethodImpl(Inline)]
        public void Deposit(in SpanBlock256<T> src)
            => Target.Deposit(src);

        [MethodImpl(Inline)]
        public SpanBlock256<S> Emit(uint index)
            => Source.Emit(index);
    }

    public readonly struct BlockPipe256<A,S,B,T> : IBlockPipe256<S,T>
        where S : unmanaged
        where A : IBlockSource256<S>
        where T : unmanaged
        where B : IBlockSink256<T>
    {
        readonly A Source;

        readonly B Sink;

        [MethodImpl(Inline)]
        public BlockPipe256(IPipeline pipes, A src, B dst)
        {
            Source = src;
            Sink = dst;
        }

        public uint BlockCount
        {
            [MethodImpl(Inline)]
            get => Source.BlockCount;
        }

        [MethodImpl(Inline)]
        public void Run<P>(P projector)
            where P : IBlockProjector256<P,S,T>
                => api.flow(this, projector);

        [MethodImpl(Inline)]
        public void Deposit(in SpanBlock256<T> src)
            => Sink.Deposit(src);

        [MethodImpl(Inline)]
        public SpanBlock256<S> Emit(uint index)
            => Source.Emit(index);
    }
}