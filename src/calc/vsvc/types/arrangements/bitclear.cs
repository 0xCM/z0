//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static SFx;

    partial class VBitSvcHosts
    {
        [Closures(Integers)]
        public readonly struct BitClear128<T> : IUnaryImm8x2Op128D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte offset, byte count)
                => gcpu.vbitclear(x,offset,count);

            [MethodImpl(Inline)]
            public T Invoke(T a, byte b, byte c)
                => gbits.disable(a, b, c);
        }

        [Closures(Integers)]
        public readonly struct BitClear256<T> : IUnaryImm8x2Op256D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte offset, byte count)
                => gcpu.vbitclear(x,offset, count);

            [MethodImpl(Inline)]
            public T Invoke(T a, byte b, byte c)
                => gbits.disable(a, b, c);
        }
    }
}