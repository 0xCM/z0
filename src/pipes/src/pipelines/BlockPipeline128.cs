//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = Pipes;

    public struct BlockPipeline128<S,T>
        where S : unmanaged
        where T : unmanaged
    {
        public IBlockSource128<S> Emitter {get;}

        public IBlockProjector128<S,T> Projector {get;}

        public IBlockSink128<T> Receiver {get;}

        [MethodImpl(Inline)]
        public BlockPipeline128(IPipeline pipes, IBlockSource128<S> emitter, IBlockProjector128<S,T> projector, IBlockSink128<T> receiver)
        {
            Emitter = emitter;
            Projector = projector;
            Receiver = receiver;
        }

        [MethodImpl(Inline)]
        public void Run(uint count, in SpanBlock128<T> buffer)
            => api.run(this,count, buffer);
    }

    public struct BlockPipeline128<A,S,P,B,T>
        where S : unmanaged
        where A : IBlockSource128<S>
        where P : IBlockProjector128<S,T>
        where T : unmanaged
        where B : IBlockSink128<T>
    {
        public A Emitter {get;}

        public P Projector {get;}

        public B Receiver {get;}

        [MethodImpl(Inline)]
        public BlockPipeline128(IPipeline pipes, A emitter, P projector, B receiver)
        {
            Emitter = emitter;
            Projector = projector;
            Receiver = receiver;
        }

        [MethodImpl(Inline)]
        public void Run(uint count, in SpanBlock128<T> buffer)
            => api.run(this,count, buffer);
    }
}