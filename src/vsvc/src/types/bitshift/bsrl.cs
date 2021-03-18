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

    partial class VSvcHosts
    {
        [Closures(Integers), Bsrl]
        public readonly struct Bsrl128<T> : IShiftOp128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte count)
                => gcpu.vbsrl(x,count);
        }

        [Closures(Integers), Bsrl]
        public readonly struct Bsrl256<T> : IShiftOp256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte count)
                => gcpu.vbsrl(x,count);
        }
    }
}