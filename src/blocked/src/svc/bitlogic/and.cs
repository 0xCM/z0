
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
        // [Closures(Integers), And]
        // public readonly struct And64<T> : IBlockedBinaryOp64<T>
        //     where T : unmanaged
        // {
        //     [MethodImpl(Inline)]
        //     public ref readonly Block64<T> Invoke(in Block64<T> a, in Block64<T> b, in Block64<T> dst)
        //         => ref zip(a, b, dst, MSvc.and<T>);
        // }

        [Closures(Integers), And]
        public readonly struct And128<T> : IBlockedBinaryOp128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock128<T> Invoke(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
                => ref zip(a, b, dst, VSvc.vand<T>(w128));
        }

        [Closures(Integers), And]
        public readonly struct And256<T> : IBlockedBinaryOp256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock256<T> Invoke(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
                => ref zip(a, b, dst, VSvc.vand<T>(w256));
        }
    }
}