
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
        [Closures(Integers), Bsrl]
        public readonly struct Bsrl128<T> : IBlockedUnaryImm8Op128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock128<T> Invoke(in SpanBlock128<T> a, [Imm] byte count, in SpanBlock128<T> dst)
                => ref zip(a, count, dst, VSvc.vbsrl<T>(n128));
        }

        [Closures(Integers), Bsrl]
        public readonly struct Bsrl256<T> : IBlockedUnaryImm8Op256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock256<T> Invoke(in SpanBlock256<T> a, [Imm] byte count, in SpanBlock256<T> dst)
                => ref zip(a, count, dst, VSvc.vbsrl<T>(n256));
        }
    }
}