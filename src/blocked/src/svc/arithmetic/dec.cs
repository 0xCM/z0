
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;
    using static SBlock;

    partial class BSvcHosts
    {
        [NumericClosures(AllNumeric), Dec]
        public readonly struct Dec128<T> : IBlockedUnaryOp128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock128<T> Invoke(in SpanBlock128<T> src, in SpanBlock128<T> dst)
                => ref map(src, dst, VSvc.vdec<T>(w128));
        }

        [NumericClosures(AllNumeric), Dec]
        public readonly struct Dec256<T> : IBlockedUnaryOp256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock256<T> Invoke(in SpanBlock256<T> src, in SpanBlock256<T> dst)
                => ref map(src, dst, VSvc.vdec<T>(w256));
        }
    }
}