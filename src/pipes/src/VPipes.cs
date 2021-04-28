//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;
    using static SFx;

    public readonly struct VPipes
    {
        [MethodImpl(Inline)]
        public static VPipe128<P,S,T> pipe<P,S,T>(W128 w, P vmap, S s = default, T t = default)
            where S : unmanaged
            where P : IVMap128<P,S,T>
            where T : unmanaged
                => new VPipe128<P,S,T>(vmap);

        [MethodImpl(Inline)]
        public static VPipe256<P,S,T> pipe<P,S,T>(W256 w, P vmap, S s = default, T t = default)
            where S : unmanaged
            where P : IVMap256<P,S,T>
            where T : unmanaged
                => new VPipe256<P,S,T>(vmap);


        [MethodImpl(Inline)]
        public static VPipes128<B,M,R,S,T> runner<B,M,R,S,T>(W128 w, B blocks, M mapper, R sink, S s = default, T t = default)
            where R : IBlockSink128<R,T>
            where B : IBlockSource128<S>
            where M : IVMap128<M,S,T>
            where S : unmanaged
            where T : unmanaged
                => new VPipes128<B,M,R,S,T>(blocks,mapper,sink);

        [MethodImpl(Inline)]
        public static VPipes256<B,M,R,S,T> runner<B,M,R,S,T>(W256 w, B blocks, M mapper, R sink, S s = default, T t = default)
            where R : IBlockSink256<R,T>
            where B : IBlockSource256<S>
            where M : IVMap256<M,S,T>
            where S : unmanaged
            where T : unmanaged
                => new VPipes256<B,M,R,S,T>(blocks,mapper,sink);
    }
}