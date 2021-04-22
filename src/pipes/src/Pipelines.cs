//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;
    using static memory;

    using System.Runtime.CompilerServices;

    using static SFx;

    public readonly struct Pipelines
    {
        public static Pipeline<S,T> connect<S,T>(IEmitter<S> emitter, IProjector<S,T> projector, IReceiver<T> receiver)
        {
            var connection = new Pipeline<S,T>();
            connection.Emitter = emitter;
            connection.Projector = projector;
            connection.Receiver = receiver;
            connection.Connected = true;
            return connection;
        }

        [MethodImpl(Inline)]
        public static BlockPipeline128<S,T> blocked<S,T>(IBlockSource128<S> src, IBlockProjector128<S,T> map, IBlockSink128<T> dst)
            where S : unmanaged
            where T : unmanaged
                => new BlockPipeline128<S,T>(src, map, dst);

        [MethodImpl(Inline)]
        public static BlockPipeline256<S,T> blocked<S,T>(IBlockSource256<S> src, IBlockProjector256<S,T> map, IBlockSink256<T> dst)
            where S : unmanaged
            where T : unmanaged
                => new BlockPipeline256<S,T>(src, map, dst);

        [MethodImpl(Inline)]
        public static BlockPipeline128<A,S,P,B,T> blocked<A,S,P,B,T>(W128 w, A src, P map, B dst)
            where S : unmanaged
            where A : IBlockSource128<S>
            where P : IBlockProjector128<S,T>
            where T : unmanaged
            where B : IBlockSink128<T>
                => new BlockPipeline128<A,S,P,B,T>(src,map,dst);

        [MethodImpl(Inline)]
        public static BlockPipeline256<A,S,P,B,T> blocked<A,S,P,B,T>(W256 w, A src, P map, B dst)
            where S : unmanaged
            where A : IBlockSource256<S>
            where P : IBlockProjector256<S,T>
            where T : unmanaged
            where B : IBlockSink256<T>
                => new BlockPipeline256<A,S,P,B,T>(src,map,dst);
    }
}