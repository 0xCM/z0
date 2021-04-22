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

    partial struct Pipes
    {
        [MethodImpl(Inline)]
        public static BlockPipe128<S,T> bpipe<S,T>(IBlockSource128<S> src, IBlockSink128<T> dst)
            where S : unmanaged
            where T : unmanaged
                => new BlockPipe128<S,T>(src,dst);

        [MethodImpl(Inline)]
        public static BlockPipe128<A,S,B,T> bpipe<A,S,B,T>(W128 w, A src, B dst)
            where S : unmanaged
            where A : IBlockSource128<S>
            where T : unmanaged
            where B : IBlockSink128<T>
                => new BlockPipe128<A,S,B,T>(src,dst);

        [MethodImpl(Inline)]
        public static BlockPipe256<S,T> bpipe<S,T>(IBlockSource256<S> src, IBlockSink256<T> dst)
            where S : unmanaged
            where T : unmanaged
                => new BlockPipe256<S,T>(src,dst);

        [MethodImpl(Inline)]
        public static BlockPipe256<A,S,B,T> bpipe<A,S,B,T>(W256 w, A src, B dst)
            where S : unmanaged
            where A : IBlockSource256<S>
            where T : unmanaged
            where B : IBlockSink256<T>
                => new BlockPipe256<A,S,B,T>(src,dst);
    }
}