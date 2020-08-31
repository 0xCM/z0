
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;
    using static SBlock;

    partial class BSvcHosts
    {
        [Closures(Integers), Select]
        public readonly struct Select128<T> : IBlockedTernaryOp128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock128<T> Invoke(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> c, in SpanBlock128<T> dst)
                => ref zip(a,b,c,dst, VSvc.vselect<T>(w128));
        }

        [Closures(Integers), Select]
        public readonly struct Select256<T> : IBlockedTernaryOp256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock256<T> Invoke(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> c, in SpanBlock256<T> dst)
                => ref zip(a,b,c,dst, VSvc.vselect<T>(w256));
        }
    }
}