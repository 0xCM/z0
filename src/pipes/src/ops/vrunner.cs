//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;
    using static SFx;


    partial struct Pipes
    {
        [MethodImpl(Inline)]
        public static VPipeRunner128<B,M,R,S,T> vrunner<B,M,R,S,T>(W128 w, B blocks, M mapper, R sink, S s = default, T t = default)
            where R : IBlockSink128<R,T>
            where B : IBlockSource128<S>
            where M : IVMap128<M,S,T>
            where S : unmanaged
            where T : unmanaged
                => new VPipeRunner128<B,M,R,S,T>(blocks,mapper,sink);
    }
}