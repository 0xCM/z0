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
        static T identity<T>(T src)
            => src;

        public static SpanPipe<S,T> pipe<S,T>(IPipeline pipes, ISpanMap<S,T> map)
            => SpanPipe<S,T>.create(pipes).With(map);

        [Op, Closures(Closure)]
        public static Pipe<T> pipe<T>(IPipeline pipes)
            => pipe(pipes, new PipeBuffer<T>(), new SFx.Projector<T>(identity));

        [Op, Closures(Closure)]
        public static Pipe<T> pipe<T>(IPipeline pipes, ISFxProjector<T> projector)
            => pipe(pipes, new PipeBuffer<T>(), projector);

        public static Pipe<S,T> pipe<S,T>(IPipeline pipes, ISFxProjector<S,T> projector)
            => pipe<S,T>(pipes, new PipeBuffer<S>(), projector);

        [MethodImpl(Inline)]
        internal static Pipe<S,T> pipe<S,T>(IPipeline pipes, PipeBuffer<S> buffer, ISFxProjector<S,T> fx)
            => new Pipe<S,T>(pipes, buffer, fx);

        [MethodImpl(Inline), Op, Closures(Closure)]
        internal static Pipe<T> pipe<T>(IPipeline pipes, PipeBuffer<T> buffer, ISFxProjector<T> projector)
            => new Pipe<T>(pipes, buffer, projector);

        [MethodImpl(Inline)]
        public static BlockPipe128<S,T> pipe<S,T>(IPipeline pipes, IBlockSource128<S> src, IBlockSink128<T> dst)
            where S : unmanaged
            where T : unmanaged
                => new BlockPipe128<S,T>(pipes, src,dst);

        [MethodImpl(Inline)]
        public static BlockPipe128<A,S,B,T> pipe<A,S,B,T>(W128 w, IPipeline pipes,  A src, B dst)
            where S : unmanaged
            where A : IBlockSource128<S>
            where T : unmanaged
            where B : IBlockSink128<T>
                => new BlockPipe128<A,S,B,T>(pipes, src,dst);

        [MethodImpl(Inline)]
        public static BlockPipe256<S,T> pipe<S,T>(IPipeline pipes, IBlockSource256<S> src, IBlockSink256<T> dst)
            where S : unmanaged
            where T : unmanaged
                => new BlockPipe256<S,T>(pipes, src,dst);

        [MethodImpl(Inline)]
        public static BlockPipe256<A,S,B,T> pipe<A,S,B,T>(W256 w, IPipeline pipes, A src, B dst)
            where S : unmanaged
            where A : IBlockSource256<S>
            where T : unmanaged
            where B : IBlockSink256<T>
                => new BlockPipe256<A,S,B,T>(pipes, src,dst);


        [MethodImpl(Inline)]
        public static VPipe128<P,S,T> vpipe<P,S,T>(W128 w, P vmap, S s = default, T t = default)
            where S : unmanaged
            where P : IVMap128<P,S,T>
            where T : unmanaged
                => new VPipe128<P,S,T>(vmap);

        [MethodImpl(Inline)]
        public static VPipe256<P,S,T> vpipe<P,S,T>(W256 w, P vmap, S s = default, T t = default)
            where S : unmanaged
            where P : IVMap256<P,S,T>
            where T : unmanaged
                => new VPipe256<P,S,T>(vmap);
    }
}