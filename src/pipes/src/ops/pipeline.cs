//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static SFx;

    partial struct Pipes
    {
        public static Pipeline<S,T> pipeline<S,T>(EventSignal signal, IEmitter<S> emitter, IProjector<S,T> projector, IReceiver<T> receiver)
        {
            var connection = new Pipeline<S,T>(signal);
            connection.Emitter = emitter;
            connection.Projector = projector;
            connection.Receiver = receiver;
            connection.Connected = true;
            return connection;
        }

        [MethodImpl(Inline)]
        public static BlockPipeline128<S,T> pipeline<S,T>(IPipeline pipes, IBlockSource128<S> src, IBlockProjector128<S,T> map, IBlockSink128<T> dst)
            where S : unmanaged
            where T : unmanaged
                => new BlockPipeline128<S,T>(pipes, src, map, dst);

        [MethodImpl(Inline)]
        public static BlockPipeline256<S,T> pipeline<S,T>(IPipeline pipes, IBlockSource256<S> src, IBlockProjector256<S,T> map, IBlockSink256<T> dst)
            where S : unmanaged
            where T : unmanaged
                => new BlockPipeline256<S,T>(pipes, src, map, dst);

        [MethodImpl(Inline)]
        public static BlockPipeline128<A,S,P,B,T> pipeline<A,S,P,B,T>(W128 w, IPipeline pipes, A src, P map, B dst)
            where S : unmanaged
            where A : IBlockSource128<S>
            where P : IBlockProjector128<S,T>
            where T : unmanaged
            where B : IBlockSink128<T>
                => new BlockPipeline128<A,S,P,B,T>(pipes, src,map,dst);

        [MethodImpl(Inline)]
        public static BlockPipeline256<A,S,P,B,T> pipeline<A,S,P,B,T>(W256 w, IPipeline pipes, A src, P map, B dst)
            where S : unmanaged
            where A : IBlockSource256<S>
            where P : IBlockProjector256<S,T>
            where T : unmanaged
            where B : IBlockSink256<T>
                => new BlockPipeline256<A,S,P,B,T>(pipes, src,map,dst);


        [MethodImpl(Inline)]
        public static VPipeline128<B,M,R,S,T> vpipeline<B,M,R,S,T>(W128 w, B blocks, M mapper, R sink, S s = default, T t = default)
            where R : IBlockSink128<R,T>
            where B : IBlockSource128<S>
            where M : IVMap128<M,S,T>
            where S : unmanaged
            where T : unmanaged
                => new VPipeline128<B,M,R,S,T>(blocks,mapper,sink);

        [MethodImpl(Inline)]
        public static VPipeline256<B,M,R,S,T> vpipeline<B,M,R,S,T>(W256 w, B blocks, M mapper, R sink, S s = default, T t = default)
            where R : IBlockSink256<R,T>
            where B : IBlockSource256<S>
            where M : IVMap256<M,S,T>
            where S : unmanaged
            where T : unmanaged
                => new VPipeline256<B,M,R,S,T>(blocks,mapper,sink);
    }
}