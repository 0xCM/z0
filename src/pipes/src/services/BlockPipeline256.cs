//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = Pipes;

    public struct BlockPipeline256<S,T>
        where S : unmanaged
        where T : unmanaged
    {
        public IBlockSource256<S> Emitter {get;}

        public IBlockProjector256<S,T> Projector {get;}

        public IBlockSink256<T> Receiver {get;}

        uint Counter;

        [MethodImpl(Inline)]
        public BlockPipeline256(IBlockSource256<S> emitter, IBlockProjector256<S,T> projector, IBlockSink256<T> receiver)
        {
            Emitter = emitter;
            Projector = projector;
            Receiver = receiver;
            Counter = 0;
        }

        [MethodImpl(Inline)]
        public void Run(uint count, in SpanBlock256<T> buffer)
            => api.run(this,count, buffer);
    }

    public struct BlockPipeline256<A,S,P,B,T>
        where S : unmanaged
        where A : IBlockSource256<S>
        where P : IBlockProjector256<S,T>
        where T : unmanaged
        where B : IBlockSink256<T>
    {
        public A Emitter {get;}

        public P Projector {get;}

        public B Receiver {get;}

        uint Counter;

        [MethodImpl(Inline)]
        public BlockPipeline256(A emitter, P projector, B receiver)
        {
            Emitter = emitter;
            Projector = projector;
            Receiver = receiver;
            Counter = 0;
        }

        [MethodImpl(Inline)]
        public void Run(uint count, in SpanBlock256<T> buffer)
            => api.run(this,count, buffer);
    }
}