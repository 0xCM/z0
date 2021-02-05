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

    partial class VServices
    {
        public readonly struct Sllv128<T> : IBinaryOp128D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> offsets)
                => gcpu.vsllv(x,offsets);

            [MethodImpl(Inline)]
            public T Invoke(T a, T offset)
                => gmath.sll(a, Numeric.force<T,byte>(offset));
        }

        public readonly struct Sllv256<T> : IBinaryOp256D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> offsets)
                => gcpu.vsllv(x,offsets);

            [MethodImpl(Inline)]
            public T Invoke(T a, T offset)
                => gmath.sll(a, Numeric.force<T,byte>(offset));
        }
    }
}