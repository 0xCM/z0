
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static SFx;

    partial class BSvcHosts
    {
        [NumericClosures(AllNumeric), Negate]
        public readonly struct Negate128<T> : IBlockedUnaryOp128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock128<T> Invoke(in SpanBlock128<T> a, in SpanBlock128<T> c)
                => ref map(a, c, VSvc.vnegate<T>(w128));
        }

        [NumericClosures(AllNumeric), Negate]
        public readonly struct Negate256<T> : IBlockedUnaryOp256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock256<T> Invoke(in SpanBlock256<T> a, in SpanBlock256<T> c)
                => ref map(a, c, VSvc.vnegate<T>(w256));
        }
    }
}