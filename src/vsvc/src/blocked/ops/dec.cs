
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;
    using static SBlock;

    partial class VBlockHosts
    {
        [NumericClosures(AllNumeric), Dec]
        public readonly struct Dec128<T> : IBlockedUnaryOp128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> src, in Block128<T> dst)
                => ref map(src, dst, VSvc.vdec<T>(w128));
        }

        [NumericClosures(AllNumeric), Dec]
        public readonly struct Dec256<T> : IBlockedUnaryOp256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> src, in Block256<T> dst)
                => ref map(src, dst, VSvc.vdec<T>(w256));
        }
    }
}